using System.Collections.Generic;
using System.Threading.Tasks;

namespace TP.Client.WinForm.Common
{
    public interface IDataService
    {
        Task<TModel> GetSingleAsync<TModel>(string controller, string action, string parameters) where TModel : class;

        Task<IEnumerable<TModel>> GetListAsync<TModel>(string controller) where TModel : class;

        Task<IEnumerable<TModel>> GetListAsync<TModel>(string controller, string action) where TModel : class;

        Task<IEnumerable<TModel>> GetListAsync<TModel>(string controller, string action, string parameters) where TModel : class;

        Task PostAsync(string controller, string content);

        Task PostAsync(string controller, string action, string content);

        Task PutAsync(string controller, string content);

        Task PutAsync(string controller, string action, string content);


        Task<bool> RPostAsync(string controller, string content);

        Task<bool> RPostAsync(string controller, string action, string content);

        Task<bool> RPutAsync(string controller, string content);

        Task<bool> RPutAsync(string controller, string action, string content);
    }
}
