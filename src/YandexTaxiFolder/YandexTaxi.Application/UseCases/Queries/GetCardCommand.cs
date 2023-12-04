using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexTaxi.Domain.Entity;

namespace YandexTaxi.Application.UseCases.Queries
{
    public class GetCardCommand:IRequest<List<Card>>
    {
    }
}
