using MediatR;

namespace YandexTaxi.Application.UseCases.Order.Commands
{
    public class DeleteOrderCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
