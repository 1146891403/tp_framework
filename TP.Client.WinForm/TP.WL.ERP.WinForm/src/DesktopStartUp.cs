using DevExpress.XtraSplashScreen;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Client.WinForm.Common;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Helper;
using TP.WL.ERP.Model.Administration;
using static TP.WL.ERP.WinForm.ssMain;

namespace TP.WL.ERP.WinForm
{
    public class DesktopStartUp
    {
        public static async Task InitializeAsync(string username, string password)
        {
            SplashScreenManager.Default.SendCommand(SplashScreenCommand.Running, "驗證用戶名和密碼...");
            await LoginAsync(username, password);

            if (UserLoginInfo.Current.Succeeded)
            {
                SplashScreenManager.Default.SendCommand(SplashScreenCommand.Running, "獲取用戶權限信息...");
                await GetUserNavigationsAsync();
                await GetUserFunctionsAsync();
            }
        }

        public static async Task LoginAsync(string username, string password)
        {
            try
            {
                var token = await ApiService.Current.GetAccessTokenAsync(username, password);
                UserLoginInfo.Current.Token = token;
                UserLoginInfo.Current.Succeeded = true;
            }
            catch
            {
                UserLoginInfo.Current.Succeeded = false;
            }
        }

        public static async Task GetUserNavigationsAsync()
        {
            var content = await ApiService.Current.GetAsync("users", "get_views");
            
            var model = JsonHelper.DeserializeObject<WebApiResult<NavigationListModel>>(content);

            UserLoginInfo.Current.Navigations = ConvertModelToUserInfo(model.Results);
        }

        public static async Task GetUserFunctionsAsync()
        {
            var content = await ApiService.Current.GetAsync("users", "get_functions");

            var model = JsonHelper.DeserializeObject<WebApiResult<string>>(content);

            UserLoginInfo.Current.Functions = model.Results;
        }

        private static ICollection<UserNavigation> ConvertModelToUserInfo(IEnumerable<NavigationListModel> models)
        {
            var result = new List<UserNavigation>();

            foreach(var m in models)
            {
                var nav = new UserNavigation()
                {
                    Name = m.ViewName,
                    Text = m.DisplayName,
                    Category = m.Category
                };

                if (m.Children.Count > 0)
                    nav.Children = ConvertModelToUserInfo(m.Children);

                result.Add(nav);
            }

            return result;
        }
    }
}
