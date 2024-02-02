using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Taxi.Commands;

namespace YandexTaxi.Application.UseCases.Taxi.Handlers
{
    public class DeleteTaxiCommandHandler :
        IRequestHandler<DeleteTaxiCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteTaxiCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteTaxiCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _context.Taxi.FirstOrDefaultAsync(x => x.Id == request.Id);

                if (res == null)
                {
                    return false;
                }

                _context.Taxi.Remove(res);
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
