using MediatR;

namespace Olx.Application.UseCases.Catalog.Commands
{
    public class PutCatalogCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        
    }
}
