using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Basket.Queries;
using YandexEats.Application.UseCases.Card.Queries;
using YandexEats.Application.UseCases.User.Queries;

namespace YandexEats.Application.UseCases.Basket.Handlers
{
    public class GetBasketCommandHandler :
          IRequestHandler<GetBasketCommand, List<Domain.Entities.Basket>>
    {
        private readonly IApplicationDbContext _context;

        public GetBasketCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entities.Basket>> Handle(GetBasketCommand request, CancellationToken cancellationToken)
        {
            return await _context.Baskets.ToListAsync();
        }
    }
}
