using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common.Dependency;

namespace TP.Business.Administration.Interfaces
{
    public interface IRefreshTokenService : ITransientDependency
    {
        Task<RefreshToken> Get(long id);

        Task<bool> Add(RefreshToken refreshToken);

        Task<bool> Remove(long id);
    }
}
