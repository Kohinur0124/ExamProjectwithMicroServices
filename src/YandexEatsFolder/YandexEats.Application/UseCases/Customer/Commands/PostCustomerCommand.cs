using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Application.UseCases.Customer.Commands
{
    public class PostCustomerCommand : IRequest<bool>
    {
        public int UserId { get; set; }
     
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
      
        public int CardId { get; set; }
    }
}
