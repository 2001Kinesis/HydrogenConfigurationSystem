using SqlSugar;
using Custom.HydrogenConfigurationSystem.Helpers;

namespace Custom.HydrogenConfigurationSystem.Data.DB
{
    public class DbContext
    {
        private static SqlSugarClient? _db;

        public static SqlSugarClient Db
        {
            get
            {
                if (_db == null)
                {
                    _db = new SqlSugarClient(new ConnectionConfig()
                    {
                        ConnectionString = "Server=localhost;Database=testmes;Uid=root;Pwd=admin;Port=3306;SslMode=none;",
                        DbType = DbType.MySql,
                        IsAutoCloseConnection = true,
                        InitKeyType = InitKeyType.Attribute
                    });
                }
                return _db;
            }
        }

        public static void InitDatabase()
        {
            try
            {
                var db = Db;

                // 删除并重建RecipeEntity表以确保自增ID正确
                try
                {
                    db.Ado.ExecuteCommand("DROP TABLE IF EXISTS RecipeEntity");
                    LogHelper.Info("已删除旧RecipeEntity表，将重新创建");
                }
                catch (Exception ex)
                {
                    LogHelper.Info($"删除RecipeEntity表时出错: {ex.Message}");
                }

                db.CodeFirst.InitTables(
                    typeof(Data.Entities.UserEntity),
                    typeof(Data.Entities.RoleAuthEntity),
                    typeof(Data.Entities.RecipeEntity),
                    typeof(Data.Entities.LogAlarmEntity),
                    typeof(Data.Entities.LogOperateEntity),
                    typeof(Data.Entities.ProductionDataEntity));

                // 数据播种
                SeedData();
            }
            catch (Exception ex)
            {
                LogHelper.Error($"数据库初始化失败: {ex.Message}");
            }
        }
        
        private static void SeedData()
        {
            var db = Db;
            
            // 播种角色权限数据
            if (!db.Queryable<Data.Entities.RoleAuthEntity>().Any())
            {
                var roleAuths = new List<Data.Entities.RoleAuthEntity>
                {
                    new Data.Entities.RoleAuthEntity
                    {
                        Role = "Admin",
                        ControlAuth = true,
                        MonitorAuth = true,
                        RecipeAuth = true,
                        LogAuth = true,
                        ReportAuth = true,
                        ConfigAuth = true,
                        UserAuth = true
                    },
                    new Data.Entities.RoleAuthEntity
                    {
                        Role = "Operator",
                        ControlAuth = true,
                        MonitorAuth = true,
                        RecipeAuth = true,
                        LogAuth = true,
                        ReportAuth = true,
                        ConfigAuth = false,
                        UserAuth = false
                    },
                    new Data.Entities.RoleAuthEntity
                    {
                        Role = "Visitor",
                        ControlAuth = false,
                        MonitorAuth = true,
                        RecipeAuth = false,
                        LogAuth = true,
                        ReportAuth = true,
                        ConfigAuth = false,
                        UserAuth = false
                    }
                };
                db.Insertable(roleAuths).ExecuteCommand();
            }
            
            // 播种默认用户数据
            if (!db.Queryable<Data.Entities.UserEntity>().Any())
            {
                var users = new List<Data.Entities.UserEntity>
                {
                    new Data.Entities.UserEntity
                    {
                        UserName = "Admin",
                        UserPassword = "123",
                        Role = "Admin"
                    },
                    new Data.Entities.UserEntity
                    {
                        UserName = "Operator",
                        UserPassword = "123",
                        Role = "Operator"
                    },
                    new Data.Entities.UserEntity
                    {
                        UserName = "Visitor",
                        UserPassword = "123",
                        Role = "Visitor"
                    }
                };
                db.Insertable(users).ExecuteCommand();
            }
            
            // 播种默认配方数据
            if (!db.Queryable<Data.Entities.RecipeEntity>().Any())
            {
                var recipes = new List<Data.Entities.RecipeEntity>
                {
                    new Data.Entities.RecipeEntity
                    {
                        RecipeName = "工业用氢默认配方",
                        ApplicationScene = "工业用氢",
                        ElectrolysisCurrentMin = 100.0,
                        ElectrolysisCurrentMax = 500.0,
                        PurificationPressureMin = 0.5,
                        PurificationPressureMax = 1.5,
                        StoragePressure = 20.0,
                        HydrogenFlowMin = 10.0,
                        HydrogenFlowMax = 50.0,
                        HydrogenPurity = 99.9
                    },
                    new Data.Entities.RecipeEntity
                    {
                        RecipeName = "燃料电池用氢默认配方",
                        ApplicationScene = "燃料电池用氢",
                        ElectrolysisCurrentMin = 150.0,
                        ElectrolysisCurrentMax = 600.0,
                        PurificationPressureMin = 0.8,
                        PurificationPressureMax = 1.8,
                        StoragePressure = 25.0,
                        HydrogenFlowMin = 15.0,
                        HydrogenFlowMax = 60.0,
                        HydrogenPurity = 99.999
                    }
                };
                db.Insertable(recipes).ExecuteCommand();
            }
        }
    }
}
