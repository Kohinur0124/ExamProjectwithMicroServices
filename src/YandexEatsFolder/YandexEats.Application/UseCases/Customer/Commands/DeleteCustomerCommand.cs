using MediatR;

namespace YandexEats.Application.UseCases.Customer.Commands
{
    public class DeleteCustomerCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
