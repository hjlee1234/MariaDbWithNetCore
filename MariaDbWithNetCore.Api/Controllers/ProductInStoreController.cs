using MariaDbWithNetCore.Entity;

using Microsoft.AspNetCore.Mvc;

namespace MariaDbWithNetCore.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductInStoreController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(ProductInStore model)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            return Ok();
        }
    }
}