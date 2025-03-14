using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace Grossery
{
    public partial class MarketEntities : DbContext
    {
        public MarketEntities() : base("name=MarketEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }


        public virtual DbSet<Product> Products { get; set; }
    }
}


