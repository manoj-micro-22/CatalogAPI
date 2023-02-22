using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System;
using SPAECom.Api.Catalog.Data;
using System.Threading.Tasks;
using SPAECom.Api.Catalog.Repository.Provider;

namespace SPAECom.Api.Catalog.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        private readonly IProductRepository _productRepository;

        public ProductController(ILogger<ProductController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        [HttpGet]
        [Route("products")]
        [ProducesResponseType(typeof(IEnumerable<Product>), StatusCodes.Status200OK)]
        public async Task<JsonResult> GetProductList()
        {
           var result = await _productRepository.GetProductList();
           return new JsonResult(result);
        }

        [HttpGet]
        [Route("product/{productId}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        public async Task<Product> GetProductById(int productId)
        {
            return await _productRepository.GetProductById(productId);
        }

        [HttpGet]
        [Route("productname/{productName}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        public async Task<Product> GetProductByName(string productName)
        {
            return await _productRepository.GetProductByName(productName);
        }
    }
}
