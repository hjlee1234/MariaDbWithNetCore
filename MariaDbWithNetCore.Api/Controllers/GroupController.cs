
using MariaDbWithNetCore.Api.Commands.Group;
using MariaDbWithNetCore.Api.Queries.Group;
using MariaDbWithNetCore.Entity;

using MediatR;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MariaDbWithNetCore.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private IMediator _mediator;
        public GroupController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(Group model)
        {
            if (ModelState.IsValid)
            {
                return BadRequest(ModelState.ErrorCount);
            }

            var executionResult = await _mediator.Send(new CreateNewGroupRequest(model));
            if (executionResult.State) return Created(Url.Action("Get"), executionResult.Result);
            return BadRequest(executionResult.Message);
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            if (ModelState.IsValid)
            {
                return BadRequest(ModelState.ErrorCount);
            }

            var group = await _mediator.Send(new GetGroupByIdRequest(id));
            if (group == null) return NotFound(id);
            return Ok(group);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Group model)
        {
            if (ModelState.IsValid)
            {
                return BadRequest(ModelState.ErrorCount);
            }

            var executionResult = await _mediator.Send(new UpdateGroupRequest(model));
            if (executionResult.State) return Ok();
            return BadRequest(executionResult);
        }
    }
}