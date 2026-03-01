using System.Text.Json;
using System.IO;
using System.Windows.Forms;

namespace Custom.HydrogenConfigurationSystem.Configs
{
    public class SystemConfig
    {
        public string SoftwareVersion { get; set; } = "V1.0.0";
        public int TrialDays { get; set; } = 30;
        public int LogCleanDays { get; set; } = 7;
        public string LogPath { get; set; } = "Logs";
        public string DefaultFont { get; set; } = "Microsoft YaHei";
        public int DefaultFontSize { get; set; } = 12;

        public static SystemConfig Load()
        {
            var filePath = Path.Combine(Application.StartupPath, "Configs", "system_config.json");
            
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<SystemConfig>(json) ?? new SystemConfig();
            }

            return new SystemConfig();
        }

        public void Save()
        {
            var filePath = Path.Combine(Application.StartupPath, "Configs", "system_config.json");
            var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
