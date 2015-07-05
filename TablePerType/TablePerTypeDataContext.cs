using System.Data.Entity;
using TablePerType.Configurations;
using TablePerType.Entities;

namespace TablePerType
{
    public class TablePerTypeDataContext : DbContext
    {
        private const string ConnectionString = @"Server=.;Database=TablePerTypeDemo;User Id=sa;Password=rootroot;";

        public TablePerTypeDataContext() : base(ConnectionString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Configurations.Add(new BaseConfiguration());
            modelBuilder.Configurations.Add(new DerivateConfiguration());
        }

        public DbSet<Base> Bases { get; set; }

        public DbSet<Derivate> Derivate { get; set; }
    }
}
