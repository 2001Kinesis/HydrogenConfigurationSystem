namespace Custom.HydrogenConfigurationSystem.Data.Entities
{
    public class LogOperateEntity
    {
        public int Id { get; set; }
        public DateTime OperateTime { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string OperateModule { get; set; } = string.Empty;
        public string OperateContent { get; set; } = string.Empty;
    }
}
