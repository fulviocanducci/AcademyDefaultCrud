using Academy.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Academy.Dals
{
    public class DalStudent
    {
        private readonly IDbConnection _connection;
        public DalStudent(IDbConnection connection)
        {
            _connection = connection;
        }

        public Student Insert(Student model)
        {
            model.Id = (int)_connection.Insert(model);
            return model;
        }

        public bool Update(Student model)
        {
            return _connection.Update(model);
        }

        public Student Find(int id)
        {
            return _connection.Get<Student>(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _connection.GetAll<Student>();
        }

        public IEnumerable<Student> GetAll(string name)
        {
            StringBuilder str = new StringBuilder();
            DynamicParameters parameters = new DynamicParameters();
            str.Append("SELECT * FROM Students");
            if (!string.IsNullOrEmpty(name))
            {
                str.Append(" WHERE Name Like @Name");
                parameters.Add("@Name", $"%{name}%", DbType.String, ParameterDirection.Input, 50);
            }
            str.Append(" ORDER BY Name ASC");
            return _connection.Query<Student>(str.ToString(), parameters);
        }

        public bool Delete(int id)
        {
            Student model = Find(id);
            if (model != null)
            {
                return _connection.Delete(model);
            }
            return false;
        }
    }
}
