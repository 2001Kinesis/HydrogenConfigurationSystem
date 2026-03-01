using Custom.HydrogenConfigurationSystem.Globals;
using Custom.HydrogenConfigurationSystem.Helpers;
using System.Data;
using System.IO;

namespace Custom.HydrogenConfigurationSystem.PlcComm
{
    public static class PlcVarConfigHelper
    {
        public static void LoadPlcVarConfig()
        {
            var startupPath = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = Path.Combine(startupPath, "Configs", "plc_var_config.xlsx");

            if (!File.Exists(filePath))
            {
                filePath = Path.Combine(startupPath, "Configs", "plc_var_config.csv");
            }

            if (!File.Exists(filePath))
            {
                LoadDefaultPlcVarConfig();
                return;
            }

            try
            {
                GlobalVariables.PlcVarConfigList.Clear();
                var dt = ExcelHelper.Import(filePath);

                foreach (DataRow row in dt.Rows)
                {
                    var config = new PlcVarConfigModel();
                    
                    if (row.Table.Columns.Contains("变量名称"))
                        config.变量名称 = row["变量名称"]?.ToString() ?? "";
                    else if (row.Table.Columns.Contains("参数名称"))
                        config.变量名称 = row["参数名称"]?.ToString() ?? "";
                    
                    if (row.Table.Columns.Contains("PLC地址"))
                        config.PLC地址 = row["PLC地址"]?.ToString() ?? "";
                    
                    if (row.Table.Columns.Contains("数据类型"))
                        config.数据类型 = row["数据类型"]?.ToString() ?? "";
                    
                    if (row.Table.Columns.Contains("读写属性"))
                        config.读写属性 = row["读写属性"]?.ToString() ?? "R";
                    
                    if (row.Table.Columns.Contains("所属模块"))
                        config.所属模块 = row["所属模块"]?.ToString() ?? "";
                    
                    if (row.Table.Columns.Contains("采集间隔"))
                        config.采集间隔 = row["采集间隔"]?.ToString() ?? "-";
                    
                    if (row.Table.Columns.Contains("备注"))
                        config.备注 = row["备注"]?.ToString() ?? "";

                    if (!string.IsNullOrEmpty(config.变量名称) && !string.IsNullOrEmpty(config.PLC地址))
                    {
                        GlobalVariables.PlcVarConfigList.Add(config);
                        
                        var readWrite = config.读写属性;
                        var paramName = config.变量名称;
                        var plcAddress = config.PLC地址;

                        if (readWrite.Contains("R") || readWrite.Contains("r"))
                        {
                            GlobalVariables.ReadDic[paramName] = plcAddress;
                        }

                        if (readWrite.Contains("W") || readWrite.Contains("w"))
                        {
                            GlobalVariables.WriteDic[paramName] = plcAddress;
                        }

                        if (string.IsNullOrEmpty(readWrite) || readWrite == "R")
                        {
                            GlobalVariables.ReadDic[paramName] = plcAddress;
                        }
                    }
                }

                LogHelper.Info($"PLC变量配置加载完成，读取变量: {GlobalVariables.ReadDic.Count}，写入变量: {GlobalVariables.WriteDic.Count}，总配置: {GlobalVariables.PlcVarConfigList.Count}");
            }
            catch (Exception ex)
            {
                LogHelper.Error($"加载PLC变量配置失败: {ex.Message}");
                LoadDefaultPlcVarConfig();
            }
        }

        private static void LoadDefaultPlcVarConfig()
        {
            GlobalVariables.ReadDic.Clear();
            GlobalVariables.WriteDic.Clear();
            GlobalVariables.PlcVarConfigList.Clear();

            AddDefaultPlcVar("氢气浓度", "DB1.DBD19", "Real", "R", "环境监控", "300", "精度1位，量程：0~10%VOL，阈值4%（爆炸下限）");
            AddDefaultPlcVar("产氢量", "DB1.DBD99", "Real", "R", "生产统计", "500", "精度1位，单位：Nm³/h");
            AddDefaultPlcVar("累计产氢量", "DB1.DBD103", "Real", "R", "生产统计", "500", "精度1位，单位：Nm³，PLC掉电保持");
            AddDefaultPlcVar("生产实时能耗", "DB1.DBD115", "Real", "R", "生产统计", "500", "精度1位，单位：kWh/Nm³");
            AddDefaultPlcVar("累计生产能耗", "DB1.DBD119", "Real", "R", "生产统计", "500", "精度1位，单位：kWh，PLC掉电保持");
            AddDefaultPlcVar("系统状态", "DB1.DBX4.0", "Bool", "R", "总控制", "-", "1=运行，0=停止");
            AddDefaultPlcVar("电解电流", "DB1.DBD35", "Real", "RW", "电解槽", "300", "精度1位，量程：0~500A，配方可设上下限");
            AddDefaultPlcVar("储氢压力", "DB1.DBD47", "Real", "RW", "储氢", "300", "精度1位，量程：0~40MPa，配方可设定值");
            AddDefaultPlcVar("环境温度", "DB1.DBD11", "Real", "R", "环境监控", "300", "精度1位，量程：-20~80℃");
            AddDefaultPlcVar("环境湿度", "DB1.DBD15", "Real", "R", "环境监控", "300", "精度1位，量程：0~100%RH");
            AddDefaultPlcVar("氢气纯度", "DB1.DBD59", "Real", "R", "检测", "300", "精度1位，量程：99.0~99.999%");

            AddDefaultPlcVar("电解槽运行状态", "DB1.DBX4.2", "Bool", "R", "电解槽", "-", "1=运行，0=停止");
            AddDefaultPlcVar("纯化装置运行状态", "DB1.DBX4.5", "Bool", "R", "纯化", "-", "1=运行，0=停止");
            AddDefaultPlcVar("储氢罐运行状态", "DB1.DBX4.7", "Bool", "R", "储氢", "-", "1=运行，0=停止");
            AddDefaultPlcVar("加氢机运行状态", "DB1.DBX5.1", "Bool", "R", "加氢", "-", "1=运行，0=停止");
            AddDefaultPlcVar("冷却系统运行状态", "DB1.DBX5.3", "Bool", "R", "冷却", "-", "1=运行，0=停止");
            AddDefaultPlcVar("检测设备运行状态", "DB1.DBX5.5", "Bool", "R", "检测", "-", "1=运行，0=停止");
            AddDefaultPlcVar("输送泵运行状态", "DB1.DBX5.7", "Bool", "R", "输送", "-", "1=运行，0=停止");

            AddDefaultPlcVar("电解槽工作电压", "DB1.DBD63", "Real", "R", "电解槽", "300", "精度1位，量程：0~50V");
            AddDefaultPlcVar("电解槽区域温度", "DB1.DBD67", "Real", "R", "电解槽", "300", "精度1位，量程：0~150℃");
            AddDefaultPlcVar("电解液液位", "DB1.DBD71", "Real", "R", "电解槽", "300", "精度1位，量程：0~100%（满液）");

            AddDefaultPlcVar("纯化工位工作压力", "DB1.DBD75", "Real", "RW", "纯化", "300", "精度1位，量程：0~10MPa，配方可设上下限");
            AddDefaultPlcVar("纯化工位区域温度", "DB1.DBD79", "Real", "R", "纯化", "300", "精度1位，量程：0~100℃");
            AddDefaultPlcVar("纯化工位氢气纯度", "DB1.DBD83", "Real", "R", "纯化", "300", "精度1位，量程：99.0~99.999%");

            AddDefaultPlcVar("储氢罐压力", "DB1.DBD87", "Real", "R", "储氢", "300", "精度1位，量程：0~40MPa");
            AddDefaultPlcVar("储氢罐温度", "DB1.DBD91", "Real", "R", "储氢", "300", "精度1位，量程：-20~60℃");
            AddDefaultPlcVar("储氢罐液位", "DB1.DBD95", "Real", "R", "储氢", "300", "精度1位，量程：0~100%（满罐）");

            AddDefaultPlcVar("加氢机流量", "DB1.DBD103", "Real", "RW", "加氢", "300", "精度1位，量程：0~100Nm³/h，配方可设上限");

            AddDefaultPlcVar("冷却系统出水温度", "DB1.DBD107", "Real", "RW", "冷却", "300", "精度1位，量程：0~50℃，配方可设定值");
            AddDefaultPlcVar("冷却系统回水温度", "DB1.DBD111", "Real", "R", "冷却", "300", "精度1位，量程：0~80℃");

            AddDefaultPlcVar("检测工位最终纯度", "DB1.DBD115", "Real", "R", "检测", "300", "精度1位，量程：99.0~99.999%");

            AddDefaultPlcVar("输送工位工作压力", "DB1.DBD119", "Real", "R", "输送", "300", "精度1位，量程：0~5MPa");

            AddDefaultPlcVar("生产线总启动", "DB1.DBX1.0", "Bool", "W", "总控制", "-", "1=启动，0=无操作，PLC互锁：总停止优先");
            AddDefaultPlcVar("生产线总停止", "DB1.DBX1.1", "Bool", "W", "总控制", "-", "1=停止，0=无操作，最高优先级");
            AddDefaultPlcVar("氢能压缩机复位", "DB1.DBX1.2", "Bool", "W", "总控制", "-", "1=复位，0=无操作，复位后自动置0");
            AddDefaultPlcVar("系统报警复位", "DB1.DBX1.3", "Bool", "W", "总控制", "-", "1=复位，0=无操作，复位后自动置0");
            AddDefaultPlcVar("生产线空运行", "DB1.DBX1.4", "Bool", "W", "总控制", "-", "1=空运行，0=正常生产");
            AddDefaultPlcVar("电解槽工位启动", "DB1.DBX1.5", "Bool", "W", "电解槽", "-", "1=启动，0=无操作，需总启动前置");
            AddDefaultPlcVar("电解槽工位停止", "DB1.DBX1.6", "Bool", "W", "电解槽", "-", "1=停止，0=无操作");
            AddDefaultPlcVar("纯化工位启动", "DB1.DBX1.7", "Bool", "W", "纯化", "-", "1=启动，0=无操作，需总启动前置");
            AddDefaultPlcVar("纯化工位停止", "DB1.DBX2.0", "Bool", "W", "纯化", "-", "1=停止，0=无操作");
            AddDefaultPlcVar("储氢工位启动", "DB1.DBX2.1", "Bool", "W", "储氢", "-", "1=启动，0=无操作，需总启动前置");
            AddDefaultPlcVar("储氢工位停止", "DB1.DBX2.2", "Bool", "W", "储氢", "-", "1=停止，0=无操作");
            AddDefaultPlcVar("加氢工位启动", "DB1.DBX2.3", "Bool", "W", "加氢", "-", "1=启动，0=无操作，需总启动前置");
            AddDefaultPlcVar("加氢工位停止", "DB1.DBX2.4", "Bool", "W", "加氢", "-", "1=停止，0=无操作");
            AddDefaultPlcVar("冷却工位启动", "DB1.DBX2.5", "Bool", "W", "冷却", "-", "1=启动，0=无操作，需总启动前置");
            AddDefaultPlcVar("冷却工位停止", "DB1.DBX2.6", "Bool", "W", "冷却", "-", "1=停止，0=无操作");
            AddDefaultPlcVar("检测工位启动", "DB1.DBX2.7", "Bool", "W", "检测", "-", "1=启动，0=无操作，需总启动前置");
            AddDefaultPlcVar("检测工位停止", "DB1.DBX3.0", "Bool", "W", "检测", "-", "1=停止，0=无操作");
            AddDefaultPlcVar("输送工位启动", "DB1.DBX3.1", "Bool", "W", "输送", "-", "1=启动，0=无操作，需总启动前置");
            AddDefaultPlcVar("输送工位停止", "DB1.DBX3.2", "Bool", "W", "输送", "-", "1=停止，0=无操作");

            // 配方参数（配方下发用）
            AddDefaultPlcVar("电解电流下限", "DB1.DBD123", "Real", "RW", "配方", "-", "配方参数，精度1位，量程：0~500A");
            AddDefaultPlcVar("电解电流上限", "DB1.DBD127", "Real", "RW", "配方", "-", "配方参数，精度1位，量程：0~500A");
            AddDefaultPlcVar("纯化压力下限", "DB1.DBD131", "Real", "RW", "配方", "-", "配方参数，精度1位，量程：0~10MPa");
            AddDefaultPlcVar("纯化压力上限", "DB1.DBD135", "Real", "RW", "配方", "-", "配方参数，精度1位，量程：0~10MPa");
            AddDefaultPlcVar("储氢压力设定", "DB1.DBD139", "Real", "RW", "配方", "-", "配方参数，精度1位，量程：0~40MPa");
            AddDefaultPlcVar("加氢流量上限", "DB1.DBD143", "Real", "RW", "配方", "-", "配方参数，精度1位，量程：0~100Nm³/h");

            LogHelper.Info($"使用默认PLC变量配置，总配置: {GlobalVariables.PlcVarConfigList.Count}");
        }

        private static void AddDefaultPlcVar(string varName, string plcAddress, string dataType, string readWrite, string module, string interval, string remark)
        {
            var config = new PlcVarConfigModel
            {
                变量名称 = varName,
                PLC地址 = plcAddress,
                数据类型 = dataType,
                读写属性 = readWrite,
                所属模块 = module,
                采集间隔 = interval,
                备注 = remark
            };
            GlobalVariables.PlcVarConfigList.Add(config);

            if (readWrite.Contains("R") || readWrite.Contains("r"))
            {
                GlobalVariables.ReadDic[varName] = plcAddress;
            }

            if (readWrite.Contains("W") || readWrite.Contains("w"))
            {
                GlobalVariables.WriteDic[varName] = plcAddress;
            }

            if (string.IsNullOrEmpty(readWrite) || readWrite == "R")
            {
                GlobalVariables.ReadDic[varName] = plcAddress;
            }
        }
    }
}
