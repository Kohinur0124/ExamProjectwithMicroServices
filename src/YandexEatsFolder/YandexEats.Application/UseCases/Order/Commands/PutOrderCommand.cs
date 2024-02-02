using MediatR;

namespace YandexEats.Application.UseCases.Order.Commands
{
    public class PutOrderCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public decimal Total { get; set; }

        public string Status { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
