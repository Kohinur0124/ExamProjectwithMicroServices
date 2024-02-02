using MediatR;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.Order.Commands;

namespace YandexTaxi.Application.UseCases.Order.Handlers
{
    public class PostOrderCommandHandler :
        IRequestHandler<PostOrderCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PostOrderCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostOrderCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = new Domain.Entity.Order
                {
                    AddressIdOne = request.AddressIdOne,
                    AddressIdTwo = request.AddressIdTwo,
                    TaxiId = request.TaxiId,
                    Status = request.Status,
                    Total = request.Total,
                    CreatedDate = request.CreatedDate,

                };
                await _context.Order.AddAsync(res);
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
