using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Card.Queries;

namespace YandexTaxi.Application.UseCases.Address.Handlers
{
    public class GetAddressCommandHandler :
          IRequestHandler<GetAddressCommand, List<Domain.Entity.Address>>
    {
        private readonly IApplicationDbContext _context;

        public GetAddressCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entity.Card>> Handle(GetCardCommand request, CancellationToken cancellationToken)
        {
            return await _context.Address.ToListAsync();
        }
    }
}
