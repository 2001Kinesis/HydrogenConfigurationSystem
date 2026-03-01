namespace Custom.HydrogenConfigurationSystem.Data.Entities
{
    public class LogAlarmEntity
    {
        public int Id { get; set; }
        public DateTime AlarmTime { get; set; }
        public string AlarmType { get; set; } = string.Empty;
        public string AlarmStation { get; set; } = string.Empty;
        public string AlarmContent { get; set; } = string.Empty;
    }
}
