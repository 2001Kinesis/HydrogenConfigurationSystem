namespace Custom.HydrogenConfigurationSystem.Controls
{
    partial class UC_DeviceState
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
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.pnlStatusIndicator = new System.Windows.Forms.Panel();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Size = new System.Drawing.Size(120, 70);
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeviceName.ForeColor = System.Drawing.Color.White;
            this.lblDeviceName.Location = new System.Drawing.Point(10, 5);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(50, 17);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "设备名称";
            this.pnlStatusIndicator.BackColor = System.Drawing.Color.Gray;
            this.pnlStatusIndicator.Location = new System.Drawing.Point(10, 30);
            this.pnlStatusIndicator.Name = "pnlStatusIndicator";
            this.pnlStatusIndicator.Size = new System.Drawing.Size(20, 20);
            this.pnlStatusIndicator.TabIndex = 1;
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblStatusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.lblStatusText.Location = new System.Drawing.Point(35, 32);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(44, 17);
            this.lblStatusText.TabIndex = 2;
            this.lblStatusText.Text = "未运行";
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.pnlStatusIndicator);
            this.Controls.Add(this.lblDeviceName);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Panel pnlStatusIndicator;
        private System.Windows.Forms.Label lblStatusText;
    }
}
