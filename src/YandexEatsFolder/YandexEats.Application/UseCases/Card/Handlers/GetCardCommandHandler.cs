﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Card.Queries;
using YandexEats.Application.UseCases.User.Queries;

namespace YandexEats.Application.UseCases.Card.Handlers
{
    public class GetCardCommandHandler :
          IRequestHandler<GetCardCommand, List<Domain.Entities.Card>>
    {
        private readonly IApplicationDbContext _context;

        public GetCardCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entities.Card>> Handle(GetCardCommand request, CancellationToken cancellationToken)
        {
            return await _context.Cards.ToListAsync();
        }
    }
}