using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YandexEats.Domain.Entities
{
    [Table("Restaurant", Schema = "dbo")]
    public class Restaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("RestaurantId")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [ForeignKey("UserId")]
        [Column("UserId")]
        public int UserId { get; set; }

        [ForeignKey("CardId")]
        [Column("CardId")]
        public int CardId { get; set; }

        public User? User { get; set; }
        public Card? Card { get; set; }
        public ICollection<Foods> Foods { get; set; }
    }
}
