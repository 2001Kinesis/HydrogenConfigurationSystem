using System.IO;
using System.Linq;

namespace Custom.HydrogenConfigurationSystem.Globals
{
    /// <summary>
    /// 主题管理器 - 仅切换窗体和面板背景色
    /// 保留所有控件原有样式（按钮颜色、数据颜色等）
    /// </summary>
    public static class ThemeManager
    {
        #region 颜色定义

        // 深色模式颜色
        public static class Dark
        {
            public static readonly Color Background = Color.FromArgb(18, 22, 33);
            public static readonly Color PanelBackground = Color.FromArgb(30, 35, 48);
            public static readonly Color TextColor = Color.FromArgb(255, 255, 255);
            public static readonly Color LabelColor = Color.FromArgb(176, 182, 195);
            public static readonly Color TitleColor = Color.FromArgb(56, 189, 248);
            public static readonly Color BorderColor = Color.FromArgb(60, 70, 90);
            public static readonly Color TextBoxBack = Color.FromArgb(30, 41, 59);
            public static readonly Color GridBack = Color.FromArgb(24, 28, 40);
            public static readonly Color GridFore = Color.FromArgb(255, 255, 255);
            public static readonly Color GridHeaderBack = Color.FromArgb(45, 55, 72);
            public static readonly Color GridHeaderFore = Color.FromArgb(255, 255, 255);
            public static readonly Color GridAlternatingBack = Color.FromArgb(30, 35, 48);
        }

        // 浅色模式颜色
        public static class Light
        {
            public static readonly Color Background = Color.FromArgb(255, 255, 255);
            public static readonly Color PanelBackground = Color.FromArgb(248, 250, 252);
            public static readonly Color TextColor = Color.FromArgb(15, 23, 42);
            public static readonly Color LabelColor = Color.FromArgb(71, 85, 105);
            public static readonly Color TitleColor = Color.FromArgb(30, 64, 175);
            public static readonly Color BorderColor = Color.FromArgb(148, 163, 184);
            public static readonly Color TextBoxBack = Color.FromArgb(255, 255, 255);
            public static readonly Color GridBack = Color.FromArgb(255, 255, 255);
            public static readonly Color GridFore = Color.FromArgb(15, 23, 42);
            public static readonly Color GridHeaderBack = Color.FromArgb(226, 232, 240);
            public static readonly Color GridHeaderFore = Color.FromArgb(15, 23, 42);
            public static readonly Color GridAlternatingBack = Color.FromArgb(248, 250, 252);
        }

        #endregion

        public static bool IsDarkMode { get; private set; } = true;

        public static event EventHandler? ThemeChanged;

        private static readonly string SettingFile = Path.Combine(Application.StartupPath, "Configs", "theme.json");

        public static void Initialize()
        {
            LoadThemeSetting();
        }

        public static void LoadThemeSetting()
        {
            if (File.Exists(SettingFile))
            {
                try
                {
                    var json = File.ReadAllText(SettingFile);
                    var settings = System.Text.Json.JsonSerializer.Deserialize<ThemeSettings>(json);
                    IsDarkMode = settings?.DarkMode ?? true;
                }
                catch
                {
                    IsDarkMode = true;
                }
            }
            else
            {
                IsDarkMode = true;
            }
        }

        public static void SaveThemeSetting(bool isDarkMode)
        {
            IsDarkMode = isDarkMode;

            string? directory = Path.GetDirectoryName(SettingFile);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var settings = new ThemeSettings { DarkMode = isDarkMode };
            var json = System.Text.Json.JsonSerializer.Serialize(settings, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(SettingFile, json);

            ThemeChanged?.Invoke(null, EventArgs.Empty);
        }

        public static void ToggleTheme()
        {
            SaveThemeSetting(!IsDarkMode);
        }

        /// <summary>
        /// 应用窗体主题 - 仅修改窗体和面板背景色
        /// </summary>
        public static void ApplyFormTheme(Form form)
        {
            if (form == null || form.IsDisposed) return;

            form.BackColor = IsDarkMode ? Dark.Background : Light.Background;

            ApplyControlsTheme(form.Controls);
        }

        /// <summary>
        /// 应用控件主题 - 仅处理 Panel 和 SunnyUI 的 UIPanel/UIForm
        /// </summary>
        public static void ApplyControlsTheme(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                ApplyControlTheme(control);

                if (control.Controls.Count > 0)
                {
                    ApplyControlsTheme(control.Controls);
                }
            }
        }

        /// <summary>
        /// 应用单个控件主题 - 修改背景色和标签文字颜色，保留其他样式
        /// </summary>
        public static void ApplyControlTheme(Control control)
        {
            if (control == null || control.IsDisposed) return;

            var controlType = control.GetType();
            var typeName = controlType.FullName ?? "";

            // 处理 SunnyUI 控件
            if (typeName.Contains("Sunny.UI"))
            {
                ApplySunnyUIControlTheme(control, typeName);
                return;
            }

            // 标准 Windows 控件
            switch (control)
            {
                case Panel panel:
                    panel.BackColor = IsDarkMode ? Dark.PanelBackground : Light.PanelBackground;
                    break;

                case Label label:
                    // uiLabel2 (系统授权) 保持固定的青蓝色，不随主题变化
                    if (label.Name == "uiLabel2")
                    {
                        label.ForeColor = Color.FromArgb(56, 189, 248); // 青蓝色
                    }
                    // 只处理在浅色模式下不宜观察的白色/浅色标题文字
                    // 保留所有按钮颜色、数据颜色和其他鲜艳的颜色
                    else if (IsLightColorText(label.Text))
                    {
                        label.ForeColor = IsDarkMode ? Dark.TextColor : Light.TextColor;
                    }
                    // 其他所有标签保持原有颜色不变
                    break;

                case CheckBox checkBox:
                    // 处理 CheckBox 的文字颜色
                    if (IsLightColorText(checkBox.Text))
                    {
                        checkBox.ForeColor = IsDarkMode ? Dark.TextColor : Light.TextColor;
                    }
                    break;

                case TextBox textBox:
                    // 处理 TextBox 背景色和文字颜色
                    textBox.BackColor = IsDarkMode ? Dark.TextBoxBack : Light.TextBoxBack;
                    textBox.ForeColor = IsDarkMode ? Dark.TextColor : Light.TextColor;
                    break;

                case DataGridView dataGridView:
                    // 处理 DataGridView 主题
                    ApplyDataGridViewTheme(dataGridView);
                    break;

                case ListBox listBox:
                    // 处理 ListBox 背景色和文字颜色
                    listBox.BackColor = IsDarkMode ? Dark.TextBoxBack : Light.TextBoxBack;
                    listBox.ForeColor = IsDarkMode ? Dark.TextColor : Light.TextColor;
                    break;

                case ComboBox comboBox:
                    // 处理 ComboBox 背景色和文字颜色
                    comboBox.BackColor = IsDarkMode ? Dark.TextBoxBack : Light.TextBoxBack;
                    comboBox.ForeColor = IsDarkMode ? Dark.TextColor : Light.TextColor;
                    break;
            }
        }

        /// <summary>
        /// 应用 SunnyUI 控件主题 - 修改背景色和标签文字颜色
        /// </summary>
        private static void ApplySunnyUIControlTheme(Control control, string typeName)
        {
            try
            {
                // 处理面板和窗体背景色
                if (typeName.Contains("UIPanel") || typeName.Contains("UIGroupBox"))
                {
                    var fillColorProp = control.GetType().GetProperty("FillColor");
                    fillColorProp?.SetValue(control, IsDarkMode ? Dark.PanelBackground : Light.PanelBackground);
                }
                else if (typeName.Contains("UIForm") || typeName.Contains("UIPage") || typeName.Contains("UITabControl"))
                {
                    var fillColorProp = control.GetType().GetProperty("FillColor");
                    fillColorProp?.SetValue(control, IsDarkMode ? Dark.Background : Light.Background);
                }
                // 处理 UILabel 文字颜色
                else if (typeName.Contains("UILabel"))
                {
                    var textProp = control.GetType().GetProperty("Text");
                    var text = textProp?.GetValue(control)?.ToString() ?? "";

                    // uiLabel2 (系统授权) 保持固定的青蓝色，不随主题变化
                    if (control.Name == "uiLabel2")
                    {
                        var foreColorProp = control.GetType().GetProperty("ForeColor");
                        foreColorProp?.SetValue(control, Color.FromArgb(56, 189, 248)); // 青蓝色
                    }
                    // 只处理在浅色模式下不宜观察的白色/浅色标题文字
                    else if (IsLightColorText(text))
                    {
                        var foreColorProp = control.GetType().GetProperty("ForeColor");
                        foreColorProp?.SetValue(control, IsDarkMode ? Dark.TextColor : Light.TextColor);
                    }
                }
                // 处理 UICheckBox 文字颜色
                else if (typeName.Contains("UICheckBox"))
                {
                    var textProp = control.GetType().GetProperty("Text");
                    var text = textProp?.GetValue(control)?.ToString() ?? "";

                    // 只处理在浅色模式下不宜观察的白色/浅色标题文字
                    if (IsLightColorText(text))
                    {
                        var foreColorProp = control.GetType().GetProperty("ForeColor");
                        foreColorProp?.SetValue(control, IsDarkMode ? Dark.TextColor : Light.TextColor);
                    }
                }
                // 处理 UITextBox 背景色和文字颜色
                else if (typeName.Contains("UITextBox"))
                {
                    var fillColorProp = control.GetType().GetProperty("FillColor");
                    fillColorProp?.SetValue(control, IsDarkMode ? Dark.TextBoxBack : Light.TextBoxBack);

                    var foreColorProp = control.GetType().GetProperty("ForeColor");
                    foreColorProp?.SetValue(control, IsDarkMode ? Dark.TextColor : Light.TextColor);
                }
                // 处理 UIDataGridView 背景色
                else if (typeName.Contains("UIDataGridView"))
                {
                    var fillColorProp = control.GetType().GetProperty("FillColor");
                    fillColorProp?.SetValue(control, IsDarkMode ? Dark.PanelBackground : Light.PanelBackground);

                    var backColorProp = control.GetType().GetProperty("BackColor");
                    backColorProp?.SetValue(control, IsDarkMode ? Dark.GridBack : Light.GridBack);

                    var foreColorProp = control.GetType().GetProperty("ForeColor");
                    foreColorProp?.SetValue(control, IsDarkMode ? Dark.GridFore : Light.GridFore);
                }
                // 处理 UIListBox 背景色和文字颜色
                else if (typeName.Contains("UIListBox"))
                {
                    var fillColorProp = control.GetType().GetProperty("FillColor");
                    fillColorProp?.SetValue(control, IsDarkMode ? Dark.TextBoxBack : Light.TextBoxBack);

                    var foreColorProp = control.GetType().GetProperty("ForeColor");
                    foreColorProp?.SetValue(control, IsDarkMode ? Dark.TextColor : Light.TextColor);
                }
                // 处理 UIComboBox 背景色和文字颜色
                else if (typeName.Contains("UIComboBox"))
                {
                    var fillColorProp = control.GetType().GetProperty("FillColor");
                    fillColorProp?.SetValue(control, IsDarkMode ? Dark.TextBoxBack : Light.TextBoxBack);

                    var foreColorProp = control.GetType().GetProperty("ForeColor");
                    foreColorProp?.SetValue(control, IsDarkMode ? Dark.TextColor : Light.TextColor);
                }
                // 注意：不处理 UIButton 等控件
                // 保留它们原有的颜色样式
            }
            catch
            {
                // 忽略反射错误
            }
        }

        /// <summary>
        /// 应用 DataGridView 主题 - 仅修改背景和边框，保留数据颜色
        /// </summary>
        public static void ApplyDataGridViewTheme(DataGridView dataGridView)
        {
            if (dataGridView == null) return;

            dataGridView.BackgroundColor = IsDarkMode ? Dark.PanelBackground : Light.PanelBackground;
            dataGridView.DefaultCellStyle.BackColor = IsDarkMode ? Dark.GridBack : Light.GridBack;
            dataGridView.DefaultCellStyle.ForeColor = IsDarkMode ? Dark.GridFore : Light.GridFore;
            dataGridView.DefaultCellStyle.SelectionBackColor = IsDarkMode ? Dark.TitleColor : Light.TitleColor;
            dataGridView.DefaultCellStyle.SelectionForeColor = IsDarkMode ? Color.Black : Color.White;

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = IsDarkMode ? Dark.GridHeaderBack : Light.GridHeaderBack;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = IsDarkMode ? Dark.GridHeaderFore : Light.GridHeaderFore;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("微软雅黑", 10, FontStyle.Bold);

            dataGridView.RowHeadersDefaultCellStyle.BackColor = IsDarkMode ? Dark.GridHeaderBack : Light.GridHeaderBack;
            dataGridView.RowHeadersDefaultCellStyle.ForeColor = IsDarkMode ? Dark.GridHeaderFore : Light.GridHeaderFore;

            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = IsDarkMode ? Dark.GridAlternatingBack : Light.GridAlternatingBack;
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = IsDarkMode ? Dark.GridFore : Light.GridFore;

            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = IsDarkMode ? Dark.BorderColor : Light.BorderColor;
            dataGridView.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// 判断文本是否为需要在浅色模式下变色的标题
        /// 这些标题在深色模式下通常是白色/浅色，在浅色背景下不易观察
        /// </summary>
        private static bool IsLightColorText(string? text)
        {
            if (string.IsNullOrEmpty(text)) return false;

            // 系统总览页面
            string[] dashboardTitles = { "环境监控", "生产统计" };

            // 实时监控页面 - 工位标题
            string[] monitorTitles = { "电解槽工位", "纯化工位", "储氢工位", "加氢工位", "冷却工位", "检测工位", "输送工位" };

            // 设备控制页面
            string[] controlTitles = { "总控制", "工位控制" };

            // 页面主标题
            string[] pageTitles = { "系统总览", "实时监控", "设备控制", "日志查询", "配方管理", "用户管理", "系统配置", "报表图表" };

            // 系统配置页面
            string[] configTitles = { "激活码" };

            // 用户管理页面 - 角色权限模块
            string[] userManagerTitles = { "控制模块", "日志模块", "监控模块", "报表模块", "配方模块", "配置模块", "用户模块" };

            // 组合所有需要处理的标题
            string[] allTitles = dashboardTitles
                .Concat(monitorTitles)
                .Concat(controlTitles)
                .Concat(pageTitles)
                .Concat(configTitles)
                .Concat(userManagerTitles)
                .ToArray();

            foreach (var title in allTitles)
            {
                if (text == title)
                {
                    return true;
                }
            }

            return false;
        }

        public static Color GetBackgroundColor() => IsDarkMode ? Dark.Background : Light.Background;

        public static Color GetPanelBackgroundColor() => IsDarkMode ? Dark.PanelBackground : Light.PanelBackground;

        public static Color GetTextColor() => IsDarkMode ? Dark.TextColor : Light.TextColor;

        public static Color GetLabelColor() => IsDarkMode ? Dark.LabelColor : Light.LabelColor;

        public static Color GetTitleColor() => IsDarkMode ? Dark.TitleColor : Light.TitleColor;

        public static Color GetBorderColor() => IsDarkMode ? Dark.BorderColor : Light.BorderColor;
    }

    public class ThemeSettings
    {
        public bool DarkMode { get; set; } = true;
    }
}
