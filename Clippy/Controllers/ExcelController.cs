using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Clippy
{
    internal class ExcelController
    {
        private readonly IExcelExportSetting _setting;

        public ExcelController(IExcelExportSetting setting)
        {
            _setting = setting;
        }

        public void Export(List<ExcelExportPictureInfo> infos, string path)
        {
            using (var book = new XLWorkbook())
            {
                var sheet = book.AddWorksheet("画像一覧");
                sheet.ColumnWidth = 2;
                _ = sheet.Style.Font.SetFontName("Meiryo UI");

                // Excel行の高さ単位:ピクセル単位 = 5:7
                var rowPixcelHeight = sheet.RowHeight * 7 / 5;
                var row = 2;
                foreach (var info in infos)
                {
                    var image = ModifyImage(info);
                    var cell = sheet.Cell(row, 2);

                    using (var stream = new MemoryStream())
                    {
                        image.Save(stream, ImageFormat.Png);
                        _ = sheet.Pictures.Add(stream).MoveTo(cell);
                    }

                    row += 2 + (image.Height / (int)rowPixcelHeight);
                }

                book.SaveAs(path);
            }
        }

        private Image ModifyImage(ExcelExportPictureInfo info)
        {
            var trimTop = info.Trime ? _setting.TrimTop : 0;
            var trimBottom = info.Trime ? _setting.TrimBottom : 0;
            var trimLeft = info.Trime ? _setting.TrimLeft : 0;
            var trimRight = info.Trime ? _setting.TrimRight : 0;

            var width = info.Image.Width - trimLeft - trimRight;
            var height = info.Image.Height - trimBottom - trimTop;

            if (width <= 0 || height <= 0)
            {
                var message = $"切取結果のサイズが 0 以下になってしまいました。" + Environment.NewLine +
                    $"ファイル名：{info.Path}" + Environment.NewLine +
                    $"縦：{info.Image.Height}px 横：{info.Image.Width}px";
                throw new ClippyException(message);
            }

            var borderWidth = _setting.BorderWidth;
            var borderBrush = _setting.BorderColor == ExcelExportBorderColor.Black ? Brushes.Black
                : _setting.BorderColor == ExcelExportBorderColor.Blue ? Brushes.DodgerBlue
                : _setting.BorderColor == ExcelExportBorderColor.Silver ? Brushes.Silver
                : throw new NotImplementedException();

            var result = new Bitmap(width + (2 * borderWidth), height + (2 * borderWidth));
            var source = new Rectangle(trimLeft, trimTop, width, height);
            var dest = new Rectangle(borderWidth, borderWidth, width, height);
            using (var g = Graphics.FromImage(result))
            {
                g.FillRectangle(borderBrush, new Rectangle(0, 0, result.Width, result.Height));
                g.DrawImage(info.Image, dest, source, GraphicsUnit.Pixel);
            }

            return result;
        }
    }
}
