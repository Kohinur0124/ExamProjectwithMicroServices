using MediatR;

namespace YandexTaxi.Application.UseCases.Order.Queries
{
    public class GetOrderCommand : IRequest<List<Domain.Entity.Order>>
    {
    }
}
