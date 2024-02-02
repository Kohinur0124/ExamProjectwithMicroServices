using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Address.Commands;

namespace YandexTaxi.Application.UseCases.Address.Handlers
{
    public class PutAddressCommandHandler :
         IRequestHandler<PutAddressCommand, bool>
    {

        private readonly IApplicationDbContext _context;

        public PutAddressCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PutAddressCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var res = await _context.Address.
                    FirstOrDefaultAsync(x => x.Id == request.Id);

                res.Name = request.Name;
                res.x = request.x;
                res.y = request.y;

                _context.Address.Update(res);

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
