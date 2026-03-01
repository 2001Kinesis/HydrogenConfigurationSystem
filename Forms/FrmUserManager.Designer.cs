namespace Custom.HydrogenConfigurationSystem.Forms
{
    partial class FrmUserManager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            uiPanelTitle = new Panel();
            uiLabelSubtitle = new Label();
            uiLabelTitle = new Label();
            uiPanelUserList = new Panel();
            uiDataGridViewUsers = new DataGridView();
            uiPanelUserEdit = new Panel();
            uiButtonCancel = new Button();
            uiButtonSave = new Button();
            uiComboBoxRole = new ComboBox();
            uiLabelRole = new Label();
            uiTextBoxPassword = new TextBox();
            uiLabelPassword = new Label();
            uiTextBoxUserName = new TextBox();
            uiLabelUserName = new Label();
            uiLabelEditTitle = new Label();
            uiPanelButtons = new Panel();
            uiButtonDelete = new Button();
            uiButtonEdit = new Button();
            uiButtonAdd = new Button();
            uiPanelRoleAuth = new Panel();
            uiButtonSaveRoleAuth = new Button();
            uiCheckBoxUserAuth = new CheckBox();
            uiCheckBoxConfigAuth = new CheckBox();
            uiCheckBoxReportAuth = new CheckBox();
            uiCheckBoxLogAuth = new CheckBox();
            uiCheckBoxRecipeAuth = new CheckBox();
            uiCheckBoxMonitorAuth = new CheckBox();
            uiCheckBoxControlAuth = new CheckBox();
            uiLabelRoleAuthTitle = new Label();
            uiPanelTitle.SuspendLayout();
            uiPanelUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridViewUsers).BeginInit();
            uiPanelUserEdit.SuspendLayout();
            uiPanelButtons.SuspendLayout();
            uiPanelRoleAuth.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanelTitle
            // 
            uiPanelTitle.BackColor = Color.Transparent;
            uiPanelTitle.Controls.Add(uiLabelSubtitle);
            uiPanelTitle.Controls.Add(uiLabelTitle);
            uiPanelTitle.Location = new Point(20, 20);
            uiPanelTitle.Name = "uiPanelTitle";
            uiPanelTitle.Size = new Size(1160, 60);
            uiPanelTitle.TabIndex = 0;
            // 
            // uiLabelSubtitle
            // 
            uiLabelSubtitle.AutoSize = true;
            uiLabelSubtitle.Font = new Font("微软雅黑", 10F);
            uiLabelSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelSubtitle.Location = new Point(174, 19);
            uiLabelSubtitle.Name = "uiLabelSubtitle";
            uiLabelSubtitle.Size = new Size(192, 27);
            uiLabelSubtitle.TabIndex = 1;
            uiLabelSubtitle.Text = "用户和角色权限管理";
            // 
            // uiLabelTitle
            // 
            uiLabelTitle.AutoSize = true;
            uiLabelTitle.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            uiLabelTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelTitle.Location = new Point(4, 2);
            uiLabelTitle.Name = "uiLabelTitle";
            uiLabelTitle.Size = new Size(164, 47);
            uiLabelTitle.TabIndex = 0;
            uiLabelTitle.Text = "用户管理";
            // 
            // uiPanelUserList
            // 
            uiPanelUserList.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelUserList.BorderStyle = BorderStyle.FixedSingle;
            uiPanelUserList.Controls.Add(uiDataGridViewUsers);
            uiPanelUserList.Location = new Point(20, 100);
            uiPanelUserList.Name = "uiPanelUserList";
            uiPanelUserList.Size = new Size(560, 520);
            uiPanelUserList.TabIndex = 1;
            // 
            // uiDataGridViewUsers
            // 
            uiDataGridViewUsers.AllowUserToAddRows = false;
            uiDataGridViewUsers.AllowUserToDeleteRows = false;
            uiDataGridViewUsers.BackgroundColor = Color.FromArgb(15, 23, 42);
            uiDataGridViewUsers.BorderStyle = BorderStyle.None;
            uiDataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            uiDataGridViewUsers.Dock = DockStyle.Fill;
            uiDataGridViewUsers.GridColor = Color.FromArgb(51, 65, 85);
            uiDataGridViewUsers.Location = new Point(0, 0);
            uiDataGridViewUsers.Name = "uiDataGridViewUsers";
            uiDataGridViewUsers.ReadOnly = true;
            uiDataGridViewUsers.RowHeadersWidth = 62;
            uiDataGridViewUsers.RowTemplate.Height = 23;
            uiDataGridViewUsers.Size = new Size(558, 518);
            uiDataGridViewUsers.TabIndex = 0;
            // 
            // uiPanelUserEdit
            // 
            uiPanelUserEdit.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelUserEdit.BorderStyle = BorderStyle.FixedSingle;
            uiPanelUserEdit.Controls.Add(uiButtonCancel);
            uiPanelUserEdit.Controls.Add(uiButtonSave);
            uiPanelUserEdit.Controls.Add(uiComboBoxRole);
            uiPanelUserEdit.Controls.Add(uiLabelRole);
            uiPanelUserEdit.Controls.Add(uiTextBoxPassword);
            uiPanelUserEdit.Controls.Add(uiLabelPassword);
            uiPanelUserEdit.Controls.Add(uiTextBoxUserName);
            uiPanelUserEdit.Controls.Add(uiLabelUserName);
            uiPanelUserEdit.Controls.Add(uiLabelEditTitle);
            uiPanelUserEdit.Location = new Point(600, 100);
            uiPanelUserEdit.Name = "uiPanelUserEdit";
            uiPanelUserEdit.Size = new Size(560, 264);
            uiPanelUserEdit.TabIndex = 2;
            // 
            // uiButtonCancel
            // 
            uiButtonCancel.BackColor = Color.FromArgb(107, 114, 128);
            uiButtonCancel.FlatAppearance.BorderSize = 0;
            uiButtonCancel.FlatStyle = FlatStyle.Flat;
            uiButtonCancel.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            uiButtonCancel.ForeColor = Color.White;
            uiButtonCancel.Location = new Point(137, 210);
            uiButtonCancel.Name = "uiButtonCancel";
            uiButtonCancel.Size = new Size(100, 35);
            uiButtonCancel.TabIndex = 8;
            uiButtonCancel.Text = "取消";
            uiButtonCancel.UseVisualStyleBackColor = false;
            // 
            // uiButtonSave
            // 
            uiButtonSave.BackColor = Color.FromArgb(34, 197, 94);
            uiButtonSave.FlatAppearance.BorderSize = 0;
            uiButtonSave.FlatStyle = FlatStyle.Flat;
            uiButtonSave.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            uiButtonSave.ForeColor = Color.White;
            uiButtonSave.Location = new Point(20, 210);
            uiButtonSave.Name = "uiButtonSave";
            uiButtonSave.Size = new Size(100, 35);
            uiButtonSave.TabIndex = 7;
            uiButtonSave.Text = "保存";
            uiButtonSave.UseVisualStyleBackColor = false;
            // 
            // uiComboBoxRole
            // 
            uiComboBoxRole.BackColor = Color.FromArgb(15, 23, 42);
            uiComboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            uiComboBoxRole.Font = new Font("微软雅黑", 10F);
            uiComboBoxRole.ForeColor = Color.White;
            uiComboBoxRole.FormattingEnabled = true;
            uiComboBoxRole.Items.AddRange(new object[] { "管理员", "操作员", "访客" });
            uiComboBoxRole.Location = new Point(20, 159);
            uiComboBoxRole.Name = "uiComboBoxRole";
            uiComboBoxRole.Size = new Size(200, 35);
            uiComboBoxRole.TabIndex = 6;
            // 
            // uiLabelRole
            // 
            uiLabelRole.AutoSize = true;
            uiLabelRole.Font = new Font("微软雅黑", 10F);
            uiLabelRole.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelRole.Location = new Point(20, 129);
            uiLabelRole.Name = "uiLabelRole";
            uiLabelRole.Size = new Size(52, 27);
            uiLabelRole.TabIndex = 5;
            uiLabelRole.Text = "角色";
            // 
            // uiTextBoxPassword
            // 
            uiTextBoxPassword.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxPassword.Font = new Font("微软雅黑", 10F);
            uiTextBoxPassword.ForeColor = Color.White;
            uiTextBoxPassword.Location = new Point(260, 92);
            uiTextBoxPassword.Name = "uiTextBoxPassword";
            uiTextBoxPassword.PasswordChar = '*';
            uiTextBoxPassword.Size = new Size(200, 34);
            uiTextBoxPassword.TabIndex = 4;
            // 
            // uiLabelPassword
            // 
            uiLabelPassword.AutoSize = true;
            uiLabelPassword.Font = new Font("微软雅黑", 10F);
            uiLabelPassword.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelPassword.Location = new Point(260, 62);
            uiLabelPassword.Name = "uiLabelPassword";
            uiLabelPassword.Size = new Size(52, 27);
            uiLabelPassword.TabIndex = 3;
            uiLabelPassword.Text = "密码";
            // 
            // uiTextBoxUserName
            // 
            uiTextBoxUserName.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxUserName.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxUserName.Font = new Font("微软雅黑", 10F);
            uiTextBoxUserName.ForeColor = Color.White;
            uiTextBoxUserName.Location = new Point(20, 92);
            uiTextBoxUserName.Name = "uiTextBoxUserName";
            uiTextBoxUserName.Size = new Size(200, 34);
            uiTextBoxUserName.TabIndex = 2;
            // 
            // uiLabelUserName
            // 
            uiLabelUserName.AutoSize = true;
            uiLabelUserName.Font = new Font("微软雅黑", 10F);
            uiLabelUserName.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelUserName.Location = new Point(20, 62);
            uiLabelUserName.Name = "uiLabelUserName";
            uiLabelUserName.Size = new Size(72, 27);
            uiLabelUserName.TabIndex = 1;
            uiLabelUserName.Text = "用户名";
            // 
            // uiLabelEditTitle
            // 
            uiLabelEditTitle.AutoSize = true;
            uiLabelEditTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelEditTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelEditTitle.Location = new Point(20, 15);
            uiLabelEditTitle.Name = "uiLabelEditTitle";
            uiLabelEditTitle.Size = new Size(129, 37);
            uiLabelEditTitle.TabIndex = 0;
            uiLabelEditTitle.Text = "用户编辑";
            // 
            // uiPanelButtons
            // 
            uiPanelButtons.BackColor = Color.Transparent;
            uiPanelButtons.Controls.Add(uiButtonDelete);
            uiPanelButtons.Controls.Add(uiButtonEdit);
            uiPanelButtons.Controls.Add(uiButtonAdd);
            uiPanelButtons.Location = new Point(20, 640);
            uiPanelButtons.Name = "uiPanelButtons";
            uiPanelButtons.Size = new Size(560, 80);
            uiPanelButtons.TabIndex = 3;
            // 
            // uiButtonDelete
            // 
            uiButtonDelete.BackColor = Color.FromArgb(239, 68, 68);
            uiButtonDelete.FlatAppearance.BorderSize = 0;
            uiButtonDelete.FlatStyle = FlatStyle.Flat;
            uiButtonDelete.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiButtonDelete.ForeColor = Color.White;
            uiButtonDelete.Location = new Point(280, 20);
            uiButtonDelete.Name = "uiButtonDelete";
            uiButtonDelete.Size = new Size(120, 45);
            uiButtonDelete.TabIndex = 2;
            uiButtonDelete.Text = "删除用户";
            uiButtonDelete.UseVisualStyleBackColor = false;
            // 
            // uiButtonEdit
            // 
            uiButtonEdit.BackColor = Color.FromArgb(59, 130, 246);
            uiButtonEdit.FlatAppearance.BorderSize = 0;
            uiButtonEdit.FlatStyle = FlatStyle.Flat;
            uiButtonEdit.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiButtonEdit.ForeColor = Color.White;
            uiButtonEdit.Location = new Point(140, 20);
            uiButtonEdit.Name = "uiButtonEdit";
            uiButtonEdit.Size = new Size(120, 45);
            uiButtonEdit.TabIndex = 1;
            uiButtonEdit.Text = "修改用户";
            uiButtonEdit.UseVisualStyleBackColor = false;
            // 
            // uiButtonAdd
            // 
            uiButtonAdd.BackColor = Color.FromArgb(34, 197, 94);
            uiButtonAdd.FlatAppearance.BorderSize = 0;
            uiButtonAdd.FlatStyle = FlatStyle.Flat;
            uiButtonAdd.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiButtonAdd.ForeColor = Color.White;
            uiButtonAdd.Location = new Point(0, 20);
            uiButtonAdd.Name = "uiButtonAdd";
            uiButtonAdd.Size = new Size(120, 45);
            uiButtonAdd.TabIndex = 0;
            uiButtonAdd.Text = "添加用户";
            uiButtonAdd.UseVisualStyleBackColor = false;
            // 
            // uiPanelRoleAuth
            // 
            uiPanelRoleAuth.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelRoleAuth.BorderStyle = BorderStyle.FixedSingle;
            uiPanelRoleAuth.Controls.Add(uiButtonSaveRoleAuth);
            uiPanelRoleAuth.Controls.Add(uiCheckBoxUserAuth);
            uiPanelRoleAuth.Controls.Add(uiCheckBoxConfigAuth);
            uiPanelRoleAuth.Controls.Add(uiCheckBoxReportAuth);
            uiPanelRoleAuth.Controls.Add(uiCheckBoxLogAuth);
            uiPanelRoleAuth.Controls.Add(uiCheckBoxRecipeAuth);
            uiPanelRoleAuth.Controls.Add(uiCheckBoxMonitorAuth);
            uiPanelRoleAuth.Controls.Add(uiCheckBoxControlAuth);
            uiPanelRoleAuth.Controls.Add(uiLabelRoleAuthTitle);
            uiPanelRoleAuth.Location = new Point(600, 370);
            uiPanelRoleAuth.Name = "uiPanelRoleAuth";
            uiPanelRoleAuth.Size = new Size(560, 350);
            uiPanelRoleAuth.TabIndex = 4;
            // 
            // uiButtonSaveRoleAuth
            // 
            uiButtonSaveRoleAuth.BackColor = Color.FromArgb(34, 197, 94);
            uiButtonSaveRoleAuth.FlatAppearance.BorderSize = 0;
            uiButtonSaveRoleAuth.FlatStyle = FlatStyle.Flat;
            uiButtonSaveRoleAuth.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            uiButtonSaveRoleAuth.ForeColor = Color.White;
            uiButtonSaveRoleAuth.Location = new Point(65, 257);
            uiButtonSaveRoleAuth.Name = "uiButtonSaveRoleAuth";
            uiButtonSaveRoleAuth.Size = new Size(140, 35);
            uiButtonSaveRoleAuth.TabIndex = 8;
            uiButtonSaveRoleAuth.Text = "保存权限配置";
            uiButtonSaveRoleAuth.UseVisualStyleBackColor = false;
            // 
            // uiCheckBoxUserAuth
            // 
            uiCheckBoxUserAuth.AutoSize = true;
            uiCheckBoxUserAuth.Font = new Font("微软雅黑", 10F);
            uiCheckBoxUserAuth.ForeColor = Color.White;
            uiCheckBoxUserAuth.Location = new Point(31, 162);
            uiCheckBoxUserAuth.Name = "uiCheckBoxUserAuth";
            uiCheckBoxUserAuth.Size = new Size(118, 31);
            uiCheckBoxUserAuth.TabIndex = 7;
            uiCheckBoxUserAuth.Text = "用户模块";
            uiCheckBoxUserAuth.UseVisualStyleBackColor = true;
            // 
            // uiCheckBoxConfigAuth
            // 
            uiCheckBoxConfigAuth.AutoSize = true;
            uiCheckBoxConfigAuth.Font = new Font("微软雅黑", 10F);
            uiCheckBoxConfigAuth.ForeColor = Color.White;
            uiCheckBoxConfigAuth.Location = new Point(167, 125);
            uiCheckBoxConfigAuth.Name = "uiCheckBoxConfigAuth";
            uiCheckBoxConfigAuth.Size = new Size(118, 31);
            uiCheckBoxConfigAuth.TabIndex = 6;
            uiCheckBoxConfigAuth.Text = "配置模块";
            uiCheckBoxConfigAuth.UseVisualStyleBackColor = true;
            // 
            // uiCheckBoxReportAuth
            // 
            uiCheckBoxReportAuth.AutoSize = true;
            uiCheckBoxReportAuth.Font = new Font("微软雅黑", 10F);
            uiCheckBoxReportAuth.ForeColor = Color.White;
            uiCheckBoxReportAuth.Location = new Point(167, 90);
            uiCheckBoxReportAuth.Name = "uiCheckBoxReportAuth";
            uiCheckBoxReportAuth.Size = new Size(118, 31);
            uiCheckBoxReportAuth.TabIndex = 5;
            uiCheckBoxReportAuth.Text = "报表模块";
            uiCheckBoxReportAuth.UseVisualStyleBackColor = true;
            // 
            // uiCheckBoxLogAuth
            // 
            uiCheckBoxLogAuth.AutoSize = true;
            uiCheckBoxLogAuth.Font = new Font("微软雅黑", 10F);
            uiCheckBoxLogAuth.ForeColor = Color.White;
            uiCheckBoxLogAuth.Location = new Point(167, 55);
            uiCheckBoxLogAuth.Name = "uiCheckBoxLogAuth";
            uiCheckBoxLogAuth.Size = new Size(118, 31);
            uiCheckBoxLogAuth.TabIndex = 4;
            uiCheckBoxLogAuth.Text = "日志模块";
            uiCheckBoxLogAuth.UseVisualStyleBackColor = true;
            // 
            // uiCheckBoxRecipeAuth
            // 
            uiCheckBoxRecipeAuth.AutoSize = true;
            uiCheckBoxRecipeAuth.Font = new Font("微软雅黑", 10F);
            uiCheckBoxRecipeAuth.ForeColor = Color.White;
            uiCheckBoxRecipeAuth.Location = new Point(31, 125);
            uiCheckBoxRecipeAuth.Name = "uiCheckBoxRecipeAuth";
            uiCheckBoxRecipeAuth.Size = new Size(118, 31);
            uiCheckBoxRecipeAuth.TabIndex = 3;
            uiCheckBoxRecipeAuth.Text = "配方模块";
            uiCheckBoxRecipeAuth.UseVisualStyleBackColor = true;
            // 
            // uiCheckBoxMonitorAuth
            // 
            uiCheckBoxMonitorAuth.AutoSize = true;
            uiCheckBoxMonitorAuth.Font = new Font("微软雅黑", 10F);
            uiCheckBoxMonitorAuth.ForeColor = Color.White;
            uiCheckBoxMonitorAuth.Location = new Point(31, 90);
            uiCheckBoxMonitorAuth.Name = "uiCheckBoxMonitorAuth";
            uiCheckBoxMonitorAuth.Size = new Size(118, 31);
            uiCheckBoxMonitorAuth.TabIndex = 2;
            uiCheckBoxMonitorAuth.Text = "监控模块";
            uiCheckBoxMonitorAuth.UseVisualStyleBackColor = true;
            // 
            // uiCheckBoxControlAuth
            // 
            uiCheckBoxControlAuth.AutoSize = true;
            uiCheckBoxControlAuth.Font = new Font("微软雅黑", 10F);
            uiCheckBoxControlAuth.ForeColor = Color.White;
            uiCheckBoxControlAuth.Location = new Point(31, 55);
            uiCheckBoxControlAuth.Name = "uiCheckBoxControlAuth";
            uiCheckBoxControlAuth.Size = new Size(118, 31);
            uiCheckBoxControlAuth.TabIndex = 1;
            uiCheckBoxControlAuth.Text = "控制模块";
            uiCheckBoxControlAuth.UseVisualStyleBackColor = true;
            // 
            // uiLabelRoleAuthTitle
            // 
            uiLabelRoleAuthTitle.AutoSize = true;
            uiLabelRoleAuthTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelRoleAuthTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelRoleAuthTitle.Location = new Point(20, 15);
            uiLabelRoleAuthTitle.Name = "uiLabelRoleAuthTitle";
            uiLabelRoleAuthTitle.Size = new Size(185, 37);
            uiLabelRoleAuthTitle.TabIndex = 0;
            uiLabelRoleAuthTitle.Text = "角色权限配置";
            // 
            // FrmUserManager
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1220, 760);
            Controls.Add(uiPanelRoleAuth);
            Controls.Add(uiPanelButtons);
            Controls.Add(uiPanelUserEdit);
            Controls.Add(uiPanelUserList);
            Controls.Add(uiPanelTitle);
            Name = "FrmUserManager";
            Text = "用户管理";
            uiPanelTitle.ResumeLayout(false);
            uiPanelTitle.PerformLayout();
            uiPanelUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridViewUsers).EndInit();
            uiPanelUserEdit.ResumeLayout(false);
            uiPanelUserEdit.PerformLayout();
            uiPanelButtons.ResumeLayout(false);
            uiPanelRoleAuth.ResumeLayout(false);
            uiPanelRoleAuth.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel uiPanelTitle;
        private System.Windows.Forms.Label uiLabelTitle;
        private System.Windows.Forms.Label uiLabelSubtitle;
        private System.Windows.Forms.Panel uiPanelUserList;
        private System.Windows.Forms.DataGridView uiDataGridViewUsers;
        private System.Windows.Forms.Panel uiPanelUserEdit;
        private System.Windows.Forms.Label uiLabelEditTitle;
        private System.Windows.Forms.Label uiLabelUserName;
        private System.Windows.Forms.TextBox uiTextBoxUserName;
        private System.Windows.Forms.Label uiLabelPassword;
        private System.Windows.Forms.TextBox uiTextBoxPassword;
        private System.Windows.Forms.Label uiLabelRole;
        private System.Windows.Forms.ComboBox uiComboBoxRole;
        private System.Windows.Forms.Panel uiPanelButtons;
        private System.Windows.Forms.Button uiButtonAdd;
        private System.Windows.Forms.Button uiButtonEdit;
        private System.Windows.Forms.Button uiButtonDelete;
        private System.Windows.Forms.Button uiButtonSave;
        private System.Windows.Forms.Button uiButtonCancel;
        private System.Windows.Forms.Panel uiPanelRoleAuth;
        private System.Windows.Forms.Label uiLabelRoleAuthTitle;
        private System.Windows.Forms.CheckBox uiCheckBoxControlAuth;
        private System.Windows.Forms.CheckBox uiCheckBoxMonitorAuth;
        private System.Windows.Forms.CheckBox uiCheckBoxRecipeAuth;
        private System.Windows.Forms.CheckBox uiCheckBoxLogAuth;
        private System.Windows.Forms.CheckBox uiCheckBoxReportAuth;
        private System.Windows.Forms.CheckBox uiCheckBoxConfigAuth;
        private System.Windows.Forms.CheckBox uiCheckBoxUserAuth;
        private System.Windows.Forms.Button uiButtonSaveRoleAuth;
    }
}
