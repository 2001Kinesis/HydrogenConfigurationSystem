namespace Custom.HydrogenConfigurationSystem.Data.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string UserPassword { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
