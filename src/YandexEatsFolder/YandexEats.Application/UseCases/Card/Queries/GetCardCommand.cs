using MediatR;

namespace YandexEats.Application.UseCases.Card.Queries
{
    public class GetCardCommand : IRequest<List<Domain.Entities.Card>>
    {
    }
}
