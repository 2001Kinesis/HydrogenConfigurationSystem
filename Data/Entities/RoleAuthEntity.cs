namespace Custom.HydrogenConfigurationSystem.Data.Entities
{
    public class RoleAuthEntity
    {
        public int Id { get; set; }
        public string Role { get; set; } = string.Empty;
        public bool ControlAuth { get; set; }
        public bool MonitorAuth { get; set; }
        public bool RecipeAuth { get; set; }
        public bool LogAuth { get; set; }
        public bool ReportAuth { get; set; }
        public bool ConfigAuth { get; set; }
        public bool UserAuth { get; set; }
    }
}
