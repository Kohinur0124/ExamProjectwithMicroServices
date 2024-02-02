using MediatR;

namespace Olx.Application.UseCases.Catalog.Queries
{
    public class GetCatalogCommand : IRequest<List<Domain.Entity.Catalog>>
    {
    }
}
