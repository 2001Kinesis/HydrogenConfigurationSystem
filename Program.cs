using System.Windows.Forms;
using Custom.HydrogenConfigurationSystem.Forms;
using Custom.HydrogenConfigurationSystem.Globals;
using Custom.HydrogenConfigurationSystem.Data.DB;

namespace Custom.HydrogenConfigurationSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 初始化数据库
            try
            {
                DbContext.InitDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"数据库初始化失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 初始化主题管理器
            ThemeManager.Initialize();

            // 显示登录窗体
            using (var loginForm = new FrmLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FrmMain());
                }
            }
        }
    }
}
