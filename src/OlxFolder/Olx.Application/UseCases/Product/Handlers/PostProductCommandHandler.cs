using MediatR;
using Olx.Application.Abstraction;
using Olx.Application.UseCases.Card.Commands;
using Olx.Application.UseCases.Product.Commands;

namespace Olx.Application.UseCases.Product.Handlers
{
    public class PostProductCommandHandler :
        IRequestHandler<PostProductCommand, bool>
    {
        private readonly IApplicationDbContext _context;


        public PostProductCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = new Olx.Domain.Entity.Product
                {
                    Name = request.Name,
                    CatalogId = request.CatalogId,
                    Description = request.Description,
                    SellerId = request.SellerId,
                    Price = request.Price,
                    Date = request.Date,
                    
                };
                await _context.Products.AddAsync(res);
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
