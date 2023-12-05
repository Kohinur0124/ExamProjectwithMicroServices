using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Users.Commands;
using YandexEats.Domain.Entities;

namespace YandexEats.Application.UseCases.Users.Handlers
{
    public class PutUserCommandHandler : IRequestHandler<PutUserCommand, bool>
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
                var u = _context.Users.FirstOrDefault(x => x.Id == request.Id);
                if (u != null)
                {
                    u.PhoneNumber = request.PhoneNumber;
                    u.Password = request.Password;
                    u.Role = request.Role;

                    _context.Users.Update(u);
                    await _context.SaveChangesAsync(cancellationToken);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
