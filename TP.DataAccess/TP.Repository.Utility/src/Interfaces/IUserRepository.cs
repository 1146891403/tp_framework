using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities;
using TP.Data.EntityFramework.Entities.Administration;
using TP.Infrastructure.Common.Repository;

namespace TP.Repository.Utility.Interfaces
{
    public interface IUserRepository : IRepository
    {
        Task<ApplicationUser> FindById(string userId);

        Task<UserProfile> GetProfileById(string userId);
    }
}
