using System;
using System.Runtime.InteropServices;

// TODO タスクマネージャーが最前面に出ているとき、ホットキーが無効になってしまう

namespace Clippy
{
    internal class HotKeyController
    {
        private readonly IHotKeySetting _setting;
        private readonly Action _action;
        private DateTime _lastHotKeyPushDateTime = DateTime.MinValue;

        public EventHandler EventHandler { get; }
        public int ID { get; }

        public HotKeyController(IntPtr handle, IHotKeySettingRepository settingRepository, Action action)
        {
            _setting = settingRepository.Get();
            _action = action;
            EventHandler = new EventHandler(OnHotKeyPush);

            if (_setting.HotKeySettyngType == HotKeySettingType.None) { return; }

            for (var id = 0x0000; id <= 0xbfff; id++)
            {
                if (RegisterHotKey(handle, id, (int)_setting.ModifyHotKey, (int)_setting.HotKey) != 0)
                {
                    ID = id;
                    return;
                }
            }

            var message = "ホットキーの登録に失敗しました。" + Environment.NewLine
                + "設定画面でホットキー設定を修正して下さい。";
            throw new Exception(message);
        }

        private void OnHotKeyPush(object sender, EventArgs e)
        {
            if (_setting.IsDoubleHotKey)
            {
                // 設定した時間内に連打した場合に起動する
                var span = DateTime.Now - _lastHotKeyPushDateTime;
                if (span >= _setting.DoubleHotKeyTimeSpan)
                {
                    _lastHotKeyPushDateTime = DateTime.Now;
                    return;
                }
            }

            _action();
        }

        [DllImport("user32.dll")]
        private static extern int RegisterHotKey(IntPtr hWnd, int id, int modifierKey, int key);
    }
}
