using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Resturaunt.Queries;

namespace YandexEats.Application.UseCases.Resturaunt.Handlers
{
    public class GetResturauntCommandHandler :
          IRequestHandler<GetResturauntCommand, List<Domain.Entities.Restaurant>>
    {
        private readonly IApplicationDbContext _context;

        public GetResturauntCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entities.Restaurant>> Handle(GetResturauntCommand request, CancellationToken cancellationToken)
        {
            return await _context.Restaurants.ToListAsync();
        }
    }
}
