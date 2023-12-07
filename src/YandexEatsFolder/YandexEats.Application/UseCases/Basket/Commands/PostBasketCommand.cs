using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Basket.Commands
{
    public class PostBasketCommand:IRequest<bool>
    {
        public int UserId { get; set; }

        public int FoodId { get; set; }
        public int Count { get; set; }

        public string Status { get; set; }
    }
}
