using MediatR;
using System.ComponentModel.DataAnnotations.Schema;

namespace Olx.Application.UseCases.Order.Commands
{
    public class PostOrderCommand : IRequest<bool>
    {
        public int UserId { get; set; }

        public int ProductId { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public string Status { get; set; }
    }
}
