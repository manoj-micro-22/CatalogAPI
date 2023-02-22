using SPAECom.Api.Catalog.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPAECom.Api.Catalog.Repository.Provider
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductList();

        Task<Product> GetProductById(int id);

        Task<Product> GetProductByName(string name);
    }
}
