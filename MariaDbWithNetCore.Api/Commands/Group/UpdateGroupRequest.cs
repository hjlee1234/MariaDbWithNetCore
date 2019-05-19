using MariaDbWithNetCore.Api.Types;

using MediatR;

namespace MariaDbWithNetCore.Api.Commands.Group
{
    public class UpdateGroupRequest : IRequest<ExecutionResult<bool>>
    {
        public Entity.Group Model { get; set; }

        public UpdateGroupRequest(Entity.Group model)
        {
            Model = model;
        }
    }
}
