using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Customer.Commands;

namespace YandexEats.Application.UseCases.Customer.Handlers
{
    public class PutCustomerCommandHandler :
         IRequestHandler<PutCustomerCommand, bool>
    {

        private readonly IApplicationDbContext _context;

        public PutCustomerCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PutCustomerCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var res = await _context.Customers.
                    FirstOrDefaultAsync(x => x.Id == request.Id);

                res.FirstName = request.FirstName;
                res.LastName = request.LastName;
                res.UserId = request.UserId;
                res.CardId = request.CardId;


                _context.Customers.Update(res);

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
