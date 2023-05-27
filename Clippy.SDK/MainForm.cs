using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clippy.SDK
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _ = new ClipboardController(this, Clip);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }
        private void RdoSizeMode_CheckedChanged(object sender, System.EventArgs e)
        {
            var mode = rdoNormal.Checked ? PictureBoxSizeMode.Normal
                : rdoStretchImage.Checked ? PictureBoxSizeMode.StretchImage
                : rdoAutoSize.Checked ? PictureBoxSizeMode.AutoSize
                : rdoCenterImage.Checked ? PictureBoxSizeMode.CenterImage
                : PictureBoxSizeMode.Zoom;

            pbClipboard.SizeMode = mode;
            pbPNG.SizeMode = mode;
            pbDeviceIndependentBitmap.SizeMode = mode;
        }
        private void BtnStartFileSystemWatcher_Click(object sender, EventArgs e)
        {
            StartFileSystemWatcher();
        }

        private void Clip()
        {
            txtData.Text += Environment.NewLine + $"{DateTime.Now:yyyy/MM/dd HH:mm:ss}";
            var image = Clipboard.GetImage();
            pbClipboard.Image = image;
            if (image == null)
            {
                txtData.Text += Environment.NewLine + "image is null";
            }

            var data = Clipboard.GetDataObject();
            foreach (var format in data.GetFormats())
            {
                txtData.Text += Environment.NewLine + format;
            }

            try
            {
                if (checkBox1.Checked && data.GetFormats().Contains("PNG"))
                {
                    using (var ms = (MemoryStream)Clipboard.GetData("PNG"))
                    {
                        // TODO 仮想に配置してリモート接続元で画面ショットを撮影するとエラーで落ちる
                        var bitmap = Image.FromStream(ms);
                        pbPNG.Image = bitmap;
                    }
                }
            }
            catch (Exception ex)
            {
                txtData.Text += Environment.NewLine + ex;
            }

            try
            {
                if (checkBox2.Checked && data.GetFormats().Contains("DeviceIndependentBitmap"))
                {
                    using (var ms = (MemoryStream)Clipboard.GetData("DeviceIndependentBitmap"))
                    {
                        //ms.Position = 0;
                        var bitmap = new Bitmap(ms);
                        pbDeviceIndependentBitmap.Image = bitmap;
                    }
                }
            }
            catch (Exception ex)
            {
                txtData.Text += Environment.NewLine + ex;
            }
        }
        private void StartFileSystemWatcher()
        {
            if (!Directory.Exists(txtWatchDirectory.Text))
            {
                MessageBox.Show("パスが不正です");
                return;
            }

            var watcher = new FileSystemWatcher
            {
                Path = txtWatchDirectory.Text,
                Filter = "*.*",
                NotifyFilter = NotifyFilters.FileName,
                IncludeSubdirectories = false,
            };

            txtData.Text += $"{DateTime.Now:HH:mm:ss.fff} Watch 開始" + Environment.NewLine;

            _ = Task.Run(() =>
            {
                while (true)
                {
                    _ = watcher.WaitForChanged(WatcherChangeTypes.All);
                    Invoke(new Action(WriteDateTime));
                }
            });
        }
        private void WriteDateTime()
        {
            txtData.Text += $"{DateTime.Now:HH:mm:ss.fff}" + Environment.NewLine;
        }
    }
}
