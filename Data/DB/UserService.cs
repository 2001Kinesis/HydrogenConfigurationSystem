using Custom.HydrogenConfigurationSystem.Data.Entities;
using SqlSugar;

namespace Custom.HydrogenConfigurationSystem.Data.DB
{
    public class UserService
    {
        private readonly SqlSugarClient _db;

        public UserService()
        {
            _db = DbContext.Db;
        }

        public List<UserEntity> GetList()
        {
            return _db.Queryable<UserEntity>().ToList();
        }

        public UserEntity? GetByUserName(string userName)
        {
            return _db.Queryable<UserEntity>().Where(u => u.UserName == userName).First();
        }

        public bool Add(UserEntity entity)
        {
            return _db.Insertable(entity).ExecuteCommand() > 0;
        }

        public bool Update(UserEntity entity)
        {
            return _db.Updateable(entity).ExecuteCommand() > 0;
        }

        public bool Delete(int id)
        {
            return _db.Deleteable<UserEntity>().Where(u => u.Id == id).ExecuteCommand() > 0;
        }

        public bool CheckPassword(string userName, string password)
        {
            return _db.Queryable<UserEntity>()
                .Where(u => u.UserName == userName && u.UserPassword == password)
                .Any();
        }
    }
}
