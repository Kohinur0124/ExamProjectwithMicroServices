using MediatR;
using Microsoft.EntityFrameworkCore;
using Olx.Application.Abstraction;
using Olx.Application.UseCases.Card.Queries;

namespace Olx.Application.UseCases.Card.Handlers
{
    public class GetCardCommandHandler :
          IRequestHandler<GetCardCommand, List<Domain.Entity.Card>>
    {
        private readonly IApplicationDbContext _context;

        public GetCardCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entity.Card>> Handle(GetCardCommand request, CancellationToken cancellationToken)
        {
            return await _context.Cards.ToListAsync();
        }
    }
}
