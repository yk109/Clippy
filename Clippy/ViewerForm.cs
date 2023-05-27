using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

// TODO 画像選択して、ドラッグアンドドロップしたら貼り付けられるのも便利だな
// TODO D&Dで追加したい
// TODO お気に入り機能

namespace Clippy
{
    internal partial class ViewerForm : Form
    {
        private readonly SettingRepository _settingRepository;
        private readonly PictureRepository _pictureRepository;

        public ViewerForm(SettingRepository settingRepository, PictureRepository pictureRepository)
        {
            InitializeComponent();
            var ver = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location);
            Text = $"Clippy v{ver.FileVersion}";

            _settingRepository = settingRepository;
            _pictureRepository = pictureRepository;

            // 初期表示
            DisplayPictures();
        }

        private void ViewerForm_Shown(object sender, EventArgs e)
        {
            // 再起動後に ShowDialog すると最前面に出てこない問題の修正
            TopMost = true;
            TopMost = false;
        }
        private void ViewerForm_Activated(object sender, EventArgs e)
        {
            _ = dgvRepository.Focus();

            if (!_pictureRepository.IsChanged) { return; }

            DisplayPictures();
        }
        private void ViewerForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape: Close(); break;
                case Keys.D0: if (e.Control) { pictureBox.Reset(); } break;
                case Keys.Oemplus: if (e.Control) { pictureBox.Zoom(true); } break;
                case Keys.OemMinus: if (e.Control) { pictureBox.Zoom(false); } break;
                default: break;
            }
        }
        private void BtnExportExcel_Click(object sender, EventArgs e)
        {
            using (var f = new ExportExcelForm(_pictureRepository.Load(), _settingRepository.Get()))
            {
                _ = f.ShowDialog();
            }
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            var row = dgvRepository.CurrentRow;
            if (row == null) { return; }

            var path = (string)row.Cells[ColPath.Index].Value;
            _ = Process.Start("mspaint", $@"""{path}""");
        }
        private void BtnSetting_Click(object sender, EventArgs e)
        {
            using (var f = new SettingForm(_settingRepository.Get()))
            {
                if (f.ShowDialog() != DialogResult.OK) { return; }

                _settingRepository.Save(f.EditSetting);
            }

            Application.Restart();
        }
        private void LlOpenSaveDir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var saveFolderPath = _settingRepository.Get().PictureSaveFolderPath;
            _ = Process.Start(saveFolderPath);
        }
        private void DgvRepository_SelectionChanged(object sender, EventArgs e)
        {
            var row = dgvRepository.CurrentRow;
            if (row == null) { return; }

            var image = (Image)row.Cells[ColImage.Index].Value;
            pictureBox.Set(image);
        }
        private void DgvRepository_KeyDown(object sender, KeyEventArgs e)
        {
            var row = dgvRepository.CurrentRow;
            if (row == null) { return; }

            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                if (MessageBoxController.ShowQuestion("削除します。よろしいですか？")
                    != DialogResult.OK) { return; }

                DeleteCurrentRow();
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                ClipImage(row);
                return;
            }
        }
        private void DgvRepository_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }

            var row = dgvRepository.Rows[e.RowIndex];
            ClipImage(row);
        }
        private void DgvRepository_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) { return; }

            if (e.RowIndex == -1) { return; }

            dgvRepository.ClearSelection();
            dgvRepository.CurrentCell = dgvRepository.Rows[e.RowIndex].Cells[e.ColumnIndex];
            cmsRepository.Show(Cursor.Position);
        }
        private void TmsiDelete_Click(object sender, EventArgs e)
        {
            DeleteCurrentRow();
        }

        private void DisplayPictures()
        {
            dgvRepository.Rows.Clear();
            pictureBox.Clear();

            var i = 0;
            var pictures = _pictureRepository.Load();
            foreach (var p in pictures)
            {
                _ = dgvRepository.Rows.Add(new object[]
                {
                    ++i,
                    p.DateTime,
                    p.Image,
                    p.Path,
                    p.Hash,
                });
            }

            lblInformation.Text = $"{pictures.Count()}枚 {GetDisplayFileSize(pictures.Sum(x => x.Size))}";
        }
        private void ClipImage(DataGridViewRow row)
        {
            try
            {
                var path = (string)row.Cells[ColPath.Index].Value;
                var image = Image.FromFile(path);
                Clipboard.SetImage(image);

                // クリップボードコピー後にフォームを閉じる ※ Clibor に合わせた挙動
                Close();
                //lblMessage.Text = $"{Path.GetFileName(path)} をクリップボードにコピーしました！";
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show("クリップボードへのコピー処理に失敗しました" + Environment.NewLine + ex.ToString());
                return;
            }
        }
        private string GetDisplayFileSize(long bytes)
        {
            var size = bytes;
            if (size < 1024) { return $"{size}byte"; }

            size /= 1024;
            if (size < 1024) { return $"{size}KB"; }

            size /= 1024;
            if (size < 1024) { return $"{size}MB"; }

            size /= 1024;
            return $"{size}GB";
        }
        private void DeleteCurrentRow()
        {
            var row = dgvRepository.CurrentRow;
            var hash = (string)row.Cells[ColHash.Index].Value;
            try
            {
                // REMARK:
                //   不確定現象で画像ファイルの削除に失敗するが、リトライすると削除できる。
                _pictureRepository.Delete(hash);
                dgvRepository.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MessageBoxController.ShowError($"画像の削除に失敗しました。{ex}");
            }
        }
    }
}
