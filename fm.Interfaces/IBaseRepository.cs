using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace fm.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        TEntity GetByID(object id);

        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params Expression<Func<TEntity, object>>[] includeProperties);
        IQueryable<TEntity> GetQuery(Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy,
            Expression<Func<TEntity, object>>[] includeProperties = null);

        void Insert(TEntity entity);

        Task InsertAsync(TEntity entity);

        void InsertRange(IEnumerable<TEntity> entities);

        void Delete(object id);

        void Delete(TEntity entityToDelete);

        void Delete(IEnumerable<TEntity> entityToDelete);

        void Update(TEntity entityToUpdate);

        void Reload(TEntity instance);

        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate = null);

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
