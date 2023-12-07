using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Basket.Queries
{
    public class GetBasketCommand:IRequest<List<Domain.Entities.Basket>>
    {
    }
}
