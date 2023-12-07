using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Resturaunt.Commands
{
    public class PutResturauntCommand: IRequest<bool>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int UserId { get; set; }

        public int CardId { get; set; }
    }
}
