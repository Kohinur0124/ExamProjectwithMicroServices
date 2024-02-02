using MediatR;

namespace YandexEats.Application.UseCases.Basket.Commands
{
    public class PostBasketCommand : IRequest<bool>
    {
        public int UserId { get; set; }

        public int FoodId { get; set; }
        public int Count { get; set; }

        public string Status { get; set; }
    }
}
