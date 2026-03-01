using Custom.HydrogenConfigurationSystem.Data.Entities;
using SqlSugar;

namespace Custom.HydrogenConfigurationSystem.Data.DB
{
    public class RoleAuthService
    {
        private readonly SqlSugarClient _db;

        public RoleAuthService()
        {
            _db = DbContext.Db;
        }

        public RoleAuthEntity? GetByRole(string role)
        {
            return _db.Queryable<RoleAuthEntity>().Where(r => r.Role == role).First();
        }

        public bool Update(RoleAuthEntity entity)
        {
            return _db.Updateable(entity).ExecuteCommand() > 0;
        }
    }
}
