using Custom.HydrogenConfigurationSystem.Data.DB;
using Custom.HydrogenConfigurationSystem.PlcComm;
using Custom.HydrogenConfigurationSystem.Configs;
using Custom.HydrogenConfigurationSystem.Globals;
using Custom.HydrogenConfigurationSystem.Helpers;

namespace Custom.HydrogenConfigurationSystem.Forms
{
    public partial class FrmMain : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Form? currentForm;
        private System.Windows.Forms.Timer? plcTimer;
        private System.Windows.Forms.Timer? authTimer;
        private System.Windows.Forms.Timer? dataSaveTimer;
        private DateTime lastReconnectTime = DateTime.MinValue;
        private const int ReconnectCooldown = 5000;
        private DateTime lastDataUpdate = DateTime.MinValue;
        private const int DataUpdateInterval = 500;
        private const int DataSaveInterval = 60000;
        private Dictionary<Type, System.Windows.Forms.Form> formCache = new Dictionary<Type, System.Windows.Forms.Form>();
        private bool isReadingPlcData = false;
        private bool isAlarmActive = false;
        private bool isSimulatingData = false;
        private System.Windows.Forms.Timer? simulateTimer;
        private readonly Random random = new Random();
        private readonly ProductionDataService _productionDataService = new ProductionDataService();

        public FrmMain()
        {
            InitializeComponent();

            // 初始化菜单图标
            InitializeMenuIcons();

            // 应用主题到主窗体
            ApplyThemeToMainForm();

            // 订阅主题改变事件
            ThemeManager.ThemeChanged += OnThemeChanged;

            // 启动系统时间定时器
            timerSystemTime.Start();
            UpdateSystemTime();

            // 更新当前用户显示
            UpdateCurrentUserDisplay();

            // 在窗体加载完成后重新排列按钮
            this.Load += FrmMain_Load;

            LoadDefaultForm();
            InitializeSystemAsync();
            InitializeMenuEvents();
        }

        private void FrmMain_Load(object? sender, EventArgs e)
        {
            RearrangeMenuButtons();
        }

        private void UpdateCurrentUserDisplay()
        {
            if (!string.IsNullOrEmpty(GlobalVariables.CurrentUserName))
            {
                lblCurrentUser.Text = $"当前用户：{GlobalVariables.CurrentUserName}";
            }
        }

        /// <summary>
        /// 更新当前配方显示
        /// </summary>
        public void UpdateCurrentRecipeDisplay()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateCurrentRecipeDisplay));
                return;
            }

            if (!string.IsNullOrEmpty(GlobalVariables.CurrentRecipeName))
            {
                lblCurrentRecipe.Text = $"当前配方：{GlobalVariables.CurrentRecipeName}";
                lblCurrentRecipe.ForeColor = System.Drawing.Color.FromArgb(250, 204, 21); // 黄色
            }
            else
            {
                lblCurrentRecipe.Text = "当前配方：未设置";
                lblCurrentRecipe.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184); // 灰色
            }
        }

        /// <summary>
        /// 初始化菜单图标
        /// </summary>
        private void InitializeMenuIcons()
        {
            IconHelper.SetButtonIcon(btnDashboard, IconHelper.CreateDashboardIcon());
            IconHelper.SetButtonIcon(btnDeviceControl, IconHelper.CreateDeviceControlIcon());
            IconHelper.SetButtonIcon(btnRealTimeMonitor, IconHelper.CreateMonitorIcon());
            IconHelper.SetButtonIcon(btnRecipeManager, IconHelper.CreateRecipeIcon());
            IconHelper.SetButtonIcon(btnLogQuery, IconHelper.CreateLogIcon());
            IconHelper.SetButtonIcon(btnReportChart, IconHelper.CreateChartIcon());
            IconHelper.SetButtonIcon(btnSystemConfig, IconHelper.CreateConfigIcon());
            IconHelper.SetButtonIcon(btnUserManager, IconHelper.CreateUserIcon());
        }

        /// <summary>
        /// 主题改变事件处理
        /// </summary>
        private void OnThemeChanged(object? sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => OnThemeChanged(sender, e)));
                return;
            }

            // 应用主题到主窗体
            ApplyThemeToMainForm();

            // 应用主题到所有缓存的窗体
            foreach (var form in formCache.Values)
            {
                if (!form.IsDisposed)
                {
                    ThemeManager.ApplyFormTheme(form);
                }
            }

            // 刷新当前显示的窗体
            if (currentForm != null && !currentForm.IsDisposed)
            {
                currentForm.Refresh();
            }
        }

        /// <summary>
        /// 应用主题到主窗体
        /// </summary>
        private void ApplyThemeToMainForm()
        {
            // 设置窗体背景色
            this.BackColor = ThemeManager.GetBackgroundColor();

            // 设置面板背景色
            pnlMain.BackColor = ThemeManager.GetPanelBackgroundColor();
            pnlAside.BackColor = ThemeManager.IsDarkMode ? ThemeManager.Dark.PanelBackground : ThemeManager.Light.PanelBackground;
            pnlHeader.BackColor = ThemeManager.GetPanelBackgroundColor();
            pnlFooter.BackColor = ThemeManager.GetPanelBackgroundColor();

            // 设置按钮样式
            SetMenuButtonStyle(btnDashboard);
            SetMenuButtonStyle(btnDeviceControl);
            SetMenuButtonStyle(btnRealTimeMonitor);
            SetMenuButtonStyle(btnRecipeManager);
            SetMenuButtonStyle(btnLogQuery);
            SetMenuButtonStyle(btnReportChart);
            SetMenuButtonStyle(btnSystemConfig);
            SetMenuButtonStyle(btnUserManager);

            // 设置标签颜色
            lblPlcState.ForeColor = ThemeManager.GetLabelColor();
            lblHydrogenConcentration.ForeColor = ThemeManager.GetTextColor();
            lblHydrogenOutput.ForeColor = ThemeManager.GetTextColor();
            lblSystemStatus.ForeColor = ThemeManager.GetTextColor();
            lblElectrolysisCurrent.ForeColor = ThemeManager.GetTextColor();
            lblStoragePressure.ForeColor = ThemeManager.GetTextColor();
            lblEnvironmentTemp.ForeColor = ThemeManager.GetTextColor();
            lblEnvironmentHumidity.ForeColor = ThemeManager.GetTextColor();

            // 设置状态栏标签颜色
            lblSystemTime.ForeColor = ThemeManager.GetTextColor();
            lblCpuUsage.ForeColor = ThemeManager.GetLabelColor();
            lblMemoryUsage.ForeColor = ThemeManager.GetLabelColor();
            lblSoftwareVersion.ForeColor = ThemeManager.GetLabelColor();

            // 刷新当前活动按钮
            RefreshActiveButton();
        }

        /// <summary>
        /// 设置菜单按钮样式
        /// </summary>
        private void SetMenuButtonStyle(Button button)
        {
            button.BackColor = Color.Transparent;
            button.ForeColor = ThemeManager.GetTextColor();
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }

        /// <summary>
        /// 系统时间定时器事件处理
        /// </summary>
        private void TimerSystemTime_Tick(object? sender, EventArgs e)
        {
            UpdateSystemTime();
        }

        /// <summary>
        /// 更新系统时间显示
        /// </summary>
        private void UpdateSystemTime()
        {
            if (lblSystemTime.InvokeRequired)
            {
                lblSystemTime.Invoke(new Action(UpdateSystemTime));
                return;
            }
            lblSystemTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        /// <summary>
        /// 刷新当前活动按钮样式
        /// </summary>
        private void RefreshActiveButton()
        {
            var activeColor = ThemeManager.GetTitleColor();

            if (currentForm is FrmDashboard)
                btnDashboard.BackColor = activeColor;
            else if (currentForm is FrmDeviceControl)
                btnDeviceControl.BackColor = activeColor;
            else if (currentForm is FrmRealTimeMonitor)
                btnRealTimeMonitor.BackColor = activeColor;
            else if (currentForm is FrmRecipeManager)
                btnRecipeManager.BackColor = activeColor;
            else if (currentForm is FrmLogQuery)
                btnLogQuery.BackColor = activeColor;
            else if (currentForm is FrmReportChart)
                btnReportChart.BackColor = activeColor;
            else if (currentForm is FrmSystemConfig)
                btnSystemConfig.BackColor = activeColor;
            else if (currentForm is FrmUserManager)
                btnUserManager.BackColor = activeColor;
        }

        private void InitializeSystemAsync()
        {
            Task.Run(() =>
            {
                LoadSystemConfig();
                InitDatabase();
                LoadPlcVarConfig();
                InitPlcConnection();
            });

            StartPlcDataCollection();
            StartAuthCheck();
            StartDataSaveTimer();
        }

        private void LoadPlcVarConfig()
        {
            PlcVarConfigHelper.LoadPlcVarConfig();
        }

        private void LoadSystemConfig()
        {
            var systemConfig = SystemConfig.Load();

            // 检查窗体是否已被释放以及窗口句柄是否已创建
            if (!IsDisposed && IsHandleCreated)
            {
                try
                {
                    Invoke(new Action(() =>
                    {
                        if (!IsDisposed)
                        {
                            UIHelper.SetFont(this, systemConfig.DefaultFont, systemConfig.DefaultFontSize);
                        }
                    }));
                }
                catch (ObjectDisposedException)
                {
                    // 窗体已被释放，忽略异常
                }
            }
        }

        private void InitDatabase()
        {
            DbContext.InitDatabase();
        }

        private void InitPlcConnection()
        {
            var plcConfig = PlcConfig.Load();
            GlobalVariables.PlcIp = plcConfig.PlcIp;
            GlobalVariables.PlcPort = plcConfig.PlcPort;
            GlobalVariables.ReadInterval = plcConfig.ReadInterval;
            GlobalVariables.ReConnectInterval = plcConfig.ReConnectInterval;

            var result = PlcClientHelper.InitPlcConnection();
            if (result.IsSuccess)
            {
                UpdatePlcStatus("PLC连接正常", System.Drawing.Color.LimeGreen);
            }
            else
            {
                UpdatePlcStatus("PLC连接失败", System.Drawing.Color.Red);
                LogHelper.Error($"PLC连接失败: {result.Message}");
            }
        }

        private void UpdatePlcStatus(string statusText, System.Drawing.Color indicatorColor)
        {
            // 检查窗体是否已被释放以及窗口句柄是否已创建
            if (!IsDisposed && IsHandleCreated)
            {
                if (InvokeRequired)
                {
                    try
                    {
                        Invoke(new Action(() =>
                        {
                            if (!IsDisposed)
                            {
                                lblPlcState.Text = statusText;
                                pnlPlcIndicator.BackColor = indicatorColor;
                            }
                        }));
                    }
                    catch (ObjectDisposedException)
                    {
                        // 窗体已被释放，忽略异常
                    }
                }
                else
                {
                    lblPlcState.Text = statusText;
                    pnlPlcIndicator.BackColor = indicatorColor;
                }
            }
        }

        private void StartPlcDataCollection()
        {
            plcTimer = new System.Windows.Forms.Timer();
            plcTimer.Interval = GlobalVariables.ReadInterval;
            plcTimer.Tick += PlcTimer_Tick;
            plcTimer.Start();
        }

        private void PlcTimer_Tick(object? sender, EventArgs e)
        {
            if (!GlobalVariables.PlcIsConnected)
            {
                if ((DateTime.Now - lastReconnectTime).TotalMilliseconds >= ReconnectCooldown)
                {
                    ReConnectPlc();
                }
                return;
            }

            if ((DateTime.Now - lastDataUpdate).TotalMilliseconds >= DataUpdateInterval && !isReadingPlcData)
            {
                isReadingPlcData = true;
                System.Threading.Tasks.Task.Run(() => ReadPlcDataAsync());
            }
        }

        private void ReadPlcDataAsync()
        {
            try
            {
                var result = PlcClientHelper.BatchReadPlcData();
                if (!result.IsSuccess)
                {
                    LogHelper.Error($"PLC数据读取失败: {result.Message}");
                    GlobalVariables.PlcIsConnected = false;
                    isReadingPlcData = false;
                    return;
                }

                // 检查窗体是否已被释放以及窗口句柄是否已创建
                if (!IsDisposed && IsHandleCreated)
                {
                    try
                    {
                        Invoke(new Action(() =>
                        {
                            if (!IsDisposed)
                            {
                                lastDataUpdate = DateTime.Now;
                                UpdateDashboardData();

                                if (currentForm is FrmDashboard dashboardForm && !dashboardForm.IsDisposed)
                                {
                                    dashboardForm.RefreshData();
                                }

                                if (currentForm is FrmRealTimeMonitor monitorForm && !monitorForm.IsDisposed)
                                {
                                    monitorForm.RefreshData();
                                }

                                isReadingPlcData = false;
                            }
                        }));
                    }
                    catch (ObjectDisposedException)
                    {
                        // 窗体已被释放，忽略异常
                        isReadingPlcData = false;
                    }
                }
                else
                {
                    isReadingPlcData = false;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error($"PLC数据读取异常: {ex.Message}");
                isReadingPlcData = false;
            }
        }

        private void ReConnectPlc()
        {
            lastReconnectTime = DateTime.Now;

            // 检查窗体是否已被释放以及窗口句柄是否已创建
            if (!IsDisposed && IsHandleCreated)
            {
                try
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(ReConnectPlcInternal));
                    }
                    else
                    {
                        ReConnectPlcInternal();
                    }
                }
                catch (ObjectDisposedException)
                {
                    // 窗体已被释放，忽略异常
                }
            }
        }

        private void ReConnectPlcInternal()
        {
            UpdatePlcStatus("PLC连接断开，正在重连...", System.Drawing.Color.Orange);

            Task.Run(() =>
            {
                var result = PlcClientHelper.InitPlcConnection();
                if (result.IsSuccess)
                {
                    UpdatePlcStatus("PLC连接正常", System.Drawing.Color.LimeGreen);
                    LogHelper.Info("PLC重连成功");
                }
                else
                {
                    UpdatePlcStatus("PLC重连失败", System.Drawing.Color.Red);
                    LogHelper.Error($"PLC重连失败: {result.Message}");
                }
            });
        }

        private void UpdateDashboardData()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(UpdateDashboardData));
                return;
            }

            if (GlobalVariables.DataDic.TryGetValue("氢气浓度", out var hydrogenConcentration))
            {
                lblHydrogenConcentration.Text = $"氢气浓度：{FormatValue(hydrogenConcentration, "F2")}%";
                CheckHydrogenConcentrationAlarm(hydrogenConcentration);
            }

            if (GlobalVariables.DataDic.TryGetValue("产氢量", out var hydrogenOutput))
            {
                lblHydrogenOutput.Text = $"实时产氢：{FormatValue(hydrogenOutput, "F2")} Nm3/h";
            }

            if (GlobalVariables.DataDic.TryGetValue("系统状态", out var systemStatus))
            {
                lblSystemStatus.Text = systemStatus?.ToString() ?? "--";
            }

            if (GlobalVariables.DataDic.TryGetValue("电解电流", out var current))
            {
                lblElectrolysisCurrent.Text = $"电解电流：{FormatValue(current, "F2")} A";
            }

            if (GlobalVariables.DataDic.TryGetValue("储氢压力", out var pressure))
            {
                lblStoragePressure.Text = $"储氢压力：{FormatValue(pressure, "F2")} MPa";
            }

            if (GlobalVariables.DataDic.TryGetValue("环境温度", out var temp))
            {
                lblEnvironmentTemp.Text = $"环境温度：{FormatValue(temp, "F2")} ℃";
            }

            if (GlobalVariables.DataDic.TryGetValue("环境湿度", out var humidity))
            {
                lblEnvironmentHumidity.Text = $"环境湿度：{FormatValue(humidity, "F2")} %";
            }
        }

        private string FormatValue(object value, string format)
        {
            if (value == null)
                return "--";

            // 处理bool类型，不显示True/False
            if (value is bool b)
                return b ? "运行" : "停止";

            if (value is double d)
                return d.ToString(format);
            if (value is float f)
                return f.ToString(format);
            if (value is decimal dec)
                return dec.ToString(format);
            if (value is int i)
                return i.ToString(format);
            if (value is long l)
                return l.ToString(format);
            if (double.TryParse(value?.ToString(), out var parsed))
                return parsed.ToString(format);

            return value?.ToString() ?? "--";
        }

        private void StartAuthCheck()
        {
            authTimer = new System.Windows.Forms.Timer();
            authTimer.Interval = 60000;
            authTimer.Tick += AuthTimer_Tick;
            authTimer.Start();
        }

        private void StartDataSaveTimer()
        {
            dataSaveTimer = new System.Windows.Forms.Timer();
            dataSaveTimer.Interval = DataSaveInterval;
            dataSaveTimer.Tick += DataSaveTimer_Tick;
            dataSaveTimer.Start();
        }

        private void DataSaveTimer_Tick(object? sender, EventArgs e)
        {
            Task.Run(() => SaveProductionData());
        }

        private void SaveProductionData()
        {
            try
            {
                if (!GlobalVariables.PlcIsConnected)
                    return;

                var entity = new Data.Entities.ProductionDataEntity
                {
                    InsertTime = DateTime.Now
                };

                if (GlobalVariables.DataDic.TryGetValue("电解电流", out var current))
                {
                    entity.ElectrolysisCurrent = Convert.ToDouble(current);
                }

                if (GlobalVariables.DataDic.TryGetValue("产氢量", out var output))
                {
                    entity.HydrogenOutput = Convert.ToDouble(output);
                }

                if (GlobalVariables.DataDic.TryGetValue("氢气纯度", out var purity))
                {
                    entity.HydrogenPurity = Convert.ToDouble(purity);
                }

                if (GlobalVariables.DataDic.TryGetValue("环境温度", out var temp))
                {
                    entity.EnvironmentTemperature = Convert.ToDouble(temp);
                }

                if (GlobalVariables.DataDic.TryGetValue("环境湿度", out var humidity))
                {
                    entity.EnvironmentHumidity = Convert.ToDouble(humidity);
                }

                if (GlobalVariables.DataDic.TryGetValue("氢气浓度", out var concentration))
                {
                    entity.HydrogenConcentration = Convert.ToDouble(concentration);
                }

                _productionDataService.Add(entity);
                LogHelper.Info("生产数据已保存");
            }
            catch (Exception ex)
            {
                LogHelper.Error($"保存生产数据失败: {ex.Message}");
            }
        }

        private void AuthTimer_Tick(object? sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (!AuthHelper.ValidateAuth())
                {
                    // 检查窗体是否已被释放以及窗口句柄是否已创建
                    if (!IsDisposed && IsHandleCreated)
                    {
                        try
                        {
                            Invoke(new Action(() =>
                            {
                                if (!IsDisposed)
                                {
                                    UIHelper.ShowError("系统授权已过期，请联系管理员！", "授权验证");
                                    authTimer?.Stop();
                                }
                            }));
                        }
                        catch (ObjectDisposedException)
                        {
                            // 窗体已被释放，忽略异常
                        }
                    }
                }
            });
        }

        private void InitializeMenuEvents()
        {
            btnDashboard.Click += (s, e) => LoadForm<FrmDashboard>();
            btnDeviceControl.Click += (s, e) => LoadForm<FrmDeviceControl>();
            btnRealTimeMonitor.Click += (s, e) => LoadForm<FrmRealTimeMonitor>();
            btnRecipeManager.Click += (s, e) => LoadForm<FrmRecipeManager>();
            btnLogQuery.Click += (s, e) => LoadForm<FrmLogQuery>();
            btnReportChart.Click += (s, e) => LoadForm<FrmReportChart>();
            btnSystemConfig.Click += (s, e) => LoadForm<FrmSystemConfig>();
            btnUserManager.Click += (s, e) => LoadForm<FrmUserManager>();
            btnSimulateData.Click += BtnSimulateData_Click;
        }

        private void BtnSimulateData_Click(object? sender, EventArgs e)
        {
            if (isSimulatingData)
            {
                StopSimulateData();
            }
            else
            {
                StartSimulateData();
            }
        }

        private void StartSimulateData()
        {
            if (!GlobalVariables.PlcIsConnected || GlobalVariables.PlcClient == null)
            {
                UIHelper.ShowWarning("PLC未连接，无法启动模拟数据", "模拟数据");
                return;
            }

            isSimulatingData = true;
            btnSimulateData.Text = "停止模拟";
            btnSimulateData.BackColor = Color.FromArgb(239, 68, 68);

            simulateTimer = new System.Windows.Forms.Timer();
            simulateTimer.Interval = 1000;
            simulateTimer.Tick += SimulateTimer_Tick;
            simulateTimer.Start();

            LogHelper.Info("开始模拟PLC数据");
            UIHelper.ShowInfo("已开始模拟数据，界面将显示模拟值", "模拟数据");
        }

        private void StopSimulateData()
        {
            isSimulatingData = false;
            btnSimulateData.Text = "模拟数据";
            btnSimulateData.BackColor = Color.FromArgb(245, 158, 11);

            simulateTimer?.Stop();
            simulateTimer?.Dispose();
            simulateTimer = null;

            LogHelper.Info("停止模拟PLC数据");
            UIHelper.ShowInfo("已停止模拟数据", "模拟数据");
        }

        private void SimulateTimer_Tick(object? sender, EventArgs e)
        {
            GenerateSimulateData();
        }

        private void GenerateSimulateData()
        {
            if (!GlobalVariables.PlcIsConnected || GlobalVariables.PlcClient == null)
            {
                LogHelper.Warn("PLC未连接，停止模拟数据");
                StopSimulateData();
                return;
            }

            try
            {
                // ========== 环境监控数据 ==========
                float temp = (float)(22.0 + random.NextDouble() * 8.0);
                float humidity = (float)(45.0 + random.NextDouble() * 20.0);
                float h2Concentration = (float)(0.1 + random.NextDouble() * 0.5);

                // ========== 生产统计数据 ==========
                float hydrogenOutput = (float)(25.0 + random.NextDouble() * 15.0);
                float energyConsumption = (float)(4.5 + random.NextDouble() * 1.5);

                // 累计产氢量
                if (!GlobalVariables.DataDic.ContainsKey("累计产氢量"))
                {
                    GlobalVariables.DataDic["累计产氢量"] = 1000.0f;
                }
                float currentTotal = (float)GlobalVariables.DataDic["累计产氢量"];
                float totalHydrogen = currentTotal + (hydrogenOutput / 3600.0f);

                // 累计能耗
                if (!GlobalVariables.DataDic.ContainsKey("累计生产能耗"))
                {
                    GlobalVariables.DataDic["累计生产能耗"] = 5000.0f;
                }
                float currentTotalEnergy = (float)GlobalVariables.DataDic["累计生产能耗"];
                float totalEnergy = currentTotalEnergy + (energyConsumption * hydrogenOutput / 3600.0f);

                // ========== 电解槽工位数据 ==========
                float electrolysisCurrent = (float)(200.0 + random.NextDouble() * 50.0);
                float electrolysisVoltage = (float)(40.0 + random.NextDouble() * 5.0);
                float electrolysisTemp = (float)(70.0 + random.NextDouble() * 10.0);
                float electrolysisLevel = (float)(80.0 + random.NextDouble() * 10.0);

                // ========== 纯化工位数据 ==========
                float purificationPressure = (float)(4.0 + random.NextDouble() * 2.0);
                float purificationTemp = (float)(40.0 + random.NextDouble() * 10.0);
                float purificationPurity = (float)(99.9 + random.NextDouble() * 0.099);

                // ========== 储氢工位数据 ==========
                float storagePressure = (float)(15.0 + random.NextDouble() * 5.0);
                float storageTemp = (float)(25.0 + random.NextDouble() * 10.0);
                float storageLevel = (float)(60.0 + random.NextDouble() * 20.0);

                // ========== 加氢工位数据 ==========
                float refuelingFlow = (float)(20.0 + random.NextDouble() * 15.0);

                // ========== 冷却工位数据 ==========
                float coolingOutTemp = (float)(25.0 + random.NextDouble() * 5.0);
                float coolingInTemp = (float)(35.0 + random.NextDouble() * 8.0);

                // ========== 检测工位数据 ==========
                float detectionPurity = (float)(99.95 + random.NextDouble() * 0.049);

                // ========== 输送工位数据 ==========
                float transportPressure = (float)(2.0 + random.NextDouble() * 2.0);

                // 直接写入PLC真实地址
                var writeResults = new List<(string address, float value)>
                {
                    // 环境监控
                    ("DB1.DBD11", temp),                // 环境温度
                    ("DB1.DBD15", humidity),            // 环境湿度
                    ("DB1.DBD19", h2Concentration),     // 氢气浓度

                    // 生产统计
                    ("DB1.DBD99", hydrogenOutput),      // 实时产氢量
                    ("DB1.DBD103", totalHydrogen),      // 累计产氢量
                    ("DB1.DBD115", energyConsumption),  // 实时能耗
                    ("DB1.DBD119", totalEnergy),        // 累计能耗

                    // 电解槽工位
                    ("DB1.DBD35", electrolysisCurrent), // 电解电流
                    ("DB1.DBD63", electrolysisVoltage), // 电解槽工作电压
                    ("DB1.DBD67", electrolysisTemp),    // 电解槽区域温度
                    ("DB1.DBD71", electrolysisLevel),   // 电解液液位

                    // 纯化工位
                    ("DB1.DBD75", purificationPressure),// 纯化工位工作压力
                    ("DB1.DBD79", purificationTemp),    // 纯化工位区域温度
                    ("DB1.DBD83", purificationPurity),  // 纯化工位氢气纯度

                    // 储氢工位
                    ("DB1.DBD47", storagePressure),     // 储氢压力
                    ("DB1.DBD87", storagePressure),     // 储氢罐压力
                    ("DB1.DBD91", storageTemp),         // 储氢罐温度
                    ("DB1.DBD95", storageLevel),        // 储氢罐液位

                    // 加氢工位
                    ("DB1.DBD103", refuelingFlow),      // 加氢机流量

                    // 冷却工位
                    ("DB1.DBD107", coolingOutTemp),     // 冷却系统出水温度
                    ("DB1.DBD111", coolingInTemp),      // 冷却系统回水温度

                    // 检测工位
                    ("DB1.DBD115", detectionPurity),    // 检测工位最终纯度

                    // 输送工位
                    ("DB1.DBD119", transportPressure)   // 输送工位工作压力
                };

                bool allSuccess = true;
                foreach (var (address, value) in writeResults)
                {
                    var result = GlobalVariables.PlcClient.Write(address, value);
                    if (!result.IsSuccess)
                    {
                        LogHelper.Error($"写入PLC地址 {address} 失败: {result.Message}");
                        allSuccess = false;
                    }
                }

                if (allSuccess)
                {
                    LogHelper.Debug("模拟数据写入PLC成功");
                }

                // 系统状态写入Bool类型 - 所有设备运行中
                GlobalVariables.PlcClient.Write("DB1.DBX4.0", true);  // 系统状态
                GlobalVariables.PlcClient.Write("DB1.DBX4.2", true);  // 电解槽运行状态
                GlobalVariables.PlcClient.Write("DB1.DBX4.5", true);  // 纯化装置运行状态
                GlobalVariables.PlcClient.Write("DB1.DBX4.7", true);  // 储氢罐运行状态
                GlobalVariables.PlcClient.Write("DB1.DBX5.1", true);  // 加氢机运行状态
                GlobalVariables.PlcClient.Write("DB1.DBX5.3", true);  // 冷却系统运行状态
                GlobalVariables.PlcClient.Write("DB1.DBX5.5", true);  // 检测设备运行状态
                GlobalVariables.PlcClient.Write("DB1.DBX5.7", true);  // 输送泵运行状态
            }
            catch (Exception ex)
            {
                LogHelper.Error($"生成模拟数据失败: {ex.Message}");
            }
        }

        private void LoadDefaultForm()
        {
            ApplyUserPermissions();
            LoadForm<FrmDashboard>();
        }

        /// <summary>
        /// 刷新实时监控页面数据
        /// </summary>
        public void RefreshRealTimeMonitor()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(RefreshRealTimeMonitor));
                return;
            }

            // 刷新当前显示的实时监控页面
            if (currentForm is FrmRealTimeMonitor monitorForm && !monitorForm.IsDisposed)
            {
                monitorForm.RefreshData();
            }

            // 检查是否有其他实时监控页面实例打开
            foreach (var form in System.Windows.Forms.Application.OpenForms)
            {
                if (form is FrmRealTimeMonitor otherMonitorForm && form != currentForm && !otherMonitorForm.IsDisposed)
                {
                    otherMonitorForm.RefreshData();
                }
            }
        }

        private void ApplyUserPermissions()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(ApplyUserPermissions));
                return;
            }

            btnDashboard.Visible = true;
            btnDashboard.Enabled = true;

            btnDeviceControl.Visible = PermissionHelper.CanControlDevice();
            btnDeviceControl.Enabled = PermissionHelper.CanControlDevice();

            btnRealTimeMonitor.Visible = true;
            btnRealTimeMonitor.Enabled = true;

            btnRecipeManager.Visible = PermissionHelper.CanManageRecipe();
            btnRecipeManager.Enabled = PermissionHelper.CanManageRecipe();

            btnLogQuery.Visible = true;
            btnLogQuery.Enabled = true;

            btnReportChart.Visible = PermissionHelper.CanViewReport();
            btnReportChart.Enabled = PermissionHelper.CanViewReport();

            btnSystemConfig.Visible = PermissionHelper.CanConfigureSystem();
            btnSystemConfig.Enabled = PermissionHelper.CanConfigureSystem();

            btnUserManager.Visible = PermissionHelper.CanManageUser();
            btnUserManager.Enabled = PermissionHelper.CanManageUser();

            RearrangeMenuButtons();
        }

        private void RearrangeMenuButtons()
        {
            int yPos = 20;
            int buttonHeight = 50;
            int gap = 10;

            var buttons = new[]
            {
                btnDashboard,
                btnDeviceControl,
                btnRealTimeMonitor,
                btnRecipeManager,
                btnLogQuery,
                btnReportChart,
                btnSystemConfig,
                btnUserManager
            };

            pnlAside.SuspendLayout();
            
            try
            {
                foreach (var button in buttons)
                {
                    if (button.Visible)
                    {
                        button.Location = new System.Drawing.Point(10, yPos);
                        yPos += buttonHeight + gap;
                    }
                }
            }
            finally
            {
                pnlAside.ResumeLayout(true);
            }
        }

        private void LoadForm<T>() where T : System.Windows.Forms.Form, new()
        {
            ResetMenuButtons();

            if (currentForm != null)
            {
                currentForm.Hide();
                pnlMain.Controls.Remove(currentForm);
            }

            var formType = typeof(T);
            if (!formCache.ContainsKey(formType))
            {
                formCache[formType] = new T();
                formCache[formType].TopLevel = false;
                formCache[formType].FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formCache[formType].Dock = System.Windows.Forms.DockStyle.Fill;

                // 应用主题到新创建的窗体
                ThemeManager.ApplyFormTheme(formCache[formType]);
            }

            currentForm = formCache[formType];
            pnlMain.Controls.Add(currentForm);
            currentForm.Show();

            // 设置活动按钮
            SetActiveButton<T>();
        }

        private void ResetMenuButtons()
        {
            btnDashboard.BackColor = Color.Transparent;
            btnDeviceControl.BackColor = Color.Transparent;
            btnRealTimeMonitor.BackColor = Color.Transparent;
            btnRecipeManager.BackColor = Color.Transparent;
            btnLogQuery.BackColor = Color.Transparent;
            btnReportChart.BackColor = Color.Transparent;
            btnSystemConfig.BackColor = Color.Transparent;
            btnUserManager.BackColor = Color.Transparent;
        }

        private void SetActiveButton<T>()
        {
            var activeColor = ThemeManager.GetTitleColor();

            if (typeof(T) == typeof(FrmDashboard))
                btnDashboard.BackColor = activeColor;
            else if (typeof(T) == typeof(FrmDeviceControl))
                btnDeviceControl.BackColor = activeColor;
            else if (typeof(T) == typeof(FrmRealTimeMonitor))
                btnRealTimeMonitor.BackColor = activeColor;
            else if (typeof(T) == typeof(FrmRecipeManager))
                btnRecipeManager.BackColor = activeColor;
            else if (typeof(T) == typeof(FrmLogQuery))
                btnLogQuery.BackColor = activeColor;
            else if (typeof(T) == typeof(FrmReportChart))
                btnReportChart.BackColor = activeColor;
            else if (typeof(T) == typeof(FrmSystemConfig))
                btnSystemConfig.BackColor = activeColor;
            else if (typeof(T) == typeof(FrmUserManager))
                btnUserManager.BackColor = activeColor;
        }

        private void CheckHydrogenConcentrationAlarm(object hydrogenConcentration)
        {
            try
            {
                decimal concentration = 0;
                if (hydrogenConcentration is decimal dVal)
                {
                    concentration = dVal;
                }
                else if (hydrogenConcentration is double dbVal)
                {
                    concentration = (decimal)dbVal;
                }
                else if (hydrogenConcentration is float fVal)
                {
                    concentration = (decimal)fVal;
                }
                else if (decimal.TryParse(hydrogenConcentration.ToString(), out decimal parsedVal))
                {
                    concentration = parsedVal;
                }

                if (concentration > 4.0m)
                {
                    lblAlarmInfo.Text = $"警告：氢气浓度超标！当前：{concentration:F2}%";
                    lblAlarmInfo.ForeColor = Color.Red;
                    pnlAlarm.BackColor = Color.FromArgb(64, 0, 0);
                    
                    if (!isAlarmActive)
                    {
                        isAlarmActive = true;
                        LogHelper.LogAlarm("安全报警", "环境监控", $"氢气浓度超标！当前浓度：{concentration:F2}%");
                        LogHelper.Warn($"氢气浓度超标！当前浓度：{concentration:F2}%");
                        UIHelper.ShowError($"氢气浓度超标！当前浓度：{concentration:F2}%，请立即处理！", "安全报警");
                    }
                }
                else
                {
                    lblAlarmInfo.Text = "系统正常，无报警";
                    lblAlarmInfo.ForeColor = Color.FromArgb(34, 197, 94);
                    pnlAlarm.BackColor = Color.FromArgb(15, 23, 42);
                    isAlarmActive = false;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error($"氢气浓度报警检测异常: {ex.Message}");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // 停止定时器
            plcTimer?.Stop();
            authTimer?.Stop();
            dataSaveTimer?.Stop();

            // 取消订阅主题改变事件
            ThemeManager.ThemeChanged -= OnThemeChanged;

            base.OnFormClosing(e);
        }
    }
}
