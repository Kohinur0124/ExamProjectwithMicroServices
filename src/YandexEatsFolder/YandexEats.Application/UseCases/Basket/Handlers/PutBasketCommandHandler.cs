using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Basket.Commands;
using YandexEats.Application.UseCases.Card.Commands;
using YandexEats.Application.UseCases.User.Commands;

namespace YandexEats.Application.UseCases.Basket.Handlers
{
    public class PutBasketCommandHandler :
         IRequestHandler<PutBasketCommand, bool>
    {

        private readonly IApplicationDbContext _context;

        public PutBasketCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PutBasketCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var res = await _context.Baskets.
                    FirstOrDefaultAsync(x => x.Id == request.Id);

                res.UserId = request.UserId;
                res.FoodId = request.FoodId;
                res.Status = request.Status;
                res.Count = request.Count;

                _context.Baskets.Update(res);

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
