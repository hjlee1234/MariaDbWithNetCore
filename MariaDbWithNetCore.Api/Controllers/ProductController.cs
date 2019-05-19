using MariaDbWithNetCore.Entity;

using Microsoft.AspNetCore.Mvc;

namespace MariaDbWithNetCore.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(Product model)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Product model)
        {
            return Ok();
        }
    }
}