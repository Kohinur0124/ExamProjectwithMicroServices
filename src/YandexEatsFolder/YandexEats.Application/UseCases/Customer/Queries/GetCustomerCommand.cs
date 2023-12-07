using MediatR;

namespace YandexEats.Application.UseCases.Customer.Queries
{
    public class GetCustomerCommand : IRequest<List<Domain.Entities.Customer>>
    {
    }
}
