using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Foods.Queries;

namespace YandexEats.Application.UseCases.Food.Handlers
{
    public class GetFoodCommandHandler :
          IRequestHandler<GetFoodCommand, List<Domain.Entities.Foods>>
    {
        private readonly IApplicationDbContext _context;

        public GetFoodCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entities.Foods>> Handle(GetFoodCommand request, CancellationToken cancellationToken)
        {
            return await _context.Foods.ToListAsync();
        }
    }
}
