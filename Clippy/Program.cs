using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Clippy
{
    internal static class Program
    {
        private static readonly string _mutexName = "Clippy";

        public static string ClippyFolderPath { get; } = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            using (var mutex = new Mutex(false, _mutexName))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBoxController.ShowError($"{_mutexName} は既に起動されています。");
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Start();
            }
        }

        private static void Start()
        {
            SettingRepository settingRepository;
            try
            {
                settingRepository = new SettingRepository();
            }
            catch (Exception ex)
            {
                MessageBoxController.ShowError($"設定ファイルの復元に失敗しました。{ex}");
                return;
            }

            PictureRepository pictureRepository;
            try
            {
                pictureRepository = new PictureRepository(settingRepository);
            }
            catch (Exception ex)
            {
                MessageBoxController.ShowError($"初期化処理に失敗しました。{ex}");
                throw;
            }

            var setting = settingRepository.Get();
            if (!setting.SkipStartWindow)
            {
                new StartForm(settingRepository).Show();
            }

#if DEBUG
            //Application.Run(new ViewerForm(settingRepository, pictureRepository));
            new RegidentForm(settingRepository, pictureRepository);
            Application.Run();
#else
            new RegidentForm(settingRepository, pictureRepository);
            Application.Run();
#endif
        }
    }
}
