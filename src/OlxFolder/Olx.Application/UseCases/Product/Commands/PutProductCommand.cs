using MediatR;

namespace Olx.Application.UseCases.Product.Commands
{
    public class PutProductCommand : IRequest<bool>
    {
        public int Id { get; set; }

        public string Name { get; set; }


        public string Description { get; set; }


        public decimal Price { get; set; }


        public int CatalogId { get; set; }


        public int SellerId { get; set; }


        public DateTime Date { get; set; }
    }
}
