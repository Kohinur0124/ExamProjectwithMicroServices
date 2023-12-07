using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YandexTaxi.Domain.Entity
{
    [Table("Car", Schema = "dbo")]
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CarId")]
        public int Id { get; set; }

        [Column("Color")]
        public string Color { get; set; }

        [Column("Model")]
        public string Model { get; set; }

        [Column("Number")]
        public string Number { get; set; }

        [Column("TaxiId")]
        [ForeignKey("TaxiId")]
        public int TaxiId { get; set; }

        public Taxi? Taxi { get; set; }
    }
}
