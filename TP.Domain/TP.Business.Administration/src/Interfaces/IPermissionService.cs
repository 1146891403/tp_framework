using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Dependency;
using TP.WL.ERP.Model.Administration;

namespace TP.Business.Administration.Interfaces
{
    public interface IPermissionService : ITransientDependency
    {
        Task<WebApiResult<RoleListModel>> GetRolesAsync();

        Task<WebApiResult<RoleEditModel>> GetRoleAsync(string roleId);

        Task<WebApiResult<string>> GetViewsAsync(string roleId);

        Task<WebApiResult<string>> GetFunctionsAsync(string roleId);

        Task<WebApiResult<string>> AddRoleAsync(RoleEditModel model);

        Task<WebApiResult<string>> AddToUsersAsync(UserRoleEditModel model);

        Task<WebApiResult<string>> AddToViewsAsync(IDictionary<string, IEnumerable<long>> views);

        Task<WebApiResult<string>> AddToFunctionsAsync(IDictionary<string, IEnumerable<long>> functions);

        Task<WebApiResult<string>> UpdateRoleAsync(RoleEditModel model);
    }
}