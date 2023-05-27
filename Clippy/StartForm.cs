using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Clippy
{
    internal partial class StartForm : Form
    {
        private readonly SettingRepository _settingRepository;

        public StartForm(SettingRepository settingRepository)
        {
            InitializeComponent();
            _settingRepository = settingRepository;
        }

        private void LlOpenShellStartup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _ = Process.Start(llOpenShellStartup.Text);
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            var setting = _settingRepository.Get();
            setting.SkipStartWindow = chkSkipStartWindow.Checked;
            _settingRepository.Save(setting);

            Close();
        }
    }
}
