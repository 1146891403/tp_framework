using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Administration;
using TP.Infrastructure.Common.Extensions;
using TP.WL.ERP.Data;

namespace TP.AspNet.Identity.EntityFramework
{
    public class ApplicationUserManager : UserManager<ApplicationUser, string>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser, string> store)
               : base(store)
        { }

        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options, IOwinContext context)
        {
            //var dbContext = context.Get<ApplicationDbContext>();
            //var userStore = new ApplicationUserStore(dbContext);

            //var manager = new ApplicationUserManager(userStore);

            var manager = new ApplicationUserManager(new ApplicationUserStore(context.Get<ApplicationDbContext>()));

            // Configure validation logic for usernames
            manager.UserValidator = new UserValidator<ApplicationUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };

            // Configure validation logic for passwords
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };

            // Configure user lockout defaults
            manager.UserLockoutEnabledByDefault = true;
            manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            manager.MaxFailedAccessAttemptsBeforeLockout = 5;

            // Register two factor authentication providers. This application uses Phone and Emails as a step of receiving a code for verifying the user
            // You can write your own provider and plug it in here.
            manager.RegisterTwoFactorProvider("Phone Code", new PhoneNumberTokenProvider<ApplicationUser>
            {
                MessageFormat = "Your security code is {0}"
            });
            manager.RegisterTwoFactorProvider("Email Code", new EmailTokenProvider<ApplicationUser>
            {
                Subject = "Security Code",
                BodyFormat = "Your security code is {0}"
            });
            //manager.EmailService = new EmailService();
            //manager.SmsService = new SmsService();
            var dataProtectionProvider = options.DataProtectionProvider;
            if (dataProtectionProvider != null)
            {
                manager.UserTokenProvider =
                    new DataProtectorTokenProvider<ApplicationUser>(dataProtectionProvider.Create("ASP.NET Identity"));
            }
            return manager;
        }

        public virtual async Task<UserProfile> GetProfileAsync(string userId) => await Store.As<ApplicationUserStore>().GetProfileAsync(userId);

        public virtual async Task<IEnumerable<ApplicationUser>> GetUsersInRoleAsync(string roleId) => await Store.As<ApplicationUserStore>().GetUsersInRoleAsync(roleId);

        public virtual async Task<IEnumerable<UserProfile>> GetUsersInSubsidiaryAsync(long subsidiaryId) => await Store.As<ApplicationUserStore>().GetUsersInSubsidiaryAsync(subsidiaryId);

        public virtual async Task<IEnumerable<ApplicationUser>> GetUsersInSubsidiaryAsync(long subsidiaryId, string roleId) => await Store.As<ApplicationUserStore>().GetUsersInSubsidiaryAsync(subsidiaryId, roleId);

        public virtual async Task<IEnumerable<UserProfile>> GetUsersInDepartmentAsync(long departmentId) => await Store.As<ApplicationUserStore>().GetUsersInDepartmentAsync(departmentId);

        public virtual async Task<IEnumerable<ApplicationUser>> GetUsersInDepartmentAsync(long departmentId, string roleId) => await Store.As<ApplicationUserStore>().GetUsersInDepartmentAsync(departmentId, roleId);

        public virtual async Task<IEnumerable<ViewLink>> GetViewsAsync(string userId) => await Store.As<ApplicationUserStore>().GetViewsAsync(userId);

        public virtual async Task<IEnumerable<ViewLinkFunction>> GetFunctionsAsync(string userId) => await Store.As<ApplicationUserStore>().GetFunctionsAsync(userId);
    }
}
