using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using TP.AspNet.Identity.EntityFramework;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Administration;
using TP.Repository.Administration.Interfaces;

namespace TP.Repository.Administration.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly IOwinContext _context;
        private ApplicationUserManager _userManager;
        
        public UserRepository(IOwinContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public ApplicationUserManager UserManager
        {
            get { return _userManager ?? (_userManager = _context.GetUserManager<ApplicationUserManager>()); }
            private set { _userManager = value; }
        }

        public async Task<IEnumerable<ApplicationUser>> FindUsersAsync()
        {
            return await UserManager.Users.ToListAsync();
        }

        public async Task<ApplicationUser> FindByIdAsync(string userId)
        {
            return await UserManager.FindByIdAsync(userId);
        }

        public async Task<ApplicationUser> FindByNameAsync(string username)
        {
            return await UserManager.FindByNameAsync(username);
        }

        public async Task<ApplicationUser> FindAsync(string username, string password)
        {
            return await UserManager.FindAsync(username, password);
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsersInRoleAsync(string roleId)
        {
            return await UserManager.GetUsersInRoleAsync(roleId);
        }

        public async Task<IEnumerable<UserProfile>> GetUsersInSubsidiaryAsync(long subsidiaryId)
        {
            return await UserManager.GetUsersInSubsidiaryAsync(subsidiaryId);
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsersInSubsidiaryAsync(long subsidiaryId, string roleId)
        {
            return await UserManager.GetUsersInSubsidiaryAsync(subsidiaryId, roleId);
        }

        public async Task<IEnumerable<UserProfile>> GetUsersInDepartmentAsync(long departmentId)
        {
            return await UserManager.GetUsersInDepartmentAsync(departmentId);
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsersInDepartmentAsync(long departmentId, string roleId)
        {
            return await UserManager.GetUsersInDepartmentAsync(departmentId, roleId);
        }

        public async Task<IEnumerable<ViewLink>> GetViewsAsync(string userId)
        {
            return await UserManager.GetViewsAsync(userId);
        }

        public async Task<IEnumerable<ViewLinkFunction>> GetFunctionsAsync(string userId)
        {
            return await UserManager.GetFunctionsAsync(userId);
        }

        public async Task<IdentityResult> InsertAsync(ApplicationUser user, string password)
        {
            return await UserManager.CreateAsync(user, password);
        }

        public async Task<IdentityResult> UpdateAsync(ApplicationUser user)
        {
            return await UserManager.UpdateAsync(user);
        }

        public async Task<IdentityResult> UpdatePasswordAsync(string userId,string currentPassword, string newPassword)
        {
            return await UserManager.ChangePasswordAsync(userId, currentPassword, newPassword);
        }
    }
}
