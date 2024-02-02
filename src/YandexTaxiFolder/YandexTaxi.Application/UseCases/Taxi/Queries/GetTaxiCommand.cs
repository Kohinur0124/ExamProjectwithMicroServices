using MediatR;

namespace YandexTaxi.Application.UseCases.Taxi.Queries
{
    public class GetTaxiCommand : IRequest<List<Domain.Entity.Taxi>>
    {
    }
}
