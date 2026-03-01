using Custom.HydrogenConfigurationSystem.Data.Entities;
using SqlSugar;
using Custom.HydrogenConfigurationSystem.Helpers;

namespace Custom.HydrogenConfigurationSystem.Data.DB
{
    public class RecipeService
    {
        private readonly SqlSugarClient _db;

        public RecipeService()
        {
            _db = DbContext.Db;
        }

        public List<RecipeEntity> GetList()
        {
            return _db.Queryable<RecipeEntity>().ToList();
        }

        public RecipeEntity? GetById(int id)
        {
            return _db.Queryable<RecipeEntity>().Where(r => r.Id == id).First();
        }

        public bool Add(RecipeEntity entity)
        {
            return _db.Insertable(entity).ExecuteCommand() > 0;
        }

        public bool Update(RecipeEntity entity)
        {
            return _db.Updateable(entity).ExecuteCommand() > 0;
        }

        public bool Delete(int id)
        {
            LogHelper.Info($"RecipeService.Delete: 准备删除配方 ID={id}");
            var result = _db.Deleteable<RecipeEntity>().Where(r => r.Id == id).ExecuteCommand() > 0;
            LogHelper.Info($"RecipeService.Delete: 删除配方 ID={id}, 结果={result}");
            return result;
        }
    }
}
