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
            DatabaseContext.Entry(entity).State = EntityState.Detached;
            return entity;
        }

        public bool Update(T entity)
        {
            DatabaseContext.Entry(entity).State = EntityState.Modified;
            return DatabaseContext.SaveChanges() > 0;
        }

        public T Find(params object[] keysValues)
        {
            return Set.Find(keysValues);
        }

        public bool Delete(T entity)
        {
            DatabaseContext.Entry(entity).State = EntityState.Detached;
            return DatabaseContext.SaveChanges() > 0;
        }

        public IEnumerable<T> GetAll()
        {
            return Set.AsNoTracking().ToList();
        }
    }
}
