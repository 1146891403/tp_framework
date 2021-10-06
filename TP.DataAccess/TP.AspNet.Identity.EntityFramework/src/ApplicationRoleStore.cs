using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Administration;
using TP.WL.ERP.Data;

namespace TP.AspNet.Identity.EntityFramework
{
    public class ApplicationRoleStore : RoleStore<ApplicationRole, string, ApplicationUserRole>
    {
        public ApplicationRoleStore(ApplicationDbContext context)
            : base(context)
        {
        }
        
        private DbSet<ApplicationUserRole> Users { get { return Context.Set<ApplicationUserRole>(); } }

        private DbSet<ApplicationRoleView> RoleViews { get { return Context.Set<ApplicationRoleView>(); } }

        private DbSet<ApplicationRoleFunction> RoleFuncitons { get { return Context.Set<ApplicationRoleFunction>(); } }

        private DbSet<ViewLink> Views { get { return Context.Set<ViewLink>(); } }

        private DbSet<ViewLinkFunction> Functions { get { return Context.Set<ViewLinkFunction>(); } }

        protected Task SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }

        public async Task<ApplicationRole> FindUsersByRoleIdAsync(string roleId)
        {
            var query = from r in Roles
                        where r.Id.Equals(roleId)
                        select r;

            return await query.Include(x => x.Users).FirstOrDefaultAsync();
        }

        public async Task<ApplicationRole> FindViewsByRoleIdAsync(string roleId)
        {
            var query = from r in Roles
                        where r.Id.Equals(roleId)
                        select r;

            return await query.Include(x => x.Users).FirstOrDefaultAsync();
        }

        public async Task<ApplicationRole> FindFunctionsByRoleIdAsync(string roleId)
        {
            var query = from r in Roles
                        where r.Id.Equals(roleId)
                        select r;

            return await query.Include(x => x.Functions).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<long>> GetViewsInRoleAsync(string roleId)
        {
            var query = from rv in RoleViews
                        join vl in Views on rv.ViewLinkId equals vl.Id
                        where rv.RoleId.Equals(roleId) && vl.IsEnabled
                        select rv.ViewLinkId;

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<long>> GetFunctionsInRoleAsync(string roleId)
        {
            var query = from rf in RoleFuncitons
                        join vf in Functions on rf.FunctionId equals vf.Id
                        where rf.RoleId.Equals(roleId) && vf.IsEnabled
                        select rf.FunctionId;

            return await query.ToListAsync();
        }

        public async Task<IdentityResult> AddToUsersAsync(ApplicationRole role, IEnumerable<string> users)
        {
            if (role == null)
                throw new ArgumentNullException(nameof(role));

            if (users == null)
                throw new ArgumentNullException(nameof(users));

            foreach(var userId in users)
                Users.Add(CreateUserRole(role, userId));

            try
            {
                await SaveChangesAsync();
            }
            catch(DbUpdateException exception)
            {
                return IdentityResult.Failed(exception.Message);
            }

            return IdentityResult.Success;
        }

        private ApplicationUserRole CreateUserRole(ApplicationRole role, string userId) =>
            new ApplicationUserRole
            {
                RoleId = role.Id,
                UserId = userId
            };

        public async Task<IdentityResult> AddToViewsAsync(ApplicationRole role, IEnumerable<long> views)
        {
            if (role == null)
                throw new ArgumentNullException(nameof(role));

            if (views == null)
                throw new ArgumentNullException(nameof(views));

            foreach (var viewId in views)
                RoleViews.Add(CreateRoleView(role, viewId));

            try
            {
                await SaveChangesAsync();
            }
            catch (DbUpdateException exception)
            {
                return IdentityResult.Failed(exception.Message);
            }

            return IdentityResult.Success;
        }

        private ApplicationRoleView CreateRoleView(ApplicationRole role, long viewId) =>
            new ApplicationRoleView
            {
                RoleId = role.Id,
                ViewLinkId = viewId
            };

        public async Task<IdentityResult> AddToFunctionsAsync(ApplicationRole role, IEnumerable<long> functions)
        {
            if (role == null)
                throw new ArgumentNullException(nameof(role));

            if (functions == null)
                throw new ArgumentNullException(nameof(functions));

            foreach (var functionId in functions)
                RoleFuncitons.Add(CreateRoleFunction(role, functionId));

            try
            {
                await SaveChangesAsync();
            }
            catch (DbUpdateException exception)
            {
                return IdentityResult.Failed(exception.Message);
            }

            return IdentityResult.Success;
        }

        private ApplicationRoleFunction CreateRoleFunction(ApplicationRole role, long functionId) =>
            new ApplicationRoleFunction
            {
                RoleId = role.Id,
                FunctionId = functionId
            };

        public async Task<IdentityResult> DeleteUsersAsync(ApplicationRole role, IEnumerable<string> users)
        {
            if (role == null)
                throw new ArgumentNullException(nameof(role));

            var query = from u in Users
                        where u.RoleId.Equals(role.Id.ToString()) && users.Contains(u.UserId)
                        select u;

            var result = await query.ToListAsync();

            Users.RemoveRange(result);

            try
            {
                await SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException exception)
            {
                return IdentityResult.Failed(exception.Message);
            }

            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteViewsAsync(ApplicationRole role, IEnumerable<long> views)
        {
            if (role == null)
                throw new ArgumentNullException(nameof(role));

            var query = from rv in RoleViews
                        where rv.RoleId.Equals(role.Id.ToString()) && views.Contains(rv.ViewLinkId)
                        select rv;

            var result = await query.ToListAsync();

            RoleViews.RemoveRange(result);

            try
            {
                await SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException exception)
            {
                return IdentityResult.Failed(exception.Message);
            }

            return IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteFunctionsAsync(ApplicationRole role, IEnumerable<long> functions)
        {
            if (role == null)
                throw new ArgumentNullException(nameof(role));

            var query = from rf in RoleFuncitons
                        where rf.RoleId.Equals(role.Id.ToString()) && functions.Contains(rf.FunctionId)
                        select rf;

            var result = await query.ToListAsync();

            RoleFuncitons.RemoveRange(result);

            try
            {
                await SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException exception)
            {
                return IdentityResult.Failed(exception.Message);
            }

            return IdentityResult.Success;
        }
    }
}
