namespace Custom.HydrogenConfigurationSystem.Forms
{
    partial class FrmDashboard
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
            uiPanelEnvironment = new Panel();
            uiLabelEnvTitle = new Label();
            uiPanelEnvTemp = new Panel();
            uiLabelEnvTempUnit = new Label();
            uiLabelEnvTempValue = new Label();
            uiLabelEnvTempLabel = new Label();
            uiLabelEnvTempIcon = new Label();
            uiPanelEnvHumidity = new Panel();
            uiLabelEnvHumidityUnit = new Label();
            uiLabelEnvHumidityValue = new Label();
            uiLabelEnvHumidityLabel = new Label();
            uiLabelEnvHumidityIcon = new Label();
            uiPanelEnvHydrogen = new Panel();
            uiLabelEnvHydrogenUnit = new Label();
            uiLabelEnvHydrogenValue = new Label();
            uiLabelEnvHydrogenLabel = new Label();
            uiLabelEnvHydrogenIcon = new Label();
            uiPanelProduction = new Panel();
            uiLabelProdTitle = new Label();
            uiPanelProdHydrogen = new Panel();
            uiLabelProdHydrogenUnit = new Label();
            uiLabelProdHydrogenValue = new Label();
            uiLabelProdHydrogenLabel = new Label();
            uiLabelProdHydrogenIcon = new Label();
            uiPanelProdEnergy = new Panel();
            uiLabelProdEnergyUnit = new Label();
            uiLabelProdEnergyValue = new Label();
            uiLabelProdEnergyLabel = new Label();
            uiLabelProdEnergyIcon = new Label();
            uiPanelProdTotal = new Panel();
            uiLabelProdTotalUnit = new Label();
            uiLabelProdTotalValue = new Label();
            uiLabelProdTotalLabel = new Label();
            uiLabelProdTotalIcon = new Label();
            uiPanelTitle.SuspendLayout();
            uiPanelEnvironment.SuspendLayout();
            uiPanelEnvTemp.SuspendLayout();
            uiPanelEnvHumidity.SuspendLayout();
            uiPanelEnvHydrogen.SuspendLayout();
            uiPanelProduction.SuspendLayout();
            uiPanelProdHydrogen.SuspendLayout();
            uiPanelProdEnergy.SuspendLayout();
            uiPanelProdTotal.SuspendLayout();
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
            uiLabelSubtitle.Location = new Point(173, 20);
            uiLabelSubtitle.Name = "uiLabelSubtitle";
            uiLabelSubtitle.Size = new Size(232, 27);
            uiLabelSubtitle.TabIndex = 1;
            uiLabelSubtitle.Text = "氢能生产线实时监控数据";
            // 
            // uiLabelTitle
            // 
            uiLabelTitle.AutoSize = true;
            uiLabelTitle.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            uiLabelTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelTitle.Location = new Point(3, 0);
            uiLabelTitle.Name = "uiLabelTitle";
            uiLabelTitle.Size = new Size(164, 47);
            uiLabelTitle.TabIndex = 0;
            uiLabelTitle.Text = "系统总览";
            // 
            // uiPanelEnvironment
            // 
            uiPanelEnvironment.BackColor = Color.Transparent;
            uiPanelEnvironment.Controls.Add(uiLabelEnvTitle);
            uiPanelEnvironment.Controls.Add(uiPanelEnvTemp);
            uiPanelEnvironment.Controls.Add(uiPanelEnvHumidity);
            uiPanelEnvironment.Controls.Add(uiPanelEnvHydrogen);
            uiPanelEnvironment.Location = new Point(20, 116);
            uiPanelEnvironment.Name = "uiPanelEnvironment";
            uiPanelEnvironment.Size = new Size(1160, 201);
            uiPanelEnvironment.TabIndex = 1;
            // 
            // uiLabelEnvTitle
            // 
            uiLabelEnvTitle.AutoSize = true;
            uiLabelEnvTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelEnvTitle.ForeColor = Color.FromArgb(203, 213, 225);
            uiLabelEnvTitle.Location = new Point(3, 10);
            uiLabelEnvTitle.Name = "uiLabelEnvTitle";
            uiLabelEnvTitle.Size = new Size(129, 37);
            uiLabelEnvTitle.TabIndex = 0;
            uiLabelEnvTitle.Text = "环境监控";
            // 
            // uiPanelEnvTemp
            // 
            uiPanelEnvTemp.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelEnvTemp.BorderStyle = BorderStyle.FixedSingle;
            uiPanelEnvTemp.Controls.Add(uiLabelEnvTempUnit);
            uiPanelEnvTemp.Controls.Add(uiLabelEnvTempValue);
            uiPanelEnvTemp.Controls.Add(uiLabelEnvTempLabel);
            uiPanelEnvTemp.Controls.Add(uiLabelEnvTempIcon);
            uiPanelEnvTemp.Location = new Point(3, 64);
            uiPanelEnvTemp.Name = "uiPanelEnvTemp";
            uiPanelEnvTemp.Size = new Size(360, 130);
            uiPanelEnvTemp.TabIndex = 1;
            // 
            // uiLabelEnvTempUnit
            // 
            uiLabelEnvTempUnit.AutoSize = true;
            uiLabelEnvTempUnit.Font = new Font("微软雅黑", 14F);
            uiLabelEnvTempUnit.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelEnvTempUnit.Location = new Point(169, 70);
            uiLabelEnvTempUnit.Name = "uiLabelEnvTempUnit";
            uiLabelEnvTempUnit.Size = new Size(43, 36);
            uiLabelEnvTempUnit.TabIndex = 3;
            uiLabelEnvTempUnit.Text = "℃";
            // 
            // uiLabelEnvTempValue
            // 
            uiLabelEnvTempValue.AutoSize = true;
            uiLabelEnvTempValue.Font = new Font("微软雅黑", 28F, FontStyle.Bold);
            uiLabelEnvTempValue.ForeColor = Color.FromArgb(251, 146, 60);
            uiLabelEnvTempValue.Location = new Point(3, 39);
            uiLabelEnvTempValue.Name = "uiLabelEnvTempValue";
            uiLabelEnvTempValue.Size = new Size(153, 75);
            uiLabelEnvTempValue.TabIndex = 2;
            uiLabelEnvTempValue.Text = "25.0";
            // 
            // uiLabelEnvTempLabel
            // 
            uiLabelEnvTempLabel.AutoSize = true;
            uiLabelEnvTempLabel.Font = new Font("微软雅黑", 10F);
            uiLabelEnvTempLabel.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelEnvTempLabel.Location = new Point(33, 6);
            uiLabelEnvTempLabel.Name = "uiLabelEnvTempLabel";
            uiLabelEnvTempLabel.Size = new Size(92, 27);
            uiLabelEnvTempLabel.TabIndex = 1;
            uiLabelEnvTempLabel.Text = "厂房温度";
            // 
            // uiLabelEnvTempIcon
            // 
            uiLabelEnvTempIcon.AutoSize = true;
            uiLabelEnvTempIcon.Font = new Font("微软雅黑", 12F);
            uiLabelEnvTempIcon.ForeColor = Color.FromArgb(251, 146, 60);
            uiLabelEnvTempIcon.Location = new Point(3, 4);
            uiLabelEnvTempIcon.Name = "uiLabelEnvTempIcon";
            uiLabelEnvTempIcon.Size = new Size(40, 31);
            uiLabelEnvTempIcon.TabIndex = 0;
            uiLabelEnvTempIcon.Text = "🌡";
            // 
            // uiPanelEnvHumidity
            // 
            uiPanelEnvHumidity.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelEnvHumidity.BorderStyle = BorderStyle.FixedSingle;
            uiPanelEnvHumidity.Controls.Add(uiLabelEnvHumidityUnit);
            uiPanelEnvHumidity.Controls.Add(uiLabelEnvHumidityValue);
            uiPanelEnvHumidity.Controls.Add(uiLabelEnvHumidityLabel);
            uiPanelEnvHumidity.Controls.Add(uiLabelEnvHumidityIcon);
            uiPanelEnvHumidity.Location = new Point(400, 64);
            uiPanelEnvHumidity.Name = "uiPanelEnvHumidity";
            uiPanelEnvHumidity.Size = new Size(360, 130);
            uiPanelEnvHumidity.TabIndex = 2;
            // 
            // uiLabelEnvHumidityUnit
            // 
            uiLabelEnvHumidityUnit.AutoSize = true;
            uiLabelEnvHumidityUnit.Font = new Font("微软雅黑", 14F);
            uiLabelEnvHumidityUnit.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelEnvHumidityUnit.Location = new Point(180, 70);
            uiLabelEnvHumidityUnit.Name = "uiLabelEnvHumidityUnit";
            uiLabelEnvHumidityUnit.Size = new Size(80, 36);
            uiLabelEnvHumidityUnit.TabIndex = 3;
            uiLabelEnvHumidityUnit.Text = "%RH";
            // 
            // uiLabelEnvHumidityValue
            // 
            uiLabelEnvHumidityValue.AutoSize = true;
            uiLabelEnvHumidityValue.Font = new Font("微软雅黑", 28F, FontStyle.Bold);
            uiLabelEnvHumidityValue.ForeColor = Color.FromArgb(59, 130, 246);
            uiLabelEnvHumidityValue.Location = new Point(3, 39);
            uiLabelEnvHumidityValue.Name = "uiLabelEnvHumidityValue";
            uiLabelEnvHumidityValue.Size = new Size(153, 75);
            uiLabelEnvHumidityValue.TabIndex = 2;
            uiLabelEnvHumidityValue.Text = "55.0";
            // 
            // uiLabelEnvHumidityLabel
            // 
            uiLabelEnvHumidityLabel.AutoSize = true;
            uiLabelEnvHumidityLabel.Font = new Font("微软雅黑", 10F);
            uiLabelEnvHumidityLabel.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelEnvHumidityLabel.Location = new Point(33, 6);
            uiLabelEnvHumidityLabel.Name = "uiLabelEnvHumidityLabel";
            uiLabelEnvHumidityLabel.Size = new Size(92, 27);
            uiLabelEnvHumidityLabel.TabIndex = 1;
            uiLabelEnvHumidityLabel.Text = "厂房湿度";
            // 
            // uiLabelEnvHumidityIcon
            // 
            uiLabelEnvHumidityIcon.AutoSize = true;
            uiLabelEnvHumidityIcon.Font = new Font("微软雅黑", 12F);
            uiLabelEnvHumidityIcon.ForeColor = Color.FromArgb(59, 130, 246);
            uiLabelEnvHumidityIcon.Location = new Point(3, 4);
            uiLabelEnvHumidityIcon.Name = "uiLabelEnvHumidityIcon";
            uiLabelEnvHumidityIcon.Size = new Size(40, 31);
            uiLabelEnvHumidityIcon.TabIndex = 0;
            uiLabelEnvHumidityIcon.Text = "💧";
            // 
            // uiPanelEnvHydrogen
            // 
            uiPanelEnvHydrogen.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelEnvHydrogen.BorderStyle = BorderStyle.FixedSingle;
            uiPanelEnvHydrogen.Controls.Add(uiLabelEnvHydrogenUnit);
            uiPanelEnvHydrogen.Controls.Add(uiLabelEnvHydrogenValue);
            uiPanelEnvHydrogen.Controls.Add(uiLabelEnvHydrogenLabel);
            uiPanelEnvHydrogen.Controls.Add(uiLabelEnvHydrogenIcon);
            uiPanelEnvHydrogen.Location = new Point(800, 64);
            uiPanelEnvHydrogen.Name = "uiPanelEnvHydrogen";
            uiPanelEnvHydrogen.Size = new Size(360, 130);
            uiPanelEnvHydrogen.TabIndex = 3;
            // 
            // uiLabelEnvHydrogenUnit
            // 
            uiLabelEnvHydrogenUnit.AutoSize = true;
            uiLabelEnvHydrogenUnit.Font = new Font("微软雅黑", 14F);
            uiLabelEnvHydrogenUnit.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelEnvHydrogenUnit.Location = new Point(173, 70);
            uiLabelEnvHydrogenUnit.Name = "uiLabelEnvHydrogenUnit";
            uiLabelEnvHydrogenUnit.Size = new Size(96, 36);
            uiLabelEnvHydrogenUnit.TabIndex = 3;
            uiLabelEnvHydrogenUnit.Text = "%VOL";
            // 
            // uiLabelEnvHydrogenValue
            // 
            uiLabelEnvHydrogenValue.AutoSize = true;
            uiLabelEnvHydrogenValue.Font = new Font("微软雅黑", 28F, FontStyle.Bold);
            uiLabelEnvHydrogenValue.ForeColor = Color.FromArgb(16, 185, 129);
            uiLabelEnvHydrogenValue.Location = new Point(3, 39);
            uiLabelEnvHydrogenValue.Name = "uiLabelEnvHydrogenValue";
            uiLabelEnvHydrogenValue.Size = new Size(118, 75);
            uiLabelEnvHydrogenValue.TabIndex = 2;
            uiLabelEnvHydrogenValue.Text = "0.5";
            // 
            // uiLabelEnvHydrogenLabel
            // 
            uiLabelEnvHydrogenLabel.AutoSize = true;
            uiLabelEnvHydrogenLabel.Font = new Font("微软雅黑", 10F);
            uiLabelEnvHydrogenLabel.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelEnvHydrogenLabel.Location = new Point(33, 6);
            uiLabelEnvHydrogenLabel.Name = "uiLabelEnvHydrogenLabel";
            uiLabelEnvHydrogenLabel.Size = new Size(92, 27);
            uiLabelEnvHydrogenLabel.TabIndex = 1;
            uiLabelEnvHydrogenLabel.Text = "氢气浓度";
            // 
            // uiLabelEnvHydrogenIcon
            // 
            uiLabelEnvHydrogenIcon.AutoSize = true;
            uiLabelEnvHydrogenIcon.Font = new Font("微软雅黑", 12F);
            uiLabelEnvHydrogenIcon.ForeColor = Color.FromArgb(16, 185, 129);
            uiLabelEnvHydrogenIcon.Location = new Point(3, 4);
            uiLabelEnvHydrogenIcon.Name = "uiLabelEnvHydrogenIcon";
            uiLabelEnvHydrogenIcon.Size = new Size(40, 31);
            uiLabelEnvHydrogenIcon.TabIndex = 0;
            uiLabelEnvHydrogenIcon.Text = "⚡";
            // 
            // uiPanelProduction
            // 
            uiPanelProduction.BackColor = Color.Transparent;
            uiPanelProduction.Controls.Add(uiLabelProdTitle);
            uiPanelProduction.Controls.Add(uiPanelProdHydrogen);
            uiPanelProduction.Controls.Add(uiPanelProdEnergy);
            uiPanelProduction.Controls.Add(uiPanelProdTotal);
            uiPanelProduction.Location = new Point(20, 372);
            uiPanelProduction.Name = "uiPanelProduction";
            uiPanelProduction.Size = new Size(1160, 198);
            uiPanelProduction.TabIndex = 2;
            // 
            // uiLabelProdTitle
            // 
            uiLabelProdTitle.AutoSize = true;
            uiLabelProdTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelProdTitle.ForeColor = Color.FromArgb(203, 213, 225);
            uiLabelProdTitle.Location = new Point(3, 8);
            uiLabelProdTitle.Name = "uiLabelProdTitle";
            uiLabelProdTitle.Size = new Size(129, 37);
            uiLabelProdTitle.TabIndex = 0;
            uiLabelProdTitle.Text = "生产统计";
            // 
            // uiPanelProdHydrogen
            // 
            uiPanelProdHydrogen.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelProdHydrogen.BorderStyle = BorderStyle.FixedSingle;
            uiPanelProdHydrogen.Controls.Add(uiLabelProdHydrogenUnit);
            uiPanelProdHydrogen.Controls.Add(uiLabelProdHydrogenValue);
            uiPanelProdHydrogen.Controls.Add(uiLabelProdHydrogenLabel);
            uiPanelProdHydrogen.Controls.Add(uiLabelProdHydrogenIcon);
            uiPanelProdHydrogen.Location = new Point(0, 60);
            uiPanelProdHydrogen.Name = "uiPanelProdHydrogen";
            uiPanelProdHydrogen.Size = new Size(360, 130);
            uiPanelProdHydrogen.TabIndex = 1;
            // 
            // uiLabelProdHydrogenUnit
            // 
            uiLabelProdHydrogenUnit.AutoSize = true;
            uiLabelProdHydrogenUnit.Font = new Font("微软雅黑", 14F);
            uiLabelProdHydrogenUnit.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelProdHydrogenUnit.Location = new Point(162, 70);
            uiLabelProdHydrogenUnit.Name = "uiLabelProdHydrogenUnit";
            uiLabelProdHydrogenUnit.Size = new Size(104, 36);
            uiLabelProdHydrogenUnit.TabIndex = 3;
            uiLabelProdHydrogenUnit.Text = "Nm³/h";
            // 
            // uiLabelProdHydrogenValue
            // 
            uiLabelProdHydrogenValue.AutoSize = true;
            uiLabelProdHydrogenValue.Font = new Font("微软雅黑", 28F, FontStyle.Bold);
            uiLabelProdHydrogenValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelProdHydrogenValue.Location = new Point(3, 39);
            uiLabelProdHydrogenValue.Name = "uiLabelProdHydrogenValue";
            uiLabelProdHydrogenValue.Size = new Size(153, 75);
            uiLabelProdHydrogenValue.TabIndex = 2;
            uiLabelProdHydrogenValue.Text = "12.5";
            // 
            // uiLabelProdHydrogenLabel
            // 
            uiLabelProdHydrogenLabel.AutoSize = true;
            uiLabelProdHydrogenLabel.Font = new Font("微软雅黑", 10F);
            uiLabelProdHydrogenLabel.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelProdHydrogenLabel.Location = new Point(33, 6);
            uiLabelProdHydrogenLabel.Name = "uiLabelProdHydrogenLabel";
            uiLabelProdHydrogenLabel.Size = new Size(112, 27);
            uiLabelProdHydrogenLabel.TabIndex = 1;
            uiLabelProdHydrogenLabel.Text = "实时产氢量";
            // 
            // uiLabelProdHydrogenIcon
            // 
            uiLabelProdHydrogenIcon.AutoSize = true;
            uiLabelProdHydrogenIcon.Font = new Font("微软雅黑", 12F);
            uiLabelProdHydrogenIcon.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelProdHydrogenIcon.Location = new Point(3, 4);
            uiLabelProdHydrogenIcon.Name = "uiLabelProdHydrogenIcon";
            uiLabelProdHydrogenIcon.Size = new Size(40, 31);
            uiLabelProdHydrogenIcon.TabIndex = 0;
            uiLabelProdHydrogenIcon.Text = "📊";
            // 
            // uiPanelProdEnergy
            // 
            uiPanelProdEnergy.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelProdEnergy.BorderStyle = BorderStyle.FixedSingle;
            uiPanelProdEnergy.Controls.Add(uiLabelProdEnergyUnit);
            uiPanelProdEnergy.Controls.Add(uiLabelProdEnergyValue);
            uiPanelProdEnergy.Controls.Add(uiLabelProdEnergyLabel);
            uiPanelProdEnergy.Controls.Add(uiLabelProdEnergyIcon);
            uiPanelProdEnergy.Location = new Point(400, 60);
            uiPanelProdEnergy.Name = "uiPanelProdEnergy";
            uiPanelProdEnergy.Size = new Size(360, 130);
            uiPanelProdEnergy.TabIndex = 2;
            // 
            // uiLabelProdEnergyUnit
            // 
            uiLabelProdEnergyUnit.AutoSize = true;
            uiLabelProdEnergyUnit.Font = new Font("微软雅黑", 14F);
            uiLabelProdEnergyUnit.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelProdEnergyUnit.Location = new Point(180, 70);
            uiLabelProdEnergyUnit.Name = "uiLabelProdEnergyUnit";
            uiLabelProdEnergyUnit.Size = new Size(148, 36);
            uiLabelProdEnergyUnit.TabIndex = 3;
            uiLabelProdEnergyUnit.Text = "kWh/Nm³";
            // 
            // uiLabelProdEnergyValue
            // 
            uiLabelProdEnergyValue.AutoSize = true;
            uiLabelProdEnergyValue.Font = new Font("微软雅黑", 28F, FontStyle.Bold);
            uiLabelProdEnergyValue.ForeColor = Color.FromArgb(250, 204, 21);
            uiLabelProdEnergyValue.Location = new Point(3, 39);
            uiLabelProdEnergyValue.Name = "uiLabelProdEnergyValue";
            uiLabelProdEnergyValue.Size = new Size(118, 75);
            uiLabelProdEnergyValue.TabIndex = 2;
            uiLabelProdEnergyValue.Text = "4.2";
            // 
            // uiLabelProdEnergyLabel
            // 
            uiLabelProdEnergyLabel.AutoSize = true;
            uiLabelProdEnergyLabel.Font = new Font("微软雅黑", 10F);
            uiLabelProdEnergyLabel.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelProdEnergyLabel.Location = new Point(33, 6);
            uiLabelProdEnergyLabel.Name = "uiLabelProdEnergyLabel";
            uiLabelProdEnergyLabel.Size = new Size(92, 27);
            uiLabelProdEnergyLabel.TabIndex = 1;
            uiLabelProdEnergyLabel.Text = "实时能耗";
            // 
            // uiLabelProdEnergyIcon
            // 
            uiLabelProdEnergyIcon.AutoSize = true;
            uiLabelProdEnergyIcon.Font = new Font("微软雅黑", 12F);
            uiLabelProdEnergyIcon.ForeColor = Color.FromArgb(250, 204, 21);
            uiLabelProdEnergyIcon.Location = new Point(3, 4);
            uiLabelProdEnergyIcon.Name = "uiLabelProdEnergyIcon";
            uiLabelProdEnergyIcon.Size = new Size(40, 31);
            uiLabelProdEnergyIcon.TabIndex = 0;
            uiLabelProdEnergyIcon.Text = "⚡";
            // 
            // uiPanelProdTotal
            // 
            uiPanelProdTotal.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelProdTotal.BorderStyle = BorderStyle.FixedSingle;
            uiPanelProdTotal.Controls.Add(uiLabelProdTotalUnit);
            uiPanelProdTotal.Controls.Add(uiLabelProdTotalValue);
            uiPanelProdTotal.Controls.Add(uiLabelProdTotalLabel);
            uiPanelProdTotal.Controls.Add(uiLabelProdTotalIcon);
            uiPanelProdTotal.Location = new Point(800, 60);
            uiPanelProdTotal.Name = "uiPanelProdTotal";
            uiPanelProdTotal.Size = new Size(360, 130);
            uiPanelProdTotal.TabIndex = 3;
            // 
            // uiLabelProdTotalUnit
            // 
            uiLabelProdTotalUnit.AutoSize = true;
            uiLabelProdTotalUnit.Font = new Font("微软雅黑", 14F);
            uiLabelProdTotalUnit.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelProdTotalUnit.Location = new Point(232, 70);
            uiLabelProdTotalUnit.Name = "uiLabelProdTotalUnit";
            uiLabelProdTotalUnit.Size = new Size(75, 36);
            uiLabelProdTotalUnit.TabIndex = 3;
            uiLabelProdTotalUnit.Text = "Nm³";
            // 
            // uiLabelProdTotalValue
            // 
            uiLabelProdTotalValue.AutoSize = true;
            uiLabelProdTotalValue.Font = new Font("微软雅黑", 28F, FontStyle.Bold);
            uiLabelProdTotalValue.ForeColor = Color.FromArgb(74, 222, 128);
            uiLabelProdTotalValue.Location = new Point(3, 39);
            uiLabelProdTotalValue.Name = "uiLabelProdTotalValue";
            uiLabelProdTotalValue.Size = new Size(223, 75);
            uiLabelProdTotalValue.TabIndex = 2;
            uiLabelProdTotalValue.Text = "1250.0";
            // 
            // uiLabelProdTotalLabel
            // 
            uiLabelProdTotalLabel.AutoSize = true;
            uiLabelProdTotalLabel.Font = new Font("微软雅黑", 10F);
            uiLabelProdTotalLabel.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelProdTotalLabel.Location = new Point(33, 6);
            uiLabelProdTotalLabel.Name = "uiLabelProdTotalLabel";
            uiLabelProdTotalLabel.Size = new Size(112, 27);
            uiLabelProdTotalLabel.TabIndex = 1;
            uiLabelProdTotalLabel.Text = "累计产氢量";
            // 
            // uiLabelProdTotalIcon
            // 
            uiLabelProdTotalIcon.AutoSize = true;
            uiLabelProdTotalIcon.Font = new Font("微软雅黑", 12F);
            uiLabelProdTotalIcon.ForeColor = Color.FromArgb(74, 222, 128);
            uiLabelProdTotalIcon.Location = new Point(3, 4);
            uiLabelProdTotalIcon.Name = "uiLabelProdTotalIcon";
            uiLabelProdTotalIcon.Size = new Size(40, 31);
            uiLabelProdTotalIcon.TabIndex = 0;
            uiLabelProdTotalIcon.Text = "📈";
            // 
            // FrmDashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1220, 760);
            Controls.Add(uiPanelProduction);
            Controls.Add(uiPanelEnvironment);
            Controls.Add(uiPanelTitle);
            Name = "FrmDashboard";
            Text = "系统总览";
            uiPanelTitle.ResumeLayout(false);
            uiPanelTitle.PerformLayout();
            uiPanelEnvironment.ResumeLayout(false);
            uiPanelEnvironment.PerformLayout();
            uiPanelEnvTemp.ResumeLayout(false);
            uiPanelEnvTemp.PerformLayout();
            uiPanelEnvHumidity.ResumeLayout(false);
            uiPanelEnvHumidity.PerformLayout();
            uiPanelEnvHydrogen.ResumeLayout(false);
            uiPanelEnvHydrogen.PerformLayout();
            uiPanelProduction.ResumeLayout(false);
            uiPanelProduction.PerformLayout();
            uiPanelProdHydrogen.ResumeLayout(false);
            uiPanelProdHydrogen.PerformLayout();
            uiPanelProdEnergy.ResumeLayout(false);
            uiPanelProdEnergy.PerformLayout();
            uiPanelProdTotal.ResumeLayout(false);
            uiPanelProdTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel uiPanelTitle;
        private System.Windows.Forms.Label uiLabelTitle;
        private System.Windows.Forms.Label uiLabelSubtitle;
        private System.Windows.Forms.Panel uiPanelEnvironment;
        private System.Windows.Forms.Label uiLabelEnvTitle;
        private System.Windows.Forms.Panel uiPanelEnvTemp;
        private System.Windows.Forms.Label uiLabelEnvTempIcon;
        private System.Windows.Forms.Label uiLabelEnvTempLabel;
        private System.Windows.Forms.Label uiLabelEnvTempValue;
        private System.Windows.Forms.Label uiLabelEnvTempUnit;
        private System.Windows.Forms.Panel uiPanelEnvHumidity;
        private System.Windows.Forms.Label uiLabelEnvHumidityIcon;
        private System.Windows.Forms.Label uiLabelEnvHumidityLabel;
        private System.Windows.Forms.Label uiLabelEnvHumidityValue;
        private System.Windows.Forms.Label uiLabelEnvHumidityUnit;
        private System.Windows.Forms.Panel uiPanelEnvHydrogen;
        private System.Windows.Forms.Label uiLabelEnvHydrogenIcon;
        private System.Windows.Forms.Label uiLabelEnvHydrogenLabel;
        private System.Windows.Forms.Label uiLabelEnvHydrogenValue;
        private System.Windows.Forms.Label uiLabelEnvHydrogenUnit;
        private System.Windows.Forms.Panel uiPanelProduction;
        private System.Windows.Forms.Label uiLabelProdTitle;
        private System.Windows.Forms.Panel uiPanelProdHydrogen;
        private System.Windows.Forms.Label uiLabelProdHydrogenIcon;
        private System.Windows.Forms.Label uiLabelProdHydrogenLabel;
        private System.Windows.Forms.Label uiLabelProdHydrogenValue;
        private System.Windows.Forms.Label uiLabelProdHydrogenUnit;
        private System.Windows.Forms.Panel uiPanelProdEnergy;
        private System.Windows.Forms.Label uiLabelProdEnergyIcon;
        private System.Windows.Forms.Label uiLabelProdEnergyLabel;
        private System.Windows.Forms.Label uiLabelProdEnergyValue;
        private System.Windows.Forms.Label uiLabelProdEnergyUnit;
        private System.Windows.Forms.Panel uiPanelProdTotal;
        private System.Windows.Forms.Label uiLabelProdTotalIcon;
        private System.Windows.Forms.Label uiLabelProdTotalLabel;
        private System.Windows.Forms.Label uiLabelProdTotalValue;
        private System.Windows.Forms.Label uiLabelProdTotalUnit;
    }
}
