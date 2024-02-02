using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Olx.Domain.Entity
{
    [Table("Order", Schema = "dbo")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("OrderId")]
        public int Id { get; set; }

        [Column("UserId")]
        [ForeignKey("UserId")]
        public int UserId { get; set; }

       

        [Column("ProductId")]
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }

   

        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [Column("Status")]
        public string Status { get; set; }

        public User? User { get; set; }
        public Product? Product { get; set; }
      

    }
}
