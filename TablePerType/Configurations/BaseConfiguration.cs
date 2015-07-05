using System.Data.Entity.ModelConfiguration;
using TablePerType.Entities;

namespace TablePerType.Configurations
{
    public class BaseConfiguration : EntityTypeConfiguration<Base>
    {
        public BaseConfiguration()
        {
            HasKey(b => b.Id);

            Property(b => b.Id).HasColumnName("Id");
            Property(b => b.Name).HasColumnName("Name").IsRequired();
            
            ToTable("Base");
        }
    }

}
