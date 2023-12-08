using MediatR;
using Microsoft.EntityFrameworkCore;
using Olx.Application.Abstraction;
using Olx.Application.UseCases.Order.Commands;

namespace YandexTaxi.Application.UseCases.Order.Handlers
{
    public class PutOrderCommandHandler :
         IRequestHandler<PutOrderCommand, bool>
    {

        private readonly IApplicationDbContext _context;

        public PutOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PutOrderCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var res = await _context.Order.
                    FirstOrDefaultAsync(x => x.Id == request.Id);

                res.UserId = request.UserId;
                res.ProductId = request.ProductId;
                res.Status = request.Status;
                res.CreatedDate = request.CreatedDate;
              
                _context.Order.Update(res);

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
