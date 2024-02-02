using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Car.Commands;

namespace YandexTaxi.Application.UseCases.Car.Handlers
{
    public class DeleteCarCommandHandler :
        IRequestHandler<DeleteCarCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCarCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteCarCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _context.Car.FirstOrDefaultAsync(x => x.Id == request.Id);

                if (res == null)
                {
                    return false;
                }

                _context.Car.Remove(res);
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
