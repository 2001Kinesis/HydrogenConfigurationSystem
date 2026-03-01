using Sunny.UI;

namespace Custom.HydrogenConfigurationSystem.Forms
{
    partial class FrmDeviceControl
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
            uiPanelTitle = new UIPanel();
            uiLabelSubtitle = new UILabel();
            uiLabelTitle = new UILabel();
            uiPanelMainControl = new UIPanel();
            uiPanelMainButtons = new UIFlowLayoutPanel();
            uiButtonDryRun = new UIButton();
            uiButtonAlarmReset = new UIButton();
            uiButtonCompressorReset = new UIButton();
            uiButtonTotalStop = new UIButton();
            uiButtonTotalStart = new UIButton();
            uiLabelMainControlTitle = new UILabel();
            uiPanelStationControl = new UIPanel();
            uiPanelStations = new UIFlowLayoutPanel();
            uiPanelTransport = new UIPanel();
            uiButtonTransportStop = new UIButton();
            uiButtonTransportStart = new UIButton();
            uiLedTransportStatus = new UILight();
            uiLabelTransportTitle = new UILabel();
            uiPanelDetection = new UIPanel();
            uiButtonDetectionStop = new UIButton();
            uiButtonDetectionStart = new UIButton();
            uiLedDetectionStatus = new UILight();
            uiLabelDetectionTitle = new UILabel();
            uiPanelCooling = new UIPanel();
            uiButtonCoolingStop = new UIButton();
            uiButtonCoolingStart = new UIButton();
            uiLedCoolingStatus = new UILight();
            uiLabelCoolingTitle = new UILabel();
            uiPanelRefueling = new UIPanel();
            uiButtonRefuelingStop = new UIButton();
            uiButtonRefuelingStart = new UIButton();
            uiLedRefuelingStatus = new UILight();
            uiLabelRefuelingTitle = new UILabel();
            uiPanelStorage = new UIPanel();
            uiButtonStorageStop = new UIButton();
            uiButtonStorageStart = new UIButton();
            uiLedStorageStatus = new UILight();
            uiLabelStorageTitle = new UILabel();
            uiPanelPurification = new UIPanel();
            uiButtonPurificationStop = new UIButton();
            uiButtonPurificationStart = new UIButton();
            uiLedPurificationStatus = new UILight();
            uiLabelPurificationTitle = new UILabel();
            uiPanelElectrolyzer = new UIPanel();
            uiButtonElectrolyzerStop = new UIButton();
            uiButtonElectrolyzerStart = new UIButton();
            uiLedElectrolyzerStatus = new UILight();
            uiLabelElectrolyzerTitle = new UILabel();
            uiLabelStationControlTitle = new UILabel();
            uiPanelStatus = new UIPanel();
            uiLabelPlcStatus = new UILabel();
            uiLedPlcStatus = new UILight();
            uiPanelTitle.SuspendLayout();
            uiPanelMainControl.SuspendLayout();
            uiPanelMainButtons.SuspendLayout();
            uiPanelStationControl.SuspendLayout();
            uiPanelStations.SuspendLayout();
            uiPanelTransport.SuspendLayout();
            uiPanelDetection.SuspendLayout();
            uiPanelCooling.SuspendLayout();
            uiPanelRefueling.SuspendLayout();
            uiPanelStorage.SuspendLayout();
            uiPanelPurification.SuspendLayout();
            uiPanelElectrolyzer.SuspendLayout();
            uiPanelStatus.SuspendLayout();
            SuspendLayout();
            // 
            // uiPanelTitle
            // 
            uiPanelTitle.Controls.Add(uiLabelSubtitle);
            uiPanelTitle.Controls.Add(uiLabelTitle);
            uiPanelTitle.FillColor = Color.Transparent;
            uiPanelTitle.Font = new Font("微软雅黑", 12F);
            uiPanelTitle.Location = new Point(20, 20);
            uiPanelTitle.Margin = new Padding(4, 5, 4, 5);
            uiPanelTitle.MinimumSize = new Size(1, 1);
            uiPanelTitle.Name = "uiPanelTitle";
            uiPanelTitle.Radius = 0;
            uiPanelTitle.RectColor = Color.Transparent;
            uiPanelTitle.Size = new Size(1160, 60);
            uiPanelTitle.TabIndex = 0;
            uiPanelTitle.Text = null;
            uiPanelTitle.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabelSubtitle
            // 
            uiLabelSubtitle.Font = new Font("微软雅黑", 10F);
            uiLabelSubtitle.ForeColor = Color.FromArgb(148, 163, 184);
            uiLabelSubtitle.Location = new Point(179, 17);
            uiLabelSubtitle.Name = "uiLabelSubtitle";
            uiLabelSubtitle.Size = new Size(272, 27);
            uiLabelSubtitle.TabIndex = 1;
            uiLabelSubtitle.Text = "生产线总控制与工位单元控制";
            // 
            // uiLabelTitle
            // 
            uiLabelTitle.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            uiLabelTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelTitle.Location = new Point(8, 3);
            uiLabelTitle.Name = "uiLabelTitle";
            uiLabelTitle.Size = new Size(164, 47);
            uiLabelTitle.TabIndex = 0;
            uiLabelTitle.Text = "设备控制";
            // 
            // uiPanelMainControl
            // 
            uiPanelMainControl.Controls.Add(uiPanelMainButtons);
            uiPanelMainControl.Controls.Add(uiLabelMainControlTitle);
            uiPanelMainControl.FillColor = Color.FromArgb(30, 41, 59);
            uiPanelMainControl.Font = new Font("微软雅黑", 12F);
            uiPanelMainControl.Location = new Point(20, 100);
            uiPanelMainControl.Margin = new Padding(4, 5, 4, 5);
            uiPanelMainControl.MinimumSize = new Size(1, 1);
            uiPanelMainControl.Name = "uiPanelMainControl";
            uiPanelMainControl.Radius = 8;
            uiPanelMainControl.RectColor = Color.FromArgb(51, 65, 85);
            uiPanelMainControl.Size = new Size(1160, 149);
            uiPanelMainControl.TabIndex = 1;
            uiPanelMainControl.Text = null;
            uiPanelMainControl.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanelMainButtons
            // 
            uiPanelMainButtons.AutoScroll = false;
            uiPanelMainButtons.Controls.Add(uiButtonDryRun);
            uiPanelMainButtons.Controls.Add(uiButtonAlarmReset);
            uiPanelMainButtons.Controls.Add(uiButtonCompressorReset);
            uiPanelMainButtons.Controls.Add(uiButtonTotalStop);
            uiPanelMainButtons.Controls.Add(uiButtonTotalStart);
            uiPanelMainButtons.FillColor = Color.Transparent;
            uiPanelMainButtons.Font = new Font("微软雅黑", 12F);
            uiPanelMainButtons.Location = new Point(8, 61);
            uiPanelMainButtons.Margin = new Padding(4, 5, 4, 5);
            uiPanelMainButtons.MinimumSize = new Size(1, 1);
            uiPanelMainButtons.Name = "uiPanelMainButtons";
            uiPanelMainButtons.Padding = new Padding(10);
            uiPanelMainButtons.Radius = 0;
            uiPanelMainButtons.RectColor = Color.Transparent;
            uiPanelMainButtons.ShowText = false;
            uiPanelMainButtons.Size = new Size(1148, 83);
            uiPanelMainButtons.TabIndex = 1;
            uiPanelMainButtons.Text = null;
            uiPanelMainButtons.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButtonDryRun
            // 
            uiButtonDryRun.FillColor = Color.FromArgb(139, 92, 246);
            uiButtonDryRun.FillHoverColor = Color.FromArgb(167, 139, 250);
            uiButtonDryRun.FillPressColor = Color.FromArgb(124, 58, 237);
            uiButtonDryRun.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiButtonDryRun.Location = new Point(680, 20);
            uiButtonDryRun.Margin = new Padding(20, 10, 20, 10);
            uiButtonDryRun.MinimumSize = new Size(1, 1);
            uiButtonDryRun.Name = "uiButtonDryRun";
            uiButtonDryRun.Radius = 6;
            uiButtonDryRun.RectColor = Color.FromArgb(139, 92, 246);
            uiButtonDryRun.Size = new Size(140, 50);
            uiButtonDryRun.TabIndex = 4;
            uiButtonDryRun.Text = "空运行";
            uiButtonDryRun.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButtonAlarmReset
            // 
            uiButtonAlarmReset.FillColor = Color.FromArgb(245, 158, 11);
            uiButtonAlarmReset.FillHoverColor = Color.FromArgb(251, 191, 36);
            uiButtonAlarmReset.FillPressColor = Color.FromArgb(217, 119, 6);
            uiButtonAlarmReset.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiButtonAlarmReset.Location = new Point(520, 20);
            uiButtonAlarmReset.Margin = new Padding(20, 10, 20, 10);
            uiButtonAlarmReset.MinimumSize = new Size(1, 1);
            uiButtonAlarmReset.Name = "uiButtonAlarmReset";
            uiButtonAlarmReset.Radius = 6;
            uiButtonAlarmReset.RectColor = Color.FromArgb(245, 158, 11);
            uiButtonAlarmReset.Size = new Size(140, 50);
            uiButtonAlarmReset.TabIndex = 3;
            uiButtonAlarmReset.Text = "报警复位";
            uiButtonAlarmReset.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButtonCompressorReset
            // 
            uiButtonCompressorReset.FillColor = Color.FromArgb(59, 130, 246);
            uiButtonCompressorReset.FillHoverColor = Color.FromArgb(96, 165, 250);
            uiButtonCompressorReset.FillPressColor = Color.FromArgb(37, 99, 235);
            uiButtonCompressorReset.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiButtonCompressorReset.Location = new Point(340, 20);
            uiButtonCompressorReset.Margin = new Padding(20, 10, 20, 10);
            uiButtonCompressorReset.MinimumSize = new Size(1, 1);
            uiButtonCompressorReset.Name = "uiButtonCompressorReset";
            uiButtonCompressorReset.Radius = 6;
            uiButtonCompressorReset.RectColor = Color.FromArgb(59, 130, 246);
            uiButtonCompressorReset.Size = new Size(160, 50);
            uiButtonCompressorReset.TabIndex = 2;
            uiButtonCompressorReset.Text = "压缩机复位";
            uiButtonCompressorReset.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButtonTotalStop
            // 
            uiButtonTotalStop.FillColor = Color.FromArgb(239, 68, 68);
            uiButtonTotalStop.FillHoverColor = Color.FromArgb(248, 113, 113);
            uiButtonTotalStop.FillPressColor = Color.FromArgb(220, 38, 38);
            uiButtonTotalStop.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiButtonTotalStop.Location = new Point(180, 20);
            uiButtonTotalStop.Margin = new Padding(20, 10, 20, 10);
            uiButtonTotalStop.MinimumSize = new Size(1, 1);
            uiButtonTotalStop.Name = "uiButtonTotalStop";
            uiButtonTotalStop.Radius = 6;
            uiButtonTotalStop.RectColor = Color.FromArgb(239, 68, 68);
            uiButtonTotalStop.Size = new Size(140, 50);
            uiButtonTotalStop.TabIndex = 1;
            uiButtonTotalStop.Text = "总停止";
            uiButtonTotalStop.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButtonTotalStart
            // 
            uiButtonTotalStart.FillColor = Color.FromArgb(34, 197, 94);
            uiButtonTotalStart.FillHoverColor = Color.FromArgb(74, 222, 128);
            uiButtonTotalStart.FillPressColor = Color.FromArgb(22, 163, 74);
            uiButtonTotalStart.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiButtonTotalStart.Location = new Point(20, 20);
            uiButtonTotalStart.Margin = new Padding(20, 10, 20, 10);
            uiButtonTotalStart.MinimumSize = new Size(1, 1);
            uiButtonTotalStart.Name = "uiButtonTotalStart";
            uiButtonTotalStart.Radius = 6;
            uiButtonTotalStart.RectColor = Color.FromArgb(34, 197, 94);
            uiButtonTotalStart.Size = new Size(140, 50);
            uiButtonTotalStart.TabIndex = 0;
            uiButtonTotalStart.Text = "总启动";
            uiButtonTotalStart.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiLabelMainControlTitle
            // 
            uiLabelMainControlTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelMainControlTitle.ForeColor = Color.FromArgb(203, 213, 225);
            uiLabelMainControlTitle.Location = new Point(7, 4);
            uiLabelMainControlTitle.Name = "uiLabelMainControlTitle";
            uiLabelMainControlTitle.Size = new Size(101, 37);
            uiLabelMainControlTitle.TabIndex = 0;
            uiLabelMainControlTitle.Text = "总控制";
            // 
            // uiPanelStationControl
            // 
            uiPanelStationControl.Controls.Add(uiPanelStations);
            uiPanelStationControl.Controls.Add(uiLabelStationControlTitle);
            uiPanelStationControl.FillColor = Color.FromArgb(30, 41, 59);
            uiPanelStationControl.Font = new Font("微软雅黑", 12F);
            uiPanelStationControl.Location = new Point(20, 270);
            uiPanelStationControl.Margin = new Padding(4, 5, 4, 5);
            uiPanelStationControl.MinimumSize = new Size(1, 1);
            uiPanelStationControl.Name = "uiPanelStationControl";
            uiPanelStationControl.Radius = 8;
            uiPanelStationControl.RectColor = Color.FromArgb(51, 65, 85);
            uiPanelStationControl.Size = new Size(1160, 400);
            uiPanelStationControl.TabIndex = 2;
            uiPanelStationControl.Text = null;
            uiPanelStationControl.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanelStations
            // 
            uiPanelStations.Controls.Add(uiPanelTransport);
            uiPanelStations.Controls.Add(uiPanelDetection);
            uiPanelStations.Controls.Add(uiPanelCooling);
            uiPanelStations.Controls.Add(uiPanelRefueling);
            uiPanelStations.Controls.Add(uiPanelStorage);
            uiPanelStations.Controls.Add(uiPanelPurification);
            uiPanelStations.Controls.Add(uiPanelElectrolyzer);
            uiPanelStations.FillColor = Color.Transparent;
            uiPanelStations.Font = new Font("微软雅黑", 12F);
            uiPanelStations.Location = new Point(8, 52);
            uiPanelStations.Margin = new Padding(4, 5, 4, 5);
            uiPanelStations.MinimumSize = new Size(1, 1);
            uiPanelStations.Name = "uiPanelStations";
            uiPanelStations.Padding = new Padding(10);
            uiPanelStations.Radius = 0;
            uiPanelStations.RectColor = Color.Transparent;
            uiPanelStations.ShowText = false;
            uiPanelStations.Size = new Size(1148, 340);
            uiPanelStations.TabIndex = 1;
            uiPanelStations.Text = null;
            uiPanelStations.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanelTransport
            // 
            uiPanelTransport.Controls.Add(uiButtonTransportStop);
            uiPanelTransport.Controls.Add(uiButtonTransportStart);
            uiPanelTransport.Controls.Add(uiLedTransportStatus);
            uiPanelTransport.Controls.Add(uiLabelTransportTitle);
            uiPanelTransport.FillColor = Color.FromArgb(51, 65, 85);
            uiPanelTransport.Font = new Font("微软雅黑", 12F);
            uiPanelTransport.Location = new Point(780, 180);
            uiPanelTransport.Margin = new Padding(10);
            uiPanelTransport.MinimumSize = new Size(1, 1);
            uiPanelTransport.Name = "uiPanelTransport";
            uiPanelTransport.Radius = 6;
            uiPanelTransport.RectColor = Color.FromArgb(71, 85, 105);
            uiPanelTransport.Size = new Size(360, 140);
            uiPanelTransport.TabIndex = 6;
            uiPanelTransport.Text = null;
            uiPanelTransport.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButtonTransportStop
            // 
            uiButtonTransportStop.FillColor = Color.FromArgb(239, 68, 68);
            uiButtonTransportStop.FillHoverColor = Color.FromArgb(248, 113, 113);
            uiButtonTransportStop.FillPressColor = Color.FromArgb(220, 38, 38);
            uiButtonTransportStop.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonTransportStop.Location = new Point(200, 70);
            uiButtonTransportStop.Margin = new Padding(10);
            uiButtonTransportStop.MinimumSize = new Size(1, 1);
            uiButtonTransportStop.Name = "uiButtonTransportStop";
            uiButtonTransportStop.Radius = 6;
            uiButtonTransportStop.RectColor = Color.FromArgb(239, 68, 68);
            uiButtonTransportStop.Size = new Size(100, 40);
            uiButtonTransportStop.TabIndex = 2;
            uiButtonTransportStop.Text = "停止";
            uiButtonTransportStop.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButtonTransportStart
            // 
            uiButtonTransportStart.FillColor = Color.FromArgb(34, 197, 94);
            uiButtonTransportStart.FillHoverColor = Color.FromArgb(74, 222, 128);
            uiButtonTransportStart.FillPressColor = Color.FromArgb(22, 163, 74);
            uiButtonTransportStart.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonTransportStart.Location = new Point(60, 70);
            uiButtonTransportStart.Margin = new Padding(10);
            uiButtonTransportStart.MinimumSize = new Size(1, 1);
            uiButtonTransportStart.Name = "uiButtonTransportStart";
            uiButtonTransportStart.Radius = 6;
            uiButtonTransportStart.RectColor = Color.FromArgb(34, 197, 94);
            uiButtonTransportStart.Size = new Size(100, 40);
            uiButtonTransportStart.TabIndex = 1;
            uiButtonTransportStart.Text = "启动";
            uiButtonTransportStart.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiLedTransportStatus
            // 
            uiLedTransportStatus.BackColor = Color.Transparent;
            uiLedTransportStatus.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLedTransportStatus.Location = new Point(310, 20);
            uiLedTransportStatus.MinimumSize = new Size(1, 1);
            uiLedTransportStatus.Name = "uiLedTransportStatus";
            uiLedTransportStatus.Radius = 20;
            uiLedTransportStatus.Size = new Size(20, 20);
            uiLedTransportStatus.TabIndex = 3;
            uiLedTransportStatus.Text = "uiLedTransportStatus";
            // 
            // uiLabelTransportTitle
            // 
            uiLabelTransportTitle.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiLabelTransportTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelTransportTitle.Location = new Point(20, 20);
            uiLabelTransportTitle.Name = "uiLabelTransportTitle";
            uiLabelTransportTitle.Size = new Size(110, 31);
            uiLabelTransportTitle.TabIndex = 0;
            uiLabelTransportTitle.Text = "输送工位";
            // 
            // uiPanelDetection
            // 
            uiPanelDetection.Controls.Add(uiButtonDetectionStop);
            uiPanelDetection.Controls.Add(uiButtonDetectionStart);
            uiPanelDetection.Controls.Add(uiLedDetectionStatus);
            uiPanelDetection.Controls.Add(uiLabelDetectionTitle);
            uiPanelDetection.FillColor = Color.FromArgb(51, 65, 85);
            uiPanelDetection.Font = new Font("微软雅黑", 12F);
            uiPanelDetection.Location = new Point(400, 180);
            uiPanelDetection.Margin = new Padding(10);
            uiPanelDetection.MinimumSize = new Size(1, 1);
            uiPanelDetection.Name = "uiPanelDetection";
            uiPanelDetection.Radius = 6;
            uiPanelDetection.RectColor = Color.FromArgb(71, 85, 105);
            uiPanelDetection.Size = new Size(360, 140);
            uiPanelDetection.TabIndex = 5;
            uiPanelDetection.Text = null;
            uiPanelDetection.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButtonDetectionStop
            // 
            uiButtonDetectionStop.FillColor = Color.FromArgb(239, 68, 68);
            uiButtonDetectionStop.FillHoverColor = Color.FromArgb(248, 113, 113);
            uiButtonDetectionStop.FillPressColor = Color.FromArgb(220, 38, 38);
            uiButtonDetectionStop.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonDetectionStop.Location = new Point(200, 70);
            uiButtonDetectionStop.Margin = new Padding(10);
            uiButtonDetectionStop.MinimumSize = new Size(1, 1);
            uiButtonDetectionStop.Name = "uiButtonDetectionStop";
            uiButtonDetectionStop.Radius = 6;
            uiButtonDetectionStop.RectColor = Color.FromArgb(239, 68, 68);
            uiButtonDetectionStop.Size = new Size(100, 40);
            uiButtonDetectionStop.TabIndex = 2;
            uiButtonDetectionStop.Text = "停止";
            uiButtonDetectionStop.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButtonDetectionStart
            // 
            uiButtonDetectionStart.FillColor = Color.FromArgb(34, 197, 94);
            uiButtonDetectionStart.FillHoverColor = Color.FromArgb(74, 222, 128);
            uiButtonDetectionStart.FillPressColor = Color.FromArgb(22, 163, 74);
            uiButtonDetectionStart.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonDetectionStart.Location = new Point(60, 70);
            uiButtonDetectionStart.Margin = new Padding(10);
            uiButtonDetectionStart.MinimumSize = new Size(1, 1);
            uiButtonDetectionStart.Name = "uiButtonDetectionStart";
            uiButtonDetectionStart.Radius = 6;
            uiButtonDetectionStart.RectColor = Color.FromArgb(34, 197, 94);
            uiButtonDetectionStart.Size = new Size(100, 40);
            uiButtonDetectionStart.TabIndex = 1;
            uiButtonDetectionStart.Text = "启动";
            uiButtonDetectionStart.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiLedDetectionStatus
            // 
            uiLedDetectionStatus.BackColor = Color.Transparent;
            uiLedDetectionStatus.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLedDetectionStatus.Location = new Point(310, 20);
            uiLedDetectionStatus.MinimumSize = new Size(1, 1);
            uiLedDetectionStatus.Name = "uiLedDetectionStatus";
            uiLedDetectionStatus.Radius = 20;
            uiLedDetectionStatus.Size = new Size(20, 20);
            uiLedDetectionStatus.TabIndex = 3;
            uiLedDetectionStatus.Text = "uiLedDetectionStatus";
            // 
            // uiLabelDetectionTitle
            // 
            uiLabelDetectionTitle.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiLabelDetectionTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelDetectionTitle.Location = new Point(20, 20);
            uiLabelDetectionTitle.Name = "uiLabelDetectionTitle";
            uiLabelDetectionTitle.Size = new Size(110, 31);
            uiLabelDetectionTitle.TabIndex = 0;
            uiLabelDetectionTitle.Text = "检测工位";
            // 
            // uiPanelCooling
            // 
            uiPanelCooling.Controls.Add(uiButtonCoolingStop);
            uiPanelCooling.Controls.Add(uiButtonCoolingStart);
            uiPanelCooling.Controls.Add(uiLedCoolingStatus);
            uiPanelCooling.Controls.Add(uiLabelCoolingTitle);
            uiPanelCooling.FillColor = Color.FromArgb(51, 65, 85);
            uiPanelCooling.Font = new Font("微软雅黑", 12F);
            uiPanelCooling.Location = new Point(20, 180);
            uiPanelCooling.Margin = new Padding(10);
            uiPanelCooling.MinimumSize = new Size(1, 1);
            uiPanelCooling.Name = "uiPanelCooling";
            uiPanelCooling.Radius = 6;
            uiPanelCooling.RectColor = Color.FromArgb(71, 85, 105);
            uiPanelCooling.Size = new Size(360, 140);
            uiPanelCooling.TabIndex = 4;
            uiPanelCooling.Text = null;
            uiPanelCooling.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButtonCoolingStop
            // 
            uiButtonCoolingStop.FillColor = Color.FromArgb(239, 68, 68);
            uiButtonCoolingStop.FillHoverColor = Color.FromArgb(248, 113, 113);
            uiButtonCoolingStop.FillPressColor = Color.FromArgb(220, 38, 38);
            uiButtonCoolingStop.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonCoolingStop.Location = new Point(200, 70);
            uiButtonCoolingStop.Margin = new Padding(10);
            uiButtonCoolingStop.MinimumSize = new Size(1, 1);
            uiButtonCoolingStop.Name = "uiButtonCoolingStop";
            uiButtonCoolingStop.Radius = 6;
            uiButtonCoolingStop.RectColor = Color.FromArgb(239, 68, 68);
            uiButtonCoolingStop.Size = new Size(100, 40);
            uiButtonCoolingStop.TabIndex = 2;
            uiButtonCoolingStop.Text = "停止";
            uiButtonCoolingStop.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButtonCoolingStart
            // 
            uiButtonCoolingStart.FillColor = Color.FromArgb(34, 197, 94);
            uiButtonCoolingStart.FillHoverColor = Color.FromArgb(74, 222, 128);
            uiButtonCoolingStart.FillPressColor = Color.FromArgb(22, 163, 74);
            uiButtonCoolingStart.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonCoolingStart.Location = new Point(60, 70);
            uiButtonCoolingStart.Margin = new Padding(10);
            uiButtonCoolingStart.MinimumSize = new Size(1, 1);
            uiButtonCoolingStart.Name = "uiButtonCoolingStart";
            uiButtonCoolingStart.Radius = 6;
            uiButtonCoolingStart.RectColor = Color.FromArgb(34, 197, 94);
            uiButtonCoolingStart.Size = new Size(100, 40);
            uiButtonCoolingStart.TabIndex = 1;
            uiButtonCoolingStart.Text = "启动";
            uiButtonCoolingStart.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiLedCoolingStatus
            // 
            uiLedCoolingStatus.BackColor = Color.Transparent;
            uiLedCoolingStatus.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLedCoolingStatus.Location = new Point(310, 20);
            uiLedCoolingStatus.MinimumSize = new Size(1, 1);
            uiLedCoolingStatus.Name = "uiLedCoolingStatus";
            uiLedCoolingStatus.Radius = 20;
            uiLedCoolingStatus.Size = new Size(20, 20);
            uiLedCoolingStatus.TabIndex = 3;
            uiLedCoolingStatus.Text = "uiLedCoolingStatus";
            // 
            // uiLabelCoolingTitle
            // 
            uiLabelCoolingTitle.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiLabelCoolingTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelCoolingTitle.Location = new Point(20, 20);
            uiLabelCoolingTitle.Name = "uiLabelCoolingTitle";
            uiLabelCoolingTitle.Size = new Size(110, 31);
            uiLabelCoolingTitle.TabIndex = 0;
            uiLabelCoolingTitle.Text = "冷却工位";
            // 
            // uiPanelRefueling
            // 
            uiPanelRefueling.Controls.Add(uiButtonRefuelingStop);
            uiPanelRefueling.Controls.Add(uiButtonRefuelingStart);
            uiPanelRefueling.Controls.Add(uiLedRefuelingStatus);
            uiPanelRefueling.Controls.Add(uiLabelRefuelingTitle);
            uiPanelRefueling.FillColor = Color.FromArgb(51, 65, 85);
            uiPanelRefueling.Font = new Font("微软雅黑", 12F);
            uiPanelRefueling.Location = new Point(780, 20);
            uiPanelRefueling.Margin = new Padding(10);
            uiPanelRefueling.MinimumSize = new Size(1, 1);
            uiPanelRefueling.Name = "uiPanelRefueling";
            uiPanelRefueling.Radius = 6;
            uiPanelRefueling.RectColor = Color.FromArgb(71, 85, 105);
            uiPanelRefueling.Size = new Size(360, 140);
            uiPanelRefueling.TabIndex = 3;
            uiPanelRefueling.Text = null;
            uiPanelRefueling.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButtonRefuelingStop
            // 
            uiButtonRefuelingStop.FillColor = Color.FromArgb(239, 68, 68);
            uiButtonRefuelingStop.FillHoverColor = Color.FromArgb(248, 113, 113);
            uiButtonRefuelingStop.FillPressColor = Color.FromArgb(220, 38, 38);
            uiButtonRefuelingStop.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonRefuelingStop.Location = new Point(200, 70);
            uiButtonRefuelingStop.Margin = new Padding(10);
            uiButtonRefuelingStop.MinimumSize = new Size(1, 1);
            uiButtonRefuelingStop.Name = "uiButtonRefuelingStop";
            uiButtonRefuelingStop.Radius = 6;
            uiButtonRefuelingStop.RectColor = Color.FromArgb(239, 68, 68);
            uiButtonRefuelingStop.Size = new Size(100, 40);
            uiButtonRefuelingStop.TabIndex = 2;
            uiButtonRefuelingStop.Text = "停止";
            uiButtonRefuelingStop.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButtonRefuelingStart
            // 
            uiButtonRefuelingStart.FillColor = Color.FromArgb(34, 197, 94);
            uiButtonRefuelingStart.FillHoverColor = Color.FromArgb(74, 222, 128);
            uiButtonRefuelingStart.FillPressColor = Color.FromArgb(22, 163, 74);
            uiButtonRefuelingStart.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonRefuelingStart.Location = new Point(60, 70);
            uiButtonRefuelingStart.Margin = new Padding(10);
            uiButtonRefuelingStart.MinimumSize = new Size(1, 1);
            uiButtonRefuelingStart.Name = "uiButtonRefuelingStart";
            uiButtonRefuelingStart.Radius = 6;
            uiButtonRefuelingStart.RectColor = Color.FromArgb(34, 197, 94);
            uiButtonRefuelingStart.Size = new Size(100, 40);
            uiButtonRefuelingStart.TabIndex = 1;
            uiButtonRefuelingStart.Text = "启动";
            uiButtonRefuelingStart.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiLedRefuelingStatus
            // 
            uiLedRefuelingStatus.BackColor = Color.Transparent;
            uiLedRefuelingStatus.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLedRefuelingStatus.Location = new Point(310, 20);
            uiLedRefuelingStatus.MinimumSize = new Size(1, 1);
            uiLedRefuelingStatus.Name = "uiLedRefuelingStatus";
            uiLedRefuelingStatus.Radius = 20;
            uiLedRefuelingStatus.Size = new Size(20, 20);
            uiLedRefuelingStatus.TabIndex = 3;
            uiLedRefuelingStatus.Text = "uiLedRefuelingStatus";
            // 
            // uiLabelRefuelingTitle
            // 
            uiLabelRefuelingTitle.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiLabelRefuelingTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelRefuelingTitle.Location = new Point(20, 20);
            uiLabelRefuelingTitle.Name = "uiLabelRefuelingTitle";
            uiLabelRefuelingTitle.Size = new Size(110, 31);
            uiLabelRefuelingTitle.TabIndex = 0;
            uiLabelRefuelingTitle.Text = "加氢工位";
            // 
            // uiPanelStorage
            // 
            uiPanelStorage.Controls.Add(uiButtonStorageStop);
            uiPanelStorage.Controls.Add(uiButtonStorageStart);
            uiPanelStorage.Controls.Add(uiLedStorageStatus);
            uiPanelStorage.Controls.Add(uiLabelStorageTitle);
            uiPanelStorage.FillColor = Color.FromArgb(51, 65, 85);
            uiPanelStorage.Font = new Font("微软雅黑", 12F);
            uiPanelStorage.Location = new Point(400, 20);
            uiPanelStorage.Margin = new Padding(10);
            uiPanelStorage.MinimumSize = new Size(1, 1);
            uiPanelStorage.Name = "uiPanelStorage";
            uiPanelStorage.Radius = 6;
            uiPanelStorage.RectColor = Color.FromArgb(71, 85, 105);
            uiPanelStorage.Size = new Size(360, 140);
            uiPanelStorage.TabIndex = 2;
            uiPanelStorage.Text = null;
            uiPanelStorage.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButtonStorageStop
            // 
            uiButtonStorageStop.FillColor = Color.FromArgb(239, 68, 68);
            uiButtonStorageStop.FillHoverColor = Color.FromArgb(248, 113, 113);
            uiButtonStorageStop.FillPressColor = Color.FromArgb(220, 38, 38);
            uiButtonStorageStop.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonStorageStop.Location = new Point(200, 70);
            uiButtonStorageStop.Margin = new Padding(10);
            uiButtonStorageStop.MinimumSize = new Size(1, 1);
            uiButtonStorageStop.Name = "uiButtonStorageStop";
            uiButtonStorageStop.Radius = 6;
            uiButtonStorageStop.RectColor = Color.FromArgb(239, 68, 68);
            uiButtonStorageStop.Size = new Size(100, 40);
            uiButtonStorageStop.TabIndex = 2;
            uiButtonStorageStop.Text = "停止";
            uiButtonStorageStop.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButtonStorageStart
            // 
            uiButtonStorageStart.FillColor = Color.FromArgb(34, 197, 94);
            uiButtonStorageStart.FillHoverColor = Color.FromArgb(74, 222, 128);
            uiButtonStorageStart.FillPressColor = Color.FromArgb(22, 163, 74);
            uiButtonStorageStart.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonStorageStart.Location = new Point(60, 70);
            uiButtonStorageStart.Margin = new Padding(10);
            uiButtonStorageStart.MinimumSize = new Size(1, 1);
            uiButtonStorageStart.Name = "uiButtonStorageStart";
            uiButtonStorageStart.Radius = 6;
            uiButtonStorageStart.RectColor = Color.FromArgb(34, 197, 94);
            uiButtonStorageStart.Size = new Size(100, 40);
            uiButtonStorageStart.TabIndex = 1;
            uiButtonStorageStart.Text = "启动";
            uiButtonStorageStart.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiLedStorageStatus
            // 
            uiLedStorageStatus.BackColor = Color.Transparent;
            uiLedStorageStatus.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLedStorageStatus.Location = new Point(310, 20);
            uiLedStorageStatus.MinimumSize = new Size(1, 1);
            uiLedStorageStatus.Name = "uiLedStorageStatus";
            uiLedStorageStatus.Radius = 20;
            uiLedStorageStatus.Size = new Size(20, 20);
            uiLedStorageStatus.TabIndex = 3;
            uiLedStorageStatus.Text = "uiLedStorageStatus";
            // 
            // uiLabelStorageTitle
            // 
            uiLabelStorageTitle.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiLabelStorageTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelStorageTitle.Location = new Point(20, 20);
            uiLabelStorageTitle.Name = "uiLabelStorageTitle";
            uiLabelStorageTitle.Size = new Size(110, 31);
            uiLabelStorageTitle.TabIndex = 0;
            uiLabelStorageTitle.Text = "储氢工位";
            // 
            // uiPanelPurification
            // 
            uiPanelPurification.Controls.Add(uiButtonPurificationStop);
            uiPanelPurification.Controls.Add(uiButtonPurificationStart);
            uiPanelPurification.Controls.Add(uiLedPurificationStatus);
            uiPanelPurification.Controls.Add(uiLabelPurificationTitle);
            uiPanelPurification.FillColor = Color.FromArgb(51, 65, 85);
            uiPanelPurification.Font = new Font("微软雅黑", 12F);
            uiPanelPurification.Location = new Point(780, 20);
            uiPanelPurification.Margin = new Padding(10);
            uiPanelPurification.MinimumSize = new Size(1, 1);
            uiPanelPurification.Name = "uiPanelPurification";
            uiPanelPurification.Radius = 6;
            uiPanelPurification.RectColor = Color.FromArgb(71, 85, 105);
            uiPanelPurification.Size = new Size(360, 140);
            uiPanelPurification.TabIndex = 1;
            uiPanelPurification.Text = null;
            uiPanelPurification.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButtonPurificationStop
            // 
            uiButtonPurificationStop.FillColor = Color.FromArgb(239, 68, 68);
            uiButtonPurificationStop.FillHoverColor = Color.FromArgb(248, 113, 113);
            uiButtonPurificationStop.FillPressColor = Color.FromArgb(220, 38, 38);
            uiButtonPurificationStop.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonPurificationStop.Location = new Point(200, 70);
            uiButtonPurificationStop.Margin = new Padding(10);
            uiButtonPurificationStop.MinimumSize = new Size(1, 1);
            uiButtonPurificationStop.Name = "uiButtonPurificationStop";
            uiButtonPurificationStop.Radius = 6;
            uiButtonPurificationStop.RectColor = Color.FromArgb(239, 68, 68);
            uiButtonPurificationStop.Size = new Size(100, 40);
            uiButtonPurificationStop.TabIndex = 2;
            uiButtonPurificationStop.Text = "停止";
            uiButtonPurificationStop.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButtonPurificationStart
            // 
            uiButtonPurificationStart.FillColor = Color.FromArgb(34, 197, 94);
            uiButtonPurificationStart.FillHoverColor = Color.FromArgb(74, 222, 128);
            uiButtonPurificationStart.FillPressColor = Color.FromArgb(22, 163, 74);
            uiButtonPurificationStart.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonPurificationStart.Location = new Point(60, 70);
            uiButtonPurificationStart.Margin = new Padding(10);
            uiButtonPurificationStart.MinimumSize = new Size(1, 1);
            uiButtonPurificationStart.Name = "uiButtonPurificationStart";
            uiButtonPurificationStart.Radius = 6;
            uiButtonPurificationStart.RectColor = Color.FromArgb(34, 197, 94);
            uiButtonPurificationStart.Size = new Size(100, 40);
            uiButtonPurificationStart.TabIndex = 1;
            uiButtonPurificationStart.Text = "启动";
            uiButtonPurificationStart.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiLedPurificationStatus
            // 
            uiLedPurificationStatus.BackColor = Color.Transparent;
            uiLedPurificationStatus.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLedPurificationStatus.Location = new Point(310, 20);
            uiLedPurificationStatus.MinimumSize = new Size(1, 1);
            uiLedPurificationStatus.Name = "uiLedPurificationStatus";
            uiLedPurificationStatus.Radius = 15;
            uiLedPurificationStatus.Size = new Size(20, 20);
            uiLedPurificationStatus.TabIndex = 3;
            uiLedPurificationStatus.Text = "uiLedPurificationStatus";
            // 
            // uiLabelPurificationTitle
            // 
            uiLabelPurificationTitle.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiLabelPurificationTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelPurificationTitle.Location = new Point(20, 20);
            uiLabelPurificationTitle.Name = "uiLabelPurificationTitle";
            uiLabelPurificationTitle.Size = new Size(110, 31);
            uiLabelPurificationTitle.TabIndex = 0;
            uiLabelPurificationTitle.Text = "纯化工位";
            // 
            // uiPanelElectrolyzer
            // 
            uiPanelElectrolyzer.Controls.Add(uiButtonElectrolyzerStop);
            uiPanelElectrolyzer.Controls.Add(uiButtonElectrolyzerStart);
            uiPanelElectrolyzer.Controls.Add(uiLedElectrolyzerStatus);
            uiPanelElectrolyzer.Controls.Add(uiLabelElectrolyzerTitle);
            uiPanelElectrolyzer.FillColor = Color.FromArgb(51, 65, 85);
            uiPanelElectrolyzer.Font = new Font("微软雅黑", 12F);
            uiPanelElectrolyzer.Location = new Point(20, 20);
            uiPanelElectrolyzer.Margin = new Padding(10);
            uiPanelElectrolyzer.MinimumSize = new Size(1, 1);
            uiPanelElectrolyzer.Name = "uiPanelElectrolyzer";
            uiPanelElectrolyzer.Radius = 6;
            uiPanelElectrolyzer.RectColor = Color.FromArgb(71, 85, 105);
            uiPanelElectrolyzer.Size = new Size(360, 140);
            uiPanelElectrolyzer.TabIndex = 0;
            uiPanelElectrolyzer.Text = null;
            uiPanelElectrolyzer.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiButtonElectrolyzerStop
            // 
            uiButtonElectrolyzerStop.FillColor = Color.FromArgb(239, 68, 68);
            uiButtonElectrolyzerStop.FillHoverColor = Color.FromArgb(248, 113, 113);
            uiButtonElectrolyzerStop.FillPressColor = Color.FromArgb(220, 38, 38);
            uiButtonElectrolyzerStop.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonElectrolyzerStop.Location = new Point(200, 70);
            uiButtonElectrolyzerStop.Margin = new Padding(10);
            uiButtonElectrolyzerStop.MinimumSize = new Size(1, 1);
            uiButtonElectrolyzerStop.Name = "uiButtonElectrolyzerStop";
            uiButtonElectrolyzerStop.Radius = 6;
            uiButtonElectrolyzerStop.RectColor = Color.FromArgb(239, 68, 68);
            uiButtonElectrolyzerStop.Size = new Size(100, 40);
            uiButtonElectrolyzerStop.TabIndex = 2;
            uiButtonElectrolyzerStop.Text = "停止";
            uiButtonElectrolyzerStop.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiButtonElectrolyzerStart
            // 
            uiButtonElectrolyzerStart.FillColor = Color.FromArgb(34, 197, 94);
            uiButtonElectrolyzerStart.FillHoverColor = Color.FromArgb(74, 222, 128);
            uiButtonElectrolyzerStart.FillPressColor = Color.FromArgb(22, 163, 74);
            uiButtonElectrolyzerStart.Font = new Font("微软雅黑", 11F, FontStyle.Bold);
            uiButtonElectrolyzerStart.Location = new Point(60, 70);
            uiButtonElectrolyzerStart.Margin = new Padding(10);
            uiButtonElectrolyzerStart.MinimumSize = new Size(1, 1);
            uiButtonElectrolyzerStart.Name = "uiButtonElectrolyzerStart";
            uiButtonElectrolyzerStart.Radius = 6;
            uiButtonElectrolyzerStart.RectColor = Color.FromArgb(34, 197, 94);
            uiButtonElectrolyzerStart.Size = new Size(100, 40);
            uiButtonElectrolyzerStart.TabIndex = 1;
            uiButtonElectrolyzerStart.Text = "启动";
            uiButtonElectrolyzerStart.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            // 
            // uiLedElectrolyzerStatus
            // 
            uiLedElectrolyzerStatus.BackColor = Color.Transparent;
            uiLedElectrolyzerStatus.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLedElectrolyzerStatus.Location = new Point(310, 20);
            uiLedElectrolyzerStatus.MinimumSize = new Size(1, 1);
            uiLedElectrolyzerStatus.Name = "uiLedElectrolyzerStatus";
            uiLedElectrolyzerStatus.Radius = 20;
            uiLedElectrolyzerStatus.Size = new Size(20, 20);
            uiLedElectrolyzerStatus.TabIndex = 3;
            uiLedElectrolyzerStatus.Text = "uiLedElectrolyzerStatus";
            // 
            // uiLabelElectrolyzerTitle
            // 
            uiLabelElectrolyzerTitle.Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            uiLabelElectrolyzerTitle.ForeColor = Color.FromArgb(34, 211, 238);
            uiLabelElectrolyzerTitle.Location = new Point(20, 20);
            uiLabelElectrolyzerTitle.Name = "uiLabelElectrolyzerTitle";
            uiLabelElectrolyzerTitle.Size = new Size(134, 31);
            uiLabelElectrolyzerTitle.TabIndex = 0;
            uiLabelElectrolyzerTitle.Text = "电解槽工位";
            // 
            // uiLabelStationControlTitle
            // 
            uiLabelStationControlTitle.Font = new Font("微软雅黑", 14F, FontStyle.Bold);
            uiLabelStationControlTitle.ForeColor = Color.FromArgb(203, 213, 225);
            uiLabelStationControlTitle.Location = new Point(12, 4);
            uiLabelStationControlTitle.Name = "uiLabelStationControlTitle";
            uiLabelStationControlTitle.Size = new Size(129, 37);
            uiLabelStationControlTitle.TabIndex = 0;
            uiLabelStationControlTitle.Text = "工位控制";
            // 
            // uiPanelStatus
            // 
            uiPanelStatus.Controls.Add(uiLabelPlcStatus);
            uiPanelStatus.Controls.Add(uiLedPlcStatus);
            uiPanelStatus.FillColor = Color.FromArgb(30, 41, 59);
            uiPanelStatus.Font = new Font("微软雅黑", 12F);
            uiPanelStatus.Location = new Point(20, 690);
            uiPanelStatus.Margin = new Padding(4, 5, 4, 5);
            uiPanelStatus.MinimumSize = new Size(1, 1);
            uiPanelStatus.Name = "uiPanelStatus";
            uiPanelStatus.Radius = 8;
            uiPanelStatus.RectColor = Color.FromArgb(51, 65, 85);
            uiPanelStatus.Size = new Size(1160, 60);
            uiPanelStatus.TabIndex = 3;
            uiPanelStatus.Text = null;
            uiPanelStatus.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiLabelPlcStatus
            // 
            uiLabelPlcStatus.BackColor = Color.Transparent;
            uiLabelPlcStatus.Font = new Font("微软雅黑", 11F);
            uiLabelPlcStatus.ForeColor = Color.FromArgb(203, 213, 225);
            uiLabelPlcStatus.Location = new Point(60, 15);
            uiLabelPlcStatus.Name = "uiLabelPlcStatus";
            uiLabelPlcStatus.Size = new Size(200, 30);
            uiLabelPlcStatus.TabIndex = 1;
            uiLabelPlcStatus.Text = "PLC连接状态";
            // 
            // uiLedPlcStatus
            // 
            uiLedPlcStatus.BackColor = Color.Transparent;
            uiLedPlcStatus.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLedPlcStatus.Location = new Point(20, 15);
            uiLedPlcStatus.MinimumSize = new Size(1, 1);
            uiLedPlcStatus.Name = "uiLedPlcStatus";
            uiLedPlcStatus.Radius = 30;
            uiLedPlcStatus.Size = new Size(30, 30);
            uiLedPlcStatus.TabIndex = 0;
            uiLedPlcStatus.Text = "uiLedPlcStatus";
            // 
            // FrmDeviceControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1200, 770);
            Controls.Add(uiPanelStatus);
            Controls.Add(uiPanelStationControl);
            Controls.Add(uiPanelMainControl);
            Controls.Add(uiPanelTitle);
            Font = new Font("微软雅黑", 9F);
            Name = "FrmDeviceControl";
            Text = "设备控制";
            uiPanelTitle.ResumeLayout(false);
            uiPanelMainControl.ResumeLayout(false);
            uiPanelMainButtons.ResumeLayout(false);
            uiPanelStationControl.ResumeLayout(false);
            uiPanelStations.ResumeLayout(false);
            uiPanelTransport.ResumeLayout(false);
            uiPanelDetection.ResumeLayout(false);
            uiPanelCooling.ResumeLayout(false);
            uiPanelRefueling.ResumeLayout(false);
            uiPanelStorage.ResumeLayout(false);
            uiPanelPurification.ResumeLayout(false);
            uiPanelElectrolyzer.ResumeLayout(false);
            uiPanelStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private UIPanel uiPanelTitle;
        private UILabel uiLabelTitle;
        private UILabel uiLabelSubtitle;
        private UIPanel uiPanelMainControl;
        private UILabel uiLabelMainControlTitle;
        private UIFlowLayoutPanel uiPanelMainButtons;
        private UIButton uiButtonTotalStart;
        private UIButton uiButtonTotalStop;
        private UIButton uiButtonCompressorReset;
        private UIButton uiButtonAlarmReset;
        private UIButton uiButtonDryRun;
        private UIPanel uiPanelStationControl;
        private UILabel uiLabelStationControlTitle;
        private UIFlowLayoutPanel uiPanelStations;
        private UIPanel uiPanelElectrolyzer;
        private UILabel uiLabelElectrolyzerTitle;
        private UIButton uiButtonElectrolyzerStart;
        private UIButton uiButtonElectrolyzerStop;
        private UILight uiLedElectrolyzerStatus;
        private UIPanel uiPanelPurification;
        private UILabel uiLabelPurificationTitle;
        private UIButton uiButtonPurificationStart;
        private UIButton uiButtonPurificationStop;
        private UILight uiLedPurificationStatus;
        private UIPanel uiPanelStorage;
        private UILabel uiLabelStorageTitle;
        private UIButton uiButtonStorageStart;
        private UIButton uiButtonStorageStop;
        private UILight uiLedStorageStatus;
        private UIPanel uiPanelRefueling;
        private UILabel uiLabelRefuelingTitle;
        private UIButton uiButtonRefuelingStart;
        private UIButton uiButtonRefuelingStop;
        private UILight uiLedRefuelingStatus;
        private UIPanel uiPanelCooling;
        private UILabel uiLabelCoolingTitle;
        private UIButton uiButtonCoolingStart;
        private UIButton uiButtonCoolingStop;
        private UILight uiLedCoolingStatus;
        private UIPanel uiPanelDetection;
        private UILabel uiLabelDetectionTitle;
        private UIButton uiButtonDetectionStart;
        private UIButton uiButtonDetectionStop;
        private UILight uiLedDetectionStatus;
        private UIPanel uiPanelTransport;
        private UILabel uiLabelTransportTitle;
        private UIButton uiButtonTransportStart;
        private UIButton uiButtonTransportStop;
        private UILight uiLedTransportStatus;
        private UIPanel uiPanelStatus;
        private UILight uiLedPlcStatus;
        private UILabel uiLabelPlcStatus;
    }
}
