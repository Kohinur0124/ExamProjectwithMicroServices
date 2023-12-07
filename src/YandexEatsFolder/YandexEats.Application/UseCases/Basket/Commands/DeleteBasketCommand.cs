using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Basket.Commands
{
    public class DeleteBasketCommand: IRequest<bool>
    {
        public int Id { get; set; }
    }
}
