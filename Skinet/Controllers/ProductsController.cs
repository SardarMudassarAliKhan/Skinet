using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Skinet.Core.Entities;
using Skinet.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Skinet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet(nameof(GetProducts))]
        public ActionResult<List<Products>> GetProducts()
        {
            var obj = _productRepository.GetListOfproduct();
            return Ok(obj);
        }

        [HttpGet(nameof(GetProductById))]
        public async Task<Products> GetProductById(int Id)
        {
            return await _productRepository.GetProductByIdAsync(Id);
        }

        [HttpGet(nameof(GetProductBrand))]
        public ActionResult<List<ProductBrand>> GetProductBrand()
        {
            var obj = _productRepository.GetProductBrandAsync();
            return Ok(obj);
        }

        [HttpGet(nameof(GetProductType))]
        public ActionResult<List<ProductType>> GetProductType()
        {
            var obj = _productRepository.GetProductsTypeAsync();
            return Ok(obj);
        }
    }
}

