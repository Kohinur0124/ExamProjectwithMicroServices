using MediatR;

namespace YandexTaxi.Application.UseCases.Car.Queries
{
    public class GetCarCommand : IRequest<List<Domain.Entity.Car>>
    {
    }
}
