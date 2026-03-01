namespace Custom.HydrogenConfigurationSystem.Forms
{
    partial class FrmLogQuery
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
            uiPanelFilter = new Panel();
            uiButtonOpenDir = new Button();
            uiButtonExport = new Button();
            uiButtonReset = new Button();
            uiButtonQuery = new Button();
            uiLabelEndTime = new Label();
            uiDateTimePickerEnd = new DateTimePicker();
            uiLabelStartTime = new Label();
            uiDateTimePickerStart = new DateTimePicker();
            uiLabelLogType = new Label();
            uiComboBoxLogType = new ComboBox();
            uiPanelLogList = new Panel();
            uiDataGridViewLogs = new DataGridView();
            uiPanelTitle.SuspendLayout();
            uiPanelFilter.SuspendLayout();
            uiPanelLogList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridViewLogs).BeginInit();
            SuspendLayout();
            // 
            // uiPanelTitle
            // 
            uiPanelTitle.BackColor = Color.Transparent;
            uiPanelTitle.Controls.Add(uiLabelSubtitle);
            uiPanelTitle.Controls.Add(uiLabelTitle);
            uiPanelTitle.Location = new Point(20, 20);
            uiPanelTitle.Name = "uiPanelTitle";
            uiPanelTitle.Size = new Size(1188, 60);
            uiPanelTitle.TabIndex = 0;
            // 
            // uiLabelSubtitle
            // 
            uiLabelSubtitle.AutoSize = true;
            uiLabelSubtitle.Font = new Font("微软雅黑", 10F);
            uiLabelSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelSubtitle.Location = new Point(189, 17);
            uiLabelSubtitle.Name = "uiLabelSubtitle";
            uiLabelSubtitle.Size = new Size(192, 27);
            uiLabelSubtitle.TabIndex = 1;
            uiLabelSubtitle.Text = "报警和操作日志查询";
            // 
            // uiLabelTitle
            // 
            uiLabelTitle.AutoSize = true;
            uiLabelTitle.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            uiLabelTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelTitle.Location = new Point(3, 4);
            uiLabelTitle.Name = "uiLabelTitle";
            uiLabelTitle.Size = new Size(164, 47);
            uiLabelTitle.TabIndex = 0;
            uiLabelTitle.Text = "日志查询";
            // 
            // uiPanelFilter
            // 
            uiPanelFilter.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelFilter.BorderStyle = BorderStyle.FixedSingle;
            uiPanelFilter.Controls.Add(uiButtonOpenDir);
            uiPanelFilter.Controls.Add(uiButtonExport);
            uiPanelFilter.Controls.Add(uiButtonReset);
            uiPanelFilter.Controls.Add(uiButtonQuery);
            uiPanelFilter.Controls.Add(uiLabelEndTime);
            uiPanelFilter.Controls.Add(uiDateTimePickerEnd);
            uiPanelFilter.Controls.Add(uiLabelStartTime);
            uiPanelFilter.Controls.Add(uiDateTimePickerStart);
            uiPanelFilter.Controls.Add(uiLabelLogType);
            uiPanelFilter.Controls.Add(uiComboBoxLogType);
            uiPanelFilter.Location = new Point(20, 100);
            uiPanelFilter.Name = "uiPanelFilter";
            uiPanelFilter.Size = new Size(1188, 100);
            uiPanelFilter.TabIndex = 1;
            // 
            // uiButtonOpenDir
            // 
            uiButtonOpenDir.BackColor = Color.FromArgb(245, 158, 11);
            uiButtonOpenDir.FlatAppearance.BorderSize = 0;
            uiButtonOpenDir.FlatStyle = FlatStyle.Flat;
            uiButtonOpenDir.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            uiButtonOpenDir.ForeColor = Color.White;
            uiButtonOpenDir.Location = new Point(978, 44);
            uiButtonOpenDir.Name = "uiButtonOpenDir";
            uiButtonOpenDir.Size = new Size(150, 35);
            uiButtonOpenDir.TabIndex = 9;
            uiButtonOpenDir.Text = "打开日志目录";
            uiButtonOpenDir.UseVisualStyleBackColor = false;
            // 
            // uiButtonExport
            // 
            uiButtonExport.BackColor = Color.FromArgb(59, 130, 246);
            uiButtonExport.FlatAppearance.BorderSize = 0;
            uiButtonExport.FlatStyle = FlatStyle.Flat;
            uiButtonExport.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            uiButtonExport.ForeColor = Color.White;
            uiButtonExport.Location = new Point(858, 44);
            uiButtonExport.Name = "uiButtonExport";
            uiButtonExport.Size = new Size(100, 35);
            uiButtonExport.TabIndex = 8;
            uiButtonExport.Text = "导出";
            uiButtonExport.UseVisualStyleBackColor = false;
            // 
            // uiButtonReset
            // 
            uiButtonReset.BackColor = Color.FromArgb(107, 114, 128);
            uiButtonReset.FlatAppearance.BorderSize = 0;
            uiButtonReset.FlatStyle = FlatStyle.Flat;
            uiButtonReset.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            uiButtonReset.ForeColor = Color.White;
            uiButtonReset.Location = new Point(738, 44);
            uiButtonReset.Name = "uiButtonReset";
            uiButtonReset.Size = new Size(100, 35);
            uiButtonReset.TabIndex = 7;
            uiButtonReset.Text = "重置";
            uiButtonReset.UseVisualStyleBackColor = false;
            // 
            // uiButtonQuery
            // 
            uiButtonQuery.BackColor = Color.FromArgb(34, 197, 94);
            uiButtonQuery.FlatAppearance.BorderSize = 0;
            uiButtonQuery.FlatStyle = FlatStyle.Flat;
            uiButtonQuery.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            uiButtonQuery.ForeColor = Color.White;
            uiButtonQuery.Location = new Point(618, 44);
            uiButtonQuery.Name = "uiButtonQuery";
            uiButtonQuery.Size = new Size(100, 35);
            uiButtonQuery.TabIndex = 6;
            uiButtonQuery.Text = "查询";
            uiButtonQuery.UseVisualStyleBackColor = false;
            // 
            // uiLabelEndTime
            // 
            uiLabelEndTime.AutoSize = true;
            uiLabelEndTime.Font = new Font("微软雅黑", 10F);
            uiLabelEndTime.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelEndTime.Location = new Point(410, 15);
            uiLabelEndTime.Name = "uiLabelEndTime";
            uiLabelEndTime.Size = new Size(92, 27);
            uiLabelEndTime.TabIndex = 4;
            uiLabelEndTime.Text = "结束时间";
            // 
            // uiDateTimePickerEnd
            // 
            uiDateTimePickerEnd.CalendarForeColor = Color.White;
            uiDateTimePickerEnd.CalendarMonthBackground = Color.FromArgb(30, 41, 59);
            uiDateTimePickerEnd.CalendarTitleBackColor = Color.FromArgb(34, 211, 238);
            uiDateTimePickerEnd.CalendarTitleForeColor = Color.White;
            uiDateTimePickerEnd.CalendarTrailingForeColor = Color.FromArgb(148, 163, 184);
            uiDateTimePickerEnd.Font = new Font("微软雅黑", 10F);
            uiDateTimePickerEnd.Format = DateTimePickerFormat.Short;
            uiDateTimePickerEnd.Location = new Point(410, 46);
            uiDateTimePickerEnd.Name = "uiDateTimePickerEnd";
            uiDateTimePickerEnd.Size = new Size(180, 34);
            uiDateTimePickerEnd.TabIndex = 5;
            // 
            // uiLabelStartTime
            // 
            uiLabelStartTime.AutoSize = true;
            uiLabelStartTime.Font = new Font("微软雅黑", 10F);
            uiLabelStartTime.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelStartTime.Location = new Point(200, 15);
            uiLabelStartTime.Name = "uiLabelStartTime";
            uiLabelStartTime.Size = new Size(92, 27);
            uiLabelStartTime.TabIndex = 2;
            uiLabelStartTime.Text = "开始时间";
            // 
            // uiDateTimePickerStart
            // 
            uiDateTimePickerStart.CalendarForeColor = Color.White;
            uiDateTimePickerStart.CalendarMonthBackground = Color.FromArgb(30, 41, 59);
            uiDateTimePickerStart.CalendarTitleBackColor = Color.FromArgb(34, 211, 238);
            uiDateTimePickerStart.CalendarTitleForeColor = Color.White;
            uiDateTimePickerStart.CalendarTrailingForeColor = Color.FromArgb(148, 163, 184);
            uiDateTimePickerStart.Font = new Font("微软雅黑", 10F);
            uiDateTimePickerStart.Format = DateTimePickerFormat.Short;
            uiDateTimePickerStart.Location = new Point(200, 46);
            uiDateTimePickerStart.Name = "uiDateTimePickerStart";
            uiDateTimePickerStart.Size = new Size(180, 34);
            uiDateTimePickerStart.TabIndex = 3;
            // 
            // uiLabelLogType
            // 
            uiLabelLogType.AutoSize = true;
            uiLabelLogType.Font = new Font("微软雅黑", 10F);
            uiLabelLogType.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelLogType.Location = new Point(20, 15);
            uiLabelLogType.Name = "uiLabelLogType";
            uiLabelLogType.Size = new Size(92, 27);
            uiLabelLogType.TabIndex = 0;
            uiLabelLogType.Text = "日志类型";
            // 
            // uiComboBoxLogType
            // 
            uiComboBoxLogType.BackColor = Color.FromArgb(15, 23, 42);
            uiComboBoxLogType.DropDownStyle = ComboBoxStyle.DropDownList;
            uiComboBoxLogType.Font = new Font("微软雅黑", 10F);
            uiComboBoxLogType.ForeColor = Color.White;
            uiComboBoxLogType.FormattingEnabled = true;
            uiComboBoxLogType.Items.AddRange(new object[] { "全部", "报警日志", "操作日志" });
            uiComboBoxLogType.Location = new Point(20, 45);
            uiComboBoxLogType.Name = "uiComboBoxLogType";
            uiComboBoxLogType.Size = new Size(150, 35);
            uiComboBoxLogType.TabIndex = 1;
            // 
            // uiPanelLogList
            // 
            uiPanelLogList.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelLogList.BorderStyle = BorderStyle.FixedSingle;
            uiPanelLogList.Controls.Add(uiDataGridViewLogs);
            uiPanelLogList.Location = new Point(20, 220);
            uiPanelLogList.Name = "uiPanelLogList";
            uiPanelLogList.Size = new Size(1188, 528);
            uiPanelLogList.TabIndex = 2;
            // 
            // uiDataGridViewLogs
            // 
            uiDataGridViewLogs.AllowUserToAddRows = false;
            uiDataGridViewLogs.AllowUserToDeleteRows = false;
            uiDataGridViewLogs.BackgroundColor = Color.FromArgb(15, 23, 42);
            uiDataGridViewLogs.BorderStyle = BorderStyle.None;
            uiDataGridViewLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            uiDataGridViewLogs.Dock = DockStyle.Fill;
            uiDataGridViewLogs.GridColor = Color.FromArgb(51, 65, 85);
            uiDataGridViewLogs.Location = new Point(0, 0);
            uiDataGridViewLogs.Name = "uiDataGridViewLogs";
            uiDataGridViewLogs.ReadOnly = true;
            uiDataGridViewLogs.RowHeadersWidth = 62;
            uiDataGridViewLogs.RowTemplate.Height = 23;
            uiDataGridViewLogs.Size = new Size(1186, 526);
            uiDataGridViewLogs.TabIndex = 0;
            // 
            // FrmLogQuery
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1220, 760);
            Controls.Add(uiPanelLogList);
            Controls.Add(uiPanelFilter);
            Controls.Add(uiPanelTitle);
            Name = "FrmLogQuery";
            Text = "日志查询";
            uiPanelTitle.ResumeLayout(false);
            uiPanelTitle.PerformLayout();
            uiPanelFilter.ResumeLayout(false);
            uiPanelFilter.PerformLayout();
            uiPanelLogList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridViewLogs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel uiPanelTitle;
        private System.Windows.Forms.Label uiLabelTitle;
        private System.Windows.Forms.Label uiLabelSubtitle;
        private System.Windows.Forms.Panel uiPanelFilter;
        private System.Windows.Forms.Label uiLabelLogType;
        private System.Windows.Forms.ComboBox uiComboBoxLogType;
        private System.Windows.Forms.Label uiLabelStartTime;
        private System.Windows.Forms.DateTimePicker uiDateTimePickerStart;
        private System.Windows.Forms.Label uiLabelEndTime;
        private System.Windows.Forms.DateTimePicker uiDateTimePickerEnd;
        private System.Windows.Forms.Button uiButtonQuery;
        private System.Windows.Forms.Button uiButtonReset;
        private System.Windows.Forms.Button uiButtonExport;
        private System.Windows.Forms.Button uiButtonOpenDir;
        private System.Windows.Forms.Panel uiPanelLogList;
        private System.Windows.Forms.DataGridView uiDataGridViewLogs;
    }
}
