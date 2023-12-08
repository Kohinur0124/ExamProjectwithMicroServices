using MediatR;
using Microsoft.EntityFrameworkCore;
using Olx.Application.Abstraction;
using Olx.Application.UseCases.Card.Queries;
using Olx.Application.UseCases.Product.Queries;

namespace Olx.Application.UseCases.Product.Handlers
{
    public class GetProductCommandHandler :
          IRequestHandler<GetProductCommand, List<Domain.Entity.Product>>
    {
        private readonly IApplicationDbContext _context;

        public GetProductCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entity.Product>> Handle(GetProductCommand request, CancellationToken cancellationToken)
        {
            return await _context.Products.ToListAsync();
        }
    }
}
