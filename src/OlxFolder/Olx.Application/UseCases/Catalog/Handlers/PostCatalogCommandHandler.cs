using MediatR;
using Olx.Application.Abstraction;
using Olx.Application.UseCases.Card.Commands;
using Olx.Application.UseCases.Catalog.Commands;

namespace Olx.Application.UseCases.Card.Handlers
{
    public class PostCatalogCommandHandler :
        IRequestHandler<PostCatalogCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PostCatalogCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostCatalogCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = new Olx.Domain.Entity.Catalog
                {
                    Name = request.Name,
                   
                };
                await _context.Catalog.AddAsync(res);
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
