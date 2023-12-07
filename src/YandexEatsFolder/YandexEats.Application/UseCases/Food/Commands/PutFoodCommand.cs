﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Food.Commands
{
    public class PutFoodCommand: IRequest<bool>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }

        public int CatalogId { get; set; }

        public int ResturauntId { get; set; }

        public string Portion { get; set; }

        public decimal Price { get; set; }
    }
}
