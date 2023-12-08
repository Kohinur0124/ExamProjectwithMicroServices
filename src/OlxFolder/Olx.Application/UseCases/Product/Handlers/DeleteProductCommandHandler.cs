using MediatR;
using Microsoft.EntityFrameworkCore;
using Olx.Application.Abstraction;
using Olx.Application.UseCases.Card.Commands;
using Olx.Application.UseCases.Product.Commands;


namespace Olx.Application.UseCases.Product.Handlers
{
    public class DeleteProductCommandHandler :
        IRequestHandler<DeleteProductCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteProductCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = await _context.Products.FirstOrDefaultAsync(x => x.Id == request.Id);

                if (res == null)
                {
                    return false;
                }

                _context.Products.Remove(res);
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
