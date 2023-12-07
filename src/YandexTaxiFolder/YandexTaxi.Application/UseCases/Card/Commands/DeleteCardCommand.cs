using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexTaxi.Application.UseCases.Card.Commands
{
    public class DeleteCardCommand: IRequest<bool>
    {
        public int Id { get; set; }
    }
}
