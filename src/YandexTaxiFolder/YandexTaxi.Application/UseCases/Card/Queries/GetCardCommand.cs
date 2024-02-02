using MediatR;

namespace YandexTaxi.Application.UseCases.Card.Queries
{
    public class GetCardCommand : IRequest<List<Domain.Entity.Card>>
    {
    }
}
