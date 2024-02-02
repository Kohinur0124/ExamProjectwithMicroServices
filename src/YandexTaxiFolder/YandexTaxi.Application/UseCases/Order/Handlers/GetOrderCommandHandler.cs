using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Order.Queries;

namespace YandexTaxi.Application.UseCases.Order.Handlers
{
    public class GetOrderCommandHandler :
          IRequestHandler<GetOrderCommand, List<Domain.Entity.Order>>
    {
        private readonly IApplicationDbContext _context;

        public GetOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entity.Order>> Handle(GetOrderCommand request, CancellationToken cancellationToken)
        {
            return await _context.Order.ToListAsync();
        }
    }
}
