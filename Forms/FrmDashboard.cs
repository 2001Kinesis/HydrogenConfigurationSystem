using Custom.HydrogenConfigurationSystem.Globals;

namespace Custom.HydrogenConfigurationSystem.Forms
{
    public partial class FrmDashboard : System.Windows.Forms.Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            UpdateData();
        }

        private void UpdateData()
        {
            UpdateEnvironmentPanel();
            UpdateProductionPanel();
        }

        private void UpdateEnvironmentPanel()
        {
            if (GlobalVariables.DataDic.TryGetValue("环境温度", out var tempValue))
                uiLabelEnvTempValue.Text = FormatValue(tempValue, "F1");

            if (GlobalVariables.DataDic.TryGetValue("环境湿度", out var humidityValue))
                uiLabelEnvHumidityValue.Text = FormatValue(humidityValue, "F1");

            if (GlobalVariables.DataDic.TryGetValue("氢气浓度", out var hydrogenValue))
                uiLabelEnvHydrogenValue.Text = FormatValue(hydrogenValue, "F2");
        }

        private void UpdateProductionPanel()
        {
            if (GlobalVariables.DataDic.TryGetValue("产氢量", out var hydrogenOutputValue))
                uiLabelProdHydrogenValue.Text = FormatValue(hydrogenOutputValue, "F1");

            if (GlobalVariables.DataDic.TryGetValue("生产实时能耗", out var energyValue))
                uiLabelProdEnergyValue.Text = FormatValue(energyValue, "F1");

            if (GlobalVariables.DataDic.TryGetValue("累计产氢量", out var totalValue))
                uiLabelProdTotalValue.Text = FormatValue(totalValue, "F1");
        }

        private string FormatValue(object value, string format)
        {
            if (value == null)
                return "--";

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
    }
}
