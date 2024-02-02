using MediatR;

namespace YandexTaxi.Application.UseCases.User.Queries
{
    public class GetUserCommand : IRequest<List<Domain.Entity.User>>
    {
    }
}
