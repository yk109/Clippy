using System.Windows.Forms;

namespace Clippy
{
    public static class MessageBoxController
    {
        public static void ShowError(string message)
        {
            _ = MessageBox.Show(message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult ShowQuestion(string message)
        {
            return MessageBox.Show(message, "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
