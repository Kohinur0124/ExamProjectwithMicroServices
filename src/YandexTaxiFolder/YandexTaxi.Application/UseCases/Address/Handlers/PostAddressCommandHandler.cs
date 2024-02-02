using MediatR;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Address.Commands;

namespace YandexTaxi.Application.UseCases.Address.Handlers
{
    public class PostAddressCommandHandler :
        IRequestHandler<PostAddressCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PostAddressCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostAddressCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = new Domain.Entity.Address
                {
                    Name = request.Name,
                    x = request.x,
                    y = request.y,
                };
                await _context.Address.AddAsync(res);
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
