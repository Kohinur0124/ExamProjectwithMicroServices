using MediatR;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Resturaunt.Commands;
using YandexEats.Domain.Entities;

namespace YandexEats.Application.UseCases.Resturaunt.Handlers
{
    public class PostRestaurantCommandHandler :
         IRequestHandler<PostResturauntCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PostRestaurantCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostResturauntCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = new Restaurant
                {
                    Name = request.Name,
                    UserId = request.UserId,
                    CardId = request.CardId,

                };
                await _context.Restaurants.AddAsync(res);
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
