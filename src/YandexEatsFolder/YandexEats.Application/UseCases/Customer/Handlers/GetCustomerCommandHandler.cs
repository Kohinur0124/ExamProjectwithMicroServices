using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Catalog.Queries;
using YandexEats.Application.UseCases.Customer.Queries;
using YandexEats.Application.UseCases.User.Queries;

namespace YandexEats.Application.UseCases.Customer.Handlers
{
    public class GetCustomerCommandHandler :
          IRequestHandler<GetCustomerCommand, List<Domain.Entities.Customer>>
    {
        private readonly IApplicationDbContext _context;

        public GetCustomerCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entities.Customer>> Handle(GetCustomerCommand request, CancellationToken cancellationToken)
        {
            return await _context.Customers.ToListAsync();
        }
    }
}
