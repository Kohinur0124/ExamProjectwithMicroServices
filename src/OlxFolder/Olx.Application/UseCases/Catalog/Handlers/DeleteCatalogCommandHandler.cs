using MediatR;
using Microsoft.EntityFrameworkCore;
using Olx.Application.Abstraction;
using Olx.Application.UseCases.Catalog.Commands;


namespace Olx.Application.UseCases.Catalog.Handlers
{
    public class DeleteCatalogCommandHandler :
        IRequestHandler<DeleteCatalogCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCatalogCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteCatalogCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _context.Catalog.FirstOrDefaultAsync(x => x.Id == request.Id);

                if (res == null)
                {
                    return false;
                }

                _context.Catalog.Remove(res);
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
