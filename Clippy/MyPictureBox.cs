using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Clippy
{
    // https://maywork.net/computer/csharp-picbox-zoom/
    public partial class MyPictureBox : UserControl
    {
        private Bitmap _src = null;
        private Graphics _g = null;
        private Matrix _affineMatrix = null;
        private bool _mouseMoving = false;
        private PointF _oldPoint;

        private readonly float _magnification = 1.1f;
        private readonly float _maxMagnification = 100f;
        private readonly float _minMagnification = 0.01f;

        public MyPictureBox()
        {
            InitializeComponent();

            Resize += MyPictureBox_Resize;
            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.MouseMove += PictureBox_MouseMove;
            pictureBox.MouseUp += PictureBox_MouseUp;
            pictureBox.MouseWheel += PictureBox_MouseWheel;
        }

        public void Set(Image image)
        {
            _src = new Bitmap(image);
            Reset();
        }
        public void Clear()
        {
            _src = null;
            ResetGraphics();
        }
        public void Reset()
        {
            if (_src == null) { return; }

            // フォームを最小化した場合にサイズが0となる
            if (Width == 0 || Height == 0) { return; }

            ResetGraphics();

            // 倍率をジャストサイズにする
            var xx = Math.Min((float)Width / _src.Width, (float)Height / _src.Height);
            _affineMatrix.Scale(xx, xx, MatrixOrder.Append);

            // 中央に配置
            var x = Math.Max(0, (Width - _src.Width * xx) / 2);
            var y = Math.Max(0, (Height - _src.Height * xx) / 2);
            _affineMatrix.Translate(x, y, MatrixOrder.Append);

            DrawImage();
        }
        public void Zoom(bool increase)
        {
            var x = (Location.X + Width) / 2;
            var y = (Location.Y + Height) / 2;
            var center = new Point(x, y);

            Zoom(increase, center);
        }

        private void MyPictureBox_Resize(object sender, EventArgs e)
        {
            if (_src == null) { return; }

            // PictureBoxのResizeイベントではなく、UserControlのResizeイベントで初期化を行う必要がある
            Reset();
        }
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (_src == null) { return; }

            _oldPoint.X = e.X;
            _oldPoint.Y = e.Y;
            _mouseMoving = true;
        }
        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_src == null) { return; }

            if (_mouseMoving == true)
            {
                // 以前の座標から移動量を算出
                var xx = e.X - _oldPoint.X;
                var yy = e.Y - _oldPoint.Y;

                _affineMatrix.Translate(xx, yy, MatrixOrder.Append);
                DrawImage();

                // ポインタ位置の保持
                _oldPoint.X = e.X;
                _oldPoint.Y = e.Y;
            }
        }
        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (_src == null) { return; }

            _mouseMoving = false;
        }
        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (_src == null) { return; }
            if ((ModifierKeys & Keys.Control) != Keys.Control) { return; }

            Zoom(e.Delta > 0, e.Location);
        }

        private void ResetGraphics()
        {
            if (_g != null)
            {
                _g.Dispose();
                _g = null;
            }

            pictureBox.Image?.Dispose();
            pictureBox.Image = new Bitmap(Width, Height);

            _g = Graphics.FromImage(pictureBox.Image);
            _g.InterpolationMode = InterpolationMode.Bilinear;

            _affineMatrix = new Matrix();
        }
        private void DrawImage()
        {
            if (_src == null) { return; }

            if (_affineMatrix != null)
            {
                _g.Transform = _affineMatrix;
            }

            _g.Clear(pictureBox.BackColor);
            _g.DrawImage(_src, 0, 0);

            pictureBox.Refresh();
        }
        private void Zoom(bool increase, Point point)
        {
            if (_src == null) { return; }

            // 一旦ポインタの位置 → 原点へ移動
            _affineMatrix.Translate(-point.X, -point.Y, MatrixOrder.Append);

            if (increase)
            {
                // 正の場合拡大
                if (_affineMatrix.Elements[0] < _maxMagnification)
                {
                    _affineMatrix.Scale(_magnification, _magnification, MatrixOrder.Append);
                }
            }
            else
            {
                // 負の場合縮小
                if (_affineMatrix.Elements[0] > _minMagnification)
                {
                    _affineMatrix.Scale(1.0f / _magnification, 1.0f / _magnification, MatrixOrder.Append);
                }
            }

            // 原点 → ポインタの位置へ移動(元の位置へ戻す)
            _affineMatrix.Translate(point.X, point.Y, MatrixOrder.Append);

            DrawImage();
        }
    }
}
