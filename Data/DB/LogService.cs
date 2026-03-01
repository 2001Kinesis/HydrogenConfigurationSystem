using Custom.HydrogenConfigurationSystem.Data.Entities;
using SqlSugar;

namespace Custom.HydrogenConfigurationSystem.Data.DB
{
    public class LogService
    {
        private readonly SqlSugarClient _db;

        public LogService()
        {
            _db = DbContext.Db;
        }

        public List<LogAlarmEntity> GetAlarmList(DateTime? startTime = null, DateTime? endTime = null, string? type = null)
        {
            var query = _db.Queryable<LogAlarmEntity>();
            if (startTime.HasValue)
                query = query.Where(l => l.AlarmTime >= startTime.Value);
            if (endTime.HasValue)
                query = query.Where(l => l.AlarmTime <= endTime.Value);
            if (!string.IsNullOrEmpty(type))
                query = query.Where(l => l.AlarmType == type);
            return query.OrderBy(l => l.AlarmTime, OrderByType.Desc).ToList();
        }

        public List<LogAlarmEntity> GetAlarmLogs(DateTime startTime, DateTime endTime)
        {
            return GetAlarmList(startTime, endTime);
        }

        public List<LogOperateEntity> GetOperateList(DateTime? startTime = null, DateTime? endTime = null, string? module = null)
        {
            var query = _db.Queryable<LogOperateEntity>();
            if (startTime.HasValue)
                query = query.Where(l => l.OperateTime >= startTime.Value);
            if (endTime.HasValue)
                query = query.Where(l => l.OperateTime <= endTime.Value);
            if (!string.IsNullOrEmpty(module))
                query = query.Where(l => l.OperateModule == module);
            return query.OrderBy(l => l.OperateTime, OrderByType.Desc).ToList();
        }

        public List<LogOperateEntity> GetOperateLogs(DateTime startTime, DateTime endTime)
        {
            return GetOperateList(startTime, endTime);
        }

        public bool AddAlarm(LogAlarmEntity entity)
        {
            return _db.Insertable(entity).ExecuteCommand() > 0;
        }

        public bool AddOperate(LogOperateEntity entity)
        {
            return _db.Insertable(entity).ExecuteCommand() > 0;
        }

        public int GetAlarmCount(DateTime startTime, DateTime endTime)
        {
            return _db.Queryable<LogAlarmEntity>()
                .Where(l => l.AlarmTime >= startTime && l.AlarmTime <= endTime)
                .Count();
        }
    }
}
