using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Clippy
{
    internal partial class RegidentForm : Form
    {
        private readonly SettingRepository _settingRepository;
        private readonly PictureRepository _pictureRepository;
        private readonly ViewerForm _viewerForm;
        private readonly HotKeyController _hotKeyController;

        public RegidentForm(SettingRepository settingRepository, PictureRepository pictureRepository)
        {
            InitializeComponent();
            notifyIcon.ContextMenuStrip = contextMenuStrip;

            _settingRepository = settingRepository;
            _pictureRepository = pictureRepository;
            _viewerForm = new ViewerForm(_settingRepository, _pictureRepository);
            _ = new ClipboardController(this, SaveImage);

            try
            {
                _hotKeyController = new HotKeyController(Handle, settingRepository, ShowViewer);
            }
            catch (Exception ex)
            {
                MessageBoxController.ShowError(ex.ToString());
            }
        }

        private void TsmiOpenViewer_Click(object sender, EventArgs e)
        {
            ShowViewer();
        }
        private void TsmiOpenSetting_Click(object sender, EventArgs e)
        {
            using (var f = new SettingForm(_settingRepository.Get()))
            {
                if (f.ShowDialog() != DialogResult.OK) { return; }

                _settingRepository.Save(f.EditSetting);
            }

            Application.Restart();
        }
        private void TsmiOpenDeployFolder_Click(object sender, EventArgs e)
        {
            _ = Process.Start(Program.ClippyFolderPath);
        }
        private void TsmiRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void TsmiExitApp_Click(object sender, EventArgs e)
        {
            var message = "Clippy を終了します。" + Environment.NewLine + "よろしいですか？";
            if (MessageBoxController.ShowQuestion(message) != DialogResult.OK) { return; }

            Application.Exit();
        }
        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip.Show();
        }
        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowViewer();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312 && (int)m.WParam == _hotKeyController.ID)
            {
                _hotKeyController.EventHandler?.Invoke(this, EventArgs.Empty);
            }
        }

        private void SaveImage(Image image)
        {
            // 稀に null となることがある
            if (image == null) { return; }

            _pictureRepository.Save(image);
        }
        private void ShowViewer()
        {
            if (_viewerForm.Visible)
            {
                _viewerForm.Activate();
                return;
            }

            _ = _viewerForm.ShowDialog();
        }
    }
}
