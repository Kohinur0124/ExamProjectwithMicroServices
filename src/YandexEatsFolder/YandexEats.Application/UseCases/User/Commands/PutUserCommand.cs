using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.User.Commands
{
    public class PutUserCommand: IRequest<bool>
    {

        public int Id { get; set; }

        public string PhoneNumber { get; set; }


        public string Password { get; set; }


        public string Role { get; set; }
    }
}
