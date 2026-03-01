using HslCommunication.Profinet.Siemens;
using System.Collections.Generic;
using System.Threading;

namespace Custom.HydrogenConfigurationSystem.Globals
{
    public static class GlobalVariables
    {
        public static string PlcIp { get; set; } = GlobalConstants.DefaultPlcIp;
        public static int PlcPort { get; set; } = GlobalConstants.DefaultPlcPort;
        public static SiemensPLCS CpuType { get; set; } = SiemensPLCS.S1200;
        public static byte Rack { get; set; } = GlobalConstants.DefaultRack;
        public static byte Slot { get; set; } = GlobalConstants.DefaultSlot;
        public static int ReadInterval { get; set; } = GlobalConstants.DefaultReadInterval;
        public static int ReConnectInterval { get; set; } = GlobalConstants.DefaultReConnectInterval;

        public static Dictionary<string, string> ReadDic = new();
        public static Dictionary<string, string> WriteDic = new();
        public static Dictionary<string, object> DataDic = new();
        public static List<PlcVarConfigModel> PlcVarConfigList = new();

        public static SiemensS7Net? PlcClient { get; set; } = null;
        public static bool PlcIsConnected { get; set; } = false;
        public static CancellationTokenSource Cts { get; set; } = new CancellationTokenSource();

        public static string? CurrentUserName { get; set; }
        public static string? CurrentUserRole { get; set; }
        public static bool IsAuthorized { get; set; } = true;

        // 当前使用的配方信息
        public static string? CurrentRecipeName { get; set; }
        public static DateTime? CurrentRecipeSendTime { get; set; }
        public static Dictionary<string, object> CurrentRecipeParams { get; set; } = new();

        // 停止的工位字典，用于控制数据采集
        public static Dictionary<string, bool> StoppedStations { get; set; } = new();
    }
}
