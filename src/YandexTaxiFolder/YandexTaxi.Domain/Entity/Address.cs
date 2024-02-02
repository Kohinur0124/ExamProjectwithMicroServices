using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YandexTaxi.Domain.Entity
{
    [Table("Address", Schema = "dbo")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AddressId")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }
        [Column("x")]
        public double x { get; set; }
        [Column("y")]
        public double y { get; set; }
        [NotMapped]
        public ICollection<Order>? Orders { get; set; }
    }
}
