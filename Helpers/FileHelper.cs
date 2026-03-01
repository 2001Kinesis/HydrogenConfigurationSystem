using Custom.HydrogenConfigurationSystem.Configs;
using System.Diagnostics;
using System.Text.Json;

namespace Custom.HydrogenConfigurationSystem.Helpers
{
    public class FileHelper
    {
        public static void CreateDirectoryIfNotExists(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public static void OpenFolder(string path)
        {
            if (Directory.Exists(path))
            {
                Process.Start(new ProcessStartInfo()
                {
                    FileName = "explorer.exe",
                    Arguments = path,
                    UseShellExecute = true
                });
            }
        }

        public static void CleanOldLogs(string logPath, int days)
        {
            if (Directory.Exists(logPath))
            {
                var files = Directory.GetFiles(logPath, "*.log", SearchOption.AllDirectories);
                var cutoffDate = DateTime.Now.AddDays(-days);

                foreach (var file in files)
                {
                    var fileInfo = new FileInfo(file);
                    if (fileInfo.CreationTime < cutoffDate)
                    {
                        try
                        {
                            File.Delete(file);
                        }
                        catch
                        {
                        }
                    }
                }
            }
        }

        public static T LoadJsonFile<T>(string filePath) where T : class, new()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(json) ?? new T();
            }
            return new T();
        }

        public static void SaveJsonFile<T>(string filePath, T data)
        {
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
