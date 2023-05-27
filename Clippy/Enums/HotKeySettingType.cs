using System;

namespace Clippy
{
    public enum HotKeySettingType
    {
        None = 0,
        DoubleCtrl = 1,
        DoubleShift = 2,
        DoubleAlt = 3,
        Custom = 99,
    }
    public static class HotKeySettingTypeExtensions
    {
        public static bool IsDoubleHotKey(this HotKeySettingType hotKeySettingType)
        {
            switch (hotKeySettingType)
            {
                case HotKeySettingType.DoubleCtrl:
                case HotKeySettingType.DoubleShift:
                case HotKeySettingType.DoubleAlt:
                    return true;
                case HotKeySettingType.None:
                case HotKeySettingType.Custom:
                    return false;
                default: throw new NotImplementedException();
            }
        }
    }
}
