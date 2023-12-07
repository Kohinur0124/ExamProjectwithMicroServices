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

namespace YandexEats.Application.UseCases.Food.Handlers
{
    public class DeleteFoodCommandHandler :
        IRequestHandler<DeleteFoodCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteFoodCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteFoodCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _context.Foods.FirstOrDefaultAsync(x => x.Id == request.Id);

                if (res == null)
                {
                    return false;
                }

                _context.Foods.Remove(res);
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
