using MediatR;

namespace YandexEats.Application.UseCases.Order.Queries
{
    public class GetOrderCommand : IRequest<List<Domain.Entities.Order>>
    {
    }
}
