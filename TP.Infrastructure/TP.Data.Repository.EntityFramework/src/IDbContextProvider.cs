using System.Data.Entity;

namespace TP.Data.Repository.EntityFramework
{
    public interface IDbContextProvider<TDbContext> where TDbContext : DbContext
    {
        TDbContext GetDbContext();
    }
}
