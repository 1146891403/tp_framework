using System.Threading.Tasks;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Dependency;
using TP.WL.ERP.Model.Utilities;

namespace TP.Business.Administration.Interfaces
{
    public interface IDictionaryService : ITransientDependency
    {
        Task<WebApiResult<DictionaryTypeListModel>> GetTypesAsync();

        Task<WebApiResult<DictionaryTypeListModel>> GetTypesAsync(long parentId);

        Task<WebApiResult<DictionaryDataListModel>> GetDatasAsync(long typeId);

        Task<WebApiResult<DictionaryTypeEditModel>> GetTypeAsync(long id);

        Task<WebApiResult<DictionaryDataEditModel>> GetDataAsync(long id);

        Task<WebApiResult<string>> AddTypeAsync(DictionaryTypeEditModel model);

        Task<WebApiResult<string>> AddDataAsync(DictionaryDataEditModel model);
        
        Task<WebApiResult<string>> AddDatasAsync(DictionaryDataBatchEditModel model);

        Task<WebApiResult<string>> UpdateTypeAsync(DictionaryTypeEditModel model);

        Task<WebApiResult<string>> UpdateDataAsync(DictionaryDataEditModel model);
    }
}
