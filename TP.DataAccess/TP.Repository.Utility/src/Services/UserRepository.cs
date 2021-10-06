using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Threading.Tasks;
using TP.AspNet.Identity.EntityFramework;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Administration;
using TP.Repository.Utility.Interfaces;

namespace TP.Repository.Utility.Services
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

        public async Task<ApplicationUser> FindById(string userId)
        {
            return await UserManager.FindByIdAsync(userId);
        }

        public async Task<UserProfile> GetProfileById(string userId)
        {
            return await UserManager.GetProfileAsync(userId);
        }
    }
}
