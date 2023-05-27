using System;
using System.IO;
using System.Windows.Forms;

namespace Clippy
{
    internal partial class SettingForm : Form
    {
        private Keys _hotKey;

        public AppSetting EditSetting { get; private set; }

        public SettingForm(AppSetting setting)
        {
            InitializeComponent();

            DisplaySetting(setting);
        }

        private void RdoHotKey_CheckedChanged(object sender, EventArgs e)
        {
            pnlCustomHotKey.Enabled = rdoHotKey_Custom.Checked;
            nudDoubleHotKeyTimeSpan.Enabled = GetHotKeySettingType().IsDoubleHotKey();
        }
        private void RdoAutoDelete_CheckedChanged(object sender, EventArgs e)
        {
            nudSavePictureTimeSpan.Enabled = rdoAutoDelete_Yes.Checked;
        }
        private void TxtCustomHotKey_KeyDown(object sender, KeyEventArgs e)
        {
            _hotKey = e.KeyCode;
            txtCustomHotKey.Text = string.Empty;
        }
        private void NudSavePictureTimeSpan_ValueChanged(object sender, EventArgs e)
        {
            var day = DateTime.Now.AddDays(-1 * (int)nudSavePictureTimeSpan.Value);
            lblAutoDeleteInfo.Text = $"({day:yyyy/MM/dd} 00:00 以降のファイルが保存対象)";
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtPictureSaveFolderPath.Text))
            {
                MessageBoxController.ShowError($"「{lblPictureSaveFolderPath.Text}」に存在しないフォルダが指定されています。");
                return;
            }

            if (rdoHotKey_Custom.Checked)
            {
                if (string.IsNullOrEmpty(txtCustomHotKey.Text))
                {
                    MessageBoxController.ShowError($"「{rdoHotKey_Custom.Text}」が ON の場合は「{lblCustomKey.Text}」を指定して下さい。");
                    return;
                }

                if (!chkCtrl.Checked && !chkShift.Checked && !chkAlt.Checked)
                {
                    MessageBoxController.ShowError($"「{rdoHotKey_Custom.Text}」が ON の場合は「{lblCustomModKey.Text}」をひとつ以上 ON にして下さい。");
                    return;
                }
            }

            var message = "設定を保存して再起動します。" + Environment.NewLine + "よろしいですか？";
            if (MessageBoxController.ShowQuestion(message) != DialogResult.OK) { return; }

            EditSetting = GetSetting();

            DialogResult = DialogResult.OK;
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void BtnSearchPictureSaveFolderPath_Click(object sender, EventArgs e)
        {
            using (var f = new FolderBrowserDialog())
            {
                if (f.ShowDialog() != DialogResult.OK) { return; }

                txtPictureSaveFolderPath.Text = f.SelectedPath;
            }
        }

        private void DisplaySetting(AppSetting setting)
        {
            txtPictureSaveFolderPath.Text = setting.PictureSaveFolderPath;
            switch (setting.HotKeySettyngType)
            {
                case HotKeySettingType.None: rdoHotKey_None.Checked = true; break;
                case HotKeySettingType.DoubleCtrl: rdoHotKey_DoubleCtrl.Checked = true; break;
                case HotKeySettingType.DoubleShift: rdoHotKey_DoubleShift.Checked = true; break;
                case HotKeySettingType.DoubleAlt: rdoHotKey_DoubleAlt.Checked = true; break;
                case HotKeySettingType.Custom:
                    rdoHotKey_Custom.Checked = true;
                    chkCtrl.Checked = setting.ModifyHotKey.HasFlag(ModifierKey.Ctrl);
                    chkShift.Checked = setting.ModifyHotKey.HasFlag(ModifierKey.Shift);
                    chkAlt.Checked = setting.ModifyHotKey.HasFlag(ModifierKey.Alt);
                    _hotKey = setting.HotKey;
                    txtCustomHotKey.Text = setting.DisplayHotKey;
                    break;
                default: throw new NotImplementedException();
            }

            nudDoubleHotKeyTimeSpan.Value = (int)setting.DoubleHotKeyTimeSpan.TotalMilliseconds;
            rdoAutoDelete_Yes.Checked = setting.AutoDeletePicture;
            rdoAutoDelete_No.Checked = !setting.AutoDeletePicture;
            nudSavePictureTimeSpan.Value = (int)setting.SavePictureTimeSpan.TotalDays;
            nudTrimTop.Value = setting.TrimTop;
            nudTrimBottom.Value = setting.TrimBottom;
            nudTrimLeft.Value = setting.TrimLeft;
            nudTrimRight.Value = setting.TrimRight;
            nudBorderWidth.Value = setting.BorderWidth;
            rdoBlack.Checked = setting.BorderColor == ExcelExportBorderColor.Black;
            rdoBlue.Checked = setting.BorderColor == ExcelExportBorderColor.Blue;
            rdoSilver.Checked = setting.BorderColor == ExcelExportBorderColor.Silver;
            chkSkipStartWindow.Checked = setting.SkipStartWindow;
        }
        private AppSetting GetSetting()
        {
            var hotKeySettingType = GetHotKeySettingType();
            var isDouble = hotKeySettingType.IsDoubleHotKey();
            var modifyHotKey = GetModifyKey(hotKeySettingType);

            return new AppSetting
            {
                PictureSaveFolderPath = txtPictureSaveFolderPath.Text,
                HotKeySettyngType = hotKeySettingType,
                IsDoubleHotKey = isDouble,
                DoubleHotKeyTimeSpan = TimeSpan.FromMilliseconds((int)nudDoubleHotKeyTimeSpan.Value),
                ModifyHotKey = modifyHotKey,
                HotKey = hotKeySettingType == HotKeySettingType.Custom ? _hotKey : Keys.None,
                DisplayHotKey = hotKeySettingType == HotKeySettingType.Custom ? txtCustomHotKey.Text : string.Empty,
                AutoDeletePicture = rdoAutoDelete_Yes.Checked,
                SavePictureTimeSpan = TimeSpan.FromDays((int)nudSavePictureTimeSpan.Value),
                TrimTop = (int)nudTrimTop.Value,
                TrimBottom = (int)nudTrimBottom.Value,
                TrimLeft = (int)nudTrimLeft.Value,
                TrimRight = (int)nudTrimRight.Value,
                BorderWidth = (int)nudBorderWidth.Value,
                BorderColor = rdoBlack.Checked ? ExcelExportBorderColor.Black
                    : rdoBlue.Checked ? ExcelExportBorderColor.Blue
                    : rdoSilver.Checked ? ExcelExportBorderColor.Silver
                    : throw new NotImplementedException(),
                SkipStartWindow = chkSkipStartWindow.Checked,
            };
        }
        private HotKeySettingType GetHotKeySettingType()
        {
            return rdoHotKey_None.Checked ? HotKeySettingType.None
                : rdoHotKey_DoubleCtrl.Checked ? HotKeySettingType.DoubleCtrl
                : rdoHotKey_DoubleShift.Checked ? HotKeySettingType.DoubleShift
                : rdoHotKey_DoubleAlt.Checked ? HotKeySettingType.DoubleAlt
                : rdoHotKey_Custom.Checked ? HotKeySettingType.Custom
                : throw new NotImplementedException();
        }
        private ModifierKey GetModifyKey(HotKeySettingType type)
        {
            switch (type)
            {
                case HotKeySettingType.None: return ModifierKey.None;
                case HotKeySettingType.DoubleCtrl: return ModifierKey.Ctrl;
                case HotKeySettingType.DoubleShift: return ModifierKey.Shift;
                case HotKeySettingType.DoubleAlt: return ModifierKey.Alt;
                case HotKeySettingType.Custom:
                    return (chkCtrl.Checked ? ModifierKey.Ctrl : ModifierKey.None)
                        | (chkShift.Checked ? ModifierKey.Shift : ModifierKey.None)
                        | (chkAlt.Checked ? ModifierKey.Alt : ModifierKey.None);
                default: throw new NotImplementedException();
            }
        }
    }
}
