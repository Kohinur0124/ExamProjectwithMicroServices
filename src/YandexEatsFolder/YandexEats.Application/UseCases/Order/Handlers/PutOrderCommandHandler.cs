using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Order.Commands;

namespace YandexEats.Application.UseCases.Order.Handlers
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

                var res = await _context.Orders.
                    FirstOrDefaultAsync(x => x.Id == request.Id);

                res.UserId = request.UserId;
                res.Status = request.Status;
                res.Created = request.Created;
                res.Total = request.Total;


                _context.Orders.Update(res);

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
