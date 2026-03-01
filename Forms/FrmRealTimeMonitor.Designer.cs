namespace Custom.HydrogenConfigurationSystem.Forms
{
    partial class FrmRealTimeMonitor
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
            uiLabelRecipeStatus = new Label();
            uiPanelRecipeIndicator = new Panel();
            uiPanelElectrolyzer = new Panel();
            uiLabelElectrolyzerTitle = new Label();
            uiPanelElectrolyzerStatus = new Panel();
            uiPanelElectrolyzerParams = new Panel();
            uiLabelElecLevel = new Label();
            uiLabelElecLevelValue = new Label();
            uiLabelElecTemp = new Label();
            uiLabelElecTempValue = new Label();
            uiLabelElecVoltage = new Label();
            uiLabelElecVoltageValue = new Label();
            uiLabelElecCurrent = new Label();
            uiLabelElecCurrentValue = new Label();
            uiPanelPurification = new Panel();
            uiLabelPurificationTitle = new Label();
            uiPanelPurificationStatus = new Panel();
            uiPanelPurificationParams = new Panel();
            uiLabelPurPurity = new Label();
            uiLabelPurPurityValue = new Label();
            uiLabelPurTemp = new Label();
            uiLabelPurTempValue = new Label();
            uiLabelPurPressure = new Label();
            uiLabelPurPressureValue = new Label();
            uiPanelStorage = new Panel();
            uiLabelStorageTitle = new Label();
            uiPanelStorageStatus = new Panel();
            uiPanelStorageParams = new Panel();
            uiLabelStoLevel = new Label();
            uiLabelStoLevelValue = new Label();
            uiLabelStoTemp = new Label();
            uiLabelStoTempValue = new Label();
            uiLabelStoPressure = new Label();
            uiLabelStoPressureValue = new Label();
            uiPanelRefueling = new Panel();
            uiLabelRefuelingTitle = new Label();
            uiPanelRefuelingStatus = new Panel();
            uiPanelRefuelingParams = new Panel();
            uiLabelRefFlow = new Label();
            uiLabelRefFlowValue = new Label();
            uiPanelCooling = new Panel();
            uiLabelCoolingTitle = new Label();
            uiPanelCoolingStatus = new Panel();
            uiPanelCoolingParams = new Panel();
            uiLabelCoolOutTemp = new Label();
            uiLabelCoolOutTempValue = new Label();
            uiLabelCoolInTemp = new Label();
            uiLabelCoolInTempValue = new Label();
            uiPanelDetection = new Panel();
            uiLabelDetectionTitle = new Label();
            uiPanelDetectionStatus = new Panel();
            uiPanelDetectionParams = new Panel();
            uiLabelDetPurity = new Label();
            uiLabelDetPurityValue = new Label();
            uiPanelTransport = new Panel();
            uiLabelTransportTitle = new Label();
            uiPanelTransportStatus = new Panel();
            uiPanelTransportParams = new Panel();
            uiLabelTraPressure = new Label();
            uiLabelTraPressureValue = new Label();
            uiPanelTitle.SuspendLayout();
            uiPanelRecipeIndicator.SuspendLayout();
            uiPanelElectrolyzer.SuspendLayout();
            uiPanelElectrolyzerParams.SuspendLayout();
            uiPanelPurification.SuspendLayout();
            uiPanelPurificationParams.SuspendLayout();
            uiPanelStorage.SuspendLayout();
            uiPanelStorageParams.SuspendLayout();
            uiPanelRefueling.SuspendLayout();
            uiPanelRefuelingParams.SuspendLayout();
            uiPanelCooling.SuspendLayout();
            uiPanelCoolingParams.SuspendLayout();
            uiPanelDetection.SuspendLayout();
            uiPanelDetectionParams.SuspendLayout();
            uiPanelTransport.SuspendLayout();
            uiPanelTransportParams.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanelTitle
            // 
            uiPanelTitle.BackColor = Color.Transparent;
            uiPanelTitle.Controls.Add(uiPanelRecipeIndicator);
            uiPanelTitle.Controls.Add(uiLabelRecipeStatus);
            uiPanelTitle.Controls.Add(uiLabelSubtitle);
            uiPanelTitle.Controls.Add(uiLabelTitle);
            uiPanelTitle.Location = new Point(20, 20);
            uiPanelTitle.Name = "uiPanelTitle";
            uiPanelTitle.Size = new Size(1160, 60);
            uiPanelTitle.TabIndex = 0;
            // 
            // uiLabelRecipeStatus
            // 
            uiLabelRecipeStatus.AutoSize = true;
            uiLabelRecipeStatus.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            uiLabelRecipeStatus.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelRecipeStatus.Location = new Point(950, 21);
            uiLabelRecipeStatus.Name = "uiLabelRecipeStatus";
            uiLabelRecipeStatus.Size = new Size(132, 27);
            uiLabelRecipeStatus.TabIndex = 2;
            uiLabelRecipeStatus.Text = "配方：未设置";
            // 
            // uiPanelRecipeIndicator
            // 
            uiPanelRecipeIndicator.BackColor = Color.Gray;
            uiPanelRecipeIndicator.Location = new Point(920, 23);
            uiPanelRecipeIndicator.Name = "uiPanelRecipeIndicator";
            uiPanelRecipeIndicator.Size = new Size(20, 20);
            uiPanelRecipeIndicator.TabIndex = 3;
            // 
            // uiLabelSubtitle
            // 
            uiLabelSubtitle.AutoSize = true;
            uiLabelSubtitle.Font = new Font("微软雅黑", 10F);
            uiLabelSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelSubtitle.Location = new Point(158, 21);
            uiLabelSubtitle.Name = "uiLabelSubtitle";
            uiLabelSubtitle.Size = new Size(292, 27);
            uiLabelSubtitle.TabIndex = 1;
            uiLabelSubtitle.Text = "各工位设备状态与工艺参数监控";
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
            uiLabelTitle.Text = "实时监控";
            // 
            // uiPanelElectrolyzer
            // 
            uiPanelElectrolyzer.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelElectrolyzer.BorderStyle = BorderStyle.FixedSingle;
            uiPanelElectrolyzer.Controls.Add(uiPanelElectrolyzerStatus);
            uiPanelElectrolyzer.Controls.Add(uiLabelElectrolyzerTitle);
            uiPanelElectrolyzer.Controls.Add(uiPanelElectrolyzerParams);
            uiPanelElectrolyzer.Location = new Point(20, 100);
            uiPanelElectrolyzer.Name = "uiPanelElectrolyzer";
            uiPanelElectrolyzer.Size = new Size(280, 296);
            uiPanelElectrolyzer.TabIndex = 1;
            // 
            // uiPanelElectrolyzerStatus
            // 
            uiPanelElectrolyzerStatus.BackColor = Color.Gray;
            uiPanelElectrolyzerStatus.Location = new Point(245, 22);
            uiPanelElectrolyzerStatus.Name = "uiPanelElectrolyzerStatus";
            uiPanelElectrolyzerStatus.Size = new Size(20, 20);
            uiPanelElectrolyzerStatus.TabIndex = 2;
            // 
            // uiLabelElectrolyzerTitle
            // 
            uiLabelElectrolyzerTitle.AutoSize = true;
            uiLabelElectrolyzerTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelElectrolyzerTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelElectrolyzerTitle.Location = new Point(20, 15);
            uiLabelElectrolyzerTitle.Name = "uiLabelElectrolyzerTitle";
            uiLabelElectrolyzerTitle.Size = new Size(157, 37);
            uiLabelElectrolyzerTitle.TabIndex = 0;
            uiLabelElectrolyzerTitle.Text = "电解槽工位";
            // 
            // uiPanelElectrolyzerParams
            // 
            uiPanelElectrolyzerParams.BackColor = Color.Transparent;
            uiPanelElectrolyzerParams.Controls.Add(uiLabelElecLevel);
            uiPanelElectrolyzerParams.Controls.Add(uiLabelElecLevelValue);
            uiPanelElectrolyzerParams.Controls.Add(uiLabelElecTemp);
            uiPanelElectrolyzerParams.Controls.Add(uiLabelElecTempValue);
            uiPanelElectrolyzerParams.Controls.Add(uiLabelElecVoltage);
            uiPanelElectrolyzerParams.Controls.Add(uiLabelElecVoltageValue);
            uiPanelElectrolyzerParams.Controls.Add(uiLabelElecCurrent);
            uiPanelElectrolyzerParams.Controls.Add(uiLabelElecCurrentValue);
            uiPanelElectrolyzerParams.Location = new Point(10, 55);
            uiPanelElectrolyzerParams.Name = "uiPanelElectrolyzerParams";
            uiPanelElectrolyzerParams.Size = new Size(260, 236);
            uiPanelElectrolyzerParams.TabIndex = 1;
            // 
            // uiLabelElecLevel
            // 
            uiLabelElecLevel.AutoSize = true;
            uiLabelElecLevel.Font = new Font("微软雅黑", 10F);
            uiLabelElecLevel.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelElecLevel.Location = new Point(10, 150);
            uiLabelElecLevel.Name = "uiLabelElecLevel";
            uiLabelElecLevel.Size = new Size(112, 27);
            uiLabelElecLevel.TabIndex = 6;
            uiLabelElecLevel.Text = "电解液液位";
            // 
            // uiLabelElecLevelValue
            // 
            uiLabelElecLevelValue.AutoSize = true;
            uiLabelElecLevelValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelElecLevelValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelElecLevelValue.Location = new Point(10, 175);
            uiLabelElecLevelValue.Name = "uiLabelElecLevelValue";
            uiLabelElecLevelValue.Size = new Size(120, 40);
            uiLabelElecLevelValue.TabIndex = 7;
            uiLabelElecLevelValue.Text = "85.0 %";
            // 
            // uiLabelElecTemp
            // 
            uiLabelElecTemp.AutoSize = true;
            uiLabelElecTemp.Font = new Font("微软雅黑", 10F);
            uiLabelElecTemp.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelElecTemp.Location = new Point(10, 75);
            uiLabelElecTemp.Name = "uiLabelElecTemp";
            uiLabelElecTemp.Size = new Size(92, 27);
            uiLabelElecTemp.TabIndex = 4;
            uiLabelElecTemp.Text = "区域温度";
            // 
            // uiLabelElecTempValue
            // 
            uiLabelElecTempValue.AutoSize = true;
            uiLabelElecTempValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelElecTempValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelElecTempValue.Location = new Point(10, 100);
            uiLabelElecTempValue.Name = "uiLabelElecTempValue";
            uiLabelElecTempValue.Size = new Size(122, 40);
            uiLabelElecTempValue.TabIndex = 5;
            uiLabelElecTempValue.Text = "75.0 ℃";
            // 
            // uiLabelElecVoltage
            // 
            uiLabelElecVoltage.AutoSize = true;
            uiLabelElecVoltage.Font = new Font("微软雅黑", 10F);
            uiLabelElecVoltage.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelElecVoltage.Location = new Point(147, 10);
            uiLabelElecVoltage.Name = "uiLabelElecVoltage";
            uiLabelElecVoltage.Size = new Size(92, 27);
            uiLabelElecVoltage.TabIndex = 2;
            uiLabelElecVoltage.Text = "工作电压";
            // 
            // uiLabelElecVoltageValue
            // 
            uiLabelElecVoltageValue.AutoSize = true;
            uiLabelElecVoltageValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelElecVoltageValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelElecVoltageValue.Location = new Point(144, 37);
            uiLabelElecVoltageValue.Name = "uiLabelElecVoltageValue";
            uiLabelElecVoltageValue.Size = new Size(113, 40);
            uiLabelElecVoltageValue.TabIndex = 3;
            uiLabelElecVoltageValue.Text = "42.5 V";
            // 
            // uiLabelElecCurrent
            // 
            uiLabelElecCurrent.AutoSize = true;
            uiLabelElecCurrent.Font = new Font("微软雅黑", 10F);
            uiLabelElecCurrent.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelElecCurrent.Location = new Point(10, 10);
            uiLabelElecCurrent.Name = "uiLabelElecCurrent";
            uiLabelElecCurrent.Size = new Size(92, 27);
            uiLabelElecCurrent.TabIndex = 0;
            uiLabelElecCurrent.Text = "工作电流";
            // 
            // uiLabelElecCurrentValue
            // 
            uiLabelElecCurrentValue.AutoSize = true;
            uiLabelElecCurrentValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelElecCurrentValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelElecCurrentValue.Location = new Point(10, 35);
            uiLabelElecCurrentValue.Name = "uiLabelElecCurrentValue";
            uiLabelElecCurrentValue.Size = new Size(134, 40);
            uiLabelElecCurrentValue.TabIndex = 1;
            uiLabelElecCurrentValue.Text = "350.0 A";
            // 
            // uiPanelPurification
            // 
            uiPanelPurification.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelPurification.BorderStyle = BorderStyle.FixedSingle;
            uiPanelPurification.Controls.Add(uiPanelPurificationStatus);
            uiPanelPurification.Controls.Add(uiLabelPurificationTitle);
            uiPanelPurification.Controls.Add(uiPanelPurificationParams);
            uiPanelPurification.Location = new Point(320, 100);
            uiPanelPurification.Name = "uiPanelPurification";
            uiPanelPurification.Size = new Size(280, 296);
            uiPanelPurification.TabIndex = 2;
            // 
            // uiPanelPurificationStatus
            // 
            uiPanelPurificationStatus.BackColor = Color.Gray;
            uiPanelPurificationStatus.Location = new Point(245, 22);
            uiPanelPurificationStatus.Name = "uiPanelPurificationStatus";
            uiPanelPurificationStatus.Size = new Size(20, 20);
            uiPanelPurificationStatus.TabIndex = 2;
            // 
            // uiLabelPurificationTitle
            // 
            uiLabelPurificationTitle.AutoSize = true;
            uiLabelPurificationTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelPurificationTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelPurificationTitle.Location = new Point(20, 15);
            uiLabelPurificationTitle.Name = "uiLabelPurificationTitle";
            uiLabelPurificationTitle.Size = new Size(129, 37);
            uiLabelPurificationTitle.TabIndex = 0;
            uiLabelPurificationTitle.Text = "纯化工位";
            // 
            // uiPanelPurificationParams
            // 
            uiPanelPurificationParams.BackColor = Color.Transparent;
            uiPanelPurificationParams.Controls.Add(uiLabelPurPurity);
            uiPanelPurificationParams.Controls.Add(uiLabelPurPurityValue);
            uiPanelPurificationParams.Controls.Add(uiLabelPurTemp);
            uiPanelPurificationParams.Controls.Add(uiLabelPurTempValue);
            uiPanelPurificationParams.Controls.Add(uiLabelPurPressure);
            uiPanelPurificationParams.Controls.Add(uiLabelPurPressureValue);
            uiPanelPurificationParams.Location = new Point(10, 55);
            uiPanelPurificationParams.Name = "uiPanelPurificationParams";
            uiPanelPurificationParams.Size = new Size(260, 236);
            uiPanelPurificationParams.TabIndex = 1;
            // 
            // uiLabelPurPurity
            // 
            uiLabelPurPurity.AutoSize = true;
            uiLabelPurPurity.Font = new Font("微软雅黑", 10F);
            uiLabelPurPurity.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelPurPurity.Location = new Point(10, 150);
            uiLabelPurPurity.Name = "uiLabelPurPurity";
            uiLabelPurPurity.Size = new Size(92, 27);
            uiLabelPurPurity.TabIndex = 4;
            uiLabelPurPurity.Text = "氢气纯度";
            // 
            // uiLabelPurPurityValue
            // 
            uiLabelPurPurityValue.AutoSize = true;
            uiLabelPurPurityValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelPurPurityValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelPurPurityValue.Location = new Point(10, 175);
            uiLabelPurPurityValue.Name = "uiLabelPurPurityValue";
            uiLabelPurPurityValue.Size = new Size(158, 40);
            uiLabelPurPurityValue.TabIndex = 5;
            uiLabelPurPurityValue.Text = "99.999 %";
            // 
            // uiLabelPurTemp
            // 
            uiLabelPurTemp.AutoSize = true;
            uiLabelPurTemp.Font = new Font("微软雅黑", 10F);
            uiLabelPurTemp.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelPurTemp.Location = new Point(10, 80);
            uiLabelPurTemp.Name = "uiLabelPurTemp";
            uiLabelPurTemp.Size = new Size(92, 27);
            uiLabelPurTemp.TabIndex = 2;
            uiLabelPurTemp.Text = "区域温度";
            // 
            // uiLabelPurTempValue
            // 
            uiLabelPurTempValue.AutoSize = true;
            uiLabelPurTempValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelPurTempValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelPurTempValue.Location = new Point(10, 105);
            uiLabelPurTempValue.Name = "uiLabelPurTempValue";
            uiLabelPurTempValue.Size = new Size(122, 40);
            uiLabelPurTempValue.TabIndex = 3;
            uiLabelPurTempValue.Text = "45.0 ℃";
            // 
            // uiLabelPurPressure
            // 
            uiLabelPurPressure.AutoSize = true;
            uiLabelPurPressure.Font = new Font("微软雅黑", 10F);
            uiLabelPurPressure.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelPurPressure.Location = new Point(10, 10);
            uiLabelPurPressure.Name = "uiLabelPurPressure";
            uiLabelPurPressure.Size = new Size(92, 27);
            uiLabelPurPressure.TabIndex = 0;
            uiLabelPurPressure.Text = "工作压力";
            // 
            // uiLabelPurPressureValue
            // 
            uiLabelPurPressureValue.AutoSize = true;
            uiLabelPurPressureValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelPurPressureValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelPurPressureValue.Location = new Point(10, 35);
            uiLabelPurPressureValue.Name = "uiLabelPurPressureValue";
            uiLabelPurPressureValue.Size = new Size(141, 40);
            uiLabelPurPressureValue.TabIndex = 1;
            uiLabelPurPressureValue.Text = "5.2 MPa";
            // 
            // uiPanelStorage
            // 
            uiPanelStorage.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelStorage.BorderStyle = BorderStyle.FixedSingle;
            uiPanelStorage.Controls.Add(uiPanelStorageStatus);
            uiPanelStorage.Controls.Add(uiLabelStorageTitle);
            uiPanelStorage.Controls.Add(uiPanelStorageParams);
            uiPanelStorage.Location = new Point(620, 100);
            uiPanelStorage.Name = "uiPanelStorage";
            uiPanelStorage.Size = new Size(280, 296);
            uiPanelStorage.TabIndex = 3;
            // 
            // uiPanelStorageStatus
            // 
            uiPanelStorageStatus.BackColor = Color.Gray;
            uiPanelStorageStatus.Location = new Point(245, 22);
            uiPanelStorageStatus.Name = "uiPanelStorageStatus";
            uiPanelStorageStatus.Size = new Size(20, 20);
            uiPanelStorageStatus.TabIndex = 2;
            // 
            // uiLabelStorageTitle
            // 
            uiLabelStorageTitle.AutoSize = true;
            uiLabelStorageTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelStorageTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelStorageTitle.Location = new Point(20, 15);
            uiLabelStorageTitle.Name = "uiLabelStorageTitle";
            uiLabelStorageTitle.Size = new Size(129, 37);
            uiLabelStorageTitle.TabIndex = 0;
            uiLabelStorageTitle.Text = "储氢工位";
            // 
            // uiPanelStorageParams
            // 
            uiPanelStorageParams.BackColor = Color.Transparent;
            uiPanelStorageParams.Controls.Add(uiLabelStoLevel);
            uiPanelStorageParams.Controls.Add(uiLabelStoLevelValue);
            uiPanelStorageParams.Controls.Add(uiLabelStoTemp);
            uiPanelStorageParams.Controls.Add(uiLabelStoTempValue);
            uiPanelStorageParams.Controls.Add(uiLabelStoPressure);
            uiPanelStorageParams.Controls.Add(uiLabelStoPressureValue);
            uiPanelStorageParams.Location = new Point(10, 55);
            uiPanelStorageParams.Name = "uiPanelStorageParams";
            uiPanelStorageParams.Size = new Size(260, 236);
            uiPanelStorageParams.TabIndex = 1;
            // 
            // uiLabelStoLevel
            // 
            uiLabelStoLevel.AutoSize = true;
            uiLabelStoLevel.Font = new Font("微软雅黑", 10F);
            uiLabelStoLevel.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelStoLevel.Location = new Point(10, 150);
            uiLabelStoLevel.Name = "uiLabelStoLevel";
            uiLabelStoLevel.Size = new Size(112, 27);
            uiLabelStoLevel.TabIndex = 4;
            uiLabelStoLevel.Text = "储氢罐液位";
            // 
            // uiLabelStoLevelValue
            // 
            uiLabelStoLevelValue.AutoSize = true;
            uiLabelStoLevelValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelStoLevelValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelStoLevelValue.Location = new Point(10, 175);
            uiLabelStoLevelValue.Name = "uiLabelStoLevelValue";
            uiLabelStoLevelValue.Size = new Size(120, 40);
            uiLabelStoLevelValue.TabIndex = 5;
            uiLabelStoLevelValue.Text = "72.0 %";
            // 
            // uiLabelStoTemp
            // 
            uiLabelStoTemp.AutoSize = true;
            uiLabelStoTemp.Font = new Font("微软雅黑", 10F);
            uiLabelStoTemp.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelStoTemp.Location = new Point(10, 80);
            uiLabelStoTemp.Name = "uiLabelStoTemp";
            uiLabelStoTemp.Size = new Size(92, 27);
            uiLabelStoTemp.TabIndex = 2;
            uiLabelStoTemp.Text = "区域温度";
            // 
            // uiLabelStoTempValue
            // 
            uiLabelStoTempValue.AutoSize = true;
            uiLabelStoTempValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelStoTempValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelStoTempValue.Location = new Point(10, 105);
            uiLabelStoTempValue.Name = "uiLabelStoTempValue";
            uiLabelStoTempValue.Size = new Size(122, 40);
            uiLabelStoTempValue.TabIndex = 3;
            uiLabelStoTempValue.Text = "35.0 ℃";
            // 
            // uiLabelStoPressure
            // 
            uiLabelStoPressure.AutoSize = true;
            uiLabelStoPressure.Font = new Font("微软雅黑", 10F);
            uiLabelStoPressure.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelStoPressure.Location = new Point(10, 10);
            uiLabelStoPressure.Name = "uiLabelStoPressure";
            uiLabelStoPressure.Size = new Size(92, 27);
            uiLabelStoPressure.TabIndex = 0;
            uiLabelStoPressure.Text = "工作压力";
            // 
            // uiLabelStoPressureValue
            // 
            uiLabelStoPressureValue.AutoSize = true;
            uiLabelStoPressureValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelStoPressureValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelStoPressureValue.Location = new Point(10, 35);
            uiLabelStoPressureValue.Name = "uiLabelStoPressureValue";
            uiLabelStoPressureValue.Size = new Size(160, 40);
            uiLabelStoPressureValue.TabIndex = 1;
            uiLabelStoPressureValue.Text = "25.5 MPa";
            // 
            // uiPanelRefueling
            // 
            uiPanelRefueling.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelRefueling.BorderStyle = BorderStyle.FixedSingle;
            uiPanelRefueling.Controls.Add(uiPanelRefuelingStatus);
            uiPanelRefueling.Controls.Add(uiLabelRefuelingTitle);
            uiPanelRefueling.Controls.Add(uiPanelRefuelingParams);
            uiPanelRefueling.Location = new Point(920, 100);
            uiPanelRefueling.Name = "uiPanelRefueling";
            uiPanelRefueling.Size = new Size(260, 296);
            uiPanelRefueling.TabIndex = 4;
            // 
            // uiPanelRefuelingStatus
            // 
            uiPanelRefuelingStatus.BackColor = Color.Gray;
            uiPanelRefuelingStatus.Location = new Point(225, 22);
            uiPanelRefuelingStatus.Name = "uiPanelRefuelingStatus";
            uiPanelRefuelingStatus.Size = new Size(20, 20);
            uiPanelRefuelingStatus.TabIndex = 2;
            // 
            // uiLabelRefuelingTitle
            // 
            uiLabelRefuelingTitle.AutoSize = true;
            uiLabelRefuelingTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelRefuelingTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelRefuelingTitle.Location = new Point(20, 15);
            uiLabelRefuelingTitle.Name = "uiLabelRefuelingTitle";
            uiLabelRefuelingTitle.Size = new Size(129, 37);
            uiLabelRefuelingTitle.TabIndex = 0;
            uiLabelRefuelingTitle.Text = "加氢工位";
            // 
            // uiPanelRefuelingParams
            // 
            uiPanelRefuelingParams.BackColor = Color.Transparent;
            uiPanelRefuelingParams.Controls.Add(uiLabelRefFlow);
            uiPanelRefuelingParams.Controls.Add(uiLabelRefFlowValue);
            uiPanelRefuelingParams.Location = new Point(10, 55);
            uiPanelRefuelingParams.Name = "uiPanelRefuelingParams";
            uiPanelRefuelingParams.Size = new Size(240, 236);
            uiPanelRefuelingParams.TabIndex = 1;
            // 
            // uiLabelRefFlow
            // 
            uiLabelRefFlow.AutoSize = true;
            uiLabelRefFlow.Font = new Font("微软雅黑", 10F);
            uiLabelRefFlow.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelRefFlow.Location = new Point(10, 10);
            uiLabelRefFlow.Name = "uiLabelRefFlow";
            uiLabelRefFlow.Size = new Size(92, 27);
            uiLabelRefFlow.TabIndex = 0;
            uiLabelRefFlow.Text = "实时流量";
            // 
            // uiLabelRefFlowValue
            // 
            uiLabelRefFlowValue.AutoSize = true;
            uiLabelRefFlowValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelRefFlowValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelRefFlowValue.Location = new Point(10, 35);
            uiLabelRefFlowValue.Name = "uiLabelRefFlowValue";
            uiLabelRefFlowValue.Size = new Size(192, 40);
            uiLabelRefFlowValue.TabIndex = 1;
            uiLabelRefFlowValue.Text = "45.5 Nm³/h";
            // 
            // uiPanelCooling
            // 
            uiPanelCooling.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelCooling.BorderStyle = BorderStyle.FixedSingle;
            uiPanelCooling.Controls.Add(uiPanelCoolingStatus);
            uiPanelCooling.Controls.Add(uiLabelCoolingTitle);
            uiPanelCooling.Controls.Add(uiPanelCoolingParams);
            uiPanelCooling.Location = new Point(20, 450);
            uiPanelCooling.Name = "uiPanelCooling";
            uiPanelCooling.Size = new Size(280, 296);
            uiPanelCooling.TabIndex = 5;
            // 
            // uiPanelCoolingStatus
            // 
            uiPanelCoolingStatus.BackColor = Color.Gray;
            uiPanelCoolingStatus.Location = new Point(245, 22);
            uiPanelCoolingStatus.Name = "uiPanelCoolingStatus";
            uiPanelCoolingStatus.Size = new Size(20, 20);
            uiPanelCoolingStatus.TabIndex = 2;
            // 
            // uiLabelCoolingTitle
            // 
            uiLabelCoolingTitle.AutoSize = true;
            uiLabelCoolingTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelCoolingTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelCoolingTitle.Location = new Point(13, 15);
            uiLabelCoolingTitle.Name = "uiLabelCoolingTitle";
            uiLabelCoolingTitle.Size = new Size(129, 37);
            uiLabelCoolingTitle.TabIndex = 0;
            uiLabelCoolingTitle.Text = "冷却工位";
            // 
            // uiPanelCoolingParams
            // 
            uiPanelCoolingParams.BackColor = Color.Transparent;
            uiPanelCoolingParams.Controls.Add(uiLabelCoolOutTemp);
            uiPanelCoolingParams.Controls.Add(uiLabelCoolOutTempValue);
            uiPanelCoolingParams.Controls.Add(uiLabelCoolInTemp);
            uiPanelCoolingParams.Controls.Add(uiLabelCoolInTempValue);
            uiPanelCoolingParams.Location = new Point(10, 55);
            uiPanelCoolingParams.Name = "uiPanelCoolingParams";
            uiPanelCoolingParams.Size = new Size(260, 236);
            uiPanelCoolingParams.TabIndex = 1;
            // 
            // uiLabelCoolOutTemp
            // 
            uiLabelCoolOutTemp.AutoSize = true;
            uiLabelCoolOutTemp.Font = new Font("微软雅黑", 10F);
            uiLabelCoolOutTemp.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelCoolOutTemp.Location = new Point(10, 10);
            uiLabelCoolOutTemp.Name = "uiLabelCoolOutTemp";
            uiLabelCoolOutTemp.Size = new Size(92, 27);
            uiLabelCoolOutTemp.TabIndex = 0;
            uiLabelCoolOutTemp.Text = "出水温度";
            // 
            // uiLabelCoolOutTempValue
            // 
            uiLabelCoolOutTempValue.AutoSize = true;
            uiLabelCoolOutTempValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelCoolOutTempValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelCoolOutTempValue.Location = new Point(10, 35);
            uiLabelCoolOutTempValue.Name = "uiLabelCoolOutTempValue";
            uiLabelCoolOutTempValue.Size = new Size(122, 40);
            uiLabelCoolOutTempValue.TabIndex = 1;
            uiLabelCoolOutTempValue.Text = "25.0 ℃";
            // 
            // uiLabelCoolInTemp
            // 
            uiLabelCoolInTemp.AutoSize = true;
            uiLabelCoolInTemp.Font = new Font("微软雅黑", 10F);
            uiLabelCoolInTemp.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelCoolInTemp.Location = new Point(10, 80);
            uiLabelCoolInTemp.Name = "uiLabelCoolInTemp";
            uiLabelCoolInTemp.Size = new Size(92, 27);
            uiLabelCoolInTemp.TabIndex = 2;
            uiLabelCoolInTemp.Text = "回水温度";
            // 
            // uiLabelCoolInTempValue
            // 
            uiLabelCoolInTempValue.AutoSize = true;
            uiLabelCoolInTempValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelCoolInTempValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelCoolInTempValue.Location = new Point(10, 105);
            uiLabelCoolInTempValue.Name = "uiLabelCoolInTempValue";
            uiLabelCoolInTempValue.Size = new Size(122, 40);
            uiLabelCoolInTempValue.TabIndex = 3;
            uiLabelCoolInTempValue.Text = "38.0 ℃";
            // 
            // uiPanelDetection
            // 
            uiPanelDetection.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelDetection.BorderStyle = BorderStyle.FixedSingle;
            uiPanelDetection.Controls.Add(uiPanelDetectionStatus);
            uiPanelDetection.Controls.Add(uiLabelDetectionTitle);
            uiPanelDetection.Controls.Add(uiPanelDetectionParams);
            uiPanelDetection.Location = new Point(320, 450);
            uiPanelDetection.Name = "uiPanelDetection";
            uiPanelDetection.Size = new Size(280, 296);
            uiPanelDetection.TabIndex = 6;
            // 
            // uiPanelDetectionStatus
            // 
            uiPanelDetectionStatus.BackColor = Color.Gray;
            uiPanelDetectionStatus.Location = new Point(245, 22);
            uiPanelDetectionStatus.Name = "uiPanelDetectionStatus";
            uiPanelDetectionStatus.Size = new Size(20, 20);
            uiPanelDetectionStatus.TabIndex = 2;
            // 
            // uiLabelDetectionTitle
            // 
            uiLabelDetectionTitle.AutoSize = true;
            uiLabelDetectionTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelDetectionTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelDetectionTitle.Location = new Point(20, 15);
            uiLabelDetectionTitle.Name = "uiLabelDetectionTitle";
            uiLabelDetectionTitle.Size = new Size(129, 37);
            uiLabelDetectionTitle.TabIndex = 0;
            uiLabelDetectionTitle.Text = "检测工位";
            // 
            // uiPanelDetectionParams
            // 
            uiPanelDetectionParams.BackColor = Color.Transparent;
            uiPanelDetectionParams.Controls.Add(uiLabelDetPurity);
            uiPanelDetectionParams.Controls.Add(uiLabelDetPurityValue);
            uiPanelDetectionParams.Location = new Point(10, 55);
            uiPanelDetectionParams.Name = "uiPanelDetectionParams";
            uiPanelDetectionParams.Size = new Size(260, 236);
            uiPanelDetectionParams.TabIndex = 1;
            // 
            // uiLabelDetPurity
            // 
            uiLabelDetPurity.AutoSize = true;
            uiLabelDetPurity.Font = new Font("微软雅黑", 10F);
            uiLabelDetPurity.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelDetPurity.Location = new Point(10, 10);
            uiLabelDetPurity.Name = "uiLabelDetPurity";
            uiLabelDetPurity.Size = new Size(92, 27);
            uiLabelDetPurity.TabIndex = 0;
            uiLabelDetPurity.Text = "最终纯度";
            // 
            // uiLabelDetPurityValue
            // 
            uiLabelDetPurityValue.AutoSize = true;
            uiLabelDetPurityValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelDetPurityValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelDetPurityValue.Location = new Point(10, 35);
            uiLabelDetPurityValue.Name = "uiLabelDetPurityValue";
            uiLabelDetPurityValue.Size = new Size(158, 40);
            uiLabelDetPurityValue.TabIndex = 1;
            uiLabelDetPurityValue.Text = "99.998 %";
            // 
            // uiPanelTransport
            // 
            uiPanelTransport.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelTransport.BorderStyle = BorderStyle.FixedSingle;
            uiPanelTransport.Controls.Add(uiPanelTransportStatus);
            uiPanelTransport.Controls.Add(uiLabelTransportTitle);
            uiPanelTransport.Controls.Add(uiPanelTransportParams);
            uiPanelTransport.Location = new Point(620, 450);
            uiPanelTransport.Name = "uiPanelTransport";
            uiPanelTransport.Size = new Size(280, 296);
            uiPanelTransport.TabIndex = 7;
            // 
            // uiPanelTransportStatus
            // 
            uiPanelTransportStatus.BackColor = Color.Gray;
            uiPanelTransportStatus.Location = new Point(245, 22);
            uiPanelTransportStatus.Name = "uiPanelTransportStatus";
            uiPanelTransportStatus.Size = new Size(20, 20);
            uiPanelTransportStatus.TabIndex = 2;
            // 
            // uiLabelTransportTitle
            // 
            uiLabelTransportTitle.AutoSize = true;
            uiLabelTransportTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelTransportTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelTransportTitle.Location = new Point(20, 15);
            uiLabelTransportTitle.Name = "uiLabelTransportTitle";
            uiLabelTransportTitle.Size = new Size(129, 37);
            uiLabelTransportTitle.TabIndex = 0;
            uiLabelTransportTitle.Text = "输送工位";
            // 
            // uiPanelTransportParams
            // 
            uiPanelTransportParams.BackColor = Color.Transparent;
            uiPanelTransportParams.Controls.Add(uiLabelTraPressure);
            uiPanelTransportParams.Controls.Add(uiLabelTraPressureValue);
            uiPanelTransportParams.Location = new Point(10, 55);
            uiPanelTransportParams.Name = "uiPanelTransportParams";
            uiPanelTransportParams.Size = new Size(260, 236);
            uiPanelTransportParams.TabIndex = 1;
            // 
            // uiLabelTraPressure
            // 
            uiLabelTraPressure.AutoSize = true;
            uiLabelTraPressure.Font = new Font("微软雅黑", 10F);
            uiLabelTraPressure.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelTraPressure.Location = new Point(10, 10);
            uiLabelTraPressure.Name = "uiLabelTraPressure";
            uiLabelTraPressure.Size = new Size(92, 27);
            uiLabelTraPressure.TabIndex = 0;
            uiLabelTraPressure.Text = "工作压力";
            // 
            // uiLabelTraPressureValue
            // 
            uiLabelTraPressureValue.AutoSize = true;
            uiLabelTraPressureValue.Font = new Font("微软雅黑", 15F, FontStyle.Bold);
            uiLabelTraPressureValue.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelTraPressureValue.Location = new Point(10, 35);
            uiLabelTraPressureValue.Name = "uiLabelTraPressureValue";
            uiLabelTraPressureValue.Size = new Size(141, 40);
            uiLabelTraPressureValue.TabIndex = 1;
            uiLabelTraPressureValue.Text = "2.8 MPa";
            // 
            // FrmRealTimeMonitor
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1220, 760);
            Controls.Add(uiPanelTransport);
            Controls.Add(uiPanelDetection);
            Controls.Add(uiPanelCooling);
            Controls.Add(uiPanelRefueling);
            Controls.Add(uiPanelStorage);
            Controls.Add(uiPanelPurification);
            Controls.Add(uiPanelElectrolyzer);
            Controls.Add(uiPanelTitle);
            Name = "FrmRealTimeMonitor";
            Text = "实时监控";
            uiPanelRecipeIndicator.ResumeLayout(false);
            uiPanelTitle.ResumeLayout(false);
            uiPanelTitle.PerformLayout();
            uiPanelElectrolyzer.ResumeLayout(false);
            uiPanelElectrolyzer.PerformLayout();
            uiPanelElectrolyzerParams.ResumeLayout(false);
            uiPanelElectrolyzerParams.PerformLayout();
            uiPanelPurification.ResumeLayout(false);
            uiPanelPurification.PerformLayout();
            uiPanelPurificationParams.ResumeLayout(false);
            uiPanelPurificationParams.PerformLayout();
            uiPanelStorage.ResumeLayout(false);
            uiPanelStorage.PerformLayout();
            uiPanelStorageParams.ResumeLayout(false);
            uiPanelStorageParams.PerformLayout();
            uiPanelRefueling.ResumeLayout(false);
            uiPanelRefueling.PerformLayout();
            uiPanelRefuelingParams.ResumeLayout(false);
            uiPanelRefuelingParams.PerformLayout();
            uiPanelCooling.ResumeLayout(false);
            uiPanelCooling.PerformLayout();
            uiPanelCoolingParams.ResumeLayout(false);
            uiPanelCoolingParams.PerformLayout();
            uiPanelDetection.ResumeLayout(false);
            uiPanelDetection.PerformLayout();
            uiPanelDetectionParams.ResumeLayout(false);
            uiPanelDetectionParams.PerformLayout();
            uiPanelTransport.ResumeLayout(false);
            uiPanelTransport.PerformLayout();
            uiPanelTransportParams.ResumeLayout(false);
            uiPanelTransportParams.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel uiPanelTitle;
        private System.Windows.Forms.Label uiLabelTitle;
        private System.Windows.Forms.Label uiLabelSubtitle;
        private System.Windows.Forms.Label uiLabelRecipeStatus;
        private System.Windows.Forms.Panel uiPanelRecipeIndicator;
        private System.Windows.Forms.Panel uiPanelElectrolyzer;
        private System.Windows.Forms.Label uiLabelElectrolyzerTitle;
        private System.Windows.Forms.Panel uiPanelElectrolyzerStatus;
        private System.Windows.Forms.Panel uiPanelElectrolyzerParams;
        private System.Windows.Forms.Label uiLabelElecCurrent;
        private System.Windows.Forms.Label uiLabelElecCurrentValue;
        private System.Windows.Forms.Label uiLabelElecVoltage;
        private System.Windows.Forms.Label uiLabelElecVoltageValue;
        private System.Windows.Forms.Label uiLabelElecTemp;
        private System.Windows.Forms.Label uiLabelElecTempValue;
        private System.Windows.Forms.Label uiLabelElecLevel;
        private System.Windows.Forms.Label uiLabelElecLevelValue;
        private System.Windows.Forms.Panel uiPanelPurification;
        private System.Windows.Forms.Label uiLabelPurificationTitle;
        private System.Windows.Forms.Panel uiPanelPurificationStatus;
        private System.Windows.Forms.Panel uiPanelPurificationParams;
        private System.Windows.Forms.Label uiLabelPurPressure;
        private System.Windows.Forms.Label uiLabelPurPressureValue;
        private System.Windows.Forms.Label uiLabelPurTemp;
        private System.Windows.Forms.Label uiLabelPurTempValue;
        private System.Windows.Forms.Label uiLabelPurPurity;
        private System.Windows.Forms.Label uiLabelPurPurityValue;
        private System.Windows.Forms.Panel uiPanelStorage;
        private System.Windows.Forms.Label uiLabelStorageTitle;
        private System.Windows.Forms.Panel uiPanelStorageStatus;
        private System.Windows.Forms.Panel uiPanelStorageParams;
        private System.Windows.Forms.Label uiLabelStoPressure;
        private System.Windows.Forms.Label uiLabelStoPressureValue;
        private System.Windows.Forms.Label uiLabelStoTemp;
        private System.Windows.Forms.Label uiLabelStoTempValue;
        private System.Windows.Forms.Label uiLabelStoLevel;
        private System.Windows.Forms.Label uiLabelStoLevelValue;
        private System.Windows.Forms.Panel uiPanelRefueling;
        private System.Windows.Forms.Label uiLabelRefuelingTitle;
        private System.Windows.Forms.Panel uiPanelRefuelingStatus;
        private System.Windows.Forms.Panel uiPanelRefuelingParams;
        private System.Windows.Forms.Label uiLabelRefFlow;
        private System.Windows.Forms.Label uiLabelRefFlowValue;
        private System.Windows.Forms.Panel uiPanelCooling;
        private System.Windows.Forms.Label uiLabelCoolingTitle;
        private System.Windows.Forms.Panel uiPanelCoolingStatus;
        private System.Windows.Forms.Panel uiPanelCoolingParams;
        private System.Windows.Forms.Label uiLabelCoolOutTemp;
        private System.Windows.Forms.Label uiLabelCoolOutTempValue;
        private System.Windows.Forms.Label uiLabelCoolInTemp;
        private System.Windows.Forms.Label uiLabelCoolInTempValue;
        private System.Windows.Forms.Panel uiPanelDetection;
        private System.Windows.Forms.Label uiLabelDetectionTitle;
        private System.Windows.Forms.Panel uiPanelDetectionStatus;
        private System.Windows.Forms.Panel uiPanelDetectionParams;
        private System.Windows.Forms.Label uiLabelDetPurity;
        private System.Windows.Forms.Label uiLabelDetPurityValue;
        private System.Windows.Forms.Panel uiPanelTransport;
        private System.Windows.Forms.Label uiLabelTransportTitle;
        private System.Windows.Forms.Panel uiPanelTransportStatus;
        private System.Windows.Forms.Panel uiPanelTransportParams;
        private System.Windows.Forms.Label uiLabelTraPressure;
        private System.Windows.Forms.Label uiLabelTraPressureValue;
    }
}
