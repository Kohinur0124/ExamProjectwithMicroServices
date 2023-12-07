using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Catalog.Queries
{
    public class GetCatalogCommand:IRequest<List<Domain.Entities.Catalog>>
    {
    }
}
