using MediatR;
using System.ComponentModel.DataAnnotations.Schema;

namespace Olx.Application.UseCases.Product.Commands
{
    public class PostProductCommand : IRequest<bool>
    {
        public string Name { get; set; }

       
        public string Description { get; set; }

     
        public decimal Price { get; set; }

   
        public int CatalogId { get; set; }

      
        public int SellerId { get; set; }

      
        public DateTime Date { get; set; }
    }
}
