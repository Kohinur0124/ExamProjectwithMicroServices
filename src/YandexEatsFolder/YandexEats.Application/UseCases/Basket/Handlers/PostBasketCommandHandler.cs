using MediatR;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Basket.Commands;

namespace YandexEats.Application.UseCases.Basket.Handlers
{
    public class PostBasketCommandHandler :
        IRequestHandler<PostBasketCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PostBasketCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostBasketCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = new Domain.Entities.Basket
                {
                    UserId = request.UserId,
                    FoodId = request.FoodId,
                    Status = request.Status,
                    Count = request.Count,
                };
                await _context.Baskets.AddAsync(res);
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
