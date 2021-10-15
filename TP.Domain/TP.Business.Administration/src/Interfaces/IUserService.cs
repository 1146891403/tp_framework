using System.Threading.Tasks;
using TP.Infrastructure.Common;
using TP.Infrastructure.Common.Dependency;
using TP.WL.ERP.Model.Administration;

namespace TP.Business.Administration.Interfaces
{
    public interface IUserService : ITransientDependency
    {
        Task<WebApiResult<UserListModel>> GetAllAsync();

        Task<WebApiResult<UserEditModel>> GetAsync(string userId);

        Task<WebApiResult<UserListModel>> GetUsersByRoleAsync(long roleId);

        Task<WebApiResult<UserListModel>> GetUsersBySubsidiaryAsync(long subsidiaryId);

        Task<WebApiResult<UserListModel>> GetUsersBySubsidiaryAsync(long subsidiaryId, long roleId);

        Task<WebApiResult<UserListModel>> GetUsersByDepartmentAsync(long departmentId);

        Task<WebApiResult<UserListModel>> GetUsersByDepartmentAsync(long departmentId, long roleId);

        Task<WebApiResult<NavigationListModel>> GetViewsAsync(string userId);

        Task<WebApiResult<string>> GetFunctionsAsync(string userId);

        Task<WebApiResult<string>> AddAsync(UserEditModel model);

        Task<WebApiResult<string>> UpdateAsync(UserEditModel model);

        Task<WebApiResult<string>> UpdatePasswordAsync(string userId, string currentPassword, string newPassword);
    }
}
