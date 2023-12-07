using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace YandexTaxi.Domain.Entity
{
    [Table("Order",Schema ="dbo")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OrderId")]
        public int Id { get; set; }

        [Column("AddressIdOne")]
        public int AddressIdOne { get; set; }

        [Column("AddressIdTwo")]
        public int AddressIdTwo { get; set; }

        [Column("TaxiId")]
        public int TaxiId { get; set; }

        [Column("Total")]
        public decimal Total { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Column("Status")]
        public string Status { get; set; }

        public Address? AddressOne { get; set; }
        public Address? AddressTwo { get; set; }
        public Taxi? Taxi { get; set; }

    }
}
