using TP.Infrastructure.Common.Config;

namespace TP.Client.WinForm.Common.Configuration
{
    public class WebApiSettings
    {
        public static string DomainName => ConfigManager.GetValue("WinLabel.ERP.WebApi:DomainName");

        public static string IntranetUrl => ConfigManager.GetValue("WinLabel.ERP.WebApi:IntranetUrl");

        public static string InternetUrl => ConfigManager.GetValue("WinLabel.ERP.WebApi:InternetUrl");
    }
}
