using Custom.HydrogenConfigurationSystem.Helpers;
using Custom.HydrogenConfigurationSystem.Data.Entities;
using Custom.HydrogenConfigurationSystem.Data.DB;
using Custom.HydrogenConfigurationSystem.Globals;
using System.Data;
using ScottPlot;
using ScottPlot.WinForms;

namespace Custom.HydrogenConfigurationSystem.Forms
{
    public partial class FrmReportChart : Form
    {
        private FormsPlot? formsPlot;

        public FrmReportChart()
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
            uiComboBoxChartType.SelectedIndex = 0;

            InitializeChart();
        }

        private void InitializeChart()
        {
            formsPlot = new FormsPlot
            {
                Dock = DockStyle.Fill
            };

            uiPanelChart.Controls.Add(formsPlot);
        }

        private void BindEvents()
        {
            uiButtonQuery.Click += UiButtonQuery_Click;
            uiButtonExport.Click += UiButtonExport_Click;
            uiComboBoxChartType.SelectedIndexChanged += UiComboBoxChartType_SelectedIndexChanged;
        }

        private void UiButtonQuery_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startTime = uiDateTimePickerStart.Value;
                DateTime endTime = uiDateTimePickerEnd.Value;
                string chartType = uiComboBoxChartType.SelectedItem?.ToString() ?? "产氢量趋势";

                var productionDataService = new ProductionDataService();
                var productionData = productionDataService.GetList(startTime, endTime);

                ShowDataInGrid(productionData);
                UpdateChart(productionData, chartType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.Error($"报表查询失败: {ex.Message}");
            }
        }

        private void UiButtonExport_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startTime = uiDateTimePickerStart.Value;
                DateTime endTime = uiDateTimePickerEnd.Value;

                var productionDataService = new ProductionDataService();
                var productionData = productionDataService.GetList(startTime, endTime);

                string fileName = $"报表_{DateTime.Now:yyyyMMddHHmmss}.xlsx";
                string filePath = System.IO.Path.Combine(Application.StartupPath, "Reports", fileName);

                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(Application.StartupPath, "Reports"));

                bool success = ExcelHelper.Export(filePath, productionData);
                if (success)
                {
                    MessageBox.Show($"导出成功: {filePath}", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogHelper.Info($"报表导出成功: {filePath}");
                }
                else
                {
                    MessageBox.Show("导出失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("导出失败: " + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LogHelper.Error($"报表导出失败: {ex.Message}");
            }
        }

        private void UiComboBoxChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UiButtonQuery_Click(sender, e);
        }

        private void ShowDataInGrid(List<ProductionDataEntity> data)
        {
            uiDataGridViewReport.Columns.Clear();

            if (data.Count == 0)
            {
                uiDataGridViewReport.DataSource = null;
                UpdateStatistics(data, "产氢量趋势");
                return;
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("时间", typeof(DateTime));
            dt.Columns.Add("产氢量(m³)", typeof(double));
            dt.Columns.Add("能耗(kWh)", typeof(double));
            dt.Columns.Add("电解电流(A)", typeof(double));
            dt.Columns.Add("储氢压力(MPa)", typeof(double));
            dt.Columns.Add("氢气浓度(%)", typeof(double));

            foreach (var item in data)
            {
                dt.Rows.Add(
                    item.InsertTime,
                    item.HydrogenOutput,
                    item.EnergyConsumption,
                    item.ElectrolysisCurrent,
                    item.HydrogenPurity,
                    item.HydrogenConcentration
                );
            }

            uiDataGridViewReport.DataSource = dt;
            ThemeManager.ApplyDataGridViewTheme(uiDataGridViewReport);

            // 更新统计信息
            string chartType = uiComboBoxChartType.SelectedItem?.ToString() ?? "产氢量趋势";
            UpdateStatistics(data, chartType);
        }

        /// <summary>
        /// 更新统计信息
        /// </summary>
        private void UpdateStatistics(List<ProductionDataEntity> data, string chartType)
        {
            if (data.Count == 0)
            {
                uiLabelTotalCount.Text = "0";
                uiLabelMaxValue.Text = "0.00";
                uiLabelMinValue.Text = "0.00";
                uiLabelAvgValue.Text = "0.00";
                return;
            }

            uiLabelTotalCount.Text = data.Count.ToString();

            double[] values;
            string unit;

            switch (chartType)
            {
                case "能耗趋势":
                    values = data.Select(x => x.EnergyConsumption).ToArray();
                    unit = "kWh";
                    break;
                case "电解电流趋势":
                    values = data.Select(x => x.ElectrolysisCurrent).ToArray();
                    unit = "A";
                    break;
                case "储氢压力趋势":
                    values = data.Select(x => x.HydrogenPurity).ToArray();
                    unit = "MPa";
                    break;
                case "产氢量趋势":
                default:
                    values = data.Select(x => x.HydrogenOutput).ToArray();
                    unit = "m³";
                    break;
            }

            double max = values.Max();
            double min = values.Min();
            double avg = values.Average();

            uiLabelMaxValue.Text = $"{max:F2} {unit}";
            uiLabelMinValue.Text = $"{min:F2} {unit}";
            uiLabelAvgValue.Text = $"{avg:F2} {unit}";
        }

        private void UpdateChart(List<ProductionDataEntity> data, string chartType)
        {
            if (formsPlot == null || data.Count == 0)
            {
                return;
            }

            var sortedData = data.OrderBy(x => x.InsertTime).ToList();
            formsPlot.Plot.Clear();

            switch (chartType)
            {
                case "产氢量趋势":
                    CreateLineChart(sortedData, "产氢量 (m³)", x => x.HydrogenOutput, System.Drawing.Color.Blue);
                    break;
                case "能耗趋势":
                    CreateLineChart(sortedData, "能耗 (kWh)", x => x.EnergyConsumption, System.Drawing.Color.Orange);
                    break;
                case "电解电流趋势":
                    CreateLineChart(sortedData, "电解电流 (A)", x => x.ElectrolysisCurrent, System.Drawing.Color.Green);
                    break;
                case "储氢压力趋势":
                    CreateLineChart(sortedData, "储氢压力 (MPa)", x => x.HydrogenPurity, System.Drawing.Color.Red);
                    break;
                case "综合报表":
                    ShowCombinedChart(sortedData);
                    break;
                default:
                    CreateLineChart(sortedData, "产氢量 (m³)", x => x.HydrogenOutput, System.Drawing.Color.Blue);
                    break;
            }

            formsPlot.Refresh();
        }

        private void CreateLineChart(List<ProductionDataEntity> data, string seriesName, Func<ProductionDataEntity, double> valueSelector, System.Drawing.Color color)
        {
            if (formsPlot == null) return;

            double[] xs = Enumerable.Range(0, data.Count).Select(i => (double)i).ToArray();
            double[] ys = data.Select(valueSelector).ToArray();
            string[] labels = data.Select(x => x.InsertTime.ToString("MM-dd HH:mm")).ToArray();

            var scatter = formsPlot.Plot.Add.Scatter(xs, ys);
            scatter.Color = new ScottPlot.Color(color.R, color.G, color.B);
            scatter.LineWidth = 2;
            scatter.MarkerSize = 5;
            scatter.LegendText = seriesName;

            formsPlot.Plot.Title(seriesName);
            formsPlot.Plot.XLabel("时间");
            formsPlot.Plot.YLabel(seriesName);

            var tickPositions = xs.Where((x, i) => i % Math.Max(1, xs.Length / 10) == 0).ToArray();
            var tickLabels = labels.Where((x, i) => i % Math.Max(1, labels.Length / 10) == 0).ToArray();

            formsPlot.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(tickPositions, tickLabels);
            formsPlot.Plot.Axes.Bottom.TickLabelStyle.Rotation = 45;
            formsPlot.Plot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleLeft;

            formsPlot.Plot.ShowLegend();
        }

        private void ShowCombinedChart(List<ProductionDataEntity> data)
        {
            if (formsPlot == null) return;

            double[] xs = Enumerable.Range(0, data.Count).Select(i => (double)i).ToArray();
            string[] labels = data.Select(x => x.InsertTime.ToString("MM-dd HH:mm")).ToArray();

            var series1 = formsPlot.Plot.Add.Scatter(xs, data.Select(x => x.HydrogenOutput).ToArray());
            series1.Color = new ScottPlot.Color(System.Drawing.Color.Blue.R, System.Drawing.Color.Blue.G, System.Drawing.Color.Blue.B);
            series1.LineWidth = 2;
            series1.LegendText = "产氢量 (m³)";

            var series2 = formsPlot.Plot.Add.Scatter(xs, data.Select(x => x.EnergyConsumption).ToArray());
            series2.Color = new ScottPlot.Color(System.Drawing.Color.Orange.R, System.Drawing.Color.Orange.G, System.Drawing.Color.Orange.B);
            series2.LineWidth = 2;
            series2.LegendText = "能耗 (kWh)";

            var series3 = formsPlot.Plot.Add.Scatter(xs, data.Select(x => x.ElectrolysisCurrent).ToArray());
            series3.Color = new ScottPlot.Color(System.Drawing.Color.Green.R, System.Drawing.Color.Green.G, System.Drawing.Color.Green.B);
            series3.LineWidth = 2;
            series3.LegendText = "电解电流 (A)";

            var series4 = formsPlot.Plot.Add.Scatter(xs, data.Select(x => x.HydrogenPurity).ToArray());
            series4.Color = new ScottPlot.Color(System.Drawing.Color.Red.R, System.Drawing.Color.Red.G, System.Drawing.Color.Red.B);
            series4.LineWidth = 2;
            series4.LegendText = "储氢压力 (MPa)";

            formsPlot.Plot.Title("综合报表");
            formsPlot.Plot.XLabel("时间");
            formsPlot.Plot.YLabel("数值");

            var tickPositions = xs.Where((x, i) => i % Math.Max(1, xs.Length / 10) == 0).ToArray();
            var tickLabels = labels.Where((x, i) => i % Math.Max(1, labels.Length / 10) == 0).ToArray();

            formsPlot.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(tickPositions, tickLabels);
            formsPlot.Plot.Axes.Bottom.TickLabelStyle.Rotation = 45;
            formsPlot.Plot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleLeft;

            formsPlot.Plot.ShowLegend();
        }

        private void ApplyTheme()
        {
            ThemeManager.ApplyFormTheme(this);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ThemeManager.ThemeChanged -= OnThemeChanged;
            base.OnFormClosing(e);
        }
    }
}
