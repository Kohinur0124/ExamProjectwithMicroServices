﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Customer.Queries
{
    public class GetCustomerCommand : IRequest<List<Domain.Entities.Customer>>
    {
    }
}
