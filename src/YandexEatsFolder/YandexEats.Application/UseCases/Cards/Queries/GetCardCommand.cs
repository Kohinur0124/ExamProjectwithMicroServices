using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Domain.Entities;

namespace YandexEats.Application.UseCases.Cards.Queries
{
    public class GetCardCommand : IRequest<List<Card>>
    {


    }
}
