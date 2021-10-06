using TP.Infrastructure.Common.Entities;

namespace TP.Infrastructure.Common.Repository
{
    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : EntityBase<int>
    {
    }

    public interface IRepositoryOfLong<TEntity> : IRepository<TEntity, long> where TEntity : EntityBaseOfLong
    { }
}
