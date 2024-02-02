using MediatR;

namespace Olx.Application.UseCases.Order.Queries
{
    public class GetOrderCommand : IRequest<List<Domain.Entity.Order>>
    {
    }
}
