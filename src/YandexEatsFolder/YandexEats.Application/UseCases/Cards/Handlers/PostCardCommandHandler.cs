using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Cards.Commands;
using YandexEats.Domain.Entities;

namespace YandexEats.Application.UseCases.Cards.Handlers
{
    public class PostCardCommandHandler : IRequestHandler<PostCardCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PostCardCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostCardCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var card = new Card()
                {
                    Number = request.Number,
                    ExpireDate = request.ExpireDate,
                    Amount = request.Amount,
                };
                await _context.Cards.AddAsync(card);

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
