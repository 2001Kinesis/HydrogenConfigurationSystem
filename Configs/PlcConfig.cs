using System;
using HslCommunication.Profinet.Siemens;
using System.Text.Json;
using System.Windows.Forms;
using System.IO;

namespace Custom.HydrogenConfigurationSystem.Configs
{
    public class PlcConfig
    {
        public string PlcIp { get; set; } = "127.0.0.1";
        public int PlcPort { get; set; } = 102;
        public SiemensPLCS CpuType { get; set; } = SiemensPLCS.S1200;
        public byte Rack { get; set; } = 0;
        public byte Slot { get; set; } = 1;
        public int ReadInterval { get; set; } = 1000;
        public int ReConnectInterval { get; set; } = 2000;

        public static PlcConfig Load()
        {
            var filePath = Path.Combine(Application.StartupPath, "Configs", "plc_config.ini");
            
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                var config = new PlcConfig();
                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    var parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        switch (parts[0].Trim())
                        {
                            case "PlcIp":
                                config.PlcIp = parts[1].Trim();
                                break;
                            case "PlcPort":
                                if (int.TryParse(parts[1].Trim(), out int port))
                                    config.PlcPort = port;
                                break;
                            case "CpuType":
                                if (int.TryParse(parts[1].Trim(), out int cpuType))
                                    config.CpuType = (SiemensPLCS)cpuType;
                                break;
                            case "Rack":
                                config.Rack = byte.Parse(parts[1].Trim());
                                break;
                            case "Slot":
                                config.Slot = byte.Parse(parts[1].Trim());
                                break;
                            case "ReadInterval":
                                if (int.TryParse(parts[1].Trim(), out int interval))
                                    config.ReadInterval = interval;
                                break;
                            case "ReConnectInterval":
                                if (int.TryParse(parts[1].Trim(), out int reconnect))
                                    config.ReConnectInterval = reconnect;
                                break;
                        }
                    }
                }
                return config;
            }

            return new PlcConfig();
        }

        public void Save()
        {
            var filePath = Path.Combine(Application.StartupPath, "Configs", "plc_config.ini");
            var content = $"PlcIp={PlcIp}\n" +
                         $"PlcPort={PlcPort}\n" +
                         $"CpuType={(int)CpuType}\n" +
                         $"Rack={Rack}\n" +
                         $"Slot={Slot}\n" +
                         $"ReadInterval={ReadInterval}\n" +
                         $"ReConnectInterval={ReConnectInterval}";
            File.WriteAllText(filePath, content);
        }
    }
}
