using MediatR;

namespace YandexEats.Application.UseCases.Resturaunt.Queries
{
    public class GetResturauntCommand : IRequest<List<Domain.Entities.Restaurant>>
    {
    }
}
