using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Users.Commands;

namespace YandexEats.Application.UseCases.Users.Handlers
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUsersCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteUserCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteUsersCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x=>x.Id == request.Id);
            if (user == null)
            {
                return false;

            }
            _context.Users.Remove(user);
            await _context.SaveChangesAsync(cancellationToken);
            return true;

        }
    }
}
