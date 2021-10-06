using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common.Repository;

namespace TP.Repository.Administration.Interfaces
{
    public interface IClientTokenRepository : IRepository
    {
        Task<ClientToken> FindByIdAsync(long id);
    }
}
