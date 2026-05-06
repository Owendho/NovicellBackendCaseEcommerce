using Microsoft.AspNetCore.Mvc;
using ProductCatalogue.Models;

namespace ProductCatalogue.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductCatalogueController : ControllerBase
    {
        [HttpGet("ProductDetail")]
        public async Task<ActionResult<ProductModel>> GetProductDetail(string id)
        {
            //Simulated database call
            ProductModel product = new ProductModel { Id = "el - 01", Category = "cat-01", Image = "https://placehold.co/500x500", Price = 999.99, Title = "UltraThin Laptop", Description = "A sleek and powerful laptop for all your computing needs." };
            

            if (product == null)
            {
                return NotFound(new { message = "Product not found" });

            }

            return Ok(product);
        }


        [HttpGet("ProductList")]
        public async Task<ActionResult<ERPProduct>> GetProductList(string id)
        {
            // Simulated database call returning a list
            ERPProduct[] eRPProductList = new ERPProduct[]
            {
                new ERPProduct { Id = "el-01", Category = "cat-01", Image = "https://placehold.co/500x500", Price = 999.99, Title = "UltraThin Laptop", Description = "A sleek and powerful laptop for all your computing needs."},
                new ERPProduct { Id = "el-02", Category = "cat-02", Image = "https://placehold.co/500x500", Price = 199.99, Title = "Smart Watch Pro", Description = "Stay connected on the go with this smart watch."  },
                new ERPProduct { Id = "el-03", Category = "cat-02", Image = "https://placehold.co/500x500", Price = 149.99, Title = "Noise Cancelling Headphones", Description = "Experience music without distractions."  }
            };


            if (eRPProductList == null)
            {
                return NotFound(new { message = "Product list not found" });

            }

            return Ok(eRPProductList);
        }
        
    }
}
