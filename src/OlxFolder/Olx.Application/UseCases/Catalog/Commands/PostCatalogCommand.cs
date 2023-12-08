using MediatR;

namespace Olx.Application.UseCases.Catalog.Commands
{
    public class PostCatalogCommand : IRequest<bool>
    {
        public string Name { get; set; }

       
    }
}
