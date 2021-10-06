using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TP.Infrastructure.Common.Helper;
using TP.Client.WinForm.Common.Configuration;

namespace TP.Client.WinForm.Common
{
    public class ApiService
    {
        private static ApiService currentService;
        private static HttpClient httpClient;
        private readonly static object syncObject = new object();

        private ApiService()
        {
            httpClient = new HttpClient();
        }

        public static ApiService Current
        {
            get
            {
                if(currentService == null)
                {
                    lock(syncObject)
                    {
                        if (currentService == null)
                            currentService = new ApiService();
                    }
                }

                return currentService;
            }
        }
        
        private static string ApiDomainName { get { return WebApiSettings.DomainName; } }

        private static string ApiIntranetUrl { get { return WebApiSettings.IntranetUrl; } }

        public async Task<string> GetAsync(string controller, string action)
        {
            return await GetAsync(controller, action, "");
        }

        public async Task<string> GetAsync(string controller, string action, string parameters)
        {
            var requestUri = GetApiUrl(controller, action, parameters);

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserLoginInfo.Current.Token);

            var response = await httpClient.GetAsync(requestUri);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetAccessTokenAsync(string username, string password)
        {
            var requestUri = $"{ApiDomainName}/token";

            var parameters = new Dictionary<string, string>
            {
                { "grant_type", "password" },
                { "username", username },
                { "password", password }
            };

            var response = await httpClient.PostAsync(requestUri, new FormUrlEncodedContent(parameters));
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();

            return JsonHelper.GetJsonValue(result, "access_token");
        }
        
        public async Task<string> PostAsync(string controller, string action, string content)
        {
            var requestUri = GetApiUrl(controller, action);

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserLoginInfo.Current.Token);

            var strContent = new StringContent(content);
            strContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await httpClient.PostAsync(requestUri, strContent);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        
        public async Task<string> PutAsync(string controller, string action, string content)
        {
            var requestUri = GetApiUrl(controller, action);

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", UserLoginInfo.Current.Token);

            var strContent = new StringContent(content);
            strContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var response = await httpClient.PutAsync(requestUri, strContent);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        private string GetApiUrl(string controller, string action)
        {
            return GetApiUrl(controller, action, "");
        }

        private string GetApiUrl(string controller, string action, string parameters)
        {
            return $"{ApiIntranetUrl}/{controller}/{action}/{parameters}";
        }
    }
}
