using MediatR;

namespace YandexEats.Application.UseCases.Customer.Commands
{
    public class PutCustomerCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CardId { get; set; }
    }
}
