using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Taxi.Commands;

namespace YandexTaxi.Application.UseCases.Taxi.Handlers
{
    public class PutTaxiCommandHandler :
         IRequestHandler<PutTaxiCommand, bool>
    {

        private readonly IApplicationDbContext _context;

        public PutTaxiCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PutTaxiCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var res = await _context.Taxi.
                    FirstOrDefaultAsync(x => x.Id == request.Id);

                res.UserId = request.UserId;
                res.Mark = request.Mark;
                res.MarkCount = request.MarkCount;

                _context.Taxi.Update(res);

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
