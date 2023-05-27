using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Clippy
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    internal class ClipboardController : NativeWindow
    {
        private const int WM_DRAWCLIPBOARD = 0x0308;
        private const int WM_CHANGECBCHAIN = 0x030D;
        private IntPtr nextHandle = IntPtr.Zero;
        private readonly Action _action;

        public ClipboardController(Form form, Action action)
        {
            _action = action;

            form.HandleCreated += OnHandleCreated;
            form.HandleDestroyed += OnHandleDestroyed;
        }

        protected override void WndProc(ref Message msg)
        {
            // REMARK:なぜか2回呼ばれる
            if (msg.Msg == WM_DRAWCLIPBOARD)
            {
                if (Clipboard.ContainsImage())
                {
                    _action();
                }
            }

            if (msg.Msg == WM_CHANGECBCHAIN)
            {
                if (msg.WParam == nextHandle)
                {
                    // WParamが次のウィンドウのハンドルと同じなら
                    // 次のウィンドウはクリップボードビューアチェインから外れたことになる。
                    // 今後はLPARAM のハンドルに対してメッセージを送るため nextHandleを変更する
                    nextHandle = msg.LParam;
                }
                else if (nextHandle != IntPtr.Zero)
                {
                    // WPARAM が次のウィンドウでなければ、
                    // そのまま次のウィンドウにWM_CHANGECBCHAIN メッセージを送る
                    _ = SendMessage(nextHandle, msg.Msg, msg.WParam, msg.LParam);
                }
            }

            base.WndProc(ref msg);
        }

        private void OnHandleCreated(object sender, EventArgs e)
        {
            AssignHandle(((Form)sender).Handle);
            nextHandle = SetClipboardViewer(Handle);
        }
        private void OnHandleDestroyed(object sender, EventArgs e)
        {
            _ = ChangeClipboardChain(Handle, nextHandle);
            ReleaseHandle();
        }

        [DllImport("user32")]
        public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("user32")]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);
        [DllImport("user32")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
    }
}
