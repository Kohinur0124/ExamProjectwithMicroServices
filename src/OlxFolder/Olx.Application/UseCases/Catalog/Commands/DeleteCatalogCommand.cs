using MediatR;

namespace Olx.Application.UseCases.Catalog.Commands
{
    public class DeleteCatalogCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
