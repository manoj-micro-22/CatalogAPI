using SPAECom.Api.Catalog.Data.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SPAECom.Api.Catalog.Repository.Provider
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);
        Task<bool> DeleteProduct(int productId);
    }
}
