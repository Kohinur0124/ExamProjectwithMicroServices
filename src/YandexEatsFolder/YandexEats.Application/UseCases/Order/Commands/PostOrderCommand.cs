using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Order.Commands
{
    public class PostOrderCommand : IRequest<bool>
    {
        public int UserId { get; set; }

        public decimal Total { get; set; }

        public string Status { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
    }
}
