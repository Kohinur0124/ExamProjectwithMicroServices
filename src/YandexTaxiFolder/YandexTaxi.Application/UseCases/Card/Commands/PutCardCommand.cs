using MediatR;

namespace YandexTaxi.Application.UseCases.Card.Commands
{
    public class PutCardCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public string ExpireDate { get; set; }

        public long Amount { get; set; }
    }
}
