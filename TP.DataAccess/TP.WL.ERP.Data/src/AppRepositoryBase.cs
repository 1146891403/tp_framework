using TP.Data.Repository.EntityFramework;
using TP.Infrastructure.Common.Entities;
using TP.Infrastructure.Common.Repository;

namespace TP.WL.ERP.Data
{
    public class AppRepositoryBase<TEntity> : EfRepositoryBase<ApplicationDbContext, TEntity, int>, IRepository<TEntity>
        where TEntity : EntityBase<int>
    {
        public AppRepositoryBase(IDbContextProvider<ApplicationDbContext> dbContextProvider) : base(dbContextProvider) { }

        //public AppRepositoryBase(ApplicationDbContext dbContext) : base(dbContext) { }
    }

    public class AppRepositoryOfLongBase<TEntity> : EfRepositoryBase<ApplicationDbContext, TEntity, long>, IRepositoryOfLong<TEntity>
        where TEntity : EntityBaseOfLong
    {
        public AppRepositoryOfLongBase(IDbContextProvider<ApplicationDbContext> dbContextProvider) : base(dbContextProvider) { }

        //public AppRepositoryOfLongBase(ApplicationDbContext dbContext) : base(dbContext) { }
    }

    public class AppRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ApplicationDbContext, TEntity, TPrimaryKey>, IRepository<TEntity, TPrimaryKey>
        where TEntity : EntityBase<TPrimaryKey>
    {
        public AppRepositoryBase(IDbContextProvider<ApplicationDbContext> dbContextProvider) : base(dbContextProvider) { }

        //public AppRepositoryBase(ApplicationDbContext dbContext) : base(dbContext) { }
    }
}
