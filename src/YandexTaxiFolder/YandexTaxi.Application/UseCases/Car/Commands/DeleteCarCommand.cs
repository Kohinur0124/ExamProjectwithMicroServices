using MediatR;

namespace YandexTaxi.Application.UseCases.Car.Commands
{
    public class DeleteCarCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
