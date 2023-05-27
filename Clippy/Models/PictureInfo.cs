using System;
using System.Drawing;

namespace Clippy
{
    internal class PictureInfo
    {
        public Image Image { get; set; }
        public string Path { get; set; }
        public DateTime DateTime { get; set; }
        public long Size { get; set; }
        public string Hash { get; set; }
    }
}
