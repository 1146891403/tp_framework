using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common.Repository;

namespace TP.Repository.Administration.Interfaces
{
    public interface IRefreshTokenRepository : IRepository
    {
        Task<RefreshToken> FindByIdAsync(long id);

        Task<bool> InsertAsync(RefreshToken refreshToken);

        Task<bool> DeleteAsync(long id);
    }
}
