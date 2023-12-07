using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Card.Queries
{
    public class GetCardCommand:IRequest<List<Domain.Entities.Card>>
    {
    }
}
