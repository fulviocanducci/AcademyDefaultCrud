using Academy.Dals.Bases;
using Academy.Dals.Contexts;
using Academy.Models;

namespace Academy.Dals
{
    public class DalEnterprise : DalBaseContext<Enterprise>
    {
        public DalEnterprise(DatabaseContext databaseContext) : base(databaseContext) { }
    }
}
