using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Helper;

namespace TP.Client.WinForm.Common
{
    public class DataService : IDataService
    {
        public async Task<TModel> GetSingleAsync<TModel>(string controller, string action, string parameters) where TModel : class => (await GetListAsync<TModel>(controller, action, parameters)).FirstOrDefault();

        public async Task<IEnumerable<TModel>> GetListAsync<TModel>(string controller) where TModel : class => await GetListAsync<TModel>(controller, "get_all");

        public async Task<IEnumerable<TModel>> GetListAsync<TModel>(string controller, string action) where TModel : class => await GetListAsync<TModel>(controller, action, "");

        public async Task<IEnumerable<TModel>> GetListAsync<TModel>(string controller, string action, string parameters) where TModel : class
        {
            try
            {
                var content = await ApiService.Current.GetAsync(controller, action, $"?{parameters}");

                var obj = JsonHelper.DeserializeObject<WebApiResult<TModel>>(content);

                if (!obj.Succeeded)
                    MessageBoxService.Failed(obj.Errors);

                return obj.Results;
            }
            catch(Exception ex)
            {
                MessageBoxService.Failed(ex.Message);

                return null;
            }
        }

        public async Task PostAsync(string controller, string content) => await PostAsync(controller, "add", content);

        public async Task PostAsync(string controller, string action, string content) => await PostAsync(controller, action, content, "post");

        public async Task PutAsync(string controller, string content) => await PutAsync(controller, "update", content);

        public async Task PutAsync(string controller, string action, string content) => await PostAsync(controller, action, content, "put");

        private async Task PostAsync(string controller, string action, string content, string type)
        {
            try
            {
                string result = type == "put"
                    ? await ApiService.Current.PutAsync(controller, action, content)
                    : await ApiService.Current.PostAsync(controller, action, content);

                var obj = JsonHelper.DeserializeObject<WebApiResult<string>>(result);

                if (obj.Succeeded)
                    MessageBoxService.Successed();
                else
                    MessageBoxService.Failed(obj.Errors);
            }
            catch(Exception ex)
            {
                MessageBoxService.Failed(ex.Message);
            }
        }

        public async Task<bool> RPostAsync(string controller, string content) => await RPostAsync(controller, "add", content);


        public async Task<bool> RPostAsync(string controller, string action, string content) => await RPostAsync(controller, action, content, "post");

        public async Task<bool> RPutAsync(string controller, string content) => await RPutAsync(controller, "update", content);

        public async Task<bool> RPutAsync(string controller, string action, string content) => await RPostAsync(controller, action, content, "put");

        private async Task<bool> RPostAsync(string controller, string action, string content, string type)
        {
            try
            {
                string result = type == "put"
                    ? await ApiService.Current.PutAsync(controller, action, content)
                    : await ApiService.Current.PostAsync(controller, action, content);

                var obj = JsonHelper.DeserializeObject<WebApiResult<string>>(result);

                if (obj.Succeeded)
                    MessageBoxService.Successed();
                else
                    MessageBoxService.Failed(obj.Errors);

                return obj.Succeeded;
            }
            catch (Exception ex)
            {
                MessageBoxService.Failed(ex.Message);
                return false;
            }

        }
    }
}
