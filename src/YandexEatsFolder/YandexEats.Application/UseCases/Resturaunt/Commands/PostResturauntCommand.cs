using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Resturaunt.Commands
{
    public class PostResturauntCommand : IRequest<bool>
    {
        public string Name { get; set; }

        public int UserId { get; set; }

        public int CardId { get; set; }

    }
}
