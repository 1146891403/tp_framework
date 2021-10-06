using System.Data.Entity;

namespace TP.Data.Repository.EntityFramework
{
    public class EfDbContextProvider<TDbContext> : IDbContextProvider<TDbContext> where TDbContext : DbContext, new()
    {
        public TDbContext DbContext { get; }

        public EfDbContextProvider(TDbContext dbContext)
        {
            DbContext = dbContext;
        }
        
        public TDbContext GetDbContext()
        {
            return DbContext;
        }
    }
}
