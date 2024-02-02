using MediatR;
using Olx.Application.Abstraction;
using Olx.Application.UseCases.User.Commands;

namespace Olx.Application.UseCases.User.Handlers
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
                var res = new Domain.Entity.User
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    CardId = request.CardId,
                    PhoneNumber = request.PhoneNumber,
                    Password = request.Password,
                    Role = request.Role,
                };
                await _context.User.AddAsync(res);
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
