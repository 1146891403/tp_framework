using System.Threading.Tasks;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Dependency;
using TP.WL.ERP.Model.Crm;

namespace TP.WL.ERP.Business.Crm.Interfaces
{
    public interface ICertificateService : ITransientDependency
    {
        Task<WebApiResult<CertificateListModel>> GetAllAsync();

        Task<WebApiResult<CertificateEditModel>> GetAsync(long id);

        Task<WebApiResult<string>> AddAsync(CertificateEditModel model, string userId);

        Task<WebApiResult<string>> UpdateAsync(CertificateEditModel model, string userId);
    }
}
