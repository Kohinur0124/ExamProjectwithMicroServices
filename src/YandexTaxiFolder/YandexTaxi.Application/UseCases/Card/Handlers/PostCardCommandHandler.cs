using MediatR;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Card.Commands;

namespace YandexTaxi.Application.UseCases.Card.Handlers
{
    public class PostCardCommandHandler :
        IRequestHandler<PostCardCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PostCardCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostCardCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = new Domain.Entity.Card
                {
                    Number = request.Number,
                    ExpireDate = request.ExpireDate,
                    Amount = request.Amount,
                };
                await _context.Cards.AddAsync(res);
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
