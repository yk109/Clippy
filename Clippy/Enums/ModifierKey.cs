using System;

namespace Clippy
{
    [Flags]
    public enum ModifierKey
    {
        None = 0x0000,
        Alt = 0x0001,
        Ctrl = 0x0002,
        Shift = 0x0004,
        // TODO いつかWinキーのホットキー対応したい
        //Win = 0x0312,
    }
}
