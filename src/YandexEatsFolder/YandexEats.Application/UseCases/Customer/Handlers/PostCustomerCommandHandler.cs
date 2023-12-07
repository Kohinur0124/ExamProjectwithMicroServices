using MediatR;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Catalog.Commands;
using YandexEats.Application.UseCases.Customer.Commands;

namespace YandexEats.Application.UseCases.Customer.Handlers
{
    public class PostCustomerCommandHandler :
         IRequestHandler<PostCustomerCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PostCustomerCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostCustomerCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = new Domain.Entities.Customer
                {
                   FirstName = request.FirstName,
                   LastName = request.LastName,
                   UserId = request.UserId,
                   CardId = request.CardId,

                };
                await _context.Customers.AddAsync(res);
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
