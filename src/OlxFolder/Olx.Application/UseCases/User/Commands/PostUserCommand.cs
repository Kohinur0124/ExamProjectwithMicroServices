using MediatR;
using System.ComponentModel.DataAnnotations.Schema;

namespace Olx.Application.UseCases.User.Commands
{
    public class PostUserCommand : IRequest<bool>
    {
        public string PhoneNumber { get; set; }

      
        public string Password { get; set; }

      
        public string FirstName { get; set; }

    
        public string LastName { get; set; }

        public string Role { get; set; }

        public int CardId { get; set; }
    }
}
