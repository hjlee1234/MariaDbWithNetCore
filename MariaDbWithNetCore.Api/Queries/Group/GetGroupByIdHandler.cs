using System.Threading;
using System.Threading.Tasks;

using MediatR;
using Microsoft.EntityFrameworkCore;

namespace MariaDbWithNetCore.Api.Queries.Group
{
    public class GetGroupByIdHandler : IRequestHandler<GetGroupByIdRequest, Entity.Group>
    {
        private readonly MariaDbContext _dbContext;
        public GetGroupByIdHandler(MariaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Entity.Group> Handle(GetGroupByIdRequest request, CancellationToken cancellationToken)
        {
            return await _dbContext.Groups.FirstOrDefaultAsync(c => c.GroupId == request.Id, cancellationToken);
        }
    }
}
