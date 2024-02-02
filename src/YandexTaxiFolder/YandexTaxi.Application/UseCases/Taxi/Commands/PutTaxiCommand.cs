using MediatR;

namespace YandexTaxi.Application.UseCases.Taxi.Commands
{
    public class PutTaxiCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public float Mark { get; set; }

        public float MarkCount { get; set; }
    }
}
