namespace Custom.HydrogenConfigurationSystem.Controls
{
    partial class UC_ParamShow
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            lblParamName = new Label();
            lblParamValue = new Label();
            lblUnit = new Label();
            SuspendLayout();
            // 
            // lblParamName
            // 
            lblParamName.AutoSize = true;
            lblParamName.Font = new Font("微软雅黑", 9F);
            lblParamName.ForeColor = Color.FromArgb(148, 163, 184);
            lblParamName.Location = new Point(10, 5);
            lblParamName.Name = "lblParamName";
            lblParamName.Size = new Size(82, 24);
            lblParamName.TabIndex = 0;
            lblParamName.Text = "参数名称";
            // 
            // lblParamValue
            // 
            lblParamValue.AutoSize = true;
            lblParamValue.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            lblParamValue.ForeColor = Color.FromArgb(34, 211, 238);
            lblParamValue.Location = new Point(10, 28);
            lblParamValue.Name = "lblParamValue";
            lblParamValue.Size = new Size(59, 37);
            lblParamValue.TabIndex = 1;
            lblParamValue.Text = "0.0";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("微软雅黑", 9F);
            lblUnit.ForeColor = Color.FromArgb(148, 163, 184);
            lblUnit.Location = new Point(75, 39);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(46, 24);
            lblUnit.TabIndex = 2;
            lblUnit.Text = "单位";
            // 
            // UC_ParamShow
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(30, 41, 59);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblUnit);
            Controls.Add(lblParamValue);
            Controls.Add(lblParamName);
            Name = "UC_ParamShow";
            Size = new Size(140, 65);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblParamName;
        private System.Windows.Forms.Label lblParamValue;
        private System.Windows.Forms.Label lblUnit;
    }
}
