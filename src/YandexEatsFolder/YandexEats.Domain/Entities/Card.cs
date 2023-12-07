using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YandexEats.Domain.Entities
{
    [Table("Card", Schema = "dbo")]
    public class Card
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CardId")]
        public int Id { get; set; }
        [Column("Number")]
        public string Number { get; set; }
        [Column("ExpireDate")]
        public string ExpireDate { get; set; }
        [Column("Amount")]
        public decimal Amount { get; set; }

        public ICollection<Customer> Customers { get; set; }

    }
}
