using System.Threading.Tasks;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Dependency;
using TP.WL.ERP.Model.Utilities;

namespace TP.Business.Administration.Interfaces
{
    public interface INumberService : ITransientDependency
    {
        Task<WebApiResult<NumberTemplateListModel>> GetTemplatesAsync();

        Task<WebApiResult<NumberInstanceListModel>> GetInstancesAsync();

        Task<WebApiResult<string>> AddTemplateAsync(NumberTemplateEditModel model);

        Task<WebApiResult<string>> AddInstanceAsync(NumberInstanceEditModel model);
    }
}
