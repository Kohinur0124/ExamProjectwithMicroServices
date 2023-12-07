using MediatR;

namespace YandexTaxi.Application.UseCases.Car.Commands
{
    public class PutCarCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public string Color { get; set; }

        public string Model { get; set; }

        public string Number { get; set; }

        public int TaxiId { get; set; }
    }
}
