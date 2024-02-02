using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Olx.Domain.Entity
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
        public long Amount { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}
