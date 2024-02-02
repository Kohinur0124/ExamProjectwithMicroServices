using MediatR;

namespace YandexEats.Application.UseCases.Basket.Commands
{
    public class DeleteBasketCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
