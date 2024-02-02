using MediatR;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Taxi.Commands;

namespace YandexTaxi.Application.UseCases.Taxi.Handlers
{
    public class PostTaxiCommandHandler :
        IRequestHandler<PostTaxiCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PostTaxiCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostTaxiCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = new Domain.Entity.Taxi
                {
                    UserId = request.UserId,
                    Mark = request.Mark,
                    MarkCount = request.MarkCount,
                };
                await _context.Taxi.AddAsync(res);
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
