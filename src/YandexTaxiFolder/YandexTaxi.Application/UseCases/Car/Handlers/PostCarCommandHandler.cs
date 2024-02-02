using MediatR;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Car.Commands;

namespace YandexTaxi.Application.UseCases.Car.Handlers
{
    public class PostCarCommandHandler :
        IRequestHandler<PostCarCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PostCarCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostCarCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = new Domain.Entity.Car
                {
                    Number = request.Number,
                    Color = request.Color,
                    TaxiId = request.TaxiId,
                    Model = request.Model,
                };
                await _context.Car.AddAsync(res);
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
