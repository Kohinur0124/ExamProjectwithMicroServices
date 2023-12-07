using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Address.Commands;

namespace YandexTaxi.Application.UseCases.Address.Handlers
{
    public class DeleteAddressCommandHandler :
        IRequestHandler<DeleteAddressCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteAddressCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _context.Address.FirstOrDefaultAsync(x => x.Id == request.Id);

                if (res == null)
                {
                    return false;
                }

                _context.Address.Remove(res);
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
