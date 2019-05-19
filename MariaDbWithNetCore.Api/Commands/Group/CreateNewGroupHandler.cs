using System;
using System.Threading;
using System.Threading.Tasks;

using MariaDbWithNetCore.Api.Types;

using MediatR;

namespace MariaDbWithNetCore.Api.Commands.Group
{
    public class CreateNewGroupHandler : IRequestHandler<CreateNewGroupRequest, ExecutionResult<int>>
    {
        private readonly MariaDbContext _dbContext;
        public CreateNewGroupHandler(MariaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ExecutionResult<int>> Handle(CreateNewGroupRequest request, CancellationToken cancellationToken)
        {
            var result = new ExecutionResult<int>();

            try
            {
                await _dbContext.Groups.AddAsync(request.Model,cancellationToken);
                await _dbContext.SaveChangesAsync(cancellationToken);
                result.State = true;
            }
            catch (Exception e)
            {
                result.State = false;
                result.Message = e.Message;
            }

            return result;
        }
    }
}
