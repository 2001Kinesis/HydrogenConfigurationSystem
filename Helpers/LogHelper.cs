using NLog;
using Custom.HydrogenConfigurationSystem.Data.DB;
using Custom.HydrogenConfigurationSystem.Data.Entities;
using Custom.HydrogenConfigurationSystem.Globals;

namespace Custom.HydrogenConfigurationSystem.Helpers
{
    public class LogHelper
    {
        private static readonly Logger _logger = LogManager.GetCurrentClassLogger();
        private static readonly LogService _logService = new LogService();

        public static void Info(string message)
        {
            _logger.Info(message);
        }

        public static void Warn(string message)
        {
            _logger.Warn(message);
        }

        public static void Error(string message)
        {
            _logger.Error(message);
        }

        public static void Error(string message, Exception ex)
        {
            _logger.Error(ex, message);
        }

        public static void Debug(string message)
        {
            _logger.Debug(message);
        }

        public static void LogAlarm(string alarmType, string alarmStation, string alarmContent)
        {
            try
            {
                var entity = new LogAlarmEntity
                {
                    AlarmTime = DateTime.Now,
                    AlarmType = alarmType,
                    AlarmStation = alarmStation,
                    AlarmContent = alarmContent
                };
                _logService.AddAlarm(entity);
                Warn($"[报警] {alarmType} - {alarmStation} - {alarmContent}");
            }
            catch (Exception ex)
            {
                Error("记录报警日志失败", ex);
            }
        }

        public static void LogOperate(string operateModule, string operateContent, string? userName = null)
        {
            try
            {
                var entity = new LogOperateEntity
                {
                    OperateTime = DateTime.Now,
                    UserName = userName ?? GlobalVariables.CurrentUserName ?? "未知用户",
                    OperateModule = operateModule,
                    OperateContent = operateContent
                };
                _logService.AddOperate(entity);
                Info($"[操作] {entity.UserName} - {operateModule} - {operateContent}");
            }
            catch (Exception ex)
            {
                Error("记录操作日志失败", ex);
            }
        }
    }
}
