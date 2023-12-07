using MediatR;

namespace YandexEats.Application.UseCases.Catalog.Queries
{
    public class GetCatalogCommand : IRequest<List<Domain.Entities.Catalog>>
    {
    }
}
