using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Administration;
using TP.Infrastructure.Common.Repository;

namespace TP.Repository.Administration.Interfaces
{
    public interface IUserRepository : IRepository
    {
        Task<IEnumerable<ApplicationUser>> FindUsersAsync();

        Task<ApplicationUser> FindByIdAsync(string userId);

        Task<ApplicationUser> FindByNameAsync(string username);

        Task<ApplicationUser> FindAsync(string username, string password);

        Task<IEnumerable<ApplicationUser>> GetUsersInRoleAsync(string roleId);

        Task<IEnumerable<UserProfile>> GetUsersInSubsidiaryAsync(long subsidiaryId);

        Task<IEnumerable<ApplicationUser>> GetUsersInSubsidiaryAsync(long subsidiaryId, string roleId);

        Task<IEnumerable<UserProfile>> GetUsersInDepartmentAsync(long departmentId);

        Task<IEnumerable<ApplicationUser>> GetUsersInDepartmentAsync(long departmentId, string roleId);

        Task<IEnumerable<ViewLink>> GetViewsAsync(string userId);

        Task<IEnumerable<ViewLinkFunction>> GetFunctionsAsync(string userId);
        
        Task<IdentityResult> InsertAsync(ApplicationUser user, string password);

        Task<IdentityResult> UpdateAsync(ApplicationUser user);

        Task<IdentityResult> UpdatePasswordAsync(string userId, string currentPassword, string newPassword);
    }
}
