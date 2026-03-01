namespace Custom.HydrogenConfigurationSystem.Forms
{
    partial class FrmReportChart
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
            uiPanelTop = new Panel();
            uiButtonExport = new Button();
            uiButtonQuery = new Button();
            uiLabelEndTime = new Label();
            uiDateTimePickerEnd = new DateTimePicker();
            uiLabelStartTime = new Label();
            uiDateTimePickerStart = new DateTimePicker();
            uiLabelChartType = new Label();
            uiComboBoxChartType = new ComboBox();
            uiPanelChart = new Panel();
            uiPanelStatistics = new Panel();
            uiLabelAvgValue = new Label();
            uiLabelMinValue = new Label();
            uiLabelMaxValue = new Label();
            uiLabelTotalCount = new Label();
            uiLabelAvgTitle = new Label();
            uiLabelMinTitle = new Label();
            uiLabelMaxTitle = new Label();
            uiLabelCountTitle = new Label();
            uiLabelStatisticsTitle = new Label();
            uiPanelData = new Panel();
            uiDataGridViewReport = new DataGridView();
            uiPanelTitle.SuspendLayout();
            uiPanelTop.SuspendLayout();
            uiPanelStatistics.SuspendLayout();
            uiPanelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uiDataGridViewReport).BeginInit();
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
            uiLabelSubtitle.Location = new Point(172, 21);
            uiLabelSubtitle.Name = "uiLabelSubtitle";
            uiLabelSubtitle.Size = new Size(212, 27);
            uiLabelSubtitle.TabIndex = 1;
            uiLabelSubtitle.Text = "数据可视化与报表生成";
            // 
            // uiLabelTitle
            // 
            uiLabelTitle.AutoSize = true;
            uiLabelTitle.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            uiLabelTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelTitle.Location = new Point(2, 4);
            uiLabelTitle.Name = "uiLabelTitle";
            uiLabelTitle.Size = new Size(164, 47);
            uiLabelTitle.TabIndex = 0;
            uiLabelTitle.Text = "报表图表";
            // 
            // uiPanelTop
            // 
            uiPanelTop.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelTop.BorderStyle = BorderStyle.FixedSingle;
            uiPanelTop.Controls.Add(uiButtonExport);
            uiPanelTop.Controls.Add(uiButtonQuery);
            uiPanelTop.Controls.Add(uiLabelEndTime);
            uiPanelTop.Controls.Add(uiDateTimePickerEnd);
            uiPanelTop.Controls.Add(uiLabelStartTime);
            uiPanelTop.Controls.Add(uiDateTimePickerStart);
            uiPanelTop.Controls.Add(uiLabelChartType);
            uiPanelTop.Controls.Add(uiComboBoxChartType);
            uiPanelTop.Location = new Point(20, 100);
            uiPanelTop.Name = "uiPanelTop";
            uiPanelTop.Size = new Size(1160, 94);
            uiPanelTop.TabIndex = 1;
            // 
            // uiButtonExport
            // 
            uiButtonExport.BackColor = Color.FromArgb(59, 130, 246);
            uiButtonExport.FlatAppearance.BorderSize = 0;
            uiButtonExport.FlatStyle = FlatStyle.Flat;
            uiButtonExport.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            uiButtonExport.ForeColor = Color.White;
            uiButtonExport.Location = new Point(771, 44);
            uiButtonExport.Name = "uiButtonExport";
            uiButtonExport.Size = new Size(100, 35);
            uiButtonExport.TabIndex = 7;
            uiButtonExport.Text = "导出Excel";
            uiButtonExport.UseVisualStyleBackColor = false;
            // 
            // uiButtonQuery
            // 
            uiButtonQuery.BackColor = Color.FromArgb(34, 197, 94);
            uiButtonQuery.FlatAppearance.BorderSize = 0;
            uiButtonQuery.FlatStyle = FlatStyle.Flat;
            uiButtonQuery.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            uiButtonQuery.ForeColor = Color.White;
            uiButtonQuery.Location = new Point(652, 44);
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
            uiLabelEndTime.Location = new Point(440, 15);
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
            uiDateTimePickerEnd.Location = new Point(440, 45);
            uiDateTimePickerEnd.Name = "uiDateTimePickerEnd";
            uiDateTimePickerEnd.Size = new Size(180, 34);
            uiDateTimePickerEnd.TabIndex = 5;
            // 
            // uiLabelStartTime
            // 
            uiLabelStartTime.AutoSize = true;
            uiLabelStartTime.Font = new Font("微软雅黑", 10F);
            uiLabelStartTime.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelStartTime.Location = new Point(230, 15);
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
            uiDateTimePickerStart.Location = new Point(230, 46);
            uiDateTimePickerStart.Name = "uiDateTimePickerStart";
            uiDateTimePickerStart.Size = new Size(180, 34);
            uiDateTimePickerStart.TabIndex = 3;
            // 
            // uiLabelChartType
            // 
            uiLabelChartType.AutoSize = true;
            uiLabelChartType.Font = new Font("微软雅黑", 10F);
            uiLabelChartType.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelChartType.Location = new Point(20, 15);
            uiLabelChartType.Name = "uiLabelChartType";
            uiLabelChartType.Size = new Size(92, 27);
            uiLabelChartType.TabIndex = 0;
            uiLabelChartType.Text = "图表类型";
            // 
            // uiComboBoxChartType
            // 
            uiComboBoxChartType.BackColor = Color.FromArgb(15, 23, 42);
            uiComboBoxChartType.DropDownStyle = ComboBoxStyle.DropDownList;
            uiComboBoxChartType.Font = new Font("微软雅黑", 10F);
            uiComboBoxChartType.ForeColor = Color.White;
            uiComboBoxChartType.FormattingEnabled = true;
            uiComboBoxChartType.Items.AddRange(new object[] { "产氢量趋势", "能耗趋势", "电解电流趋势", "储氢压力趋势", "综合报表" });
            uiComboBoxChartType.Location = new Point(20, 45);
            uiComboBoxChartType.Name = "uiComboBoxChartType";
            uiComboBoxChartType.Size = new Size(180, 35);
            uiComboBoxChartType.TabIndex = 1;
            // 
            // uiPanelChart
            // 
            uiPanelChart.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelChart.BorderStyle = BorderStyle.FixedSingle;
            uiPanelChart.Location = new Point(20, 200);
            uiPanelChart.Name = "uiPanelChart";
            uiPanelChart.Size = new Size(1160, 324);
            uiPanelChart.TabIndex = 2;
            // 
            // uiPanelStatistics
            // 
            uiPanelStatistics.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelStatistics.BorderStyle = BorderStyle.FixedSingle;
            uiPanelStatistics.Controls.Add(uiLabelAvgValue);
            uiPanelStatistics.Controls.Add(uiLabelMinValue);
            uiPanelStatistics.Controls.Add(uiLabelMaxValue);
            uiPanelStatistics.Controls.Add(uiLabelTotalCount);
            uiPanelStatistics.Controls.Add(uiLabelAvgTitle);
            uiPanelStatistics.Controls.Add(uiLabelMinTitle);
            uiPanelStatistics.Controls.Add(uiLabelMaxTitle);
            uiPanelStatistics.Controls.Add(uiLabelCountTitle);
            uiPanelStatistics.Controls.Add(uiLabelStatisticsTitle);
            uiPanelStatistics.Location = new Point(20, 530);
            uiPanelStatistics.Name = "uiPanelStatistics";
            uiPanelStatistics.Size = new Size(1160, 80);
            uiPanelStatistics.TabIndex = 4;
            // 
            // uiLabelAvgValue
            // 
            uiLabelAvgValue.AutoSize = true;
            uiLabelAvgValue.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            uiLabelAvgValue.ForeColor = Color.FromArgb(245, 158, 11);
            uiLabelAvgValue.Location = new Point(665, 45);
            uiLabelAvgValue.Name = "uiLabelAvgValue";
            uiLabelAvgValue.Size = new Size(50, 25);
            uiLabelAvgValue.TabIndex = 8;
            uiLabelAvgValue.Text = "0.00";
            // 
            // uiLabelMinValue
            // 
            uiLabelMinValue.AutoSize = true;
            uiLabelMinValue.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            uiLabelMinValue.ForeColor = Color.FromArgb(59, 130, 246);
            uiLabelMinValue.Location = new Point(465, 45);
            uiLabelMinValue.Name = "uiLabelMinValue";
            uiLabelMinValue.Size = new Size(50, 25);
            uiLabelMinValue.TabIndex = 7;
            uiLabelMinValue.Text = "0.00";
            // 
            // uiLabelMaxValue
            // 
            uiLabelMaxValue.AutoSize = true;
            uiLabelMaxValue.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            uiLabelMaxValue.ForeColor = Color.FromArgb(239, 68, 68);
            uiLabelMaxValue.Location = new Point(265, 45);
            uiLabelMaxValue.Name = "uiLabelMaxValue";
            uiLabelMaxValue.Size = new Size(50, 25);
            uiLabelMaxValue.TabIndex = 6;
            uiLabelMaxValue.Text = "0.00";
            // 
            // uiLabelTotalCount
            // 
            uiLabelTotalCount.AutoSize = true;
            uiLabelTotalCount.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            uiLabelTotalCount.ForeColor = Color.FromArgb(34, 197, 94);
            uiLabelTotalCount.Location = new Point(100, 45);
            uiLabelTotalCount.Name = "uiLabelTotalCount";
            uiLabelTotalCount.Size = new Size(23, 25);
            uiLabelTotalCount.TabIndex = 5;
            uiLabelTotalCount.Text = "0";
            // 
            // uiLabelAvgTitle
            // 
            uiLabelAvgTitle.AutoSize = true;
            uiLabelAvgTitle.Font = new Font("微软雅黑", 9F);
            uiLabelAvgTitle.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelAvgTitle.Location = new Point(600, 45);
            uiLabelAvgTitle.Name = "uiLabelAvgTitle";
            uiLabelAvgTitle.Size = new Size(68, 24);
            uiLabelAvgTitle.TabIndex = 4;
            uiLabelAvgTitle.Text = "平均值:";
            // 
            // uiLabelMinTitle
            // 
            uiLabelMinTitle.AutoSize = true;
            uiLabelMinTitle.Font = new Font("微软雅黑", 9F);
            uiLabelMinTitle.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelMinTitle.Location = new Point(400, 45);
            uiLabelMinTitle.Name = "uiLabelMinTitle";
            uiLabelMinTitle.Size = new Size(68, 24);
            uiLabelMinTitle.TabIndex = 3;
            uiLabelMinTitle.Text = "最小值:";
            // 
            // uiLabelMaxTitle
            // 
            uiLabelMaxTitle.AutoSize = true;
            uiLabelMaxTitle.Font = new Font("微软雅黑", 9F);
            uiLabelMaxTitle.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelMaxTitle.Location = new Point(200, 45);
            uiLabelMaxTitle.Name = "uiLabelMaxTitle";
            uiLabelMaxTitle.Size = new Size(68, 24);
            uiLabelMaxTitle.TabIndex = 2;
            uiLabelMaxTitle.Text = "最大值:";
            // 
            // uiLabelCountTitle
            // 
            uiLabelCountTitle.AutoSize = true;
            uiLabelCountTitle.Font = new Font("微软雅黑", 9F);
            uiLabelCountTitle.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelCountTitle.Location = new Point(20, 45);
            uiLabelCountTitle.Name = "uiLabelCountTitle";
            uiLabelCountTitle.Size = new Size(86, 24);
            uiLabelCountTitle.TabIndex = 1;
            uiLabelCountTitle.Text = "数据条数:";
            // 
            // uiLabelStatisticsTitle
            // 
            uiLabelStatisticsTitle.AutoSize = true;
            uiLabelStatisticsTitle.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiLabelStatisticsTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelStatisticsTitle.Location = new Point(10, 8);
            uiLabelStatisticsTitle.Name = "uiLabelStatisticsTitle";
            uiLabelStatisticsTitle.Size = new Size(101, 30);
            uiLabelStatisticsTitle.TabIndex = 0;
            uiLabelStatisticsTitle.Text = "统计摘要";
            // 
            // uiPanelData
            // 
            uiPanelData.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelData.BorderStyle = BorderStyle.FixedSingle;
            uiPanelData.Controls.Add(uiDataGridViewReport);
            uiPanelData.Location = new Point(20, 620);
            uiPanelData.Name = "uiPanelData";
            uiPanelData.Size = new Size(1160, 128);
            uiPanelData.TabIndex = 3;
            // 
            // uiDataGridViewReport
            // 
            uiDataGridViewReport.AllowUserToAddRows = false;
            uiDataGridViewReport.AllowUserToDeleteRows = false;
            uiDataGridViewReport.BackgroundColor = Color.FromArgb(15, 23, 42);
            uiDataGridViewReport.BorderStyle = BorderStyle.None;
            uiDataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            uiDataGridViewReport.Dock = DockStyle.Fill;
            uiDataGridViewReport.GridColor = Color.FromArgb(51, 65, 85);
            uiDataGridViewReport.Location = new Point(0, 0);
            uiDataGridViewReport.Name = "uiDataGridViewReport";
            uiDataGridViewReport.ReadOnly = true;
            uiDataGridViewReport.RowHeadersWidth = 62;
            uiDataGridViewReport.RowTemplate.Height = 23;
            uiDataGridViewReport.Size = new Size(1158, 126);
            uiDataGridViewReport.TabIndex = 0;
            // 
            // FrmReportChart
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1220, 760);
            Controls.Add(uiPanelData);
            Controls.Add(uiPanelStatistics);
            Controls.Add(uiPanelChart);
            Controls.Add(uiPanelTop);
            Controls.Add(uiPanelTitle);
            Name = "FrmReportChart";
            Text = "报表图表";
            uiPanelTitle.ResumeLayout(false);
            uiPanelTitle.PerformLayout();
            uiPanelTop.ResumeLayout(false);
            uiPanelTop.PerformLayout();
            uiPanelStatistics.ResumeLayout(false);
            uiPanelStatistics.PerformLayout();
            uiPanelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)uiDataGridViewReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel uiPanelTitle;
        private System.Windows.Forms.Label uiLabelTitle;
        private System.Windows.Forms.Label uiLabelSubtitle;
        private System.Windows.Forms.Panel uiPanelTop;
        private System.Windows.Forms.Label uiLabelChartType;
        private System.Windows.Forms.ComboBox uiComboBoxChartType;
        private System.Windows.Forms.Label uiLabelStartTime;
        private System.Windows.Forms.DateTimePicker uiDateTimePickerStart;
        private System.Windows.Forms.Label uiLabelEndTime;
        private System.Windows.Forms.DateTimePicker uiDateTimePickerEnd;
        private System.Windows.Forms.Button uiButtonQuery;
        private System.Windows.Forms.Button uiButtonExport;
        private System.Windows.Forms.Panel uiPanelChart;
        private System.Windows.Forms.Panel uiPanelStatistics;
        private System.Windows.Forms.Label uiLabelStatisticsTitle;
        private System.Windows.Forms.Label uiLabelCountTitle;
        private System.Windows.Forms.Label uiLabelMaxTitle;
        private System.Windows.Forms.Label uiLabelMinTitle;
        private System.Windows.Forms.Label uiLabelAvgTitle;
        private System.Windows.Forms.Label uiLabelTotalCount;
        private System.Windows.Forms.Label uiLabelMaxValue;
        private System.Windows.Forms.Label uiLabelMinValue;
        private System.Windows.Forms.Label uiLabelAvgValue;
        private System.Windows.Forms.Panel uiPanelData;
        private System.Windows.Forms.DataGridView uiDataGridViewReport;
    }
}
