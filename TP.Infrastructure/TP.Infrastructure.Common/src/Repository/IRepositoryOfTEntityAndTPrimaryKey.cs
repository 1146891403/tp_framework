using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TP.Infrastructure.Common.Entities;

namespace TP.Infrastructure.Common.Repository
{
    public interface IRepository<TEntity, TPrimaryKey> : IRepository 
        where TEntity : EntityBase<TPrimaryKey>
    {
        #region Select/Get/Query

        /// <summary>
        /// Used to get a IQueryable that is used to retrieve entities from entire table.
        /// </summary>
        /// <returns>IQueryable to be used to select entities from database</returns>
        IQueryable<TEntity> GetAll();

        /// <summary>
        /// Used to get a IQueryable that is used to retrieve entities from entire table.
        /// One or more 
        /// </summary>
        /// <param name="propertySelectors">A list of include expressions.</param>
        /// <returns>IQueryable to be used to select entities from database</returns>
        IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] propertySelectors);
        
        /// <summary>
        /// Used to get all entities.
        /// </summary>
        /// <returns>List of all entities</returns>
        Task<IList<TEntity>> GetAllListAsync();
        
        /// <summary>
        /// Used to get all entities based on given <paramref name="predicate"/>.
        /// </summary>
        /// <param name="predicate">A condition to filter entities</param>
        /// <returns>List of all entities</returns>
        Task<IList<TEntity>> GetAllListAsync(Expression<Func<TEntity, bool>> predicate);
        
        /// <summary>
        /// Gets an entity with given primary key.
        /// </summary>
        /// <param name="id">Primary key of the entity to get</param>
        /// <returns>Entity</returns>
        Task<TEntity> GetAsync(TPrimaryKey id);
        
        /// <summary>
        /// Gets exactly one entity with given predicate.
        /// Throws exception if no entity or more than one entity.
        /// </summary>
        /// <param name="predicate">Entity</param>
        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate);
        
        /// <summary>
        /// Gets an entity with given primary key or null if not found.
        /// </summary>
        /// <param name="id">Primary key of the entity to get</param>
        /// <returns>Entity or null</returns>
        Task<TEntity> FirstOrDefaultAsync(TPrimaryKey id);
        
        /// <summary>
        /// Gets an entity with given predicate or null if not found.
        /// </summary>
        /// <param name="predicate">Predicate to filter entities</param>
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Gets an entity and properties with given predicate or null if not found.
        /// </summary>
        /// <param name="propertySelectors"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] propertySelectors);
        
        #endregion

        #region Insert
        
        /// <summary>
        /// Inserts a new entity.
        /// </summary>
        /// <param name="entity">Inserted entity</param>
        Task<TEntity> InsertAsync(TEntity entity);

        /// <summary>
        /// bulk insert entities
        /// </summary>
        /// <param name="entities"></param>
        /// <returns>get count</returns>
        Task<int> BulkInsertAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// Inserts a new entity and gets it's Id.
        /// It may require to save current unit of work
        /// to be able to retrieve id.
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>Id of the entity</returns>
        Task<TPrimaryKey> InsertAndGetIdAsync(TEntity entity);
        
        /// <summary>
        /// Inserts or updates given entity depending on Id's value.
        /// </summary>
        /// <param name="entity">Entity</param>
        Task<TEntity> InsertOrUpdateAsync(TEntity entity);
        
        /// <summary>
        /// Inserts or updates given entity depending on Id's value.
        /// Also returns Id of the entity.
        /// It may require to save current unit of work
        /// to be able to retrieve id.
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>Id of the entity</returns>
        Task<TPrimaryKey> InsertOrUpdateAndGetIdAsync(TEntity entity);

        #endregion

        #region Update
        
        /// <summary>
        /// Updates an existing entity. 
        /// </summary>
        /// <param name="entity">Entity</param>
        Task<TEntity> UpdateAsync(TEntity entity);
        
        /// <summary>
        /// Updates an existing entity.
        /// </summary>
        /// <param name="id">Id of the entity</param>
        /// <param name="updateAction">Action that can be used to change values of the entity</param>
        /// <returns>Updated entity</returns>
        Task<TEntity> UpdateAsync(TPrimaryKey id, Func<TEntity, Task> updateAction);

        #endregion

        #region Delete
        
        /// <summary>
        /// Deletes an entity.
        /// </summary>
        /// <param name="entity">Entity to be deleted</param>
        Task DeleteAsync(TEntity entity);
        
        /// <summary>
        /// Deletes an entity by primary key.
        /// </summary>
        /// <param name="id">Primary key of the entity</param>
        Task DeleteAsync(TPrimaryKey id);
        
        /// <summary>
        /// Deletes many entities by function.
        /// Notice that: All entities fits to given predicate are retrieved and deleted.
        /// This may cause major performance problems if there are too many entities with
        /// given predicate.
        /// </summary>
        /// <param name="predicate">A condition to filter entities</param>
        Task DeleteAsync(Expression<Func<TEntity, bool>> predicate);

        #endregion

        #region Aggregates
        
        /// <summary>
        /// Gets count of all entities in this repository.
        /// </summary>
        /// <returns>Count of entities</returns>
        Task<int> CountAsync();
        
        /// <summary>
        /// Gets count of all entities in this repository based on given <paramref name="predicate"/>.
        /// </summary>
        /// <param name="predicate">A method to filter count</param>
        /// <returns>Count of entities</returns>
        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);
        
        /// <summary>
        /// Gets count of all entities in this repository (use if expected return value is greather than <see cref="int.MaxValue"/>.
        /// </summary>
        /// <returns>Count of entities</returns>
        Task<long> LongCountAsync();
        
        /// <summary>
        /// Gets count of all entities in this repository based on given <paramref name="predicate"/>
        /// (use this overload if expected return value is greather than <see cref="int.MaxValue"/>).
        /// </summary>
        /// <param name="predicate">A method to filter count</param>
        /// <returns>Count of entities</returns>
        Task<long> LongCountAsync(Expression<Func<TEntity, bool>> predicate);

        #endregion
    }
}
