using Custom.HydrogenConfigurationSystem.Globals;
using Custom.HydrogenConfigurationSystem.PlcComm;
using Custom.HydrogenConfigurationSystem.Helpers;
using Sunny.UI;

namespace Custom.HydrogenConfigurationSystem.Forms
{
    public partial class FrmDeviceControl : UIPage
    {
        private System.Windows.Forms.Timer _statusTimer;

        // 工位名称与DataDic中状态变量的映射
        private readonly Dictionary<string, string> _stationStatusVarMap = new()
        {
            { "电解槽工位", "电解槽运行状态" },
            { "纯化工位", "纯化装置运行状态" },
            { "储氢工位", "储氢罐运行状态" },
            { "加氢工位", "加氢机运行状态" },
            { "冷却工位", "冷却系统运行状态" },
            { "检测工位", "检测设备运行状态" },
            { "输送工位", "输送泵运行状态" }
        };

        public FrmDeviceControl()
        {
            InitializeComponent();
            InitializeControls();
            BindEvents();
            StartStatusMonitor();
        }

        private void InitializeControls()
        {
            // 设置按钮样式
            uiButtonTotalStart.Style = UIStyle.Green;
            uiButtonTotalStop.Style = UIStyle.Red;
            uiButtonCompressorReset.Style = UIStyle.Blue;
            uiButtonAlarmReset.Style = UIStyle.Orange;
            uiButtonDryRun.Style = UIStyle.Purple;

            // 设置工位按钮样式
            uiButtonElectrolyzerStart.Style = UIStyle.Green;
            uiButtonElectrolyzerStop.Style = UIStyle.Red;
            uiButtonPurificationStart.Style = UIStyle.Green;
            uiButtonPurificationStop.Style = UIStyle.Red;
            uiButtonStorageStart.Style = UIStyle.Green;
            uiButtonStorageStop.Style = UIStyle.Red;
            uiButtonRefuelingStart.Style = UIStyle.Green;
            uiButtonRefuelingStop.Style = UIStyle.Red;
            uiButtonCoolingStart.Style = UIStyle.Green;
            uiButtonCoolingStop.Style = UIStyle.Red;
            uiButtonDetectionStart.Style = UIStyle.Green;
            uiButtonDetectionStop.Style = UIStyle.Red;
            uiButtonTransportStart.Style = UIStyle.Green;
            uiButtonTransportStop.Style = UIStyle.Red;

            // 初始状态更新
            UpdatePlcStatus();
            UpdateStationStatus();
        }

        private void BindEvents()
        {
            // 总控制按钮
            uiButtonTotalStart.Click += (s, e) => ControlTotal(true);
            uiButtonTotalStop.Click += (s, e) => ControlTotal(false);
            uiButtonCompressorReset.Click += (s, e) => CompressorReset();
            uiButtonAlarmReset.Click += (s, e) => AlarmReset();
            uiButtonDryRun.Click += (s, e) => DryRun();

            // 工位控制按钮
            uiButtonElectrolyzerStart.Click += (s, e) => StationControl("电解槽工位", true);
            uiButtonElectrolyzerStop.Click += (s, e) => StationControl("电解槽工位", false);
            uiButtonPurificationStart.Click += (s, e) => StationControl("纯化工位", true);
            uiButtonPurificationStop.Click += (s, e) => StationControl("纯化工位", false);
            uiButtonStorageStart.Click += (s, e) => StationControl("储氢工位", true);
            uiButtonStorageStop.Click += (s, e) => StationControl("储氢工位", false);
            uiButtonRefuelingStart.Click += (s, e) => StationControl("加氢工位", true);
            uiButtonRefuelingStop.Click += (s, e) => StationControl("加氢工位", false);
            uiButtonCoolingStart.Click += (s, e) => StationControl("冷却工位", true);
            uiButtonCoolingStop.Click += (s, e) => StationControl("冷却工位", false);
            uiButtonDetectionStart.Click += (s, e) => StationControl("检测工位", true);
            uiButtonDetectionStop.Click += (s, e) => StationControl("检测工位", false);
            uiButtonTransportStart.Click += (s, e) => StationControl("输送工位", true);
            uiButtonTransportStop.Click += (s, e) => StationControl("输送工位", false);
        }

        private void StartStatusMonitor()
        {
            _statusTimer = new System.Windows.Forms.Timer();
            _statusTimer.Interval = 1000; // 1秒更新一次
            _statusTimer.Tick += (s, e) =>
            {
                UpdatePlcStatus();
                UpdateStationStatus();
            };
            _statusTimer.Start();
        }

        private void UpdatePlcStatus()
        {
            if (GlobalVariables.PlcIsConnected)
            {
                uiLedPlcStatus.OnColor = Color.Lime;
                uiLedPlcStatus.OffColor = Color.Red;
                uiLedPlcStatus.State = UILightState.On;
                uiLabelPlcStatus.Text = "PLC已连接";
                uiLabelPlcStatus.ForeColor = Color.Lime;
            }
            else
            {
                uiLedPlcStatus.OnColor = Color.Lime;
                uiLedPlcStatus.OffColor = Color.Red;
                uiLedPlcStatus.State = UILightState.Off;
                uiLabelPlcStatus.Text = "PLC未连接";
                uiLabelPlcStatus.ForeColor = Color.Red;
            }
        }

        private void UpdateStationStatus()
        {
            // 首先检查停止工位字典，如果工位被停止，直接设置为红色（不运行）
            bool isElectrolyzerStopped = GlobalVariables.StoppedStations.ContainsKey("电解槽工位");
            bool isPurificationStopped = GlobalVariables.StoppedStations.ContainsKey("纯化工位");
            bool isStorageStopped = GlobalVariables.StoppedStations.ContainsKey("储氢工位");
            bool isRefuelingStopped = GlobalVariables.StoppedStations.ContainsKey("加氢工位");
            bool isCoolingStopped = GlobalVariables.StoppedStations.ContainsKey("冷却工位");
            bool isDetectionStopped = GlobalVariables.StoppedStations.ContainsKey("检测工位");
            bool isTransportStopped = GlobalVariables.StoppedStations.ContainsKey("输送工位");

            UpdateStationLight(uiLedElectrolyzerStatus, !isElectrolyzerStopped);
            UpdateStationLight(uiLedPurificationStatus, !isPurificationStopped);
            UpdateStationLight(uiLedStorageStatus, !isStorageStopped);
            UpdateStationLight(uiLedRefuelingStatus, !isRefuelingStopped);
            UpdateStationLight(uiLedCoolingStatus, !isCoolingStopped);
            UpdateStationLight(uiLedDetectionStatus, !isDetectionStopped);
            UpdateStationLight(uiLedTransportStatus, !isTransportStopped);
        }

        /// <summary>
        /// 从GlobalVariables.DataDic获取工位运行状态
        /// </summary>
        private bool GetStationRunningStatus(string stationName)
        {
            if (!_stationStatusVarMap.TryGetValue(stationName, out var statusVarName))
                return false;

            if (!GlobalVariables.DataDic.TryGetValue(statusVarName, out var statusValue))
                return false;

            return ParseRunningStatus(statusValue);
        }

        /// <summary>
        /// 解析运行状态值
        /// </summary>
        private bool ParseRunningStatus(object status)
        {
            if (status == null)
                return false;

            if (status is bool boolValue)
                return boolValue;

            if (status is int intValue)
                return intValue == 1;

            if (bool.TryParse(status.ToString(), out var parsedBool))
                return parsedBool;

            // 尝试解析数字字符串
            if (int.TryParse(status.ToString(), out var parsedInt))
                return parsedInt == 1;

            return false;
        }

        private void UpdateStationLight(UILight light, bool isRunning)
        {
            if (light == null) return;

            if (isRunning)
            {
                light.OnColor = Color.Lime;
                light.OffColor = Color.Red;
                light.State = UILightState.On;
            }
            else
            {
                light.OnColor = Color.Lime;
                light.OffColor = Color.Red;
                light.State = UILightState.Off;
            }
        }

        private bool CheckAuthorization()
        {
            if (!GlobalVariables.IsAuthorized)
            {
                UIHelper.ShowError("您没有权限执行此操作，请联系管理员！", "权限验证");
                return false;
            }
            return true;
        }

        private bool CheckPlcConnection()
        {
            if (!GlobalVariables.PlcIsConnected)
            {
                UIHelper.ShowError("PLC未连接，请检查PLC连接状态！", "连接错误");
                return false;
            }
            return true;
        }

        private void ControlTotal(bool start)
        {
            if (!CheckAuthorization()) return;
            if (!CheckPlcConnection()) return;

            var paramName = start ? "生产线总启动" : "生产线总停止";
            var confirmMsg = start ? "确定要启动生产线吗？" : "确定要停止生产线吗？";

            if (!UIHelper.ShowConfirm(confirmMsg, "确认"))
                return;

            var result = PlcClientHelper.WritePlcData(paramName, true);

            if (result.IsSuccess)
            {
                LogHelper.LogOperate("设备控制", start ? "生产线总启动" : "生产线总停止");
                UIHelper.ShowInfo(start ? "生产线总启动成功" : "生产线总停止成功", "操作成功");
                
                // 更新所有工位的停止状态
                var allStations = new[] 
                { 
                    "电解槽工位", "纯化工位", "储氢工位", "加氢工位", 
                    "冷却工位", "检测工位", "输送工位" 
                };
                
                if (start)
                {
                    // 启动时清空停止工位字典
                    GlobalVariables.StoppedStations.Clear();
                }
                else
                {
                    // 停止时添加所有工位到字典
                    foreach (var station in allStations)
                    {
                        GlobalVariables.StoppedStations[station] = true;
                    }
                }
                
                // 立即更新本页面的信号灯
                UpdateStationStatus();
                
                // PLC写入成功后，立即读取最新状态以确保界面同步
                var readResult = PlcClientHelper.BatchReadPlcData();
                if (readResult.IsSuccess)
                {
                    // 通知实时监控页面刷新数据
                    NotifyRealTimeMonitorRefresh();
                }
            }
            else
            {
                UIHelper.ShowError($"操作失败: {result.Message}", "操作失败");
            }
        }

        private void CompressorReset()
        {
            if (!CheckAuthorization()) return;
            if (!CheckPlcConnection()) return;

            if (!UIHelper.ShowConfirm("确定要复位氢能压缩机吗？", "确认"))
                return;

            var result = PlcClientHelper.WritePlcData("氢能压缩机复位", true);

            if (result.IsSuccess)
            {
                LogHelper.LogOperate("设备控制", "氢能压缩机复位");
                UIHelper.ShowInfo("氢能压缩机复位成功", "操作成功");
            }
            else
            {
                UIHelper.ShowError($"操作失败: {result.Message}", "操作失败");
            }
        }

        private void AlarmReset()
        {
            if (!CheckAuthorization()) return;
            if (!CheckPlcConnection()) return;

            var result = PlcClientHelper.WritePlcData("系统报警复位", true);

            if (result.IsSuccess)
            {
                LogHelper.LogOperate("设备控制", "系统报警复位");
                UIHelper.ShowInfo("报警复位成功", "操作成功");
            }
            else
            {
                UIHelper.ShowError($"操作失败: {result.Message}", "操作失败");
            }
        }

        private void DryRun()
        {
            if (!CheckAuthorization()) return;
            if (!CheckPlcConnection()) return;

            if (!UIHelper.ShowConfirm("确定要执行空运行操作吗？", "确认"))
                return;

            var result = PlcClientHelper.WritePlcData("生产线空运行", true);

            if (result.IsSuccess)
            {
                LogHelper.LogOperate("设备控制", "生产线空运行");
                UIHelper.ShowInfo("空运行操作成功", "操作成功");
            }
            else
            {
                UIHelper.ShowError($"操作失败: {result.Message}", "操作失败");
            }
        }

        private void StationControl(string stationName, bool start)
        {
            if (!CheckAuthorization()) return;
            if (!CheckPlcConnection()) return;

            string paramName;
            switch (stationName)
            {
                case "电解槽工位":
                    paramName = start ? "电解槽工位启动" : "电解槽工位停止";
                    break;
                case "纯化工位":
                    paramName = start ? "纯化工位启动" : "纯化工位停止";
                    break;
                case "储氢工位":
                    paramName = start ? "储氢工位启动" : "储氢工位停止";
                    break;
                case "加氢工位":
                    paramName = start ? "加氢工位启动" : "加氢工位停止";
                    break;
                case "冷却工位":
                    paramName = start ? "冷却工位启动" : "冷却工位停止";
                    break;
                case "检测工位":
                    paramName = start ? "检测工位启动" : "检测工位停止";
                    break;
                case "输送工位":
                    paramName = start ? "输送工位启动" : "输送工位停止";
                    break;
                default:
                    UIHelper.ShowError("未知设备", "错误");
                    return;
            }

            var confirmMsg = $"确定要{stationName}{(start ? "启动" : "停止")}吗？";
            if (!UIHelper.ShowConfirm(confirmMsg, "确认"))
                return;

            var result = PlcClientHelper.WritePlcData(paramName, true);

            if (result.IsSuccess)
            {
                LogHelper.LogOperate("设备控制", $"{stationName}{(start ? "启动" : "停止")}");
                UIHelper.ShowInfo($"{stationName}{(start ? "启动" : "停止")}成功", "操作成功");
                
                // 更新停止工位字典
                if (start)
                {
                    GlobalVariables.StoppedStations.Remove(stationName);
                }
                else
                {
                    GlobalVariables.StoppedStations[stationName] = true;
                }
                
                // 立即更新本页面的信号灯
                UpdateStationStatus();
                
                // PLC写入成功后，立即读取最新状态以确保界面同步
                var readResult = PlcClientHelper.BatchReadPlcData();
                if (readResult.IsSuccess)
                {
                    // 立即刷新一次状态显示
                    UpdateStationStatus();
                    
                    // 通知实时监控页面刷新数据
                    NotifyRealTimeMonitorRefresh();
                }
            }
            else
            {
                UIHelper.ShowError($"操作失败: {result.Message}", "操作失败");
            }
        }

        /// <summary>
        /// 通知实时监控页面刷新数据
        /// </summary>
        private void NotifyRealTimeMonitorRefresh()
        {
            // 查找主窗体
            var mainForm = System.Windows.Forms.Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
            if (mainForm != null)
            {
                // 调用主窗体的方法来刷新实时监控页面
                mainForm.RefreshRealTimeMonitor();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _statusTimer?.Stop();
            _statusTimer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
