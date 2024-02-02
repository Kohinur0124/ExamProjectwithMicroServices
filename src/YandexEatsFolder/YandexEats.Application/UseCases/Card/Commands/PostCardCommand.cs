using MediatR;

namespace YandexEats.Application.UseCases.Card.Commands
{
    public class PostCardCommand : IRequest<bool>
    {
        public string Number { get; set; }

        public string ExpireDate { get; set; }

        public decimal Amount { get; set; }
    }
}
