using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Food.Commands
{
    public class PostFoodCommand: IRequest<bool>
    {
        public string Name { get; set; }

        public string Desc { get; set; }

        public int CatalogId { get; set; }

        public int ResturauntId { get; set; }

        public string Portion { get; set; }

        public decimal Price { get; set; }
    }
}
