using MediatR;

namespace Olx.Application.UseCases.Order.Commands
{
    public class PutOrderCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public string Status { get; set; }
    }
}
