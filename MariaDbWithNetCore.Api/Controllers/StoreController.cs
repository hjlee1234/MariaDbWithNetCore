using MariaDbWithNetCore.Entity;

using Microsoft.AspNetCore.Mvc;

namespace MariaDbWithNetCore.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(Store model)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Store model)
        {
            return Ok();
        }
    }
}