using MediatR;

namespace YandexTaxi.Application.UseCases.Taxi.Commands
{
    public class PostTaxiCommand : IRequest<bool>
    {
        public int UserId { get; set; }

        public float Mark { get; set; }

        public float MarkCount { get; set; }
    }
}
