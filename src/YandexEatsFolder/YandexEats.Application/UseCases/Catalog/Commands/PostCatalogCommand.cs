using MediatR;

namespace YandexEats.Application.UseCases.Catalog.Commands
{
    public class PostCatalogCommand : IRequest<bool>
    {
        public string Name { get; set; }

        public string Desc { get; set; }
    }
}
