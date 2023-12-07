using MediatR;

namespace YandexTaxi.Application.UseCases.User.Commands
{
    public class PostUserCommand : IRequest<bool>
    {
        public string PhoneNumber { get; set; }


        public string Password { get; set; }


        public string Role { get; set; }
    }
}
