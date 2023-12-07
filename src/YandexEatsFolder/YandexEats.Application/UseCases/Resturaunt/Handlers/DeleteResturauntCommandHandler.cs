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
using YandexEats.Application.UseCases.Resturaunt.Commands;

namespace YandexEats.Application.UseCases.Resturaunt.Handlers
{
    public class DeleteResturauntCommandHandler :
        IRequestHandler<DeleteResturauntCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteResturauntCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteResturauntCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _context.Restaurants.FirstOrDefaultAsync(x => x.Id == request.Id);

                if (res == null)
                {
                    return false;
                }

                _context.Restaurants.Remove(res);
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
