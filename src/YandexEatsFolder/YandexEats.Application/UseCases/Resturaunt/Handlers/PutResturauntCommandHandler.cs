using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Resturaunt.Commands;

namespace YandexEats.Application.UseCases.Resturaunt.Handlers
{
    public class PutResturauntCommandHandler :
         IRequestHandler<PutResturauntCommand, bool>
    {

        private readonly IApplicationDbContext _context;

        public PutResturauntCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PutResturauntCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var res = await _context.Restaurants.
                    FirstOrDefaultAsync(x => x.Id == request.Id);

                res.Name = request.Name;
                res.UserId = request.UserId;
                res.CardId = request.CardId;

                _context.Restaurants.Update(res);

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
