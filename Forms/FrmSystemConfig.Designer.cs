namespace Custom.HydrogenConfigurationSystem.Forms
{
    partial class FrmSystemConfig
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
            uiPanelPlcConfig = new Panel();
            uiLabelPlcTitle = new Label();
            uiLabelPlcIp = new Label();
            uiTextBoxPlcIp = new TextBox();
            uiLabelPlcPort = new Label();
            uiTextBoxPlcPort = new TextBox();
            uiLabelCpuType = new Label();
            uiComboBoxCpuType = new ComboBox();
            uiLabelRack = new Label();
            uiTextBoxRack = new TextBox();
            uiLabelSlot = new Label();
            uiTextBoxSlot = new TextBox();
            uiLabelReadInterval = new Label();
            uiTextBoxReadInterval = new TextBox();
            uiLabelReconnectInterval = new Label();
            uiTextBoxReconnectInterval = new TextBox();
            uiPanelSystemConfig = new Panel();
            uiLabelSystemTitle = new Label();
            uiLabelSoftwareVersion = new Label();
            uiTextBoxSoftwareVersion = new TextBox();
            uiLabelTrialDays = new Label();
            uiTextBoxTrialDays = new TextBox();
            uiPanelLogConfig = new Panel();
            uiLabelLogTitle = new Label();
            uiLabelLogCleanDays = new Label();
            uiComboBoxLogCleanDays = new ComboBox();
            uiLabelLogPath = new Label();
            uiTextBoxLogPath = new TextBox();
            uiButtonBrowsePath = new Button();
            uiPanelButtons = new Panel();
            panel1 = new Panel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiSwitch1 = new Sunny.UI.UISwitch();
            uiButton1 = new Sunny.UI.UIButton();
            uiTextBox1 = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            label1 = new Label();
            uiButtonTestPlc = new Button();
            uiButtonSave = new Button();
            uiPanelTitle.SuspendLayout();
            uiPanelPlcConfig.SuspendLayout();
            uiPanelSystemConfig.SuspendLayout();
            uiPanelLogConfig.SuspendLayout();
            uiPanelButtons.SuspendLayout();
            panel1.SuspendLayout();
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
            uiLabelSubtitle.Size = new Size(247, 27);
            uiLabelSubtitle.TabIndex = 1;
            uiLabelSubtitle.Text = "PLC、系统和日志配置管理";
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
            uiLabelTitle.Text = "系统配置";
            // 
            // uiPanelPlcConfig
            // 
            uiPanelPlcConfig.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelPlcConfig.BorderStyle = BorderStyle.FixedSingle;
            uiPanelPlcConfig.Controls.Add(uiLabelPlcTitle);
            uiPanelPlcConfig.Controls.Add(uiLabelPlcIp);
            uiPanelPlcConfig.Controls.Add(uiTextBoxPlcIp);
            uiPanelPlcConfig.Controls.Add(uiLabelPlcPort);
            uiPanelPlcConfig.Controls.Add(uiTextBoxPlcPort);
            uiPanelPlcConfig.Controls.Add(uiLabelCpuType);
            uiPanelPlcConfig.Controls.Add(uiComboBoxCpuType);
            uiPanelPlcConfig.Controls.Add(uiLabelRack);
            uiPanelPlcConfig.Controls.Add(uiTextBoxRack);
            uiPanelPlcConfig.Controls.Add(uiLabelSlot);
            uiPanelPlcConfig.Controls.Add(uiTextBoxSlot);
            uiPanelPlcConfig.Controls.Add(uiLabelReadInterval);
            uiPanelPlcConfig.Controls.Add(uiTextBoxReadInterval);
            uiPanelPlcConfig.Controls.Add(uiLabelReconnectInterval);
            uiPanelPlcConfig.Controls.Add(uiTextBoxReconnectInterval);
            uiPanelPlcConfig.Location = new Point(20, 100);
            uiPanelPlcConfig.Name = "uiPanelPlcConfig";
            uiPanelPlcConfig.Size = new Size(560, 380);
            uiPanelPlcConfig.TabIndex = 1;
            // 
            // uiLabelPlcTitle
            // 
            uiLabelPlcTitle.AutoSize = true;
            uiLabelPlcTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelPlcTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelPlcTitle.Location = new Point(3, 0);
            uiLabelPlcTitle.Name = "uiLabelPlcTitle";
            uiLabelPlcTitle.Size = new Size(125, 37);
            uiLabelPlcTitle.TabIndex = 0;
            uiLabelPlcTitle.Text = "PLC配置";
            // 
            // uiLabelPlcIp
            // 
            uiLabelPlcIp.AutoSize = true;
            uiLabelPlcIp.Font = new Font("微软雅黑", 10F);
            uiLabelPlcIp.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelPlcIp.Location = new Point(25, 66);
            uiLabelPlcIp.Name = "uiLabelPlcIp";
            uiLabelPlcIp.Size = new Size(70, 27);
            uiLabelPlcIp.TabIndex = 1;
            uiLabelPlcIp.Text = "IP地址";
            // 
            // uiTextBoxPlcIp
            // 
            uiTextBoxPlcIp.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxPlcIp.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxPlcIp.Font = new Font("微软雅黑", 10F);
            uiTextBoxPlcIp.ForeColor = Color.White;
            uiTextBoxPlcIp.Location = new Point(25, 96);
            uiTextBoxPlcIp.Name = "uiTextBoxPlcIp";
            uiTextBoxPlcIp.Size = new Size(200, 34);
            uiTextBoxPlcIp.TabIndex = 2;
            uiTextBoxPlcIp.Text = "192.168.0.1";
            // 
            // uiLabelPlcPort
            // 
            uiLabelPlcPort.AutoSize = true;
            uiLabelPlcPort.Font = new Font("微软雅黑", 10F);
            uiLabelPlcPort.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelPlcPort.Location = new Point(308, 66);
            uiLabelPlcPort.Name = "uiLabelPlcPort";
            uiLabelPlcPort.Size = new Size(52, 27);
            uiLabelPlcPort.TabIndex = 3;
            uiLabelPlcPort.Text = "端口";
            // 
            // uiTextBoxPlcPort
            // 
            uiTextBoxPlcPort.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxPlcPort.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxPlcPort.Font = new Font("微软雅黑", 10F);
            uiTextBoxPlcPort.ForeColor = Color.White;
            uiTextBoxPlcPort.Location = new Point(308, 96);
            uiTextBoxPlcPort.Name = "uiTextBoxPlcPort";
            uiTextBoxPlcPort.Size = new Size(120, 34);
            uiTextBoxPlcPort.TabIndex = 4;
            uiTextBoxPlcPort.Text = "102";
            // 
            // uiLabelCpuType
            // 
            uiLabelCpuType.AutoSize = true;
            uiLabelCpuType.Font = new Font("微软雅黑", 10F);
            uiLabelCpuType.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelCpuType.Location = new Point(25, 145);
            uiLabelCpuType.Name = "uiLabelCpuType";
            uiLabelCpuType.Size = new Size(92, 27);
            uiLabelCpuType.TabIndex = 5;
            uiLabelCpuType.Text = "CPU类型";
            // 
            // uiComboBoxCpuType
            // 
            uiComboBoxCpuType.BackColor = Color.FromArgb(15, 23, 42);
            uiComboBoxCpuType.DropDownStyle = ComboBoxStyle.DropDownList;
            uiComboBoxCpuType.Font = new Font("微软雅黑", 10F);
            uiComboBoxCpuType.ForeColor = Color.White;
            uiComboBoxCpuType.FormattingEnabled = true;
            uiComboBoxCpuType.Items.AddRange(new object[] { "S7-200", "S7-200 SMART", "S7-300", "S7-400", "S7-1200", "S7-1500" });
            uiComboBoxCpuType.Location = new Point(25, 181);
            uiComboBoxCpuType.Name = "uiComboBoxCpuType";
            uiComboBoxCpuType.Size = new Size(200, 35);
            uiComboBoxCpuType.TabIndex = 6;
            // 
            // uiLabelRack
            // 
            uiLabelRack.AutoSize = true;
            uiLabelRack.Font = new Font("微软雅黑", 10F);
            uiLabelRack.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelRack.Location = new Point(308, 151);
            uiLabelRack.Name = "uiLabelRack";
            uiLabelRack.Size = new Size(72, 27);
            uiLabelRack.TabIndex = 7;
            uiLabelRack.Text = "机架号";
            // 
            // uiTextBoxRack
            // 
            uiTextBoxRack.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxRack.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxRack.Font = new Font("微软雅黑", 10F);
            uiTextBoxRack.ForeColor = Color.White;
            uiTextBoxRack.Location = new Point(308, 182);
            uiTextBoxRack.Name = "uiTextBoxRack";
            uiTextBoxRack.Size = new Size(80, 34);
            uiTextBoxRack.TabIndex = 8;
            uiTextBoxRack.Text = "0";
            // 
            // uiLabelSlot
            // 
            uiLabelSlot.AutoSize = true;
            uiLabelSlot.Font = new Font("微软雅黑", 10F);
            uiLabelSlot.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelSlot.Location = new Point(418, 152);
            uiLabelSlot.Name = "uiLabelSlot";
            uiLabelSlot.Size = new Size(72, 27);
            uiLabelSlot.TabIndex = 9;
            uiLabelSlot.Text = "插槽号";
            // 
            // uiTextBoxSlot
            // 
            uiTextBoxSlot.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxSlot.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxSlot.Font = new Font("微软雅黑", 10F);
            uiTextBoxSlot.ForeColor = Color.White;
            uiTextBoxSlot.Location = new Point(418, 182);
            uiTextBoxSlot.Name = "uiTextBoxSlot";
            uiTextBoxSlot.Size = new Size(80, 34);
            uiTextBoxSlot.TabIndex = 10;
            uiTextBoxSlot.Text = "1";
            // 
            // uiLabelReadInterval
            // 
            uiLabelReadInterval.AutoSize = true;
            uiLabelReadInterval.Font = new Font("微软雅黑", 10F);
            uiLabelReadInterval.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelReadInterval.Location = new Point(20, 242);
            uiLabelReadInterval.Name = "uiLabelReadInterval";
            uiLabelReadInterval.Size = new Size(134, 27);
            uiLabelReadInterval.TabIndex = 11;
            uiLabelReadInterval.Text = "采集间隔(ms)";
            // 
            // uiTextBoxReadInterval
            // 
            uiTextBoxReadInterval.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxReadInterval.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxReadInterval.Font = new Font("微软雅黑", 10F);
            uiTextBoxReadInterval.ForeColor = Color.White;
            uiTextBoxReadInterval.Location = new Point(25, 272);
            uiTextBoxReadInterval.Name = "uiTextBoxReadInterval";
            uiTextBoxReadInterval.Size = new Size(120, 34);
            uiTextBoxReadInterval.TabIndex = 12;
            uiTextBoxReadInterval.Text = "300";
            // 
            // uiLabelReconnectInterval
            // 
            uiLabelReconnectInterval.AutoSize = true;
            uiLabelReconnectInterval.Font = new Font("微软雅黑", 10F);
            uiLabelReconnectInterval.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelReconnectInterval.Location = new Point(180, 242);
            uiLabelReconnectInterval.Name = "uiLabelReconnectInterval";
            uiLabelReconnectInterval.Size = new Size(134, 27);
            uiLabelReconnectInterval.TabIndex = 13;
            uiLabelReconnectInterval.Text = "重连间隔(ms)";
            // 
            // uiTextBoxReconnectInterval
            // 
            uiTextBoxReconnectInterval.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxReconnectInterval.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxReconnectInterval.Font = new Font("微软雅黑", 10F);
            uiTextBoxReconnectInterval.ForeColor = Color.White;
            uiTextBoxReconnectInterval.Location = new Point(180, 272);
            uiTextBoxReconnectInterval.Name = "uiTextBoxReconnectInterval";
            uiTextBoxReconnectInterval.Size = new Size(120, 34);
            uiTextBoxReconnectInterval.TabIndex = 14;
            uiTextBoxReconnectInterval.Text = "2000";
            // 
            // uiPanelSystemConfig
            // 
            uiPanelSystemConfig.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelSystemConfig.BorderStyle = BorderStyle.FixedSingle;
            uiPanelSystemConfig.Controls.Add(uiLabelSystemTitle);
            uiPanelSystemConfig.Controls.Add(uiLabelSoftwareVersion);
            uiPanelSystemConfig.Controls.Add(uiTextBoxSoftwareVersion);
            uiPanelSystemConfig.Controls.Add(uiLabelTrialDays);
            uiPanelSystemConfig.Controls.Add(uiTextBoxTrialDays);
            uiPanelSystemConfig.Location = new Point(600, 100);
            uiPanelSystemConfig.Name = "uiPanelSystemConfig";
            uiPanelSystemConfig.Size = new Size(580, 180);
            uiPanelSystemConfig.TabIndex = 2;
            // 
            // uiLabelSystemTitle
            // 
            uiLabelSystemTitle.AutoSize = true;
            uiLabelSystemTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelSystemTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelSystemTitle.Location = new Point(3, 0);
            uiLabelSystemTitle.Name = "uiLabelSystemTitle";
            uiLabelSystemTitle.Size = new Size(129, 37);
            uiLabelSystemTitle.TabIndex = 0;
            uiLabelSystemTitle.Text = "系统配置";
            // 
            // uiLabelSoftwareVersion
            // 
            uiLabelSoftwareVersion.AutoSize = true;
            uiLabelSoftwareVersion.Font = new Font("微软雅黑", 10F);
            uiLabelSoftwareVersion.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelSoftwareVersion.Location = new Point(20, 76);
            uiLabelSoftwareVersion.Name = "uiLabelSoftwareVersion";
            uiLabelSoftwareVersion.Size = new Size(92, 27);
            uiLabelSoftwareVersion.TabIndex = 1;
            uiLabelSoftwareVersion.Text = "软件版本";
            // 
            // uiTextBoxSoftwareVersion
            // 
            uiTextBoxSoftwareVersion.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxSoftwareVersion.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxSoftwareVersion.Font = new Font("微软雅黑", 10F);
            uiTextBoxSoftwareVersion.ForeColor = Color.White;
            uiTextBoxSoftwareVersion.Location = new Point(20, 106);
            uiTextBoxSoftwareVersion.Name = "uiTextBoxSoftwareVersion";
            uiTextBoxSoftwareVersion.Size = new Size(200, 34);
            uiTextBoxSoftwareVersion.TabIndex = 2;
            uiTextBoxSoftwareVersion.Text = "1.0.0";
            // 
            // uiLabelTrialDays
            // 
            uiLabelTrialDays.AutoSize = true;
            uiLabelTrialDays.Font = new Font("微软雅黑", 10F);
            uiLabelTrialDays.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelTrialDays.Location = new Point(260, 76);
            uiLabelTrialDays.Name = "uiLabelTrialDays";
            uiLabelTrialDays.Size = new Size(92, 27);
            uiLabelTrialDays.TabIndex = 3;
            uiLabelTrialDays.Text = "试用天数";
            // 
            // uiTextBoxTrialDays
            // 
            uiTextBoxTrialDays.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxTrialDays.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxTrialDays.Font = new Font("微软雅黑", 10F);
            uiTextBoxTrialDays.ForeColor = Color.White;
            uiTextBoxTrialDays.Location = new Point(260, 106);
            uiTextBoxTrialDays.Name = "uiTextBoxTrialDays";
            uiTextBoxTrialDays.Size = new Size(120, 34);
            uiTextBoxTrialDays.TabIndex = 4;
            uiTextBoxTrialDays.Text = "30";
            // 
            // uiPanelLogConfig
            // 
            uiPanelLogConfig.BackColor = Color.FromArgb(30, 41, 59);
            uiPanelLogConfig.BorderStyle = BorderStyle.FixedSingle;
            uiPanelLogConfig.Controls.Add(uiLabelLogTitle);
            uiPanelLogConfig.Controls.Add(uiLabelLogCleanDays);
            uiPanelLogConfig.Controls.Add(uiComboBoxLogCleanDays);
            uiPanelLogConfig.Controls.Add(uiLabelLogPath);
            uiPanelLogConfig.Controls.Add(uiTextBoxLogPath);
            uiPanelLogConfig.Controls.Add(uiButtonBrowsePath);
            uiPanelLogConfig.Location = new Point(600, 300);
            uiPanelLogConfig.Name = "uiPanelLogConfig";
            uiPanelLogConfig.Size = new Size(580, 180);
            uiPanelLogConfig.TabIndex = 3;
            // 
            // uiLabelLogTitle
            // 
            uiLabelLogTitle.AutoSize = true;
            uiLabelLogTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelLogTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelLogTitle.Location = new Point(3, 0);
            uiLabelLogTitle.Name = "uiLabelLogTitle";
            uiLabelLogTitle.Size = new Size(129, 37);
            uiLabelLogTitle.TabIndex = 0;
            uiLabelLogTitle.Text = "日志配置";
            // 
            // uiLabelLogCleanDays
            // 
            uiLabelLogCleanDays.AutoSize = true;
            uiLabelLogCleanDays.Font = new Font("微软雅黑", 10F);
            uiLabelLogCleanDays.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelLogCleanDays.Location = new Point(260, 25);
            uiLabelLogCleanDays.Name = "uiLabelLogCleanDays";
            uiLabelLogCleanDays.Size = new Size(132, 27);
            uiLabelLogCleanDays.TabIndex = 1;
            uiLabelLogCleanDays.Text = "日志清理天数";
            // 
            // uiComboBoxLogCleanDays
            // 
            uiComboBoxLogCleanDays.BackColor = Color.FromArgb(15, 23, 42);
            uiComboBoxLogCleanDays.DropDownStyle = ComboBoxStyle.DropDownList;
            uiComboBoxLogCleanDays.Font = new Font("微软雅黑", 10F);
            uiComboBoxLogCleanDays.ForeColor = Color.White;
            uiComboBoxLogCleanDays.FormattingEnabled = true;
            uiComboBoxLogCleanDays.Items.AddRange(new object[] { "不清理", "3天", "7天", "15天", "30天", "60天" });
            uiComboBoxLogCleanDays.Location = new Point(260, 55);
            uiComboBoxLogCleanDays.Name = "uiComboBoxLogCleanDays";
            uiComboBoxLogCleanDays.Size = new Size(200, 35);
            uiComboBoxLogCleanDays.TabIndex = 2;
            // 
            // uiLabelLogPath
            // 
            uiLabelLogPath.AutoSize = true;
            uiLabelLogPath.Font = new Font("微软雅黑", 10F);
            uiLabelLogPath.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelLogPath.Location = new Point(20, 79);
            uiLabelLogPath.Name = "uiLabelLogPath";
            uiLabelLogPath.Size = new Size(92, 27);
            uiLabelLogPath.TabIndex = 3;
            uiLabelLogPath.Text = "日志路径";
            // 
            // uiTextBoxLogPath
            // 
            uiTextBoxLogPath.BackColor = Color.FromArgb(15, 23, 42);
            uiTextBoxLogPath.BorderStyle = BorderStyle.FixedSingle;
            uiTextBoxLogPath.Font = new Font("微软雅黑", 10F);
            uiTextBoxLogPath.ForeColor = Color.White;
            uiTextBoxLogPath.Location = new Point(20, 118);
            uiTextBoxLogPath.Name = "uiTextBoxLogPath";
            uiTextBoxLogPath.Size = new Size(420, 34);
            uiTextBoxLogPath.TabIndex = 4;
            uiTextBoxLogPath.Text = "C:\\Logs";
            // 
            // uiButtonBrowsePath
            // 
            uiButtonBrowsePath.BackColor = Color.FromArgb(59, 130, 246);
            uiButtonBrowsePath.FlatAppearance.BorderSize = 0;
            uiButtonBrowsePath.FlatStyle = FlatStyle.Flat;
            uiButtonBrowsePath.Font = new Font("微软雅黑", 10F, FontStyle.Bold);
            uiButtonBrowsePath.ForeColor = Color.White;
            uiButtonBrowsePath.Location = new Point(455, 116);
            uiButtonBrowsePath.Name = "uiButtonBrowsePath";
            uiButtonBrowsePath.Size = new Size(79, 34);
            uiButtonBrowsePath.TabIndex = 5;
            uiButtonBrowsePath.Text = "浏览";
            uiButtonBrowsePath.UseVisualStyleBackColor = false;
            // 
            // uiPanelButtons
            // 
            uiPanelButtons.BackColor = Color.Transparent;
            uiPanelButtons.Controls.Add(panel1);
            uiPanelButtons.Location = new Point(20, 500);
            uiPanelButtons.Name = "uiPanelButtons";
            uiPanelButtons.Size = new Size(1160, 192);
            uiPanelButtons.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(uiLabel2);
            panel1.Controls.Add(uiSwitch1);
            panel1.Controls.Add(uiButton1);
            panel1.Controls.Add(uiTextBox1);
            panel1.Controls.Add(uiLabel1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1160, 192);
            panel1.TabIndex = 4;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.White;
            uiLabel2.Location = new Point(15, 114);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(139, 44);
            uiLabel2.TabIndex = 20;
            uiLabel2.Text = "深色模式";
            // 
            // uiSwitch1
            // 
            uiSwitch1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiSwitch1.Location = new Point(160, 114);
            uiSwitch1.MinimumSize = new Size(1, 1);
            uiSwitch1.Name = "uiSwitch1";
            uiSwitch1.Size = new Size(112, 44);
            uiSwitch1.TabIndex = 19;
            uiSwitch1.Text = "uiSwitch1";
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Location = new Point(685, 46);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(150, 40);
            uiButton1.TabIndex = 18;
            uiButton1.Text = "激活";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiTextBox1
            // 
            uiTextBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTextBox1.Location = new Point(123, 46);
            uiTextBox1.Margin = new Padding(4, 5, 4, 5);
            uiTextBox1.MinimumSize = new Size(1, 16);
            uiTextBox1.Name = "uiTextBox1";
            uiTextBox1.Padding = new Padding(5);
            uiTextBox1.ShowText = false;
            uiTextBox1.Size = new Size(524, 40);
            uiTextBox1.TabIndex = 17;
            uiTextBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiTextBox1.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 14F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.White;
            uiLabel1.Location = new Point(15, 46);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(113, 40);
            uiLabel1.TabIndex = 16;
            uiLabel1.Text = "激活码";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(34, 211, 238);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 37);
            label1.TabIndex = 15;
            label1.Text = "系统授权";
            // 
            // uiButtonTestPlc
            // 
            uiButtonTestPlc.BackColor = Color.FromArgb(59, 130, 246);
            uiButtonTestPlc.FlatAppearance.BorderSize = 0;
            uiButtonTestPlc.FlatStyle = FlatStyle.Flat;
            uiButtonTestPlc.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiButtonTestPlc.ForeColor = Color.White;
            uiButtonTestPlc.Location = new Point(166, 698);
            uiButtonTestPlc.Name = "uiButtonTestPlc";
            uiButtonTestPlc.Size = new Size(181, 50);
            uiButtonTestPlc.TabIndex = 1;
            uiButtonTestPlc.Text = "测试PLC连接";
            uiButtonTestPlc.UseVisualStyleBackColor = false;
            // 
            // uiButtonSave
            // 
            uiButtonSave.BackColor = Color.FromArgb(34, 197, 94);
            uiButtonSave.FlatAppearance.BorderSize = 0;
            uiButtonSave.FlatStyle = FlatStyle.Flat;
            uiButtonSave.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiButtonSave.ForeColor = Color.White;
            uiButtonSave.Location = new Point(20, 698);
            uiButtonSave.Name = "uiButtonSave";
            uiButtonSave.Size = new Size(140, 50);
            uiButtonSave.TabIndex = 0;
            uiButtonSave.Text = "保存配置";
            uiButtonSave.UseVisualStyleBackColor = false;
            // 
            // FrmSystemConfig
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1220, 760);
            Controls.Add(uiButtonSave);
            Controls.Add(uiButtonTestPlc);
            Controls.Add(uiPanelButtons);
            Controls.Add(uiPanelLogConfig);
            Controls.Add(uiPanelSystemConfig);
            Controls.Add(uiPanelPlcConfig);
            Controls.Add(uiPanelTitle);
            Name = "FrmSystemConfig";
            Text = "系统配置";
            uiPanelTitle.ResumeLayout(false);
            uiPanelTitle.PerformLayout();
            uiPanelPlcConfig.ResumeLayout(false);
            uiPanelPlcConfig.PerformLayout();
            uiPanelSystemConfig.ResumeLayout(false);
            uiPanelSystemConfig.PerformLayout();
            uiPanelLogConfig.ResumeLayout(false);
            uiPanelLogConfig.PerformLayout();
            uiPanelButtons.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel uiPanelTitle;
        private System.Windows.Forms.Label uiLabelTitle;
        private System.Windows.Forms.Label uiLabelSubtitle;
        private System.Windows.Forms.Panel uiPanelPlcConfig;
        private System.Windows.Forms.Label uiLabelPlcTitle;
        private System.Windows.Forms.Label uiLabelPlcIp;
        private System.Windows.Forms.TextBox uiTextBoxPlcIp;
        private System.Windows.Forms.Label uiLabelPlcPort;
        private System.Windows.Forms.TextBox uiTextBoxPlcPort;
        private System.Windows.Forms.Label uiLabelCpuType;
        private System.Windows.Forms.ComboBox uiComboBoxCpuType;
        private System.Windows.Forms.Label uiLabelRack;
        private System.Windows.Forms.TextBox uiTextBoxRack;
        private System.Windows.Forms.Label uiLabelSlot;
        private System.Windows.Forms.TextBox uiTextBoxSlot;
        private System.Windows.Forms.Label uiLabelReadInterval;
        private System.Windows.Forms.TextBox uiTextBoxReadInterval;
        private System.Windows.Forms.Label uiLabelReconnectInterval;
        private System.Windows.Forms.TextBox uiTextBoxReconnectInterval;
        private System.Windows.Forms.Panel uiPanelSystemConfig;
        private System.Windows.Forms.Label uiLabelSystemTitle;
        private System.Windows.Forms.Label uiLabelSoftwareVersion;
        private System.Windows.Forms.TextBox uiTextBoxSoftwareVersion;
        private System.Windows.Forms.Label uiLabelTrialDays;
        private System.Windows.Forms.TextBox uiTextBoxTrialDays;
        private System.Windows.Forms.Panel uiPanelLogConfig;
        private System.Windows.Forms.Label uiLabelLogTitle;
        private System.Windows.Forms.Label uiLabelLogCleanDays;
        private System.Windows.Forms.ComboBox uiComboBoxLogCleanDays;
        private System.Windows.Forms.Label uiLabelLogPath;
        private System.Windows.Forms.TextBox uiTextBoxLogPath;
        private System.Windows.Forms.Button uiButtonBrowsePath;
        private System.Windows.Forms.Panel uiPanelButtons;
        private System.Windows.Forms.Button uiButtonSave;
        private System.Windows.Forms.Button uiButtonTestPlc;
        private Panel panel1;
        private Label label1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox uiTextBox1;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UISwitch uiSwitch1;
    }
}
