using System.Drawing;
using System.Windows.Forms;

namespace Custom.HydrogenConfigurationSystem.Helpers
{
    public class UIHelper
    {
        public static void ShowInfo(string message, string title = "提示")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowWarning(string message, string title = "警告")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowError(string message, string title = "错误")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool ShowConfirm(string message, string title = "确认")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
        }

        public static void UpdateControlAsync(Control control, Action updateAction)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() => updateAction()));
            }
            else
            {
                updateAction();
            }
        }

        public static void SetTheme(Form form, string themeName = "Dark")
        {
            if (themeName == "Dark")
            {
                form.BackColor = Color.FromArgb(15, 23, 42);
            }
            else if (themeName == "Blue")
            {
                form.BackColor = Color.FromArgb(20, 50, 100);
            }
            else if (themeName == "Green")
            {
                form.BackColor = Color.FromArgb(20, 60, 40);
            }
            else if (themeName == "Orange")
            {
                form.BackColor = Color.FromArgb(80, 50, 20);
            }
        }

        public static void SetFont(Control control, string fontName, float fontSize)
        {
            try
            {
                control.Font = new Font(fontName, fontSize);
            }
            catch
            {
                control.Font = new Font("Microsoft YaHei", fontSize);
            }
        }
    }
}
