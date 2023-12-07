using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Catalog.Commands;
using YandexEats.Application.UseCases.User.Commands;

namespace YandexEats.Application.UseCases.Catalog.Handlers
{
    public class PostCatalogCommandHandler :
         IRequestHandler<PostCatalogCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PostCatalogCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostCatalogCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = new Domain.Entities.Catalog
                {
                    Name = request.Name,
                    Desc = request.Desc,
                 
                };
                await _context.Catalog.AddAsync(res);
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
