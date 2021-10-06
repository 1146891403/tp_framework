using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Reflection;
using TP.Data.EntityFramework.Entities;
using TP.WL.ERP.Data.Extensions;

namespace TP.WL.ERP.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
            //this.Configuration.LazyLoadingEnabled = true;
        }

        public ApplicationDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        { }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            var user = modelBuilder.Entity<ApplicationUser>();
            user.ToTable("tpwl_admin_Users");
            user.HasOptional(x => x.Agent).WithMany().HasForeignKey(k => k.AgentId).WillCascadeOnDelete(false);
            user.HasMany(x => x.Groups).WithRequired().HasForeignKey(k => k.UserId);
            
            var role = modelBuilder.Entity<ApplicationRole>();
            role.ToTable("tpwl_admin_Roles");
            role.Property(x => x.Description).HasMaxLength(512);
            role.Property(x => x.IsEnabled).IsRequired();
            role.HasRequired(x => x.Subsidiary).WithMany(y => y.Roles).HasForeignKey(k => k.SubsidiaryId).WillCascadeOnDelete(false);
            role.HasMany(x => x.Groups).WithRequired().HasForeignKey(k => k.RoleId);
            role.HasMany(x => x.ViewLinks).WithRequired().HasForeignKey(k => k.RoleId);
            role.HasMany(x => x.Functions).WithRequired().HasForeignKey(k => k.RoleId);
            role.WithTraceable();
            
            var userRole = modelBuilder.Entity<ApplicationUserRole>();
            userRole.ToTable("tpwl_admin_UserInRoles");

            var userLogin = modelBuilder.Entity<ApplicationUserLogin>();
            userLogin.ToTable("tpwl_admin_UserLogins");

            var userClaim = modelBuilder.Entity<ApplicationUserClaim>();
            userClaim.ToTable("tpwl_admin_UserClaims");

            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
