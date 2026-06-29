using Academy.Models;
using System.Data.Entity;
using System.Reflection;

namespace Academy.Dals.Contexts
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(string nameOrConnectionString)
            : base(nameOrConnectionString) { }

        public DbSet<Enterprise> Enterprise { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(typeof(DatabaseContext)));
            base.OnModelCreating(modelBuilder);
        }
    }
}
