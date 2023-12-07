using MediatR;

namespace YandexEats.Application.UseCases.Card.Commands
{
    public class PutCardCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string ExpireDate { get; set; }

        public decimal Amount { get; set; }
    }
}
