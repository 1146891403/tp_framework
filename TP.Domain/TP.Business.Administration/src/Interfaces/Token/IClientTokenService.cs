using System.Threading.Tasks;
using TP.Data.EntityFramework.Entities.Utilities;
using TP.Infrastructure.Common.Dependency;

namespace TP.Business.Administration.Interfaces
{
    public interface IClientTokenService : ITransientDependency
    {
        Task<ClientToken> Get(long clientId);
    }
}
