using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TP.Infrastructure.Common.Entities;
using TP.Infrastructure.Common.Extensions;

namespace TP.Data.Repository.EntityFramework
{
    public class EfRepositoryBase<TDbContext, TEntity, TPrimaryKey> : RepositoryBase<TEntity, TPrimaryKey>, IDisposable
        where TEntity : EntityBase<TPrimaryKey>
        where TDbContext : DbContext
    {
        private readonly IDbContextProvider<TDbContext> _dbContextProvider;

        public EfRepositoryBase(IDbContextProvider<TDbContext> dbContextProvider)
        {
            _dbContextProvider = dbContextProvider ?? throw new ArgumentNullException(nameof(dbContextProvider));
        }

        //public EfRepositoryBase(TDbContext dbContext)
        //{
        //    Context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        //}

        public virtual TDbContext Context { get { return _dbContextProvider.GetDbContext(); } }

        //public virtual TDbContext Context { get; set; }

        public virtual DbSet<TEntity> Table { get { return Context.Set<TEntity>(); } }

        public override DbContext GetContext()
        {
            return Context;
        }

        public override IQueryable<TEntity> GetAll()
        {
            return Table;
        }

        public override IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            var query = GetAll();

            if (propertySelectors.IsNullOrEmpty())
            {
                return query;
            }

            foreach(var propertySelector in propertySelectors)
            {
                query = query.Include(propertySelector);
            }

            return query;
        }

        public override async Task<IList<TEntity>> GetAllListAsync()
        {
            return await Table.ToListAsync();
        }

        public override async Task<IList<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Table.Where(predicate).ToListAsync();
        }

        public override async Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Table.SingleAsync(predicate);
        }
        
        public override async Task<TEntity> FirstOrDefaultAsync(TPrimaryKey id)
        {
            return await Table.AsNoTracking().FirstOrDefaultAsync(CreateEqualityExpressionForId(id));
        }

        public override async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await Table.AsNoTracking().FirstOrDefaultAsync(predicate);
        }

        public override async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] propertySelectors)
        {
            return await GetAllIncluding(propertySelectors).FirstOrDefaultAsync(predicate);
        }

        public override async Task<TEntity> GetAsync(TPrimaryKey id)
        {
            return await Table.AsNoTracking().FirstOrDefaultAsync(CreateEqualityExpressionForId(id));
        }

        public override TEntity Insert(TEntity entity)
        {
            return Table.Add(entity);
        }

        public override async Task<TEntity> InsertAsync(TEntity entity)
        {
            var ent = Table.Add(entity);

            await Context.SaveChangesAsync();
            
            return await Task.FromResult(ent);
        }

        public override int BulkInsert(IEnumerable<TEntity> entities)
        {
            Table.AddRange(entities);

            return Context.SaveChanges();
        }

        public override async Task<int> BulkInsertAsync(IEnumerable<TEntity> entities)
        {
            var ent = Table.AddRange(entities);

            return await Context.SaveChangesAsync();
        }

        public override async Task<TEntity> InsertOrUpdateAsync(TEntity entity)
        {
            return entity.IsTransient() ? await InsertAsync(entity) : await UpdateAsync(entity);
        }

        public override TPrimaryKey InsertAndGetId(TEntity entity)
        {
            entity = Insert(entity);

            if (entity.IsTransient())
            {
                Context.SaveChanges();
            }

            return entity.Id;
        }

        public override async Task<TPrimaryKey> InsertAndGetIdAsync(TEntity entity)
        {
            entity = await InsertAsync(entity);

            if (entity.IsTransient())
            {
                await Context.SaveChangesAsync();
            }

            return entity.Id;
        }
        
        public override TPrimaryKey InsertOrUpdateAndGetId(TEntity entity)
        {
            entity = InsertOrUpdate(entity);

            if (entity.IsTransient())
            {
                Context.SaveChanges();
            }

            return entity.Id;
        }

        public override async Task<TPrimaryKey> InsertOrUpdateAndGetIdAsync(TEntity entity)
        {
            entity = await InsertOrUpdateAsync(entity);

            if (entity.IsTransient())
            {
                await Context.SaveChangesAsync();
            }

            return entity.Id;
        }

        public override TEntity Update(TEntity entity)
        {
            AttachIfNot(entity);

            Context.Entry(entity).State = EntityState.Modified;
            Context.SaveChanges();

            return entity;
        }

        public override async Task<TEntity> UpdateAsync(TEntity entity)
        {
            AttachIfNot(entity);

            //Context.Entry(entity).State = EntityState.Modified;

            var entry = Context.Entry(entity);

            var objectContext = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)Context).ObjectContext;

            var aaa = objectContext.ObjectStateManager.GetObjectStateEntry(entity).EntityKey.EntityKeyValues.Select(k => k.Key);

            var a = entry.OriginalValues.GetValue<string>("Remark");
            var b = entry.CurrentValues.GetValue<string>("Remark");

            var c = a == b;

            var propertyNames = entry.CurrentValues.PropertyNames;

            IEnumerable<string> modifiedProperties = from name in propertyNames
                                                     where entry.Property(name).IsModified
                                                     select name;

            foreach(var name in modifiedProperties)
            {
                entry.Property(name).IsModified = true;
            }

            await Context.SaveChangesAsync();

            return await Task.FromResult(entity);
        }

        public override async Task<TEntity> UpdateAsync(TPrimaryKey id, Func<TEntity, Task> updateAction)
        {
            var entity = await GetAsync(id);
            await updateAction(entity);
            return entity;
        }

        public override void Delete(TEntity entity)
        {
            AttachIfNot(entity);
            Table.Remove(entity);
        }

        public override void Delete(TPrimaryKey id)
        {
            var entity = Table.Local.FirstOrDefault(ent => EqualityComparer<TPrimaryKey>.Default.Equals(ent.Id, id));
            if (entity == null)
            {
                entity = FirstOrDefault(id);
                if (entity == null)
                {
                    return;
                }
            }

            Delete(entity);
        }

        public override Task DeleteAsync(TEntity entity)
        {
            AttachIfNot(entity);

            Table.Remove(entity);
            
            return Task.FromResult(0);
        }

        public override async Task DeleteAsync(TPrimaryKey id)
        {
            var entity = Table.Local.FirstOrDefault(ent => EqualityComparer<TPrimaryKey>.Default.Equals(ent.Id, id));

            if (entity == null)
            {
                entity = await FirstOrDefaultAsync(id);
                if (entity == null)
                {
                    return;
                }
            }

            await DeleteAsync(id);
        }

        public override async Task DeleteAsync(Expression<Func<TEntity, bool>> predicate)
        {
            foreach (var entity in await GetAllListAsync(predicate))
            {
                await DeleteAsync(entity);
            }
        }

        public override async Task<int> CountAsync()
        {
            return await GetAll().CountAsync();
        }

        public override async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await GetAll().Where(predicate).CountAsync();
        }

        public override async Task<long> LongCountAsync()
        {
            return await GetAll().LongCountAsync();
        }

        public override async Task<long> LongCountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await GetAll().Where(predicate).LongCountAsync();
        }

        protected virtual void AttachIfNot(TEntity entity)
        {
            if (!Table.Local.Contains(entity))
            {
                Table.Attach(entity);
            }
        }

        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
        }
    }
}
