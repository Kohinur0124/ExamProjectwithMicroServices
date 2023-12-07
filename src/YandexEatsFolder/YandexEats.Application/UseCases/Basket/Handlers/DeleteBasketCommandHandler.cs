﻿using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Basket.Commands;
using YandexEats.Application.UseCases.Card.Commands;

namespace YandexEats.Application.UseCases.Basket.Handlers
{
    public class DeleteBasketCommandHandler :
        IRequestHandler<DeleteBasketCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteBasketCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteBasketCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _context.Baskets.FirstOrDefaultAsync(x => x.Id == request.Id);

                if (res == null)
                {
                    return false;
                }

                _context.Baskets.Remove(res);
                await _context.SaveChangesAsync(cancellationToken);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
