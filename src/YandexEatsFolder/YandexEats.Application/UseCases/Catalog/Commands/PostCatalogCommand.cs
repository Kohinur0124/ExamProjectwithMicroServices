using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Catalog.Commands
{
    public class PostCatalogCommand: IRequest<bool>
    {
        public string Name { get; set; }

        public string Desc { get; set; }
    }
}
