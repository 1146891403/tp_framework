using System.Threading.Tasks;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Dependency;
using TP.WL.ERP.Model.Administration;

namespace TP.Business.Administration.Interfaces
{
    public interface IViewLinkService : ITransientDependency
    {
        Task<WebApiResult<ViewLinkListModel>> GetAllAsync();

        Task<WebApiResult<ViewLinkListModel>> GetAllEnabledAsync();

        Task<WebApiResult<ViewLinkListModel>> GetDirectoriesAsync();

        Task<WebApiResult<ViewLinkListModel>> GetLinksAsync(long directoryId);

        Task<WebApiResult<FunctionListModel>> GetFunctionsAsync();

        Task<WebApiResult<FunctionListModel>> GetFunctionsAsync(long linkId);

        Task<WebApiResult<FunctionListModel>> GetFunctionsAsync(string linkIds);

        Task<WebApiResult<string>> AddLinkAsync(ViewLinkEditModel model);

        Task<WebApiResult<string>> AddFunctionAsync(FunctionEditModel model);

        Task<WebApiResult<string>> AddFunctionsAsync(FunctionBatchEditModel model);

        Task<WebApiResult<string>> UpdateLinkAsync(ViewLinkEditModel model);

        Task<WebApiResult<string>> UpdateFunctionAsync(FunctionEditModel model);
    }
}
