using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Users.Commands
{
    public class PostUserCommand:IRequest<bool>
    {
        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }
    }
}
