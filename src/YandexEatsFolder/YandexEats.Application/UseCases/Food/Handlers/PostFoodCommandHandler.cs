using MediatR;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Food.Commands;

namespace YandexEats.Application.UseCases.Foods.Handlers
{
    public class PostFoodCommandHandler :
         IRequestHandler<PostFoodCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PostFoodCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostFoodCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = new Domain.Entities.Foods
                {
                    Name = request.Name,
                    Desc = request.Desc,
                    CatalogId = request.CatalogId,
                    ResturauntId = request.ResturauntId,
                    Portion = request.Portion,
                    Price = request.Price,

                };
                await _context.Foods.AddAsync(res);
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
