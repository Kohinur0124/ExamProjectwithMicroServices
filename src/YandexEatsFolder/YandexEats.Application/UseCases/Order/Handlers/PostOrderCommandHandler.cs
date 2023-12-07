using MediatR;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Order.Commands;

namespace YandexEats.Application.UseCases.Order.Handlers
{
    public class PostOrderCommandHandler :
         IRequestHandler<PostOrderCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PostOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostOrderCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = new Domain.Entities.Order
                {
                    UserId = request.UserId,
                    Total = request.Total,
                    Created = request.Created,
                    Status = request.Status,

                };
                await _context.Orders.AddAsync(res);
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
