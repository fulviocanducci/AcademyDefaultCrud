using Academy.Models;
using System.Data.Entity.ModelConfiguration;

namespace Academy.Dals.Contexts.Configurations
{
    internal class EnterpriseConfiguration : EntityTypeConfiguration<Enterprise>
    {
        public EnterpriseConfiguration()
        {
            ToTable("Enterprises");

            HasKey(x => x.Id);

            Property(x => x.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            Property(x => x.Name).HasMaxLength(50).IsRequired();
            Property(x => x.Active).IsRequired();
        }
    }
}
