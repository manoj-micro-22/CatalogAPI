using Microsoft.EntityFrameworkCore;
using SPAECom.Api.Catalog.Data.Models;
using System.Linq;

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
