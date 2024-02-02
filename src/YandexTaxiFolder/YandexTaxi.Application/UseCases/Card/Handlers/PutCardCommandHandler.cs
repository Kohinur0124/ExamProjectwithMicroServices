using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Card.Commands;

namespace YandexTaxi.Application.UseCases.Card.Handlers
{
    public class PutCardCommandHandler :
         IRequestHandler<PutCardCommand, bool>
    {

        private readonly IApplicationDbContext _context;

        public PutCardCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PutCardCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var res = await _context.Cards.
                    FirstOrDefaultAsync(x => x.Id == request.Id);

                res.Number = request.Number;
                res.ExpireDate = request.ExpireDate;
                res.Amount = request.Amount;

                _context.Cards.Update(res);

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
