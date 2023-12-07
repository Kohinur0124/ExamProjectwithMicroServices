using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Order.Queries;

namespace YandexEats.Application.UseCases.Order.Handlers
{
    public class GetOrderCommandHandler :
          IRequestHandler<GetOrderCommand, List<Domain.Entities.Order>>
    {
        private readonly IApplicationDbContext _context;

        public GetOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entities.Order>> Handle(GetOrderCommand request, CancellationToken cancellationToken)
        {
            return await _context.Orders.ToListAsync();
        }
    }
}
