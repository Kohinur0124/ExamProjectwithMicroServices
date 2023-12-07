using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Card.Commands
{
    public class PostCardCommand:IRequest<bool>
    {
        public string Number { get; set; }

        public string ExpireDate { get; set; }
       
        public decimal Amount { get; set; }
    }
}
