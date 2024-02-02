using MediatR;

namespace Olx.Application.UseCases.Order.Commands
{
    public class DeleteOrderCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
