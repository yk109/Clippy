using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Clippy
{
    internal class PictureRepository
    {
        private readonly IPictureRepositorySettingRepository _settingRepository;
        private readonly PictureRepositoryWatcher _watcher;
        private readonly HashAlgorithm _hashProvider = new SHA1CryptoServiceProvider();

        private Dictionary<string, string> _imageHashAndFileName = new Dictionary<string, string>();
        private DateTime _changeDateTimeWhenLastLoaded = DateTime.MinValue;
        private DateTime _autoDeleteLastDateTime = DateTime.MinValue;
        private IEnumerable<PictureInfo> _cache;

        // ペタペタリロード問題：
        // 画像一覧からコピー → 貼り付け → 一覧再表示 とした場合に、一覧が初期化されることを防ぐための実装
        public bool IsChanged => _changeDateTimeWhenLastLoaded != _watcher.ChangeDateTime;

        public PictureRepository(IPictureRepositorySettingRepository settingRepository)
        {
            _settingRepository = settingRepository;
            var setting = _settingRepository.Get();
            var saveFolderPath = setting.PictureSaveFolderPath;

            if (!Directory.Exists(saveFolderPath))
            {
                _ = Directory.CreateDirectory(saveFolderPath);
            }

            DeleteAutomatically();
            _watcher = new PictureRepositoryWatcher(saveFolderPath);
            _cache = LoadFromFile().ToList();
        }

        public void Save(Image source)
        {
            // REMARK:
            //   この実装によって、画像一覧からコピーした場合に画像ファイルが増殖することを防ぐ
            // MEMO:
            //   Clibor に倣うと、まったく同一の画像をコピーした場合に、古いものが削除されて新しいもので更新される、という挙動が自然かもしれない。
            //   しかし、画面ショットにおいて連続で同一画像を貼り付けるという FI/FO 的な利用想定が考えにくいため、実装を見送った。
            var hash = ComputeHash(source);
            if (_imageHashAndFileName.ContainsKey(hash))
            {
                return;
            }

            var saveFolderPath = _settingRepository.Get().PictureSaveFolderPath;
            var path = Path.Combine(saveFolderPath, $@"{DateTime.Now:yyyy-MM-dd-HH-mm-ss-fff}.png");
            source.Save(path, ImageFormat.Png);
            _imageHashAndFileName.Add(hash, path);
        }
        public void Delete(string hash)
        {
            var path = _imageHashAndFileName[hash];

            // REMARK:
            //   先に実体を削除する。削除処理が失敗した場合にリトライ可能とするため。
            File.Delete(path);
            _ = _imageHashAndFileName.Remove(hash);
        }
        public IEnumerable<PictureInfo> Load()
        {
            // メイン画面に画像表示するタイミングで自動削除の判定が実行される想定
            DeleteAutomatically();

            // キャッシュの更新
            if (IsChanged)
            {
                _cache = LoadFromFile().ToList();

                // 明示的にガベージコレクションを行う
                GC.Collect();
            }

            return _cache;
        }

        private void DeleteAutomatically()
        {
            var setting = _settingRepository.Get();
            var saveFolderPath = setting.PictureSaveFolderPath;
            if (!setting.AutoDeletePicture) { return; }

            // 自動削除実行済の日は削除処理を行わない（パフォーマンス改善のため）
            if (_autoDeleteLastDateTime.Date == DateTime.Now.Date) { return; }

            var deleteLimit = DateTime.Now.Date - setting.SavePictureTimeSpan;
            foreach (var info in Directory.GetFiles(saveFolderPath, "*.png").Select(x => new FileInfo(x)))
            {
                if (Min(info.CreationTime, info.LastWriteTime) < deleteLimit)
                {
                    File.Delete(info.FullName);
                }
            }

            _autoDeleteLastDateTime = DateTime.Now;
        }
        private IEnumerable<PictureInfo> LoadFromFile()
        {
            _imageHashAndFileName = new Dictionary<string, string>();

            var saveFolderPath = _settingRepository.Get().PictureSaveFolderPath;
            var hashSet = new HashSet<string>();
            var deletes = new List<string>();
            foreach (var info in Directory.GetFiles(saveFolderPath, "*.png")
                .Select(x => new FileInfo(x)).OrderByDescending(x => Min(x.CreationTime, x.LastWriteTime)))
            {
                var image = FromFile(info.FullName);
                var hash = ComputeHash(image);
                if (hashSet.Contains(hash))
                {
                    // 同一の画像データが存在する場合、過去のファイルは表示しない
                    // これによって、Dictionary のキー重複を回避することができる
                    // MEMO:
                    //   削除しようとしていたが、タイミングによってはシステムエラーとなるため対応を見送る。
                    //   保存フォルダにツールの機能以外の方法でファイル配置した場合は同一画像データが配置されてしまうが
                    //   そのようなパターンまで完全には考慮しない。
                    continue;
                }

                _ = hashSet.Add(hash);
                _imageHashAndFileName.Add(hash, info.FullName);

                yield return new PictureInfo
                {
                    Image = image,
                    Path = info.FullName,
                    DateTime = Min(info.CreationTime, info.LastWriteTime),
                    Size = info.Length,
                    Hash = hash,
                };
            }

            _changeDateTimeWhenLastLoaded = _watcher.ChangeDateTime;
        }
        private Image FromFile(string path)
        {
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                return Image.FromStream(stream);
            }
        }
        private string ComputeHash(Image image)
        {
            // クリップボードから取得した Image クラスのままでは異なるハッシュ値となるため、 Bitmap クラスに変換してからハッシュ値を計算する
            byte[] bytes;
            using (var ms = new MemoryStream())
            using (var bitmap = new Bitmap(image))
            {
                bitmap.Save(ms, ImageFormat.Png);
                bytes = ms.GetBuffer();
            }

            var hash = _hashProvider.ComputeHash(bytes);
            return BitConverter.ToString(hash);
        }
        private DateTime Min(DateTime a, DateTime b)
        {
            return a < b ? a : b;
        }
    }

    internal class PictureRepositoryWatcher
    {
        private DateTime _updateDateTime = DateTime.Now;
        private readonly object _lockObject = new object();

        public DateTime ChangeDateTime { get { lock (_lockObject) { return _updateDateTime; } } }

        public PictureRepositoryWatcher(string pictureSaveFolderPath)
        {
            // tsclient に対して FileSystemWatcher が機能しない
            //  → リモート接続先で Clippy のメイン画面を起動する利用想定がないため、問題ないと判断した
            var watcher = new FileSystemWatcher
            {
                Path = pictureSaveFolderPath,
                Filter = "*.png",
                NotifyFilter = NotifyFilters.FileName,
                IncludeSubdirectories = false,
            };

            _ = Task.Run(() =>
            {
                while (true)
                {
                    _ = watcher.WaitForChanged(WatcherChangeTypes.All);

                    lock (_lockObject)
                    {
                        _updateDateTime = DateTime.Now;
                    }
                }
            });
        }
    }
}
