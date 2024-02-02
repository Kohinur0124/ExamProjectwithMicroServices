using MediatR;

namespace YandexTaxi.Application.UseCases.User.Commands
{
    public class PutUserCommand : IRequest<bool>
    {

        public int Id { get; set; }

        public string PhoneNumber { get; set; }


        public string Password { get; set; }


        public string Role { get; set; }
    }
}
