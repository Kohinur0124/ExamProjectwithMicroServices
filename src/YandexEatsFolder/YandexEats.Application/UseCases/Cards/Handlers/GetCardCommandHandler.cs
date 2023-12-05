using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Cards.Queries;
using YandexEats.Domain.Entities;

namespace YandexEats.Application.UseCases.Cards.Handlers
{
    public class GetCardCommandHandler : IRequestHandler<GetCardCommand, List<Card>>
    {

        private readonly IApplicationDbContext _context;

        public GetCardCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<List<Card>> Handle(GetCardCommand request, CancellationToken cancellationToken)
        {
            return await _context.Cards.ToListAsync();
        }
    }
}
