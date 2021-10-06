using System.Threading.Tasks;
using TP.Infrastructure.Common.Repository;

namespace TP.Repository.Utility.Interfaces
{
    public interface INumberRepository : IRepository
    {
        Task<string> GenerateAsync(string applicationName, long subsidiaryId);
    }
}
