using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data;
namespace Academy.Dals.Bases
{
    public abstract class DalBase<T> where T : class
    {
        protected readonly IDbConnection Connection;

        public DalBase(IDbConnection connection)
        {
            Connection = connection;
        }

        public long Insert(T model)
        {
            return Connection.Insert(model);
        }

        public bool Update(T model)
        {
            return Connection.Update(model);
        }

        public T Find(int id)
        {
            return Connection.Get<T>(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Connection.GetAll<T>();
        }

        public bool Delete(T model)
        {
            if (model != null)
            {
                return Connection.Delete(model);
            }
            return false;
        }
    }
}
