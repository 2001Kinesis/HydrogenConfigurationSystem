using Custom.HydrogenConfigurationSystem.Data.Entities;
using SqlSugar;

namespace Custom.HydrogenConfigurationSystem.Data.DB
{
    public class ProductionDataService
    {
        private readonly SqlSugarClient _db;

        public ProductionDataService()
        {
            _db = DbContext.Db;
        }

        public List<ProductionDataEntity> GetList(DateTime startTime, DateTime endTime)
        {
            return _db.Queryable<ProductionDataEntity>()
                .Where(p => p.InsertTime >= startTime && p.InsertTime <= endTime)
                .OrderBy(p => p.InsertTime, OrderByType.Desc)
                .ToList();
        }

        public ProductionDataEntity? GetLatest()
        {
            return _db.Queryable<ProductionDataEntity>()
                .OrderBy(p => p.InsertTime, OrderByType.Desc)
                .First();
        }

        public bool Add(ProductionDataEntity entity)
        {
            return _db.Insertable(entity).ExecuteCommand() > 0;
        }

        public double GetTotalOutput(DateTime startTime, DateTime endTime)
        {
            var list = _db.Queryable<ProductionDataEntity>()
                .Where(p => p.InsertTime >= startTime && p.InsertTime <= endTime)
                .ToList();
            return list.Sum(p => p.HydrogenOutput);
        }

        public double GetAvgPurity(DateTime startTime, DateTime endTime)
        {
            var list = _db.Queryable<ProductionDataEntity>()
                .Where(p => p.InsertTime >= startTime && p.InsertTime <= endTime)
                .ToList();
            return list.Count > 0 ? list.Average(p => p.HydrogenPurity) : 0;
        }

        public double GetTotalEnergy(DateTime startTime, DateTime endTime)
        {
            var list = _db.Queryable<ProductionDataEntity>()
                .Where(p => p.InsertTime >= startTime && p.InsertTime <= endTime)
                .ToList();
            return list.Sum(p => p.EnergyConsumption);
        }
    }
}
