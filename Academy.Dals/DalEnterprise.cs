using Academy.Dals.Bases;
using Academy.Dals.Contexts;
using Academy.Models;
using System.Collections.Generic;
using System.Linq;

namespace Academy.Dals
{
    public class DalEnterprise : DalBaseContext<Enterprise>
    {
        public DalEnterprise(DatabaseContext databaseContext) : base(databaseContext) { }

        public List<Enterprise> GetAll(string name)
        {
            var query = Query();
            if (string.IsNullOrWhiteSpace(name) == false)
            {
                query = query.Where(c => c.Name.Contains(name));
            }
            return query.OrderBy(c => c.Name).ToList();
        }
    }
}
