using Custom.HydrogenConfigurationSystem.Data.DB;
using Custom.HydrogenConfigurationSystem.Data.Entities;
using Custom.HydrogenConfigurationSystem.Helpers;
using Custom.HydrogenConfigurationSystem.Globals;
using System.Data;
using System.Diagnostics;

namespace Custom.HydrogenConfigurationSystem.Forms
{
    public partial class FrmLogQuery : System.Windows.Forms.Form
    {
        private readonly LogService _logService = new LogService();

        public FrmLogQuery()
        {
            InitializeComponent();
            InitializeControls();
            BindEvents();
            ThemeManager.ThemeChanged += OnThemeChanged;
        }

        private void OnThemeChanged(object? sender, EventArgs e)
        {
            ApplyTheme();
        }

        private void InitializeControls()
        {
            uiDateTimePickerStart.Value = DateTime.Now.AddDays(-7);
            uiDateTimePickerEnd.Value = DateTime.Now;
            uiComboBoxLogType.SelectedIndex = 0;

            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            uiDataGridViewLogs.AutoGenerateColumns = false;
            uiDataGridViewLogs.Columns.Clear();

            uiDataGridViewLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LogTime",
                HeaderText = "日志时间",
                DataPropertyName = "LogTime",
                Width = 180
            });

            uiDataGridViewLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "LogType",
                HeaderText = "日志类型",
                DataPropertyName = "LogType",
                Width = 120
            });

            uiDataGridViewLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Station",
                HeaderText = "工位/模块",
                DataPropertyName = "Station",
                Width = 150
            });

            uiDataGridViewLogs.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Content",
                HeaderText = "日志内容",
                DataPropertyName = "Content",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void BindEvents()
        {
            uiButtonQuery.Click += UiButtonQuery_Click;
            uiButtonReset.Click += UiButtonReset_Click;
            uiButtonExport.Click += UiButtonExport_Click;
            uiButtonOpenDir.Click += UiButtonOpenDir_Click;
        }

        private void UiButtonQuery_Click(object? sender, EventArgs e)
        {
            LoadLogs();
        }

        private void UiButtonReset_Click(object? sender, EventArgs e)
        {
            uiDateTimePickerStart.Value = DateTime.Now.AddDays(-7);
            uiDateTimePickerEnd.Value = DateTime.Now;
            uiComboBoxLogType.SelectedIndex = 0;
            uiDataGridViewLogs.DataSource = null;
        }

        private void UiButtonExport_Click(object? sender, EventArgs e)
        {
            try
            {
                var dt = GetLogsForExportAsDataTable();
                if (dt == null || dt.Rows.Count == 0)
                {
                    UIHelper.ShowInfo("没有可导出的日志数据", "提示");
                    return;
                }

                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel文件|*.xlsx|CSV文件|*.csv";
                    saveFileDialog.Title = "导出日志";
                    saveFileDialog.FileName = $"日志_{DateTime.Now:yyyyMMddHHmmss}";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        bool success = ExcelHelper.Export(saveFileDialog.FileName, dt);
                        if (success)
                        {
                            UIHelper.ShowInfo("导出成功！", "成功");
                            LogHelper.Info($"导出日志到: {saveFileDialog.FileName}");
                        }
                        else
                        {
                            UIHelper.ShowError("导出失败！", "错误");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"导出失败: {ex.Message}", "错误");
                LogHelper.Error($"导出日志失败: {ex.Message}\n堆栈跟踪: {ex.StackTrace}");
            }
        }

        private void UiButtonOpenDir_Click(object? sender, EventArgs e)
        {
            try
            {
                var logPath = System.IO.Path.Combine(Application.StartupPath, "Logs");
                if (!System.IO.Directory.Exists(logPath))
                {
                    System.IO.Directory.CreateDirectory(logPath);
                }
                Process.Start(new ProcessStartInfo
                {
                    FileName = logPath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"打开日志目录失败: {ex.Message}", "错误");
                LogHelper.Error($"打开日志目录失败: {ex.Message}");
            }
        }

        private void LoadLogs()
        {
            try
            {
                DateTime startTime = uiDateTimePickerStart.Value.Date;
                DateTime endTime = uiDateTimePickerEnd.Value.Date.AddDays(1).AddSeconds(-1);
                string logType = uiComboBoxLogType.SelectedItem?.ToString() ?? "全部";

                var allLogs = new List<object>();

                if (logType == "全部" || logType == "报警日志")
                {
                    var alarmLogs = _logService.GetAlarmLogs(startTime, endTime);
                    allLogs.AddRange(alarmLogs.Select(x => new
                    {
                        LogTime = x.AlarmTime,
                        LogType = "报警日志",
                        Station = x.AlarmStation,
                        Content = x.AlarmContent
                    }));
                }

                if (logType == "全部" || logType == "操作日志")
                {
                    var operateLogs = _logService.GetOperateLogs(startTime, endTime);
                    allLogs.AddRange(operateLogs.Select(x => new
                    {
                        LogTime = x.OperateTime,
                        LogType = "操作日志",
                        Station = x.OperateModule,
                        Content = $"{x.UserName} - {x.OperateContent}"
                    }));
                }

                var sortedLogs = allLogs.OrderByDescending(x => ((dynamic)x).LogTime).ToList();
                uiDataGridViewLogs.DataSource = sortedLogs;

                ThemeManager.ApplyDataGridViewTheme(uiDataGridViewLogs);
            }
            catch (Exception ex)
            {
                UIHelper.ShowError($"加载日志失败: {ex.Message}", "错误");
                LogHelper.Error($"加载日志失败: {ex.Message}");
            }
        }

        private DataTable GetLogsForExportAsDataTable()
        {
            DateTime startTime = uiDateTimePickerStart.Value.Date;
            DateTime endTime = uiDateTimePickerEnd.Value.Date.AddDays(1).AddSeconds(-1);
            string logType = uiComboBoxLogType.SelectedItem?.ToString() ?? "全部";

            var allLogs = new List<(DateTime LogTime, string LogType, string Station, string Content)>();

            if (logType == "全部" || logType == "报警日志")
            {
                var alarmLogs = _logService.GetAlarmLogs(startTime, endTime);
                allLogs.AddRange(alarmLogs.Select(x => (
                    x.AlarmTime,
                    "报警日志",
                    x.AlarmStation ?? "",
                    x.AlarmContent ?? ""
                )));
            }

            if (logType == "全部" || logType == "操作日志")
            {
                var operateLogs = _logService.GetOperateLogs(startTime, endTime);
                allLogs.AddRange(operateLogs.Select(x => (
                    x.OperateTime,
                    "操作日志",
                    x.OperateModule ?? "",
                    $"{x.UserName} - {x.OperateContent}"
                )));
            }

            var sortedLogs = allLogs.OrderByDescending(x => x.LogTime).ToList();

            var dt = new DataTable();
            dt.Columns.Add("日志时间", typeof(string));
            dt.Columns.Add("日志类型", typeof(string));
            dt.Columns.Add("工位/模块", typeof(string));
            dt.Columns.Add("内容", typeof(string));

            foreach (var log in sortedLogs)
            {
                dt.Rows.Add(
                    log.LogTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    log.LogType,
                    log.Station,
                    log.Content
                );
            }

            return dt;
        }

        private void ApplyTheme()
        {
            ThemeManager.ApplyFormTheme(this);
            ThemeManager.ApplyDataGridViewTheme(uiDataGridViewLogs);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ThemeManager.ThemeChanged -= OnThemeChanged;
            base.OnFormClosing(e);
        }
    }
}
