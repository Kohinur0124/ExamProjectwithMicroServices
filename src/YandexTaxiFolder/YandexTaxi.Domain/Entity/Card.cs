using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexTaxi.Domain.Entity
{
    public class Card
    {
        public int Id { get; set; }
        
        public string Number { get; set; }

        public DateTime ExpireDate { get; set; }

        public long Amount { get; set; }

    }
}
