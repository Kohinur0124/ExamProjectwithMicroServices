using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexEats.Application.Abstractions;
using YandexEats.Application.UseCases.Users.Queries;
using YandexEats.Domain.Entities;

namespace YandexEats.Application.UseCases.Users.Handlers
{
    public class GetUserCommandHandler : IRequestHandler<GetUserCommand, List<User>>
    {

        private readonly IApplicationDbContext _context;

        public GetUserCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> Handle(GetUserCommand request, CancellationToken cancellationToken)
        {
            return await _context.Users.ToListAsync();
        }
    }
}
