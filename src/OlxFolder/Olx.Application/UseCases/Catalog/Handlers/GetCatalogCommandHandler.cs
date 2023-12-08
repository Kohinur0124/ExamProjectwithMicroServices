using MediatR;
using Microsoft.EntityFrameworkCore;
using Olx.Application.Abstraction;
using Olx.Application.UseCases.Card.Queries;
using Olx.Application.UseCases.Catalog.Queries;

namespace Olx.Application.UseCases.Catalog.Handlers
{
    public class GetCatalogCommandHandler :
          IRequestHandler<GetCatalogCommand, List<Domain.Entity.Catalog>>
    {
        private readonly IApplicationDbContext _context;

        public GetCatalogCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entity.Catalog>> Handle(GetCatalogCommand request, CancellationToken cancellationToken)
        {
            return await _context.Catalog.ToListAsync();
        }
    }
}
