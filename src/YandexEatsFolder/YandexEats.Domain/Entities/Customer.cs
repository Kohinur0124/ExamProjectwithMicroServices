using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YandexEats.Domain.Entities
{
    [Table("Customer", Schema = "dbo")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CustomerId")]
        public int Id { get; set; }

        [ForeignKey("UserId")]
        [Column("UserId")]
        public int UserId { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [ForeignKey("CardId")]
        [Column("CardId")]
        public int CardId { get; set; }

        public User? User { get; set; }
        public Card? Card { get; set; }
    }
}
