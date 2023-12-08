using MediatR;

namespace YandexTaxi.Application.UseCases.Address.Queries
{
    public class GetAddressCommand : IRequest<List<Domain.Entity.Address>>
    {
    }
}
