using Custom.HydrogenConfigurationSystem.Data.DB;
using Custom.HydrogenConfigurationSystem.Data.Entities;
using Custom.HydrogenConfigurationSystem.Globals;
using Custom.HydrogenConfigurationSystem.Helpers;

namespace Custom.HydrogenConfigurationSystem.Forms
{
    public partial class FrmLogin : Form
    {
        private readonly UserService _userService;
        private int _loginAttempts = 0;
        private const int MaxLoginAttempts = 5;

        public FrmLogin()
        {
            InitializeComponent();
            _userService = new UserService();
            InitializeDefaultUsers();
        }

        private void InitializeDefaultUsers()
        {
            try
            {
                var users = _userService.GetList();
                if (users.Count == 0)
                {
                    _userService.Add(new UserEntity { UserName = "Admin", UserPassword = "123", Role = "Admin" });
                    _userService.Add(new UserEntity { UserName = "Operator", UserPassword = "123", Role = "Operator" });
                    _userService.Add(new UserEntity { UserName = "Visitor", UserPassword = "123", Role = "Visitor" });
                    LogHelper.Info("初始化默认用户成功");
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("初始化默认用户失败：" + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(userName))
            {
                UIHelper.ShowError("请输入用户名");
                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                UIHelper.ShowError("请输入密码");
                txtPassword.Focus();
                return;
            }

            if (_loginAttempts >= MaxLoginAttempts)
            {
                UIHelper.ShowError($"登录次数过多，请稍后再试（最多{MaxLoginAttempts}次）");
                btnLogin.Enabled = false;
                return;
            }

            try
            {
                var user = _userService.GetByUserName(userName);
                if (user == null || user.UserPassword != password)
                {
                    _loginAttempts++;
                    int remaining = MaxLoginAttempts - _loginAttempts;
                    UIHelper.ShowError($"用户名或密码错误，剩余尝试次数：{remaining}");
                    LogHelper.Warn($"用户登录失败：{userName}，剩余尝试次数：{remaining}");
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                GlobalVariables.CurrentUserName = user.UserName;
                GlobalVariables.CurrentUserRole = user.Role;

                LogHelper.LogOperate("用户登录", "用户登录成功", user.UserName);
                LogHelper.Info($"用户登录成功：{userName}，角色：{user.Role}");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                UIHelper.ShowError("登录失败：" + ex.Message);
                LogHelper.Error("登录异常：" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(sender, e);
            }
        }
    }
}
