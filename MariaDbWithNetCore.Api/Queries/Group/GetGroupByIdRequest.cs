using MediatR;

namespace MariaDbWithNetCore.Api.Queries.Group
{
    public class GetGroupByIdRequest : IRequest<Entity.Group>
    {
        public int Id { get; set; }

        public GetGroupByIdRequest(int id)
        {
            Id = id;
        }
    }
}
