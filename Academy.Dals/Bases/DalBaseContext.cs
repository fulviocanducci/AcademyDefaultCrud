using Academy.Dals.Contexts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace Academy.Dals.Bases
{
    public abstract class DalBaseContext<T> where T : class
    {
        protected readonly DatabaseContext DatabaseContext;
        protected readonly DbSet<T> Set;

        protected DalBaseContext(DatabaseContext databaseContext)
        {
            DatabaseContext = databaseContext;
            Set = databaseContext.Set<T>();
        }

        public T Insert(T entity)
        {
            Set.Add(entity);
            DatabaseContext.SaveChanges();
            Detach(entity);
            return entity;
        }

        public bool Update(T entity)
        {
            Attach(entity);
            Modified(entity);
            bool status = DatabaseContext.SaveChanges() > 0;
            Detach(entity);
            return status;
        }

        public T Get(params object[] keysValues)
        {
            var entity = Find(keysValues);
            if (entity != null)
            {
                Detach(entity);
            }
            return entity;
        }

        public T Find(params object[] keysValues)
        {
            return Set.Find(keysValues);
        }

        public bool Delete(T entity)
        {
            try
            {
                Deleted(entity);
                return DatabaseContext.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return Set.AsNoTracking().ToList();
        }

        public IQueryable<T> Query()
        {
            return Set.AsNoTracking();
        }

        public int Save()
        {
            return DatabaseContext.SaveChanges();
        }

        #region protected
        protected virtual void Detach(T entity)
        {
            if (entity != null)
            {
                DatabaseContext.Entry(entity).State = EntityState.Detached;
            }
        }

        protected virtual void Modified(T entity)
        {
            DatabaseContext.Entry(entity).State = EntityState.Modified;
        }

        protected virtual void Deleted(T entity)
        {
            if (DatabaseContext.Entry(entity).State == EntityState.Detached)
            {
                Set.Attach(entity);
            }
            Set.Remove(entity);
        }

        protected virtual void Attach(T entity)
        {
            if (DatabaseContext.Entry(entity).State == EntityState.Detached)
            {
                Set.Attach(entity);
            }
        }
        #endregion
    }
}
