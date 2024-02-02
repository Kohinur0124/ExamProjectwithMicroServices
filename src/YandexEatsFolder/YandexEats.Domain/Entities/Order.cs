using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YandexEats.Domain.Entities
{
    [Table("Order", Schema = "dbo")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OrderId")]
        public int Id { get; set; }

        [Column("UserId")]
        public int UserId { get; set; }

        [Column("Total")]
        public decimal Total { get; set; }

        [Column("Status")]
        public string Status { get; set; }

        [Column("Date")]
        public DateTime Created { get; set; } = DateTime.UtcNow;

        public User? User { get; set; }

    }
}
