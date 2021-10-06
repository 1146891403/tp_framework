using System.Configuration;

namespace TP.Infrastructure.Common.Config
{
    public class ConfigManager
    {
        public static string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key].ToString();
        }
    }
}
