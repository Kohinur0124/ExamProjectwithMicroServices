using MediatR;
using Olx.Application.Abstraction;
using Olx.Application.UseCases.Order.Commands;

namespace Olx.Application.UseCases.Order.Handlers
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
                var res = new Domain.Entity.Order
                {
                    UserId = request.UserId,
                    ProductId = request.ProductId,
                                       
                    Status = request.Status,
                 
                    CreatedDate = request.CreatedDate,

                };
                await _context.Order.AddAsync(res);
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
