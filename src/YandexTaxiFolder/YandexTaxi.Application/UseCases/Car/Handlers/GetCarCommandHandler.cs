using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Car.Queries;

namespace YandexTaxi.Application.UseCases.Car.Handlers
{
    public class GetCarCommandHandler :
          IRequestHandler<GetCarCommand, List<Domain.Entity.Car>>
    {
        private readonly IApplicationDbContext _context;

        public GetCarCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entity.Car>> Handle(GetCarCommand request, CancellationToken cancellationToken)
        {
            return await _context.Car.ToListAsync();
        }
    }
}
