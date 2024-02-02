using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Order.Commands;

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

                res.AddressIdTwo = request.AddressIdTwo;
                res.AddressIdOne = request.AddressIdOne;
                res.Status = request.Status;
                res.CreatedDate = request.CreatedDate;
                res.TaxiId = request.TaxiId;
                res.Total = request.Total;

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
