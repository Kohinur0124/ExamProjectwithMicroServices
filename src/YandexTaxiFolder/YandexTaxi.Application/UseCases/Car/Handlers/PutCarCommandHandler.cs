using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Car.Commands;

namespace YandexTaxi.Application.UseCases.Car.Handlers
{
    public class PutCarCommandHandler :
         IRequestHandler<PutCarCommand, bool>
    {

        private readonly IApplicationDbContext _context;

        public PutCarCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PutCarCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var res = await _context.Car.
                    FirstOrDefaultAsync(x => x.Id == request.Id);

                res.Number = request.Number;
                res.Color = request.Color;
                res.TaxiId = request.TaxiId;
                res.Model = request.Model;

                _context.Car.Update(res);

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
