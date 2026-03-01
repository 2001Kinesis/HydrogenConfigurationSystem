using Custom.HydrogenConfigurationSystem.Data.DB;
using Custom.HydrogenConfigurationSystem.Data.Entities;
using Custom.HydrogenConfigurationSystem.Helpers;
using Custom.HydrogenConfigurationSystem.Globals;

namespace Custom.HydrogenConfigurationSystem.Forms
{
    public partial class FrmUserManager : Form
    {
        private readonly UserService _userService;
        private readonly RoleAuthService _roleAuthService;
        private UserEntity? _selectedUser;
        private bool _isEditMode = false;
        private int _editingUserId = -1;

        public FrmUserManager()
        {
            InitializeComponent();
            _userService = new UserService();
            _roleAuthService = new RoleAuthService();
            InitializeDataGridView();
            InitializeEventHandlers();
            LoadUsers();
            SetEditMode(false);
        }

        private void InitializeDataGridView()
        {
            uiDataGridViewUsers.AutoGenerateColumns = false;
            uiDataGridViewUsers.Columns.Clear();
            uiDataGridViewUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id",
                Width = 60,
                Visible = false
            });
            uiDataGridViewUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "UserName",
                HeaderText = "用户名",
                DataPropertyName = "UserName",
                Width = 180
            });
            uiDataGridViewUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Role",
                HeaderText = "角色",
                DataPropertyName = "Role",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void InitializeEventHandlers()
        {
            uiButtonAdd.Click += UiButtonAdd_Click;
            uiButtonEdit.Click += UiButtonEdit_Click;
            uiButtonDelete.Click += UiButtonDelete_Click;
            uiButtonSave.Click += UiButtonSave_Click;
            uiButtonCancel.Click += UiButtonCancel_Click;
            uiButtonSaveRoleAuth.Click += UiButtonSaveRoleAuth_Click;
            uiDataGridViewUsers.SelectionChanged += UiDataGridViewUsers_SelectionChanged;
            uiComboBoxRole.SelectedIndexChanged += UiComboBoxRole_SelectedIndexChanged;
        }

        private void LoadUsers()
        {
            try
            {
                var users = _userService.GetList();
                uiDataGridViewUsers.DataSource = users;
                if (users.Count > 0)
                {
                    uiDataGridViewUsers.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError("加载用户列表失败：" + ex.Message);
                LogHelper.Error("加载用户列表失败：" + ex.Message);
            }
        }

        private void UiDataGridViewUsers_SelectionChanged(object? sender, EventArgs e)
        {
            if (uiDataGridViewUsers.SelectedRows.Count > 0)
            {
                var row = uiDataGridViewUsers.SelectedRows[0];
                _selectedUser = row.DataBoundItem as UserEntity;
                LoadRoleAuth(_selectedUser?.Role ?? "");
            }
            else
            {
                _selectedUser = null;
            }
            SetEditMode(_isEditMode);
        }

        private void UiComboBoxRole_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (uiComboBoxRole.SelectedItem != null)
            {
                string role = uiComboBoxRole.SelectedItem.ToString() switch
                {
                    "管理员" => "Admin",
                    "操作员" => "Operator",
                    "访客" => "Visitor",
                    _ => ""
                };
                LoadRoleAuth(role);
            }
        }

        private void LoadRoleAuth(string role)
        {
            try
            {
                var roleAuth = _roleAuthService.GetByRole(role);
                if (roleAuth != null)
                {
                    uiCheckBoxControlAuth.Checked = roleAuth.ControlAuth;
                    uiCheckBoxMonitorAuth.Checked = roleAuth.MonitorAuth;
                    uiCheckBoxRecipeAuth.Checked = roleAuth.RecipeAuth;
                    uiCheckBoxLogAuth.Checked = roleAuth.LogAuth;
                    uiCheckBoxReportAuth.Checked = roleAuth.ReportAuth;
                    uiCheckBoxConfigAuth.Checked = roleAuth.ConfigAuth;
                    uiCheckBoxUserAuth.Checked = roleAuth.UserAuth;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("加载角色权限失败：" + ex.Message);
            }
        }

        private void UiButtonAdd_Click(object? sender, EventArgs e)
        {
            if (!PermissionHelper.CanManageUser())
            {
                UIHelper.ShowError("您没有用户管理权限");
                return;
            }

            _isEditMode = true;
            _editingUserId = -1;
            ClearEditPanel();
            SetEditMode(true);
            uiTextBoxUserName.Focus();
        }

        private void UiButtonEdit_Click(object? sender, EventArgs e)
        {
            if (!PermissionHelper.CanManageUser())
            {
                UIHelper.ShowError("您没有用户管理权限");
                return;
            }

            if (_selectedUser == null)
            {
                UIHelper.ShowInfo("请先选择要编辑的用户");
                return;
            }

            _isEditMode = true;
            _editingUserId = _selectedUser.Id;
            uiTextBoxUserName.Text = _selectedUser.UserName;
            uiTextBoxPassword.Text = _selectedUser.UserPassword;
            uiComboBoxRole.SelectedIndex = _selectedUser.Role switch
            {
                "Admin" => 0,
                "Operator" => 1,
                "Visitor" => 2,
                _ => 0
            };
            SetEditMode(true);
            uiTextBoxUserName.Focus();
        }

        private void UiButtonDelete_Click(object? sender, EventArgs e)
        {
            if (!PermissionHelper.CanManageUser())
            {
                UIHelper.ShowError("您没有用户管理权限");
                return;
            }

            if (_selectedUser == null)
            {
                UIHelper.ShowInfo("请先选择要删除的用户");
                return;
            }

            if (_selectedUser.UserName == GlobalVariables.CurrentUserName)
            {
                UIHelper.ShowError("不能删除当前登录用户");
                return;
            }

            var result = MessageBox.Show($"确定要删除用户 \"{_selectedUser.UserName}\" 吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (_userService.Delete(_selectedUser.Id))
                    {
                        UIHelper.ShowInfo("删除成功");
                        LogHelper.Info($"删除用户：{_selectedUser.UserName}");
                        LoadUsers();
                        _selectedUser = null;
                    }
                    else
                    {
                        UIHelper.ShowError("删除失败");
                    }
                }
                catch (Exception ex)
                {
                    UIHelper.ShowError("删除失败：" + ex.Message);
                    LogHelper.Error("删除用户失败：" + ex.Message);
                }
            }
        }

        private void UiButtonSave_Click(object? sender, EventArgs e)
        {
            string userName = uiTextBoxUserName.Text.Trim();
            string password = uiTextBoxPassword.Text;
            string role = uiComboBoxRole.SelectedItem?.ToString() switch
            {
                "管理员" => "Admin",
                "操作员" => "Operator",
                "访客" => "Visitor",
                _ => ""
            };

            if (string.IsNullOrEmpty(userName))
            {
                UIHelper.ShowError("请输入用户名");
                uiTextBoxUserName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                UIHelper.ShowError("请输入密码");
                uiTextBoxPassword.Focus();
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                UIHelper.ShowError("请选择角色");
                uiComboBoxRole.Focus();
                return;
            }

            try
            {
                if (_editingUserId == -1)
                {
                    var existingUser = _userService.GetByUserName(userName);
                    if (existingUser != null)
                    {
                        UIHelper.ShowError("用户名已存在");
                        uiTextBoxUserName.Focus();
                        return;
                    }

                    var newUser = new UserEntity
                    {
                        UserName = userName,
                        UserPassword = password,
                        Role = role
                    };

                    if (_userService.Add(newUser))
                    {
                        UIHelper.ShowInfo("添加成功");
                        LogHelper.Info($"添加用户：{userName}，角色：{role}");
                        LoadUsers();
                        SetEditMode(false);
                    }
                    else
                    {
                        UIHelper.ShowError("添加失败");
                    }
                }
                else
                {
                    var userToUpdate = new UserEntity
                    {
                        Id = _editingUserId,
                        UserName = userName,
                        UserPassword = password,
                        Role = role
                    };

                    if (_userService.Update(userToUpdate))
                    {
                        UIHelper.ShowInfo("修改成功");
                        LogHelper.Info($"修改用户：{userName}，角色：{role}");
                        LoadUsers();
                        SetEditMode(false);
                    }
                    else
                    {
                        UIHelper.ShowError("修改失败");
                    }
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError("保存失败：" + ex.Message);
                LogHelper.Error("保存用户失败：" + ex.Message);
            }
        }

        private void UiButtonCancel_Click(object? sender, EventArgs e)
        {
            SetEditMode(false);
            ClearEditPanel();
        }

        private void UiButtonSaveRoleAuth_Click(object? sender, EventArgs e)
        {
            if (!PermissionHelper.CanManageUser())
            {
                UIHelper.ShowError("您没有用户管理权限");
                return;
            }

            string role = uiComboBoxRole.SelectedItem?.ToString() switch
            {
                "管理员" => "Admin",
                "操作员" => "Operator",
                "访客" => "Visitor",
                _ => ""
            };

            if (string.IsNullOrEmpty(role))
            {
                UIHelper.ShowError("请选择角色");
                return;
            }

            try
            {
                var roleAuth = _roleAuthService.GetByRole(role);
                if (roleAuth != null)
                {
                    roleAuth.ControlAuth = uiCheckBoxControlAuth.Checked;
                    roleAuth.MonitorAuth = uiCheckBoxMonitorAuth.Checked;
                    roleAuth.RecipeAuth = uiCheckBoxRecipeAuth.Checked;
                    roleAuth.LogAuth = uiCheckBoxLogAuth.Checked;
                    roleAuth.ReportAuth = uiCheckBoxReportAuth.Checked;
                    roleAuth.ConfigAuth = uiCheckBoxConfigAuth.Checked;
                    roleAuth.UserAuth = uiCheckBoxUserAuth.Checked;

                    if (_roleAuthService.Update(roleAuth))
                    {
                        UIHelper.ShowInfo("权限保存成功");
                        LogHelper.Info($"保存角色权限：{role}");
                    }
                    else
                    {
                        UIHelper.ShowError("权限保存失败");
                    }
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError("保存权限失败：" + ex.Message);
                LogHelper.Error("保存角色权限失败：" + ex.Message);
            }
        }

        private void SetEditMode(bool isEditing)
        {
            _isEditMode = isEditing;
            uiButtonAdd.Enabled = !isEditing;
            uiButtonEdit.Enabled = !isEditing && _selectedUser != null;
            uiButtonDelete.Enabled = !isEditing && _selectedUser != null;
            uiButtonSave.Enabled = isEditing;
            uiButtonCancel.Enabled = isEditing;
            uiTextBoxUserName.Enabled = isEditing;
            uiTextBoxPassword.Enabled = isEditing;
            uiComboBoxRole.Enabled = isEditing;
            uiDataGridViewUsers.Enabled = !isEditing;
        }

        private void ClearEditPanel()
        {
            uiTextBoxUserName.Clear();
            uiTextBoxPassword.Clear();
            uiComboBoxRole.SelectedIndex = -1;
            _isEditMode = false;
            _editingUserId = -1;
        }
    }
}
