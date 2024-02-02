using MediatR;

namespace YandexEats.Application.UseCases.Card.Commands
{
    public class DeleteCardCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
