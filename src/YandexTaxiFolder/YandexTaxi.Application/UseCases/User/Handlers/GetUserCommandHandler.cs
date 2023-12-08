using MediatR;
using Microsoft.EntityFrameworkCore;
using YandexTaxi.Application.Abstraction;
using YandexTaxi.Application.UseCases.User.Queries;

namespace YandexTaxi.Application.UseCases.User.Handlers
{
    public class GetUserCommandHandler :
        IRequestHandler<GetUserCommand, List<Domain.Entity.User>>
    {

        private readonly IApplicationDbContext _context;

        public GetUserCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Domain.Entity.User>> Handle(GetUserCommand request, CancellationToken cancellationToken)
        {
            return await _context.User.ToListAsync();
        }
    }
}
