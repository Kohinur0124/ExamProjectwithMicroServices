using MediatR;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.User.Commands;

namespace YandexEats.Application.UseCases.User.Handlers
{
    public class PostUserCommandHandler :
        IRequestHandler<PostUserCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PostUserCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PostUserCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var res = new Domain.Entities.User
                {
                    PhoneNumber = request.PhoneNumber,
                    Password = request.Password,
                    Role = request.Role,
                };
                await _context.Users.AddAsync(res);
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
