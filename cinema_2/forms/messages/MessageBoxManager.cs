using System;
using System.Text;
using System.Windows.Forms;

namespace cinema_2.forms.messages
{
    public class MessageBoxManager
    {
        public static void Error(string title, string message)
        {
            Show(title, message, MessageBoxIcon.Error);
        }

        public static void Exclamation(string title, string message)
        {
            Show(title, message, MessageBoxIcon.Exclamation);
        }

        private static void Show(string title, string message, MessageBoxIcon mbi)
        {
            MessageBox.Show(
                   message,
                   title,
                   MessageBoxButtons.OK,
                   mbi,
                   MessageBoxDefaultButton.Button1);
        }
    }
}
