using System;

namespace Custom.HydrogenConfigurationSystem.Globals
{
    /// <summary>
    /// PLC变量配置模型（与Config/plc_var_config.xlsx列名严格一致）
    /// </summary>
    public class PlcVarConfigModel
    {
        /// <summary>
        /// 变量名称（如：厂房氢气浓度）
        /// </summary>
        public string 变量名称 { get; set; } = string.Empty;

        /// <summary>
        /// PLC地址（如：DB1.DBD19、DB1.DBX1.0）
        /// </summary>
        public string PLC地址 { get; set; } = string.Empty;

        /// <summary>
        /// 数据类型（Bool/Real/Int/Dint，与HslCommunication匹配）
        /// </summary>
        public string 数据类型 { get; set; } = string.Empty;

        /// <summary>
        /// 读写属性（W=上位机写/R=上位机读/RW=双向）
        /// </summary>
        public string 读写属性 { get; set; } = string.Empty;

        /// <summary>
        /// 所属模块（如：控制模块、环境参数模块）
        /// </summary>
        public string 所属模块 { get; set; } = string.Empty;

        /// <summary>
        /// 采集间隔(ms)，-表示无采集（控制指令）
        /// </summary>
        public string 采集间隔 { get; set; } = "-";

        /// <summary>
        /// 备注（阈值、掉电保持等）
        /// </summary>
        public string 备注 { get; set; } = string.Empty;

        /// <summary>
        /// 获取采集间隔（转int，-则返回0）
        /// </summary>
        public int GetCollectInterval()
        {
            if (int.TryParse(采集间隔, out int interval) && interval > 0)
                return interval;
            return 0;
        }
    }
}
