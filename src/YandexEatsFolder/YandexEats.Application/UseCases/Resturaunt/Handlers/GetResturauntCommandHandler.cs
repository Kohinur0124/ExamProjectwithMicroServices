using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Catalog.Queries;
using YandexEats.Application.UseCases.Food.Commands;
using YandexEats.Application.UseCases.Foods.Queries;
using YandexEats.Application.UseCases.Resturaunt.Commands;
using YandexEats.Application.UseCases.Resturaunt.Queries;
using YandexEats.Application.UseCases.User.Queries;

namespace YandexEats.Application.UseCases.Resturaunt.Handlers
{
    public class GetResturauntCommandHandler :
          IRequestHandler<GetResturauntCommand, List<Domain.Entities.Restaurant>>
    {
        private readonly IApplicationDbContext _context;

        public GetResturauntCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entities.Restaurant>> Handle(GetResturauntCommand request, CancellationToken cancellationToken)
        {
            return await _context.Restaurants.ToListAsync();
        }
    }
}
