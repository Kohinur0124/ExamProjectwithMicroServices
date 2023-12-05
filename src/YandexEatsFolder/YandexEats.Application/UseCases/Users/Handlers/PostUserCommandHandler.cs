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
    public class PostUserCommandHandler : IRequestHandler<PostUserCommand, bool>
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

                var user = new User()
                {
                    PhoneNumber = request.PhoneNumber,
                    Password = request.Password,
                    Role = request.Role,
                };

                await _context.Users.AddAsync(user);
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
