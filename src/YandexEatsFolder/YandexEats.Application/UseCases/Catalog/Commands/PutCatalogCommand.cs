﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Catalog.Commands
{
    public class PutCatalogCommand: IRequest<bool>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }
    }
}
