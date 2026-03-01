using Custom.HydrogenConfigurationSystem.Configs;
using Custom.HydrogenConfigurationSystem.Globals;

namespace Custom.HydrogenConfigurationSystem.Helpers
{
    public static class AuthHelper
    {
        public static bool ValidateAuth()
        {
            try
            {
                var config = AuthConfig.Load();

                if (config.AuthType == "Permanent")
                {
                    GlobalVariables.IsAuthorized = true;
                    return true;
                }

                if (config.AuthType == "Trial")
                {
                    if (DateTime.Now <= config.ExpiryDate)
                    {
                        GlobalVariables.IsAuthorized = true;
                        return true;
                    }
                }

                GlobalVariables.IsAuthorized = false;
                return false;
            }
            catch
            {
                GlobalVariables.IsAuthorized = true;
                return true;
            }
        }

        public static void SetPermanentAuth()
        {
            var config = AuthConfig.Load();
            config.AuthType = "Permanent";
            config.Save();
            GlobalVariables.IsAuthorized = true;
        }

        public static void SetTrialAuth(int days)
        {
            var config = AuthConfig.Load();
            config.AuthType = "Trial";
            config.ExpiryDate = DateTime.Now.AddDays(days);
            config.Save();
            GlobalVariables.IsAuthorized = true;
        }
    }
}
