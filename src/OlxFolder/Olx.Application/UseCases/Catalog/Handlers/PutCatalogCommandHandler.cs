using MediatR;
using Microsoft.EntityFrameworkCore;
using Olx.Application.Abstraction;
using Olx.Application.UseCases.Card.Commands;
using Olx.Application.UseCases.Catalog.Commands;

namespace Olx.Application.UseCases.Card.Handlers
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
