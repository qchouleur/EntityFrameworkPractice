using System.Data.Entity.ModelConfiguration;
using TablePerType.Entities;

namespace TablePerType.Configurations
{
    public class DerivateConfiguration : EntityTypeConfiguration<Derivate>
    {
        public DerivateConfiguration()
        {
            HasKey(b => b.Id);

            Property(b => b.Id).HasColumnName("DerivateId");
            Property(d => d.Description).HasColumnName("Description");

            ToTable("Derivate");
        }
    }
}
