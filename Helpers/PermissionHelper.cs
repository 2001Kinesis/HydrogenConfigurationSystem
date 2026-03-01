using Custom.HydrogenConfigurationSystem.Globals;

namespace Custom.HydrogenConfigurationSystem.Helpers
{
    public static class PermissionHelper
    {
        public static bool HasPermission(string module)
        {
            if (string.IsNullOrEmpty(GlobalVariables.CurrentUserRole))
            {
                return false;
            }

            return GlobalVariables.CurrentUserRole switch
            {
                "Admin" => true,
                "Operator" => module != "UserManager",
                "Visitor" => module == "Dashboard" || module == "RealTimeMonitor" || module == "LogQuery",
                _ => false
            };
        }

        public static bool CanControlDevice()
        {
            return GlobalVariables.CurrentUserRole == "Admin" || GlobalVariables.CurrentUserRole == "Operator";
        }

        public static bool CanManageRecipe()
        {
            return GlobalVariables.CurrentUserRole == "Admin" || GlobalVariables.CurrentUserRole == "Operator";
        }

        public static bool CanManageUser()
        {
            return GlobalVariables.CurrentUserRole == "Admin";
        }

        public static bool CanViewReport()
        {
            return GlobalVariables.CurrentUserRole == "Admin" || GlobalVariables.CurrentUserRole == "Operator" || GlobalVariables.CurrentUserRole == "Visitor";
        }

        public static bool CanConfigureSystem()
        {
            return GlobalVariables.CurrentUserRole == "Admin";
        }
    }
}
