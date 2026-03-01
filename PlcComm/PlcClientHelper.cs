using HslCommunication;
using HslCommunication.Profinet.Siemens;
using Custom.HydrogenConfigurationSystem.Globals;
using Custom.HydrogenConfigurationSystem.Helpers;

namespace Custom.HydrogenConfigurationSystem.PlcComm
{
    public static class PlcClientHelper
    {
        public static OperateResult InitPlcConnection()
        {
            try
            {
                GlobalVariables.PlcClient = new SiemensS7Net(GlobalVariables.CpuType, GlobalVariables.PlcIp);
                GlobalVariables.PlcClient.Port = GlobalVariables.PlcPort;
                GlobalVariables.PlcClient.Rack = GlobalVariables.Rack;
                GlobalVariables.PlcClient.Slot = GlobalVariables.Slot;
                GlobalVariables.PlcClient.ConnectTimeOut = 3000;
                GlobalVariables.PlcClient.ReceiveTimeOut = 3000;

                var result = GlobalVariables.PlcClient.ConnectServer();
                GlobalVariables.PlcIsConnected = result.IsSuccess;

                return result;
            }
            catch (Exception ex)
            {
                return new OperateResult(ex.Message);
            }
        }

        public static OperateResult<Dictionary<string, object>> BatchReadPlcData()
        {
            if (!GlobalVariables.PlcIsConnected || GlobalVariables.PlcClient == null)
            {
                var result = new OperateResult<Dictionary<string, object>>();
                result.Message = "PLC未连接";
                return result;
            }

            try
            {
                var readResult = new Dictionary<string, object>();

                foreach (var config in GlobalVariables.PlcVarConfigList)
                {
                    var paramName = config.变量名称;
                    var plcAddress = config.PLC地址;
                    var dataType = config.数据类型?.ToLower() ?? "real";
                    var readWrite = config.读写属性 ?? "R";

                    // 只读取配置了读属性的变量
                    if (!readWrite.Contains("R") && !readWrite.Contains("r"))
                        continue;

                    object? value = null;

                    // 根据数据类型读取
                    switch (dataType)
                    {
                        case "bool":
                            var boolResult = GlobalVariables.PlcClient.ReadBool(plcAddress);
                            if (boolResult.IsSuccess)
                                value = boolResult.Content;
                            break;

                        case "int":
                        case "int32":
                            var intResult = GlobalVariables.PlcClient.ReadInt32(plcAddress);
                            if (intResult.IsSuccess)
                                value = intResult.Content;
                            break;

                        case "dint":
                        case "int64":
                            var longResult = GlobalVariables.PlcClient.ReadInt64(plcAddress);
                            if (longResult.IsSuccess)
                                value = longResult.Content;
                            break;

                        case "real":
                        case "float":
                            var floatResult = GlobalVariables.PlcClient.ReadFloat(plcAddress);
                            if (floatResult.IsSuccess)
                                value = floatResult.Content;
                            break;

                        case "double":
                            var doubleResult = GlobalVariables.PlcClient.ReadDouble(plcAddress);
                            if (doubleResult.IsSuccess)
                                value = doubleResult.Content;
                            break;

                        case "word":
                        case "uint16":
                            var ushortResult = GlobalVariables.PlcClient.ReadUInt16(plcAddress);
                            if (ushortResult.IsSuccess)
                                value = ushortResult.Content;
                            break;

                        case "dword":
                        case "uint32":
                            var uintResult = GlobalVariables.PlcClient.ReadUInt32(plcAddress);
                            if (uintResult.IsSuccess)
                                value = uintResult.Content;
                            break;

                        default:
                            // 默认尝试读取浮点数
                            var defaultResult = GlobalVariables.PlcClient.ReadFloat(plcAddress);
                            if (defaultResult.IsSuccess)
                                value = defaultResult.Content;
                            break;
                    }

                    if (value != null)
                    {
                        readResult[paramName] = value;
                        GlobalVariables.DataDic[paramName] = value;
                    }
                }

                var successResult = new OperateResult<Dictionary<string, object>>();
                successResult.Content = readResult;
                successResult.IsSuccess = true;
                return successResult;
            }
            catch (Exception ex)
            {
                var errorResult = new OperateResult<Dictionary<string, object>>();
                errorResult.Message = ex.Message;
                return errorResult;
            }
        }

        public static OperateResult BatchWritePlcData(Dictionary<string, object> writeValues)
        {
            if (!GlobalVariables.PlcIsConnected || GlobalVariables.PlcClient == null)
                return new OperateResult("PLC未连接");

            try
            {
                foreach (var kvp in writeValues)
                {
                    var paramName = kvp.Key;
                    var value = kvp.Value;
                    
                    if (GlobalVariables.WriteDic.TryGetValue(paramName, out var plcAddress))
                    {
                        if (value is bool boolValue)
                        {
                            var result = GlobalVariables.PlcClient.Write(plcAddress, boolValue);
                            if (!result.IsSuccess)
                            {
                                return result;
                            }
                        }
                        else if (value is int intValue)
                        {
                            var result = GlobalVariables.PlcClient.Write(plcAddress, intValue);
                            if (!result.IsSuccess)
                            {
                                return result;
                            }
                        }
                        else if (value is float floatValue)
                        {
                            var result = GlobalVariables.PlcClient.Write(plcAddress, floatValue);
                            if (!result.IsSuccess)
                            {
                                return result;
                            }
                        }
                        else if (value is double doubleValue)
                        {
                            // double 类型转换为 float 写入PLC
                            var result = GlobalVariables.PlcClient.Write(plcAddress, (float)doubleValue);
                            if (!result.IsSuccess)
                            {
                                return result;
                            }
                        }
                        else if (value is decimal decimalValue)
                        {
                            // decimal 类型转换为 float 写入PLC
                            var result = GlobalVariables.PlcClient.Write(plcAddress, (float)decimalValue);
                            if (!result.IsSuccess)
                            {
                                return result;
                            }
                        }
                    }
                    else
                    {
                        LogHelper.Warn($"PLC写入失败：参数'{paramName}'在WriteDic中不存在");
                        return new OperateResult($"参数'{paramName}'未配置PLC地址");
                    }
                }
                return new OperateResult() { IsSuccess = true };
            }
            catch (Exception ex)
            {
                return new OperateResult(ex.Message);
            }
        }

        public static OperateResult WritePlcData(string paramName, object value)
        {
            return BatchWritePlcData(new Dictionary<string, object> { { paramName, value } });
        }

        public static void CloseConnection()
        {
            GlobalVariables.PlcClient?.ConnectClose();
            GlobalVariables.PlcIsConnected = false;
        }

        public static bool IsConnectionHealthy()
        {
            if (GlobalVariables.PlcClient == null)
                return false;

            try
            {
                var result = GlobalVariables.PlcClient.ReadBool("Q0.0");
                return result.IsSuccess;
            }
            catch
            {
                return false;
            }
        }
    }
}
