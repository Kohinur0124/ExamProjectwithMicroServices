using MediatR;

namespace YandexEats.Application.UseCases.User.Queries
{
    public class GetUserCommand : IRequest<List<Domain.Entities.User>>
    {
    }
}
