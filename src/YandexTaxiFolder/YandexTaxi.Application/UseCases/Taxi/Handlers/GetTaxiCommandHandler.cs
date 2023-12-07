using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Taxi.Queries;

namespace YandexTaxi.Application.UseCases.Taxi.Handlers
{
    public class GetTaxiCommandHandler :
          IRequestHandler<GetTaxiCommand, List<Domain.Entity.Taxi>>
    {
        private readonly IApplicationDbContext _context;

        public GetTaxiCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entity.Taxi>> Handle(GetTaxiCommand request, CancellationToken cancellationToken)
        {
            return await _context.Taxi.ToListAsync();
        }
    }
}
