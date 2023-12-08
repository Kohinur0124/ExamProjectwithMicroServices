using MediatR;

namespace Olx.Application.UseCases.User.Queries
{
    public class GetUserCommand : IRequest<List<Olx.Domain.Entity.User>>
    {
    }
}
