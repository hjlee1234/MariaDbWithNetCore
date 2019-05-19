using MariaDbWithNetCore.Entity;

using Microsoft.AspNetCore.Mvc;

namespace MariaDbWithNetCore.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(ProductImage model)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductImage model)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok();
        }
    }
}