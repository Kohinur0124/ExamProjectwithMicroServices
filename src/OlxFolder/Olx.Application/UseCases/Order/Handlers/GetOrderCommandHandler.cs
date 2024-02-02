using MediatR;
using Microsoft.EntityFrameworkCore;
using Olx.Application.Abstraction;
using Olx.Application.UseCases.Order.Queries;

namespace YandexTaxi.Application.UseCases.Order.Handlers
{
    public class GetOrderCommandHandler :
          IRequestHandler<GetOrderCommand, List<Olx.Domain.Entity.Order>>
    {
        private readonly IApplicationDbContext _context;

        public GetOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Olx.Domain.Entity.Order>> Handle(GetOrderCommand request, CancellationToken cancellationToken)
        {
            return await _context.Order.ToListAsync();
        }
    }
}
