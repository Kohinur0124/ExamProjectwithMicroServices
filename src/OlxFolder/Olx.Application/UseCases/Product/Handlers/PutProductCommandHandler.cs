using MediatR;
using Microsoft.EntityFrameworkCore;
using Olx.Application.Abstraction;
using Olx.Application.UseCases.Card.Commands;
using Olx.Application.UseCases.Product.Commands;

namespace Olx.Application.UseCases.Product.Handlers
{
    public class PutProductCommandHandler :
         IRequestHandler<PutProductCommand, bool>
    {

        private readonly IApplicationDbContext _context;

        public PutProductCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PutProductCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var res = await _context.Products.
                    FirstOrDefaultAsync(x => x.Id == request.Id);

                res.Name = request.Name;
                res.Description = request.Description;
                res.SellerId = request.SellerId;
                res.CatalogId = request.CatalogId;
                res.Date = request.Date;
                res.Price = request.Price;

                _context.Products.Update(res);

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
