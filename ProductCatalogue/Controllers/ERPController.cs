using Microsoft.AspNetCore.Mvc;
using ProductCatalogue.Models;
using Microsoft.Extensions.Http;

namespace ProductCatalogue.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ERPController : ControllerBase
    {

        private readonly ERPSync _erpSync;

        public ERPController(ERPSync erpSync) {
            _erpSync = erpSync;
        }

        [HttpPost("products")]
        public async Task<IActionResult> GetERPProduct()
        {
            await _erpSync.GetAsyncEcommerceProducts();
            return Ok("Got products");
            //Save to Database
        }

        [HttpPost("categories")]
        public async Task<IActionResult> GetERPCategory()
        {
            await _erpSync.GetAsyncEcommerceCategories();
            return Ok("Got Catergories");
            //save to Database
        }

    }
}
