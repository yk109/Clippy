using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clippy
{
    internal partial class ExportExcelForm : Form
    {
        private readonly IExcelExportSetting _setting;
        private readonly IEnumerable<PictureInfo> _pictures;
        private bool _nextAllSelect = true;
        private bool _nextAllTrim = true;
        private Rectangle _dragBoxFromMouseDown;
        private int _rowIndexDragFrom;

        public ExportExcelForm(IEnumerable<PictureInfo> pictures, IExcelExportSetting setting)
        {
            _pictures = pictures;
            _setting = setting;

            InitializeComponent();
            dtpFilterFrom.Value = DateTime.Now.Date;
            dtpFilterTo.Value = DateTime.Now.Date;
        }

        private void ExportExcelForm_Load(object sender, EventArgs e)
        {
            // 日付をセットした後にOFFにする必要がある
            dtpFilterFrom.Checked = false;
            dtpFilterTo.Checked = false;
            DisplayPictures(DateTime.MinValue, DateTime.MaxValue);
        }
        private void ExportExcelForm_KeyDown(object sender, KeyEventArgs e)
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
        private void DgvRepository_SelectionChanged(object sender, EventArgs e)
        {
            var rows = dgvRepository.SelectedRows;
            if (rows.Count == 0) { return; }

            var image = (Image)rows[0].Cells[ColImage.Index].Value;
            pictureBox.Set(image);
        }
        private void DgvRepository_MouseDown(object sender, MouseEventArgs e)
        {
            _rowIndexDragFrom = dgvRepository.HitTest(e.X, e.Y).RowIndex;

            if (_rowIndexDragFrom == -1)
            {
                _dragBoxFromMouseDown = Rectangle.Empty;
                return;
            }

            var size = SystemInformation.DragSize;
            _dragBoxFromMouseDown = new Rectangle(new Point(e.X - (size.Width / 2), e.Y - (size.Height / 2)), size);
        }
        private void DgvRepository_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { return; }

            if (_dragBoxFromMouseDown == Rectangle.Empty) { return; }

            if (_dragBoxFromMouseDown.Contains(e.X, e.Y)) { return; }

            _ = dgvRepository.DoDragDrop(dgvRepository.Rows[_rowIndexDragFrom], DragDropEffects.Move);
        }
        private void DgvRepository_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void DgvRepository_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Effect != DragDropEffects.Move) { return; }

            var p = dgvRepository.PointToClient(new Point(e.X, e.Y));
            var toIndex = dgvRepository.HitTest(p.X, p.Y).RowIndex;
            if (toIndex == -1) { return; }

            var row = dgvRepository.Rows[_rowIndexDragFrom];
            dgvRepository.Rows.RemoveAt(_rowIndexDragFrom);
            dgvRepository.Rows.Insert(toIndex, row);
            dgvRepository.CurrentCell = dgvRepository.Rows[toIndex].Cells[0];
        }
        private void BtnExportExcel_Click(object sender, EventArgs e)
        {
            var infos = GetSelectedPictureInfo().ToList();
            if (!infos.Any())
            {
                MessageBoxController.ShowError("Excel出力対象の画像が選択されていません。");
                return;
            }

            string path;
            using (var d = new SaveFileDialog
            {
                FileName = "画像一覧.xlsx",
                Filter = "Excel|*.xlsx",
            })
            {
                if (d.ShowDialog() != DialogResult.OK) { return; }

                path = d.FileName;
            }

            try
            {
                var controller = new ExcelController(_setting);
                controller.Export(infos, path);
                _ = Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBoxController.ShowError($"Excel出力処理でエラーが発生しました。{ex}");
            }
        }
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            if (dtpFilterFrom.Checked && dtpFilterTo.Checked && dtpFilterFrom.Value > dtpFilterTo.Value)
            {
                MessageBoxController.ShowError($"抽出条件の開始日付と終了日付の大小が不正です。");
                return;
            }

            var from = dtpFilterFrom.Checked ? dtpFilterFrom.Value : DateTime.MinValue;
            var to = dtpFilterTo.Checked ? dtpFilterTo.Value : DateTime.MaxValue;
            DisplayPictures(from, to);
        }
        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRepository.Rows)
            {
                row.Cells[ColSelect.Index].Value = _nextAllSelect;
            }

            _nextAllSelect = !_nextAllSelect;
        }
        private void BtnTrimAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRepository.Rows)
            {
                row.Cells[ColTrim.Index].Value = _nextAllTrim;
            }

            _nextAllTrim = !_nextAllTrim;
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayPictures(DateTime from, DateTime to)
        {
            dgvRepository.Rows.Clear();
            pictureBox.Clear();

            foreach (var p in _pictures.Where(x => x.DateTime >= from && x.DateTime <= to))
            {
                _ = dgvRepository.Rows.Add(new object[]
                {
                    false,
                    false,
                    p.DateTime,
                    p.Image,
                    p.Path,
                });
            }
        }
        private IEnumerable<ExcelExportPictureInfo> GetSelectedPictureInfo()
        {
            foreach (DataGridViewRow row in dgvRepository.Rows)
            {
                if (!(bool)row.Cells[ColSelect.Index].Value) { continue; }

                yield return new ExcelExportPictureInfo
                {
                    Trime = (bool)row.Cells[ColTrim.Index].Value,
                    Path = (string)row.Cells[ColPath.Index].Value,
                    Image = (Image)row.Cells[ColImage.Index].Value,
                };
            }
        }
    }
}
