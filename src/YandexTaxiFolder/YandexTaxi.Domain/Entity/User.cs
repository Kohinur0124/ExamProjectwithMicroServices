using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YandexTaxi.Domain.Entity
{
    [Table("User", Schema = "dbo")]
    public class User

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("User")]
        public int Id { get; set; }

        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Column("Password")]
        public string Password { get; set; }

        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }

        [Column("Role")]
        public string Role { get; set; }

        [Column("CardId")]
        [ForeignKey("CardId")]
        public int CardId { get; set; }

        public Card? Card { get; set; }

        public ICollection<Taxi>? Taxis { get; set; }
        public ICollection<Order>? Order { get; set; }

    }
}
