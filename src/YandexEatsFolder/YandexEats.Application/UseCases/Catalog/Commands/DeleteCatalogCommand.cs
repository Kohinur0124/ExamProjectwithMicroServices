using MediatR;

namespace YandexEats.Application.UseCases.Catalog.Commands
{
    public class DeleteCatalogCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
