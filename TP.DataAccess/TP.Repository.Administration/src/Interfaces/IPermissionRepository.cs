using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Administration;
using TP.Infrastructure.Common.Repository;

namespace TP.Repository.Administration.Interfaces
{
    public interface IPermissionRepository : IRepository
    {
        Task<IEnumerable<ApplicationRole>> FindRolesAsync();

        Task<IEnumerable<Subsidiary>> FindRolesBySubsidiaryId(long subsidiaryId);

        Task<ApplicationRole> FindRoleByIdAsync(string roleId);

        Task<ApplicationRole> FindRoleByNameAsync(string roleName);

        Task<ApplicationRole> FindUsersByRoleIdAsync(string roleId);

        Task<ApplicationRole> FindViewsByRoleIdAsync(string roleId);

        Task<ApplicationRole> FindFunctionsByRoleIdAsync(string roleId);

        Task<IEnumerable<long>> GetViewsInRoleAsync(string roleId);

        Task<IEnumerable<long>> GetFunctionsInRoleAsync(string roleId);
        
        Task<IdentityResult> InsertRoleAsync(ApplicationRole role);

        Task<bool> InsertRoleViewAsync(ApplicationRoleView roleView);

        Task<bool> InsertRoleFunctionAsync(ApplicationRoleFunction roleFunction);

        Task<IdentityResult> BulkInsertUserRolesAsync(ApplicationRole role, IEnumerable<string> users);

        Task<IdentityResult> BulkInsertRoleViewsAsync(ApplicationRole role, IEnumerable<long> views);

        Task<IdentityResult> BulkInsertRoleFunctionsAsync(ApplicationRole role, IEnumerable<long> functions);
        
        Task<IdentityResult> UpdateRoleAsync(ApplicationRole role);

        Task<IdentityResult> DeleteUserRolesAsync(ApplicationRole role, IEnumerable<string> users);

        Task<IdentityResult> DeleteRoleViewsAsync(ApplicationRole role, IEnumerable<long> views);

        Task<IdentityResult> DeleteRoleFunctionsAsync(ApplicationRole role, IEnumerable<long> functions);
    }
}
