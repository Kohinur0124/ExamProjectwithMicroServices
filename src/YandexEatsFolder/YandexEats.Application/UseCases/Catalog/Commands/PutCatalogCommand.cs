using MediatR;

namespace YandexEats.Application.UseCases.Catalog.Commands
{
    public class PutCatalogCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }
    }
}
