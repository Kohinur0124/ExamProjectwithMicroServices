using MediatR;

namespace YandexEats.Application.UseCases.Food.Commands
{
    public class DeleteFoodCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
