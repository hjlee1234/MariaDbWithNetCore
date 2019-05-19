using System;
using System.Threading;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using MariaDbWithNetCore.Api.Types;

using MediatR;

namespace MariaDbWithNetCore.Api.Commands.Group
{
    public class UpdateGroupHandler : IRequestHandler<UpdateGroupRequest, ExecutionResult<bool>>
    {
        private readonly MariaDbContext _dbContext;
        public UpdateGroupHandler(MariaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ExecutionResult<bool>> Handle(UpdateGroupRequest request, CancellationToken cancellationToken)
        {
            var result = new ExecutionResult<bool>();
            try
            {
                ValidateGroupId(request);
                var currentGroup = await _dbContext.Groups.FirstOrDefaultAsync(c => c.GroupId == request.Model.GroupId, cancellationToken);
                ValidateGroupExistence(request, currentGroup);
                SetNewValues(request, currentGroup);
                _dbContext.Groups.Update(currentGroup);
                await _dbContext.SaveChangesAsync(cancellationToken);
                result.State = true;
            }
            catch (Exception ex)
            {
                result.State = false;
                result.Message = ex.Message;
            }

            return result;
        }

        private static void SetNewValues(UpdateGroupRequest request, Entity.Group currentGroup)
        {
            if(!string.IsNullOrEmpty(request.Model.Description))
            currentGroup.Description = request.Model.Description;

            if (!string.IsNullOrEmpty(request.Model.ImageUrl))
                currentGroup.ImageUrl = request.Model.ImageUrl;

            if (!string.IsNullOrEmpty(request.Model.LatinName))
                currentGroup.LatinName = request.Model.LatinName;

            if (!string.IsNullOrEmpty(request.Model.Name))
                currentGroup.Name = request.Model.Name;
        }

        private static void ValidateGroupExistence(UpdateGroupRequest request, Entity.Group currentGroup)
        {
            if (currentGroup == null) throw new Exception("There is not any group with this GroupId : " + request);
        }

        private static void ValidateGroupId(UpdateGroupRequest request)
        {
            if (request.Model.GroupId < 1) throw new Exception("GroupId not set");
        }
    }
}
