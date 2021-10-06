using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TP.AspNet.Identity.EntityFramework;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Administration;
using TP.Infrastructure.Common.Repository;
using TP.Repository.Administration.Interfaces;

namespace TP.Repository.Administration.Services
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly IOwinContext _context;
        private ApplicationRoleManager _roleManager;
        private IRepositoryOfLong<Subsidiary> _subsidiaryRepository;

        public PermissionRepository(IOwinContext context, IRepositoryOfLong<Subsidiary> subsidiaryRepository)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _subsidiaryRepository = subsidiaryRepository ?? throw new ArgumentNullException(nameof(subsidiaryRepository));
        }

        public ApplicationRoleManager RoleManager
        {
            get { return _roleManager ?? (_roleManager = _context.Get<ApplicationRoleManager>()); }
            private set { _roleManager = value; }
        }

        public async Task<IEnumerable<ApplicationRole>> FindRolesAsync()
        {
            return await RoleManager.Roles.ToListAsync();
        }

        public async Task<IEnumerable<Subsidiary>> FindRolesBySubsidiaryId(long subsidiaryId)
        {
            var query = _subsidiaryRepository.GetAll().Where(x => x.IsEnabled);

            query = subsidiaryId > 0 ? query.Where(x => x.Id == subsidiaryId) : query;

            return await query.Include(x => x.Roles).Where(r => r.IsEnabled).ToListAsync();
        }

        public async Task<ApplicationRole> FindRoleByIdAsync(string roleId)
        {
            return await RoleManager.FindByIdAsync(roleId);
        }

        public async Task<ApplicationRole> FindRoleByNameAsync(string roleName)
        {
            return await RoleManager.FindByNameAsync(roleName);
        }

        public async Task<ApplicationRole> FindUsersByRoleIdAsync(string roleId)
        {
            return await RoleManager.FindUsersByRoleIdAsync(roleId);
        }

        public async Task<ApplicationRole> FindViewsByRoleIdAsync(string roleId)
        {
            return await RoleManager.FindViewsByRoleIdAsync(roleId);
        }

        public async Task<ApplicationRole> FindFunctionsByRoleIdAsync(string roleId)
        {
            return await RoleManager.FindFunctionsByRoleIdAsync(roleId);
        }

        public async Task<IEnumerable<long>> GetViewsInRoleAsync(string roleId)
        {
            return await RoleManager.GetViewsInRoleAsync(roleId);
        }

        public async Task<IEnumerable<long>> GetFunctionsInRoleAsync(string roleId)
        {
            return await RoleManager.GetFunctionsInRoleAsync(roleId);
        }

        public async Task<IdentityResult> InsertRoleAsync(ApplicationRole role)
        {
            return await RoleManager.CreateAsync(role);
        }

        public async Task<bool> InsertRoleViewAsync(ApplicationRoleView roleView)
        {
            return await Task.FromResult(true);
        }

        public async Task<bool> InsertRoleFunctionAsync(ApplicationRoleFunction roleFunction)
        {
            return await Task.FromResult(true);
        }

        public async Task<IdentityResult> BulkInsertUserRolesAsync(ApplicationRole role, IEnumerable<string> users)
        {
            return await RoleManager.AddToUsersAsync(role, users);
        }

        public async Task<IdentityResult> BulkInsertRoleViewsAsync(ApplicationRole role, IEnumerable<long> views)
        {
            return await RoleManager.AddToViewsAsync(role, views);
        }

        public async Task<IdentityResult> BulkInsertRoleFunctionsAsync(ApplicationRole role, IEnumerable<long> functions)
        {
            return await RoleManager.AddToFunctionsAsync(role, functions);
        }

        public async Task<IdentityResult> UpdateRoleAsync(ApplicationRole role)
        {
            return await RoleManager.UpdateAsync(role);
        }

        public async Task<IdentityResult> DeleteUserRolesAsync(ApplicationRole role, IEnumerable<string> users)
        {
            return await RoleManager.DeleteUsersAsync(role, users);
        }

        public async Task<IdentityResult> DeleteRoleViewsAsync(ApplicationRole role, IEnumerable<long> views)
        {
            return await RoleManager.DeleteViewAsync(role, views);
        }

        public async Task<IdentityResult> DeleteRoleFunctionsAsync(ApplicationRole role, IEnumerable<long> functions)
        {
            return await RoleManager.DeleteFunctionAsync(role, functions);
        }
    }
}
