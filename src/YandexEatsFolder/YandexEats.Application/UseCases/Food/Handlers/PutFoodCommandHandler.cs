using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Catalog.Commands;
using YandexEats.Application.UseCases.Food.Commands;
using YandexEats.Application.UseCases.User.Commands;

namespace YandexEats.Application.UseCases.Food.Handlers
{
    public class PutFoodCommandHandler :
         IRequestHandler<PutFoodCommand, bool>
    {

        private readonly IApplicationDbContext _context;

        public PutFoodCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PutFoodCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var res = await _context.Foods.
                    FirstOrDefaultAsync(x => x.Id == request.Id);

                res.Name = request.Name;
                res.Desc = request.Desc;
                res.CatalogId = request.CatalogId;
                res.ResturauntId = request.ResturauntId;
                res.Price = request.Price;
                res.Portion = request.Portion;
                

                _context.Foods.Update(res);

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
