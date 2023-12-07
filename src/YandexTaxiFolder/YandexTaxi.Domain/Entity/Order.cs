using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YandexTaxi.Domain.Entity
{
    [Table("Order", Schema = "dbo")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OrderId")]
        public int Id { get; set; }

        [Column("AddressIdOne")]
        [ForeignKey("AddressIdOne")]
        public int AddressIdOne { get; set; }

        [Column("AddressIdTwo")]
        [ForeignKey("AddressIdTwo")]
        public int AddressIdTwo { get; set; }

        [Column("TaxiId")]
        [ForeignKey("TaxiId")]
        public int TaxiId { get; set; }

        [Column("Total")]
        public long Total { get; set; }

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Column("Status")]
        public string Status { get; set; }

        public Address? AddressOne { get; set; }
        public Address? AddressTwo { get; set; }
        public Taxi? Taxi { get; set; }

    }
}
