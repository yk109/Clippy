using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;

namespace Clippy
{
    internal class SettingRepository : IPictureRepositorySettingRepository, IHotKeySettingRepository, IExcelExportSettingRepository
    {
        private AppSetting _setting;
        private readonly string _settingSavePath = Path.Combine(Program.ClippyFolderPath, "clippy.setting.json");
        private readonly DataContractJsonSerializer _serializer = new DataContractJsonSerializer(typeof(AppSetting), new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true });

        public SettingRepository()
        {
            if (!File.Exists(_settingSavePath))
            {
                Save(new AppSetting());
                return;
            }

            using (var stream = new FileStream(_settingSavePath, FileMode.Open, FileAccess.Read))
            using (var reader = JsonReaderWriterFactory.CreateJsonReader(stream, XmlDictionaryReaderQuotas.Max))
            {
                _setting = (AppSetting)_serializer.ReadObject(reader);
            }
        }

        public AppSetting Get() { return _setting; }
        IHotKeySetting IHotKeySettingRepository.Get() { return _setting; }
        IPictureRepositorySetting IPictureRepositorySettingRepository.Get() { return _setting; }
        IExcelExportSetting IExcelExportSettingRepository.Get() { return _setting; }

        public void Save(AppSetting setting)
        {
            _setting = setting;

            using (var stream = new FileStream(_settingSavePath, FileMode.Create, FileAccess.Write))
            using (var writer = JsonReaderWriterFactory.CreateJsonWriter(stream, Encoding.UTF8, true, true))
            {
                _serializer.WriteObject(writer, setting);
            }
        }
    }

    public interface IPictureRepositorySettingRepository
    {
        IPictureRepositorySetting Get();
    }
    public interface IHotKeySettingRepository
    {
        IHotKeySetting Get();
    }
    public interface IExcelExportSettingRepository
    {
        IExcelExportSetting Get();
    }
}
