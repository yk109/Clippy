using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Clippy
{
    [DataContract]
    internal class AppSetting : IPictureRepositorySetting, IHotKeySetting, IExcelExportSetting
    {
        [DataMember]
        public bool SkipStartWindow { get; set; }
        [DataMember]
        public string PictureSaveFolderPath { get; set; } = Path.Combine(Program.ClippyFolderPath, "pictures");
        [DataMember]
        public bool AutoDeletePicture { get; set; } = false;
        [DataMember]
        public TimeSpan SavePictureTimeSpan { get; set; } = TimeSpan.FromDays(10);
        [DataMember]
        public HotKeySettingType HotKeySettyngType { get; set; } = HotKeySettingType.DoubleShift;
        [DataMember]
        public bool IsDoubleHotKey { get; set; } = true;
        [DataMember]
        public TimeSpan DoubleHotKeyTimeSpan { get; set; } = TimeSpan.FromMilliseconds(500);
        [DataMember]
        public ModifierKey ModifyHotKey { get; set; } = ModifierKey.Shift;
        [DataMember]
        public Keys HotKey { get; set; } = 0;
        [DataMember]
        public string DisplayHotKey { get; set; } = string.Empty;
        [DataMember]
        public int TrimTop { get; set; } = 0;
        [DataMember]
        public int TrimBottom { get; set; } = 22;
        [DataMember]
        public int TrimLeft { get; set; } = 0;
        [DataMember]
        public int TrimRight { get; set; } = 0;
        [DataMember]
        public int BorderWidth { get; set; } = 0;
        [DataMember]
        public ExcelExportBorderColor BorderColor { get; set; } = ExcelExportBorderColor.Black;
    }

    public interface IPictureRepositorySetting
    {
        string PictureSaveFolderPath { get; }
        bool AutoDeletePicture { get; }
        TimeSpan SavePictureTimeSpan { get; }
    }
    public interface IHotKeySetting
    {
        HotKeySettingType HotKeySettyngType { get; }
        bool IsDoubleHotKey { get; }
        TimeSpan DoubleHotKeyTimeSpan { get; }
        ModifierKey ModifyHotKey { get; }
        Keys HotKey { get; }
    }
    public interface IExcelExportSetting
    {
        int TrimTop { get; }
        int TrimBottom { get; }
        int TrimLeft { get; }
        int TrimRight { get; }
        int BorderWidth { get; }
        ExcelExportBorderColor BorderColor { get; }
    }
}
