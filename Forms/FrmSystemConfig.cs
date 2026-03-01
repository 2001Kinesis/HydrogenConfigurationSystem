using Custom.HydrogenConfigurationSystem.Configs;
using Custom.HydrogenConfigurationSystem.Helpers;
using Custom.HydrogenConfigurationSystem.Globals;

namespace Custom.HydrogenConfigurationSystem.Forms
{
    public partial class FrmSystemConfig : System.Windows.Forms.Form
    {
        public FrmSystemConfig()
        {
            InitializeComponent();
            InitializeControls();
            BindEvents();
        }

        private void InitializeControls()
        {
            // 加载PLC配置
            var plcConfig = PlcConfig.Load();
            uiTextBoxPlcIp.Text = plcConfig.PlcIp;
            uiTextBoxPlcPort.Text = plcConfig.PlcPort.ToString();
            uiComboBoxCpuType.SelectedIndex = (int)plcConfig.CpuType - 1;
            uiTextBoxRack.Text = plcConfig.Rack.ToString();
            uiTextBoxSlot.Text = plcConfig.Slot.ToString();
            uiTextBoxReadInterval.Text = plcConfig.ReadInterval.ToString();
            uiTextBoxReconnectInterval.Text = plcConfig.ReConnectInterval.ToString();

            // 加载系统配置
            var systemConfig = SystemConfig.Load();
            uiTextBoxSoftwareVersion.Text = systemConfig.SoftwareVersion;
            uiTextBoxTrialDays.Text = systemConfig.TrialDays.ToString();
            uiComboBoxLogCleanDays.SelectedIndex = GetLogCleanDaysIndex(systemConfig.LogCleanDays);
            uiTextBoxLogPath.Text = systemConfig.LogPath;

            // 加载授权信息
            var authConfig = AuthConfig.Load();
            uiTextBox1.Text = string.Empty;

            // 设置深色模式开关 - 使用全局主题管理器
            uiSwitch1.Active = ThemeManager.IsDarkMode;
        }

        private void BindEvents()
        {
            uiButtonSave.Click += UiButtonSave_Click;
            uiButtonTestPlc.Click += UiButtonTestPlc_Click;
            uiButtonBrowsePath.Click += UiButtonBrowsePath_Click;
            uiButton1.Click += UiButton1_Click;
            uiSwitch1.ValueChanged += UiSwitch1_ValueChanged;
        }

        private void UiButtonSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                // 保存PLC配置
                var plcConfig = new PlcConfig
                {
                    PlcIp = uiTextBoxPlcIp.Text,
                    PlcPort = int.Parse(uiTextBoxPlcPort.Text),
                    CpuType = (HslCommunication.Profinet.Siemens.SiemensPLCS)(uiComboBoxCpuType.SelectedIndex + 1),
                    Rack = byte.Parse(uiTextBoxRack.Text),
                    Slot = byte.Parse(uiTextBoxSlot.Text),
                    ReadInterval = int.Parse(uiTextBoxReadInterval.Text),
                    ReConnectInterval = int.Parse(uiTextBoxReconnectInterval.Text)
                };
                plcConfig.Save();

                // 保存系统配置
                var systemConfig = new SystemConfig
                {
                    SoftwareVersion = uiTextBoxSoftwareVersion.Text,
                    TrialDays = int.Parse(uiTextBoxTrialDays.Text),
                    LogCleanDays = GetLogCleanDaysValue(uiComboBoxLogCleanDays.SelectedIndex),
                    LogPath = uiTextBoxLogPath.Text,
                    DefaultFont = "Microsoft YaHei",
                    DefaultFontSize = 12
                };
                systemConfig.Save();

                MessageBox.Show("配置保存成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存配置失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.Error($"保存配置失败: {ex.Message}");
            }
        }

        private void UiButtonTestPlc_Click(object sender, System.EventArgs e)
        {
            try
            {
                // 临时创建PLC配置进行测试
                var plcConfig = new PlcConfig
                {
                    PlcIp = uiTextBoxPlcIp.Text,
                    PlcPort = int.Parse(uiTextBoxPlcPort.Text),
                    CpuType = (HslCommunication.Profinet.Siemens.SiemensPLCS)(uiComboBoxCpuType.SelectedIndex + 1),
                    Rack = byte.Parse(uiTextBoxRack.Text),
                    Slot = byte.Parse(uiTextBoxSlot.Text)
                };

                // 应用临时配置
                GlobalVariables.PlcIp = plcConfig.PlcIp;
                GlobalVariables.PlcPort = plcConfig.PlcPort;
                GlobalVariables.CpuType = plcConfig.CpuType;
                GlobalVariables.Rack = plcConfig.Rack;
                GlobalVariables.Slot = plcConfig.Slot;

                // 测试连接
                var result = PlcComm.PlcClientHelper.InitPlcConnection();
                if (result.IsSuccess)
                {
                    MessageBox.Show("PLC连接成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PlcComm.PlcClientHelper.CloseConnection();
                }
                else
                {
                    MessageBox.Show("PLC连接失败: " + result.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("测试PLC连接失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.Error($"测试PLC连接失败: {ex.Message}");
            }
        }

        private void UiButtonBrowsePath_Click(object sender, System.EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    uiTextBoxLogPath.Text = folderBrowser.SelectedPath;
                }
            }
        }

        private void UiButton1_Click(object sender, System.EventArgs e)
        {
            try
            {
                string activationCode = uiTextBox1.Text.Trim();
                if (string.IsNullOrEmpty(activationCode))
                {
                    MessageBox.Show("请输入激活码", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 这里应该调用HSLCOMMUNITY的激活方法
                // 暂时模拟激活成功
                AuthHelper.SetPermanentAuth();
                MessageBox.Show("激活成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LogHelper.Info("系统授权激活成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show("激活失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.Error($"系统授权激活失败: {ex.Message}");
            }
        }

        private void UiSwitch1_ValueChanged(object sender, bool value)
        {
            // 使用全局主题管理器保存并应用主题
            ThemeManager.SaveThemeSetting(value);
        }

        private int GetLogCleanDaysIndex(int days)
        {
            return days switch
            {
                0 => 0,
                3 => 1,
                7 => 2,
                15 => 3,
                30 => 4,
                60 => 5,
                _ => 2
            };
        }

        private int GetLogCleanDaysValue(int index)
        {
            return index switch
            {
                0 => 0,
                1 => 3,
                2 => 7,
                3 => 15,
                4 => 30,
                5 => 60,
                _ => 7
            };
        }
    }
}
