using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Catalog.Queries;

namespace YandexEats.Application.UseCases.Catalog.Handlers
{
    public class GetCatalogCommandHandler :
          IRequestHandler<GetCatalogCommand, List<Domain.Entities.Catalog>>
    {
        private readonly IApplicationDbContext _context;

        public GetCatalogCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entities.Catalog>> Handle(GetCatalogCommand request, CancellationToken cancellationToken)
        {
            return await _context.Catalog.ToListAsync();
        }
    }
}
