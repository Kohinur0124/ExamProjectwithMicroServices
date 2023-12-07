using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Resturaunt.Queries
{
    public class GetResturauntCommand : IRequest<List<Domain.Entities.Restaurant>>
    {
    }
}
