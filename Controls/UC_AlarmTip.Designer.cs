namespace Custom.HydrogenConfigurationSystem.Controls
{
    partial class UC_AlarmTip
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _blinkTimer?.Stop();
                _blinkTimer?.Dispose();
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblAlarmMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Size = new System.Drawing.Size(400, 50);
            this.lblAlarmMessage.AutoSize = true;
            this.lblAlarmMessage.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.lblAlarmMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.lblAlarmMessage.Location = new System.Drawing.Point(10, 15);
            this.lblAlarmMessage.Name = "lblAlarmMessage";
            this.lblAlarmMessage.Size = new System.Drawing.Size(120, 19);
            this.lblAlarmMessage.TabIndex = 0;
            this.lblAlarmMessage.Text = "系统正常，无报警";
            this.Controls.Add(this.lblAlarmMessage);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAlarmMessage;
    }
}
