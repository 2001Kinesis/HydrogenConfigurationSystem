namespace Custom.HydrogenConfigurationSystem.Forms
{
    partial class FrmMain
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
            pnlHeader = new Panel();
            pnlAlarm = new Panel();
            lblAlarmInfo = new Label();
            lblSystemStatus = new Label();
            lblHydrogenOutput = new Label();
            lblHydrogenConcentration = new Label();
            lblCurrentRecipe = new Label();
            lblCurrentUser = new Label();
            lblSystemName = new Label();
            pnlAside = new Panel();
            btnSimulateData = new Button();
            btnUserManager = new Button();
            btnSystemConfig = new Button();
            btnReportChart = new Button();
            btnLogQuery = new Button();
            btnRecipeManager = new Button();
            btnRealTimeMonitor = new Button();
            btnDeviceControl = new Button();
            btnDashboard = new Button();
            pnlMain = new Panel();
            pnlFooter = new Panel();
            lblSystemTime = new Label();
            lblAuthState = new Label();
            lblSoftwareVersion = new Label();
            lblMemoryUsage = new Label();
            lblCpuUsage = new Label();
            pnlPlcIndicator = new Panel();
            lblPlcState = new Label();
            lblElectrolysisCurrent = new Label();
            lblStoragePressure = new Label();
            lblEnvironmentTemp = new Label();
            lblEnvironmentHumidity = new Label();
            timerSystemTime = new System.Windows.Forms.Timer();
            pnlHeader.SuspendLayout();
            pnlAlarm.SuspendLayout();
            pnlAside.SuspendLayout();
            pnlFooter.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 41, 59);
            pnlHeader.Controls.Add(pnlAlarm);
            pnlHeader.Controls.Add(lblSystemStatus);
            pnlHeader.Controls.Add(lblHydrogenOutput);
            pnlHeader.Controls.Add(lblHydrogenConcentration);
            pnlHeader.Controls.Add(lblCurrentRecipe);
            pnlHeader.Controls.Add(lblCurrentUser);
            pnlHeader.Controls.Add(lblSystemName);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1400, 70);
            pnlHeader.TabIndex = 0;
            // 
            // pnlAlarm
            // 
            pnlAlarm.BackColor = Color.FromArgb(15, 23, 42);
            pnlAlarm.BorderStyle = BorderStyle.FixedSingle;
            pnlAlarm.Controls.Add(lblAlarmInfo);
            pnlAlarm.Location = new Point(1172, 14);
            pnlAlarm.Name = "pnlAlarm";
            pnlAlarm.Size = new Size(208, 40);
            pnlAlarm.TabIndex = 5;
            // 
            // lblAlarmInfo
            // 
            lblAlarmInfo.AutoSize = true;
            lblAlarmInfo.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblAlarmInfo.ForeColor = Color.FromArgb(34, 197, 94);
            lblAlarmInfo.Location = new Point(10, 10);
            lblAlarmInfo.Name = "lblAlarmInfo";
            lblAlarmInfo.Size = new Size(172, 27);
            lblAlarmInfo.TabIndex = 0;
            lblAlarmInfo.Text = "系统正常，无报警";
            // 
            // lblSystemStatus
            // 
            lblSystemStatus.AutoSize = true;
            lblSystemStatus.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblSystemStatus.ForeColor = Color.FromArgb(34, 197, 94);
            lblSystemStatus.Location = new Point(1074, 25);
            lblSystemStatus.Name = "lblSystemStatus";
            lblSystemStatus.Size = new Size(92, 27);
            lblSystemStatus.TabIndex = 4;
            lblSystemStatus.Text = "系统正常";
            // 
            // lblHydrogenOutput
            // 
            lblHydrogenOutput.AutoSize = true;
            lblHydrogenOutput.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblHydrogenOutput.ForeColor = Color.White;
            lblHydrogenOutput.Location = new Point(874, 25);
            lblHydrogenOutput.Name = "lblHydrogenOutput";
            lblHydrogenOutput.Size = new Size(194, 27);
            lblHydrogenOutput.TabIndex = 5;
            lblHydrogenOutput.Text = "实时产氢：0.0 Nm3/h";
            // 
            // lblHydrogenConcentration
            // 
            lblHydrogenConcentration.AutoSize = true;
            lblHydrogenConcentration.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblHydrogenConcentration.ForeColor = Color.White;
            lblHydrogenConcentration.Location = new Point(707, 25);
            lblHydrogenConcentration.Name = "lblHydrogenConcentration";
            lblHydrogenConcentration.Size = new Size(161, 27);
            lblHydrogenConcentration.TabIndex = 2;
            lblHydrogenConcentration.Text = "氢气浓度：0.0%";
            // 
            // lblCurrentRecipe
            // 
            lblCurrentRecipe.AutoSize = true;
            lblCurrentRecipe.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblCurrentRecipe.ForeColor = Color.FromArgb(250, 204, 21);
            lblCurrentRecipe.Location = new Point(320, 27);
            lblCurrentRecipe.Name = "lblCurrentRecipe";
            lblCurrentRecipe.Size = new Size(172, 27);
            lblCurrentRecipe.TabIndex = 6;
            lblCurrentRecipe.Text = "当前配方：未设置";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("微软雅黑", 10F);
            lblCurrentUser.ForeColor = Color.FromArgb(148, 163, 184);
            lblCurrentUser.Location = new Point(510, 27);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(112, 27);
            lblCurrentUser.TabIndex = 1;
            lblCurrentUser.Text = "当前用户：";
            // 
            // lblCurrentRecipe
            // 
            lblCurrentRecipe.AutoSize = true;
            lblCurrentRecipe.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblCurrentRecipe.ForeColor = Color.FromArgb(250, 204, 21);
            lblCurrentRecipe.Location = new Point(320, 27);
            lblCurrentRecipe.Name = "lblCurrentRecipe";
            lblCurrentRecipe.Size = new Size(172, 27);
            lblCurrentRecipe.TabIndex = 6;
            lblCurrentRecipe.Text = "当前配方：未设置";
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            lblSystemName.ForeColor = Color.FromArgb(34, 211, 238);
            lblSystemName.Location = new Point(3, 9);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(308, 47);
            lblSystemName.TabIndex = 0;
            lblSystemName.Text = "氢能组态监控系统";
            // 
            // pnlAside
            // 
            pnlAside.BackColor = Color.FromArgb(22, 30, 46);
            pnlAside.Controls.Add(btnSimulateData);
            pnlAside.Controls.Add(btnUserManager);
            pnlAside.Controls.Add(btnSystemConfig);
            pnlAside.Controls.Add(btnReportChart);
            pnlAside.Controls.Add(btnLogQuery);
            pnlAside.Controls.Add(btnRecipeManager);
            pnlAside.Controls.Add(btnRealTimeMonitor);
            pnlAside.Controls.Add(btnDeviceControl);
            pnlAside.Controls.Add(btnDashboard);
            pnlAside.Dock = DockStyle.Left;
            pnlAside.Location = new Point(0, 70);
            pnlAside.Name = "pnlAside";
            pnlAside.Size = new Size(180, 830);
            pnlAside.TabIndex = 1;
            // 
            // btnUserManager
            // 
            btnUserManager.BackColor = Color.Transparent;
            btnUserManager.FlatAppearance.BorderSize = 0;
            btnUserManager.FlatStyle = FlatStyle.Flat;
            btnUserManager.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            btnUserManager.ForeColor = Color.White;
            btnUserManager.Location = new Point(10, 440);
            btnUserManager.Name = "btnUserManager";
            btnUserManager.Size = new Size(160, 50);
            btnUserManager.TabIndex = 7;
            btnUserManager.Text = "用户管理";
            btnUserManager.UseVisualStyleBackColor = false;
            // 
            // btnSystemConfig
            // 
            btnSystemConfig.BackColor = Color.Transparent;
            btnSystemConfig.FlatAppearance.BorderSize = 0;
            btnSystemConfig.FlatStyle = FlatStyle.Flat;
            btnSystemConfig.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            btnSystemConfig.ForeColor = Color.White;
            btnSystemConfig.Location = new Point(10, 380);
            btnSystemConfig.Name = "btnSystemConfig";
            btnSystemConfig.Size = new Size(160, 50);
            btnSystemConfig.TabIndex = 6;
            btnSystemConfig.Text = "系统配置";
            btnSystemConfig.UseVisualStyleBackColor = false;
            // 
            // btnReportChart
            // 
            btnReportChart.BackColor = Color.Transparent;
            btnReportChart.FlatAppearance.BorderSize = 0;
            btnReportChart.FlatStyle = FlatStyle.Flat;
            btnReportChart.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            btnReportChart.ForeColor = Color.White;
            btnReportChart.Location = new Point(10, 320);
            btnReportChart.Name = "btnReportChart";
            btnReportChart.Size = new Size(160, 50);
            btnReportChart.TabIndex = 5;
            btnReportChart.Text = "报表图表";
            btnReportChart.UseVisualStyleBackColor = false;
            // 
            // btnLogQuery
            // 
            btnLogQuery.BackColor = Color.Transparent;
            btnLogQuery.FlatAppearance.BorderSize = 0;
            btnLogQuery.FlatStyle = FlatStyle.Flat;
            btnLogQuery.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            btnLogQuery.ForeColor = Color.White;
            btnLogQuery.Location = new Point(10, 260);
            btnLogQuery.Name = "btnLogQuery";
            btnLogQuery.Size = new Size(160, 50);
            btnLogQuery.TabIndex = 4;
            btnLogQuery.Text = "日志查询";
            btnLogQuery.UseVisualStyleBackColor = false;
            // 
            // btnRecipeManager
            // 
            btnRecipeManager.BackColor = Color.Transparent;
            btnRecipeManager.FlatAppearance.BorderSize = 0;
            btnRecipeManager.FlatStyle = FlatStyle.Flat;
            btnRecipeManager.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            btnRecipeManager.ForeColor = Color.White;
            btnRecipeManager.Location = new Point(10, 200);
            btnRecipeManager.Name = "btnRecipeManager";
            btnRecipeManager.Size = new Size(160, 50);
            btnRecipeManager.TabIndex = 3;
            btnRecipeManager.Text = "配方管理";
            btnRecipeManager.UseVisualStyleBackColor = false;
            // 
            // btnRealTimeMonitor
            // 
            btnRealTimeMonitor.BackColor = Color.Transparent;
            btnRealTimeMonitor.FlatAppearance.BorderSize = 0;
            btnRealTimeMonitor.FlatStyle = FlatStyle.Flat;
            btnRealTimeMonitor.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            btnRealTimeMonitor.ForeColor = Color.White;
            btnRealTimeMonitor.Location = new Point(10, 140);
            btnRealTimeMonitor.Name = "btnRealTimeMonitor";
            btnRealTimeMonitor.Size = new Size(160, 50);
            btnRealTimeMonitor.TabIndex = 2;
            btnRealTimeMonitor.Text = "实时监控";
            btnRealTimeMonitor.UseVisualStyleBackColor = false;
            // 
            // btnDeviceControl
            // 
            btnDeviceControl.BackColor = Color.Transparent;
            btnDeviceControl.FlatAppearance.BorderSize = 0;
            btnDeviceControl.FlatStyle = FlatStyle.Flat;
            btnDeviceControl.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            btnDeviceControl.ForeColor = Color.White;
            btnDeviceControl.Location = new Point(10, 80);
            btnDeviceControl.Name = "btnDeviceControl";
            btnDeviceControl.Size = new Size(160, 50);
            btnDeviceControl.TabIndex = 1;
            btnDeviceControl.Text = "设备控制";
            btnDeviceControl.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(34, 211, 238);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 20);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(160, 50);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "系统总览";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnSimulateData
            // 
            btnSimulateData.BackColor = Color.FromArgb(245, 158, 11);
            btnSimulateData.FlatAppearance.BorderSize = 0;
            btnSimulateData.FlatStyle = FlatStyle.Flat;
            btnSimulateData.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            btnSimulateData.ForeColor = Color.White;
            btnSimulateData.Location = new Point(10, 500);
            btnSimulateData.Name = "btnSimulateData";
            btnSimulateData.Size = new Size(160, 40);
            btnSimulateData.TabIndex = 8;
            btnSimulateData.Text = "模拟数据";
            btnSimulateData.UseVisualStyleBackColor = false;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(15, 23, 42);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(180, 70);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1220, 785);
            pnlMain.TabIndex = 2;
            // 
            // pnlFooter
            // 
            pnlFooter.BackColor = Color.FromArgb(30, 41, 59);
            pnlFooter.Controls.Add(lblSystemTime);
            pnlFooter.Controls.Add(lblAuthState);
            pnlFooter.Controls.Add(lblSoftwareVersion);
            pnlFooter.Controls.Add(lblMemoryUsage);
            pnlFooter.Controls.Add(lblCpuUsage);
            pnlFooter.Controls.Add(pnlPlcIndicator);
            pnlFooter.Controls.Add(lblPlcState);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(180, 855);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(1220, 45);
            pnlFooter.TabIndex = 3;
            // 
            // lblSystemTime
            // 
            lblSystemTime.AutoSize = true;
            lblSystemTime.Font = new Font("微软雅黑", 9F, FontStyle.Bold);
            lblSystemTime.ForeColor = Color.White;
            lblSystemTime.Location = new Point(1000, 14);
            lblSystemTime.Name = "lblSystemTime";
            lblSystemTime.Size = new Size(196, 24);
            lblSystemTime.TabIndex = 6;
            lblSystemTime.Text = "2026-02-28 00:00:00";
            // 
            // lblAuthState
            // 
            lblAuthState.AutoSize = true;
            lblAuthState.Font = new Font("微软雅黑", 9F);
            lblAuthState.ForeColor = Color.FromArgb(34, 197, 94);
            lblAuthState.Location = new Point(680, 14);
            lblAuthState.Name = "lblAuthState";
            lblAuthState.Size = new Size(82, 24);
            lblAuthState.TabIndex = 5;
            lblAuthState.Text = "授权正常";
            // 
            // lblSoftwareVersion
            // 
            lblSoftwareVersion.AutoSize = true;
            lblSoftwareVersion.Font = new Font("微软雅黑", 9F);
            lblSoftwareVersion.ForeColor = Color.FromArgb(148, 163, 184);
            lblSoftwareVersion.Location = new Point(520, 14);
            lblSoftwareVersion.Name = "lblSoftwareVersion";
            lblSoftwareVersion.Size = new Size(106, 24);
            lblSoftwareVersion.TabIndex = 4;
            lblSoftwareVersion.Text = "版本：1.0.0";
            // 
            // lblMemoryUsage
            // 
            lblMemoryUsage.AutoSize = true;
            lblMemoryUsage.Font = new Font("微软雅黑", 9F);
            lblMemoryUsage.ForeColor = Color.FromArgb(148, 163, 184);
            lblMemoryUsage.Location = new Point(400, 14);
            lblMemoryUsage.Name = "lblMemoryUsage";
            lblMemoryUsage.Size = new Size(92, 24);
            lblMemoryUsage.TabIndex = 3;
            lblMemoryUsage.Text = "内存：0%";
            // 
            // lblCpuUsage
            // 
            lblCpuUsage.AutoSize = true;
            lblCpuUsage.Font = new Font("微软雅黑", 9F);
            lblCpuUsage.ForeColor = Color.FromArgb(148, 163, 184);
            lblCpuUsage.Location = new Point(280, 14);
            lblCpuUsage.Name = "lblCpuUsage";
            lblCpuUsage.Size = new Size(92, 24);
            lblCpuUsage.TabIndex = 2;
            lblCpuUsage.Text = "CPU：0%";
            // 
            // pnlPlcIndicator
            // 
            pnlPlcIndicator.BackColor = Color.Gray;
            pnlPlcIndicator.Location = new Point(20, 14);
            pnlPlcIndicator.Name = "pnlPlcIndicator";
            pnlPlcIndicator.Size = new Size(16, 16);
            pnlPlcIndicator.TabIndex = 1;
            // 
            // lblPlcState
            // 
            lblPlcState.AutoSize = true;
            lblPlcState.Font = new Font("微软雅黑", 9F);
            lblPlcState.ForeColor = Color.FromArgb(148, 163, 184);
            lblPlcState.Location = new Point(45, 14);
            lblPlcState.Name = "lblPlcState";
            lblPlcState.Size = new Size(96, 24);
            lblPlcState.TabIndex = 0;
            lblPlcState.Text = "PLC未连接";
            // 
            // lblElectrolysisCurrent
            // 
            lblElectrolysisCurrent.AutoSize = true;
            lblElectrolysisCurrent.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblElectrolysisCurrent.ForeColor = Color.White;
            lblElectrolysisCurrent.Location = new Point(880, 27);
            lblElectrolysisCurrent.Name = "lblElectrolysisCurrent";
            lblElectrolysisCurrent.Size = new Size(120, 19);
            lblElectrolysisCurrent.TabIndex = 6;
            lblElectrolysisCurrent.Text = "电解电流：0.0 A";
            // 
            // lblStoragePressure
            // 
            lblStoragePressure.AutoSize = true;
            lblStoragePressure.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblStoragePressure.ForeColor = Color.White;
            lblStoragePressure.Location = new Point(1010, 27);
            lblStoragePressure.Name = "lblStoragePressure";
            lblStoragePressure.Size = new Size(120, 19);
            lblStoragePressure.TabIndex = 7;
            lblStoragePressure.Text = "储氢压力：0.0 MPa";
            // 
            // lblEnvironmentTemp
            // 
            lblEnvironmentTemp.AutoSize = true;
            lblEnvironmentTemp.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblEnvironmentTemp.ForeColor = Color.White;
            lblEnvironmentTemp.Location = new Point(1140, 27);
            lblEnvironmentTemp.Name = "lblEnvironmentTemp";
            lblEnvironmentTemp.Size = new Size(120, 19);
            lblEnvironmentTemp.TabIndex = 8;
            lblEnvironmentTemp.Text = "环境温度：0.0 ℃";
            // 
            // lblEnvironmentHumidity
            // 
            lblEnvironmentHumidity.AutoSize = true;
            lblEnvironmentHumidity.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            lblEnvironmentHumidity.ForeColor = Color.White;
            lblEnvironmentHumidity.Location = new Point(1270, 27);
            lblEnvironmentHumidity.Name = "lblEnvironmentHumidity";
            lblEnvironmentHumidity.Size = new Size(120, 19);
            lblEnvironmentHumidity.TabIndex = 9;
            lblEnvironmentHumidity.Text = "环境湿度：0.0 %";
            // 
            // FrmMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1400, 900);
            Controls.Add(pnlMain);
            Controls.Add(pnlFooter);
            Controls.Add(pnlAside);
            Controls.Add(pnlHeader);
            Name = "FrmMain";
            Text = "氢能组态监控系统";
            lblCurrentRecipe.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlAlarm.ResumeLayout(false);
            pnlAlarm.PerformLayout();
            pnlAside.ResumeLayout(false);
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ResumeLayout(false);
            // 
            // timerSystemTime
            // 
            timerSystemTime.Interval = 1000;
            timerSystemTime.Tick += TimerSystemTime_Tick;
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSystemName;
        private System.Windows.Forms.Label lblCurrentRecipe;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Label lblSystemStatus;
        private System.Windows.Forms.Panel pnlAlarm;
        private System.Windows.Forms.Label lblAlarmInfo;
        private System.Windows.Forms.Panel pnlAside;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnDeviceControl;
        private System.Windows.Forms.Button btnRealTimeMonitor;
        private System.Windows.Forms.Button btnRecipeManager;
        private System.Windows.Forms.Button btnLogQuery;
        private System.Windows.Forms.Button btnReportChart;
        private System.Windows.Forms.Button btnSystemConfig;
        private System.Windows.Forms.Button btnUserManager;
        private System.Windows.Forms.Button btnSimulateData;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblPlcState;
        private System.Windows.Forms.Panel pnlPlcIndicator;
        private System.Windows.Forms.Label lblCpuUsage;
        private System.Windows.Forms.Label lblMemoryUsage;
        private System.Windows.Forms.Label lblSoftwareVersion;
        private System.Windows.Forms.Label lblAuthState;
        private System.Windows.Forms.Label lblSystemTime;
        private System.Windows.Forms.Label lblHydrogenConcentration;
        private System.Windows.Forms.Label lblElectrolysisCurrent;
        private System.Windows.Forms.Label lblStoragePressure;
        private System.Windows.Forms.Label lblEnvironmentTemp;
        private System.Windows.Forms.Label lblEnvironmentHumidity;
        private System.Windows.Forms.Label lblHydrogenOutput;
        private System.Windows.Forms.Timer timerSystemTime;
    }
}
