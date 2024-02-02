using MediatR;

namespace YandexEats.Application.UseCases.Basket.Queries
{
    public class GetBasketCommand : IRequest<List<Domain.Entities.Basket>>
    {
    }
}
