using MediatR;

namespace Olx.Application.UseCases.User.Commands
{
    public class DeleteUserCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
