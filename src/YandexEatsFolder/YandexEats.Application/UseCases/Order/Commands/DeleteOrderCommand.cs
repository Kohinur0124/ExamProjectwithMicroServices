using MediatR;

namespace YandexEats.Application.UseCases.Order.Commands
{
    public class DeleteOrderCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
