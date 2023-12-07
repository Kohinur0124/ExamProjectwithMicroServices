using MediatR;

namespace YandexTaxi.Application.UseCases.Taxi.Commands
{
    public class DeleteTaxiCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
