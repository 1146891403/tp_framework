using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Administration;
using TP.WL.ERP.Data;

namespace TP.AspNet.Identity.EntityFramework
{
    public class ApplicationUserStore : UserStore<ApplicationUser, ApplicationRole, string, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public ApplicationUserStore(ApplicationDbContext context)
            : base(context)
        {
            base.DisposeContext = true;
        }

        public ApplicationUserStore(DbContext context)
            : base(context)
        {
        }

        private DbSet<UserProfile> Profiles { get { return Context.Set<UserProfile>(); } }

        private DbSet<ApplicationUserRole> UserRoles { get { return Context.Set<ApplicationUserRole>(); } }

        private DbSet<ApplicationRoleView> RoleViews { get { return Context.Set<ApplicationRoleView>(); } }

        private DbSet<ApplicationRoleFunction> RoleFunctions { get { return Context.Set<ApplicationRoleFunction>(); } }

        private DbSet<Department> Departments { get { return Context.Set<Department>(); } }

        public async Task<UserProfile> GetProfileAsync(string userId)
        {
            var query = from profile in Profiles
                        where profile.Id.Equals(userId)
                        select profile;

            return await query.FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsersInRoleAsync(string roleId)
        {
            var query = from user in Users
                        join userrole in UserRoles on user.Id equals userrole.UserId
                        where userrole.RoleId.Equals(roleId)
                        select user;

            return await query.Include(x => x.Profile.Department).ToListAsync();
        }

        public async Task<IEnumerable<UserProfile>> GetUsersInSubsidiaryAsync(long subsidiaryId)
        {
            var query = from profile in Profiles
                        where profile.SubsidiaryId.Equals(subsidiaryId)
                        select profile;

            return await query.Include(x => x.User).ToListAsync();
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsersInSubsidiaryAsync(long subsidiaryId, string roleId)
        {
            var query = from u in Users
                        join p in Profiles on u.Id equals p.Id
                        where !u.LockoutEnabled && p.SubsidiaryId == subsidiaryId && !u.Roles.Any(r => r.RoleId == roleId)
                        select new { u, p };

            return (await query.ToListAsync()).Select(x => x.u);
        }
        
        public async Task<IEnumerable<UserProfile>> GetUsersInDepartmentAsync(long departmentId)
        {
            var query = from profile in Profiles
                        where profile.DepartmentId.Equals(departmentId)
                        select profile;

            return await query.Include(x => x.User).ToListAsync();
        }

        public async Task<IEnumerable<ApplicationUser>> GetUsersInDepartmentAsync(long departmentId, string roleId)
        {
            var query = from u in Users
                        join p in Profiles on u.Id equals p.Id
                        where !u.LockoutEnabled && p.DepartmentId.Equals(departmentId) && !u.Roles.Any(x => x.RoleId == roleId)
                        select new { u, p };

            return (await query.ToListAsync()).Select(x => x.u);
        }

        public async Task<IEnumerable<ViewLink>> GetViewsAsync(string userId)
        {
            var query = from userrole in UserRoles
                        join roleview in RoleViews on userrole.RoleId equals roleview.RoleId
                        where userrole.UserId.Equals(userId) && roleview.ViewLink.IsEnabled
                        select roleview.ViewLink;

            return await query.Include(x => x.Parent.Parent).ToListAsync();
        }

        public async Task<IEnumerable<ViewLinkFunction>> GetFunctionsAsync(string userId)
        {
            var query = from userrole in UserRoles
                        join rolefunc in RoleFunctions on userrole.RoleId equals rolefunc.RoleId
                        where userrole.UserId.Equals(userId) && rolefunc.Function.IsEnabled
                        select rolefunc.Function;

            return await query.ToListAsync();
        }
    }
}
