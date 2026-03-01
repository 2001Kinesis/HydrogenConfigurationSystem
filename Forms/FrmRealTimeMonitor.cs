using Custom.HydrogenConfigurationSystem.Globals;

namespace Custom.HydrogenConfigurationSystem.Forms
{
    public partial class FrmRealTimeMonitor : System.Windows.Forms.Form
    {
        // 工位名称与数据更新方法的映射
        private readonly Dictionary<string, Action> _stationUpdateMap = new();

        public FrmRealTimeMonitor()
        {
            InitializeComponent();
            InitializeStationUpdateMap();
        }

        private void InitializeStationUpdateMap()
        {
            _stationUpdateMap.Add("电解槽工位", UpdateElectrolyzerData);
            _stationUpdateMap.Add("纯化工位", UpdatePurificationData);
            _stationUpdateMap.Add("储氢工位", UpdateStorageData);
            _stationUpdateMap.Add("加氢工位", UpdateRefuelingData);
            _stationUpdateMap.Add("冷却工位", UpdateCoolingData);
            _stationUpdateMap.Add("检测工位", UpdateDetectionData);
            _stationUpdateMap.Add("输送工位", UpdateTransportData);
        }

        public void RefreshData()
        {
            foreach (var kvp in _stationUpdateMap)
            {
                if (!GlobalVariables.StoppedStations.ContainsKey(kvp.Key))
                {
                    kvp.Value();
                }
            }
            // 即使工位被停止，也要更新状态指示器
            UpdateAllStationStatusIndicators();
            UpdateRecipeParamsDisplay();
        }

        /// <summary>
        /// 更新所有工位的状态指示器
        /// </summary>
        private void UpdateAllStationStatusIndicators()
        {
            // 首先检查停止工位字典，如果工位被停止，直接设置为红色（不运行）
            bool isElectrolyzerStopped = GlobalVariables.StoppedStations.ContainsKey("电解槽工位");
            bool isPurificationStopped = GlobalVariables.StoppedStations.ContainsKey("纯化工位");
            bool isStorageStopped = GlobalVariables.StoppedStations.ContainsKey("储氢工位");
            bool isRefuelingStopped = GlobalVariables.StoppedStations.ContainsKey("加氢工位");
            bool isCoolingStopped = GlobalVariables.StoppedStations.ContainsKey("冷却工位");
            bool isDetectionStopped = GlobalVariables.StoppedStations.ContainsKey("检测工位");
            bool isTransportStopped = GlobalVariables.StoppedStations.ContainsKey("输送工位");

            UpdateStatusIndicator(uiPanelElectrolyzerStatus, !isElectrolyzerStopped);
            UpdateStatusIndicator(uiPanelPurificationStatus, !isPurificationStopped);
            UpdateStatusIndicator(uiPanelStorageStatus, !isStorageStopped);
            UpdateStatusIndicator(uiPanelRefuelingStatus, !isRefuelingStopped);
            UpdateStatusIndicator(uiPanelCoolingStatus, !isCoolingStopped);
            UpdateStatusIndicator(uiPanelDetectionStatus, !isDetectionStopped);
            UpdateStatusIndicator(uiPanelTransportStatus, !isTransportStopped);
        }

        /// <summary>
        /// 更新配方参数显示
        /// </summary>
        private void UpdateRecipeParamsDisplay()
        {
            // 更新配方状态指示器
            UpdateRecipeStatusIndicator();

            // 检查是否有配方参数
            if (GlobalVariables.CurrentRecipeParams.Count == 0)
                return;

            // 更新电解槽工位的配方限值显示
            if (GlobalVariables.CurrentRecipeParams.TryGetValue("电解电流下限", out var elecMin) &&
                GlobalVariables.CurrentRecipeParams.TryGetValue("电解电流上限", out var elecMax))
            {
                // 可以在标签上显示限值，例如：电解电流 (100.0-400.0A)
                var minVal = Convert.ToDouble(elecMin);
                var maxVal = Convert.ToDouble(elecMax);
                uiLabelElecCurrent.Text = $"工作电流 ({minVal:F1}-{maxVal:F1}A)";
            }

            // 更新纯化工位的配方限值显示
            if (GlobalVariables.CurrentRecipeParams.TryGetValue("纯化压力下限", out var purMin) &&
                GlobalVariables.CurrentRecipeParams.TryGetValue("纯化压力上限", out var purMax))
            {
                var minVal = Convert.ToDouble(purMin);
                var maxVal = Convert.ToDouble(purMax);
                uiLabelPurPressure.Text = $"工作压力 ({minVal:F2}-{maxVal:F2}MPa)";
            }

            // 更新储氢工位的配方设定值显示
            if (GlobalVariables.CurrentRecipeParams.TryGetValue("储氢压力设定", out var stoSet))
            {
                var setVal = Convert.ToDouble(stoSet);
                uiLabelStoPressure.Text = $"工作压力 (设定:{setVal:F2}MPa)";
            }

            // 更新加氢工位的配方上限显示
            if (GlobalVariables.CurrentRecipeParams.TryGetValue("加氢流量上限", out var refMax))
            {
                var maxVal = Convert.ToDouble(refMax);
                uiLabelRefFlow.Text = $"实时流量 (上限:{maxVal:F1}Nm³/h)";
            }
        }

        /// <summary>
        /// 更新配方状态指示器
        /// </summary>
        private void UpdateRecipeStatusIndicator()
        {
            if (!string.IsNullOrEmpty(GlobalVariables.CurrentRecipeName))
            {
                // 有配方生效 - 绿色指示器
                uiPanelRecipeIndicator.BackColor = System.Drawing.Color.FromArgb(34, 197, 94);
                uiLabelRecipeStatus.Text = $"配方：{GlobalVariables.CurrentRecipeName}";
                uiLabelRecipeStatus.ForeColor = System.Drawing.Color.FromArgb(34, 197, 94);
            }
            else
            {
                // 无配方 - 灰色指示器
                uiPanelRecipeIndicator.BackColor = System.Drawing.Color.Gray;
                uiLabelRecipeStatus.Text = "配方：未设置";
                uiLabelRecipeStatus.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            }
        }

        private void UpdateElectrolyzerData()
        {
            if (GlobalVariables.DataDic.TryGetValue("电解电流", out var current))
                uiLabelElecCurrentValue.Text = FormatDouble(current, "F1 A");

            if (GlobalVariables.DataDic.TryGetValue("电解槽工作电压", out var voltage))
                uiLabelElecVoltageValue.Text = FormatDouble(voltage, "F1 V");

            if (GlobalVariables.DataDic.TryGetValue("电解槽区域温度", out var temp))
                uiLabelElecTempValue.Text = FormatDouble(temp, "F1 ℃");

            if (GlobalVariables.DataDic.TryGetValue("电解液液位", out var level))
                uiLabelElecLevelValue.Text = FormatDouble(level, "F1 %");
        }

        private void UpdatePurificationData()
        {
            if (GlobalVariables.DataDic.TryGetValue("纯化工位工作压力", out var pressure))
                uiLabelPurPressureValue.Text = FormatDouble(pressure, "F2 MPa");

            if (GlobalVariables.DataDic.TryGetValue("纯化工位区域温度", out var temp))
                uiLabelPurTempValue.Text = FormatDouble(temp, "F1 ℃");

            if (GlobalVariables.DataDic.TryGetValue("纯化工位氢气纯度", out var purity))
                uiLabelPurPurityValue.Text = FormatDouble(purity, "F3 %");
        }

        private void UpdateStorageData()
        {
            if (GlobalVariables.DataDic.TryGetValue("储氢罐压力", out var pressure))
                uiLabelStoPressureValue.Text = FormatDouble(pressure, "F2 MPa");

            if (GlobalVariables.DataDic.TryGetValue("储氢罐温度", out var temp))
                uiLabelStoTempValue.Text = FormatDouble(temp, "F1 ℃");

            if (GlobalVariables.DataDic.TryGetValue("储氢罐液位", out var level))
                uiLabelStoLevelValue.Text = FormatDouble(level, "F1 %");
        }

        private void UpdateRefuelingData()
        {
            if (GlobalVariables.DataDic.TryGetValue("加氢机流量", out var flow))
                uiLabelRefFlowValue.Text = FormatDouble(flow, "F1 Nm³/h");
        }

        private void UpdateCoolingData()
        {
            if (GlobalVariables.DataDic.TryGetValue("冷却系统出水温度", out var outTemp))
                uiLabelCoolOutTempValue.Text = FormatDouble(outTemp, "F1 ℃");

            if (GlobalVariables.DataDic.TryGetValue("冷却系统回水温度", out var inTemp))
                uiLabelCoolInTempValue.Text = FormatDouble(inTemp, "F1 ℃");
        }

        private void UpdateDetectionData()
        {
            if (GlobalVariables.DataDic.TryGetValue("检测工位最终纯度", out var purity))
                uiLabelDetPurityValue.Text = FormatDouble(purity, "F3 %");
        }

        private void UpdateTransportData()
        {
            if (GlobalVariables.DataDic.TryGetValue("输送工位工作压力", out var pressure))
                uiLabelTraPressureValue.Text = FormatDouble(pressure, "F2 MPa");
        }

        private void UpdateStatusIndicator(Panel statusPanel, object status)
        {
            bool isRunning = false;
            if (status is bool boolValue)
            {
                isRunning = boolValue;
            }
            else if (status is int intValue)
            {
                isRunning = intValue == 1;
            }
            else if (bool.TryParse(status?.ToString(), out var parsedBool))
            {
                isRunning = parsedBool;
            }

            statusPanel.BackColor = isRunning ? Color.LimeGreen : Color.Gray;
        }

        private string FormatDouble(object value, string formatWithUnit)
        {
            if (value == null)
                return "--";

            // 解析格式字符串，如 "F1 A" -> 格式 "F1"，单位 " A"
            string format = formatWithUnit;
            string unit = "";
            int spaceIndex = formatWithUnit.IndexOf(' ');
            if (spaceIndex > 0)
            {
                format = formatWithUnit.Substring(0, spaceIndex);
                unit = formatWithUnit.Substring(spaceIndex);
            }

            string result;
            if (value is double d)
                result = d.ToString(format);
            else if (value is float f)
                result = f.ToString(format);
            else if (value is decimal dec)
                result = dec.ToString(format);
            else if (value is int i)
                result = i.ToString(format);
            else if (value is long l)
                result = l.ToString(format);
            else if (double.TryParse(value?.ToString(), out var parsed))
                result = parsed.ToString(format);
            else
                result = value?.ToString() ?? "--";

            return result + unit;
        }
    }
}
