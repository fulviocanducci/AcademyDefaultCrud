using Academy.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Text;
namespace Academy.Dals
{
    public class DalStudent : Bases.DalBase<Student>
    {
        public DalStudent(IDbConnection connection) : base(connection) { }

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
            return Connection.Query<Student>(str.ToString(), parameters);
        }
    }
}
