using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Queries;
using YandexTaxi.Domain.Entity;

namespace YandexTaxi.Application.UseCases.Handlers
{
    public class GetCardCommandHandler : IRequestHandler<GetCardCommand, List<Card>>
    {

        public readonly IApplicationDbContext _context;



        public GetCardCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Card>> Handle(GetCardCommand request, CancellationToken cancellationToken)
        {
            return await _context.Cards.ToListAsync();
        }
    }
}
