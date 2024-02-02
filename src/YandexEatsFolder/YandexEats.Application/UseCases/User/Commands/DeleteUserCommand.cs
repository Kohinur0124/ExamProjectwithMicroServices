using MediatR;

namespace YandexEats.Application.UseCases.User.Commands
{
    public class DeleteUserCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
