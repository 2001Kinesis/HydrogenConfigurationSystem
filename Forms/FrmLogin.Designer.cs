namespace Custom.HydrogenConfigurationSystem.Forms
{
    partial class FrmLogin
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
            this.uiPanelMain = new System.Windows.Forms.Panel();
            this.uiPanelBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.uiPanelCenter = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.uiLabelPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.uiLabelUserName = new System.Windows.Forms.Label();
            this.uiPanelTop = new System.Windows.Forms.Panel();
            this.uiLabelTitle = new System.Windows.Forms.Label();
            this.uiPanelMain.SuspendLayout();
            this.uiPanelBottom.SuspendLayout();
            this.uiPanelCenter.SuspendLayout();
            this.uiPanelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanelMain
            // 
            this.uiPanelMain.Controls.Add(this.uiPanelBottom);
            this.uiPanelMain.Controls.Add(this.uiPanelCenter);
            this.uiPanelMain.Controls.Add(this.uiPanelTop);
            this.uiPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelMain.Location = new System.Drawing.Point(0, 0);
            this.uiPanelMain.Name = "uiPanelMain";
            this.uiPanelMain.Size = new System.Drawing.Size(500, 400);
            this.uiPanelMain.TabIndex = 0;
            // 
            // uiPanelBottom
            // 
            this.uiPanelBottom.Controls.Add(this.btnCancel);
            this.uiPanelBottom.Controls.Add(this.btnLogin);
            this.uiPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanelBottom.Location = new System.Drawing.Point(0, 300);
            this.uiPanelBottom.Name = "uiPanelBottom";
            this.uiPanelBottom.Size = new System.Drawing.Size(500, 100);
            this.uiPanelBottom.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(280, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(211)))), ((int)(((byte)(238)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(100, 30);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 45);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // uiPanelCenter
            // 
            this.uiPanelCenter.Controls.Add(this.txtPassword);
            this.uiPanelCenter.Controls.Add(this.uiLabelPassword);
            this.uiPanelCenter.Controls.Add(this.txtUserName);
            this.uiPanelCenter.Controls.Add(this.uiLabelUserName);
            this.uiPanelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanelCenter.Location = new System.Drawing.Point(0, 100);
            this.uiPanelCenter.Name = "uiPanelCenter";
            this.uiPanelCenter.Size = new System.Drawing.Size(500, 200);
            this.uiPanelCenter.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtPassword.Location = new System.Drawing.Point(150, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(250, 39);
            this.txtPassword.TabIndex = 3;
            // 
            // uiLabelPassword
            // 
            this.uiLabelPassword.AutoSize = true;
            this.uiLabelPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.uiLabelPassword.Location = new System.Drawing.Point(60, 105);
            this.uiLabelPassword.Name = "uiLabelPassword";
            this.uiLabelPassword.Size = new System.Drawing.Size(72, 31);
            this.uiLabelPassword.TabIndex = 2;
            this.uiLabelPassword.Text = "密码：";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txtUserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txtUserName.Location = new System.Drawing.Point(150, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(250, 39);
            this.txtUserName.TabIndex = 1;
            // 
            // uiLabelUserName
            // 
            this.uiLabelUserName.AutoSize = true;
            this.uiLabelUserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.uiLabelUserName.Location = new System.Drawing.Point(60, 35);
            this.uiLabelUserName.Name = "uiLabelUserName";
            this.uiLabelUserName.Size = new System.Drawing.Size(72, 31);
            this.uiLabelUserName.TabIndex = 0;
            this.uiLabelUserName.Text = "用户：";
            // 
            // uiPanelTop
            // 
            this.uiPanelTop.Controls.Add(this.uiLabelTitle);
            this.uiPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanelTop.Location = new System.Drawing.Point(0, 0);
            this.uiPanelTop.Name = "uiPanelTop";
            this.uiPanelTop.Size = new System.Drawing.Size(500, 100);
            this.uiPanelTop.TabIndex = 0;
            // 
            // uiLabelTitle
            // 
            this.uiLabelTitle.AutoSize = true;
            this.uiLabelTitle.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(211)))), ((int)(((byte)(238)))));
            this.uiLabelTitle.Location = new System.Drawing.Point(90, 30);
            this.uiLabelTitle.Name = "uiLabelTitle";
            this.uiLabelTitle.Size = new System.Drawing.Size(320, 62);
            this.uiLabelTitle.TabIndex = 0;
            this.uiLabelTitle.Text = "氢能组态系统";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.uiPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "FrmLogin";
            this.ShowInTaskbar = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            this.uiPanelMain.ResumeLayout(false);
            this.uiPanelBottom.ResumeLayout(false);
            this.uiPanelCenter.ResumeLayout(false);
            this.uiPanelCenter.PerformLayout();
            this.uiPanelTop.ResumeLayout(false);
            this.uiPanelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uiPanelMain;
        private System.Windows.Forms.Panel uiPanelTop;
        private System.Windows.Forms.Label uiLabelTitle;
        private System.Windows.Forms.Panel uiPanelCenter;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label uiLabelUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label uiLabelPassword;
        private System.Windows.Forms.Panel uiPanelBottom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
    }
}
