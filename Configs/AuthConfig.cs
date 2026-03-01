using System.Text.Json;
using System.IO;
using System;

namespace Custom.HydrogenConfigurationSystem.Configs
{
    public class AuthConfig
    {
        public string AuthType { get; set; } = "Trial";
        public DateTime ExpiryDate { get; set; } = DateTime.Now.AddYears(1);
        public string DeviceId { get; set; } = string.Empty;

        public static AuthConfig Load()
        {
            var startupPath = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(startupPath, "Configs", "auth.json");
            
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<AuthConfig>(json) ?? new AuthConfig();
            }

            return new AuthConfig();
        }

        public void Save()
        {
            var startupPath = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(startupPath, "Configs", "auth.json");
            var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}