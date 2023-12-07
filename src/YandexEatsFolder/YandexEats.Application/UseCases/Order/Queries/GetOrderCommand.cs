using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Order.Queries
{
    public class GetOrderCommand : IRequest<List<Domain.Entities.Order>>
    {
    }
}
