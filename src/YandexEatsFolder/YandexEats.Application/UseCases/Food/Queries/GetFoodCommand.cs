using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Foods.Queries
{
    public class GetFoodCommand:IRequest<List<Domain.Entities.Foods>>
    {
    }
}
