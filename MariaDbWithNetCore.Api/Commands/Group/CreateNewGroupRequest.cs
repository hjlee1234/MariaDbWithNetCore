
using MariaDbWithNetCore.Api.Types;

using MediatR;

namespace MariaDbWithNetCore.Api.Commands.Group
{
    public class CreateNewGroupRequest : IRequest<ExecutionResult<int>>
    {
        public Entity.Group Model { get; set; }
        public CreateNewGroupRequest(Entity.Group model)
        {
            Model = model;
        }
    }
}
