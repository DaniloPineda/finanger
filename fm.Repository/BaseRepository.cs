using fm.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace fm.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {

        protected DbContext Context { get; set; }

        private DbSet<TEntity> DbSet => Context.Set<TEntity>();

        public BaseRepository(DbContext context)
        {
            this.Context = context;
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = this.DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }

        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> predicate = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return this.GetQuery(predicate, orderBy, includeProperties);
        }


        public virtual IEnumerable<T> Get<T>(
            Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            params Expression<Func<T, object>>[] includeProperties) where T : class
        {
            return this.GetQuery<T>(predicate, orderBy, includeProperties);
        }

        public virtual TEntity GetByID(object id)
        {
            return this.DbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            this.DbSet.Add(entity);
        }
        public async virtual Task InsertAsync(TEntity entity)
        {
            await this.DbSet.AddAsync(entity);
        }

        public virtual void InsertRange(IEnumerable<TEntity> entities)
        {
            this.DbSet.AddRange(entities);
        }

        public virtual void Delete(object id)
        {
            TEntity entityToDelete = this.DbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (this.Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                this.DbSet.Attach(entityToDelete);
            }

            this.DbSet.Remove(entityToDelete);
        }

        public virtual void Delete(IEnumerable<TEntity> entityToDelete)
        {
            this.DbSet.RemoveRange(entityToDelete);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            this.DbSet.Attach(entityToUpdate);
            this.Context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        protected void UpdateEntity(TEntity entity, TEntity updatedEntity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.Entry(entity).CurrentValues.SetValues(updatedEntity);
        }

        protected TEntity SaveEntity(TEntity newEntity, Action<TEntity> forInsert = null, params object[] ids)
        {
            var entity = this.DbSet.Find(ids);
            if (entity != null)
            {
                UpdateEntity(entity, newEntity);
            }
            else
            {
                forInsert?.Invoke(newEntity);
                this.DbSet.Add(newEntity);
            }

            return newEntity;
        }

        public virtual IQueryable<TEntity> GetQuery(Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = this.DbSet;

            if (includeProperties != null)
            {

                foreach (var includeProperty in includeProperties)
                {
                    query = query.Include(includeProperty);
                }



            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return orderBy != null ? orderBy(query) : query;
        }

        public virtual IQueryable<T> GetQuery<T>(Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy,
            params Expression<Func<T, object>>[] includeProperties) where T : class
        {
            IQueryable<T> query = Context.Set<T>();

            if (includeProperties != null)
            {

                foreach (var includeProperty in includeProperties)
                {
                    var includePropertyAsString = includeProperty.Body.ToString();

                    var index = includePropertyAsString.IndexOf(".", StringComparison.Ordinal);

                    query = query.Include(index < 0
                        ? includePropertyAsString
                        : includePropertyAsString.Remove(0, index + 1));
                }
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return orderBy != null ? orderBy(query) : query;
        }        

        public void Reload(TEntity entity)
        {
            Context.Entry(entity).Reload();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            return await DbSet.AnyAsync(predicate);
        }
    }

}
