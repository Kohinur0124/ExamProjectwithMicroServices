using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Catalog.Commands;
using YandexEats.Application.UseCases.User.Commands;

namespace YandexEats.Application.UseCases.Catalog.Handlers
{
    public class PutCatalogCommandHandler :
         IRequestHandler<PutCatalogCommand, bool>
    {

        private readonly IApplicationDbContext _context;

        public PutCatalogCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PutCatalogCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var res = await _context.Catalog.
                    FirstOrDefaultAsync(x => x.Id == request.Id);

                res.Name = request.Name;
                res.Desc = request.Desc;
                

                _context.Catalog.Update(res);

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
