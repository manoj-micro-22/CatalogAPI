using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SPAECom.Api.Catalog.Data;
using SPAECom.Api.Catalog.Data.Models;
using SPAECom.Api.Catalog.Repository.Provider;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPAECom.Api.Catalog.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ILogger _logger;

        private readonly DatabaseContext _dbContext;

        public ProductRepository(ILogger<ProductRepository> logger, DatabaseContext context)
        {
            _logger = logger;
            _dbContext = context;
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(i => i.ProductId == id);
        }

        public async Task<Product> GetProductByName(string name)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(i => i.Name == name);
        }

        public async Task<IEnumerable<Product>> GetProductList()
        {
            return await _dbContext.Products.ToListAsync();
        }
    }
}
