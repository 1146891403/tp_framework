using System.Threading.Tasks;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Dependency;
using TP.WL.ERP.Model.Administration;

namespace TP.Business.Administration.Interfaces
{
    public interface IOrganizationService : ITransientDependency
    {
        Task<WebApiResult<OrganizationListModel>> GetOrganizationsAsync();

        Task<WebApiResult<SubsidiaryListModel>> GetSubsidiariesAsync();

        Task<WebApiResult<DepartmentListModel>> GetDepartmentsAsync();

        Task<WebApiResult<SubsidiaryEditModel>> GetSubsidiaryAsync(int id);

        Task<WebApiResult<DepartmentEditModel>> GetDepartmentAsync(int id);

        Task<WebApiResult<string>> AddSubsidiaryAsync(SubsidiaryEditModel model);

        Task<WebApiResult<string>> AddDepartmentAsync(DepartmentEditModel model);

        Task<WebApiResult<string>> UpdateSubsidiaryAsync(SubsidiaryEditModel model);

        Task<WebApiResult<string>> UpdateDepartmentAsync(DepartmentEditModel model);
    }
}
