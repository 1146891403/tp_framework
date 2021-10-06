using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System.Collections.Generic;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities;
using TP.Infrastructure.Common.Extensions;
using TP.WL.ERP.Data;

namespace TP.AspNet.Identity.EntityFramework
{
    public class ApplicationRoleManager : RoleManager<ApplicationRole, string>
    {
        public ApplicationRoleManager(IRoleStore<ApplicationRole, string> store)
            : base(store)
        {
        }

        public static ApplicationRoleManager Create(IdentityFactoryOptions<ApplicationRoleManager> options, IOwinContext context)
        {
            var manager = new ApplicationRoleManager(new ApplicationRoleStore(context.Get<ApplicationDbContext>()));
            return manager;
        }

        public virtual async Task<ApplicationRole> FindUsersByRoleIdAsync(string roleId)
        {
            return await Store.As<ApplicationRoleStore>().FindUsersByRoleIdAsync(roleId);
        }

        public virtual async Task<ApplicationRole> FindViewsByRoleIdAsync(string roleId)
        {
            return await Store.As<ApplicationRoleStore>().FindViewsByRoleIdAsync(roleId);
        }

        public virtual async Task<ApplicationRole> FindFunctionsByRoleIdAsync(string roleId)
        {
            return await Store.As<ApplicationRoleStore>().FindFunctionsByRoleIdAsync(roleId);
        }

        public virtual async Task<IEnumerable<long>> GetViewsInRoleAsync(string roleId)
        {
            return await Store.As<ApplicationRoleStore>().GetViewsInRoleAsync(roleId);
        }

        public virtual async Task<IEnumerable<long>> GetFunctionsInRoleAsync(string roleId)
        {
            return await Store.As<ApplicationRoleStore>().GetFunctionsInRoleAsync(roleId);
        }

        public virtual async Task<IdentityResult> AddToUsersAsync(ApplicationRole role, IEnumerable<string> users)
        {
            return await Store.As<ApplicationRoleStore>().AddToUsersAsync(role, users);
        }

        public virtual async Task<IdentityResult> AddToViewsAsync(ApplicationRole role, IEnumerable<long> views)
        {
            return await Store.As<ApplicationRoleStore>().AddToViewsAsync(role, views);
        }

        public virtual async Task<IdentityResult> AddToFunctionsAsync(ApplicationRole role, IEnumerable<long> functions)
        {
            return await Store.As<ApplicationRoleStore>().AddToFunctionsAsync(role, functions);
        }

        public virtual async Task<IdentityResult> DeleteUsersAsync(ApplicationRole role, IEnumerable<string> users)
        {
            return await Store.As<ApplicationRoleStore>().DeleteUsersAsync(role, users);
        }

        public virtual async Task<IdentityResult> DeleteViewAsync(ApplicationRole role, IEnumerable<long> views)
        {
            return await Store.As<ApplicationRoleStore>().DeleteViewsAsync(role, views);
        }

        public virtual async Task<IdentityResult> DeleteFunctionAsync(ApplicationRole role, IEnumerable<long> functions)
        {
            return await Store.As<ApplicationRoleStore>().DeleteFunctionsAsync(role, functions);
        }
    }
}
