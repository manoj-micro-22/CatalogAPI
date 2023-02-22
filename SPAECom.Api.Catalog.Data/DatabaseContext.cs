using Microsoft.EntityFrameworkCore;

namespace SPAECom.Api.Catalog.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
