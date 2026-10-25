using System.Data.Entity;

namespace ProductStore.Mvc.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext()
            : base("ProductStoreConnection")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}