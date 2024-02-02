using MediatR;
using Microsoft.EntityFrameworkCore;
using Olx.Application.Abstraction;
using Olx.Application.UseCases.User.Commands;

namespace Olx.Application.UseCases.User.Handlers
{
    public class PutUserCommandHandler :
        IRequestHandler<PutUserCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public PutUserCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(PutUserCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var res = await _context.User.
                    FirstOrDefaultAsync(x => x.Id == request.Id);

                res.PhoneNumber = request.PhoneNumber;
                res.Password = request.Password;
                res.Role = request.Role;

                _context.User.Update(res);

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
