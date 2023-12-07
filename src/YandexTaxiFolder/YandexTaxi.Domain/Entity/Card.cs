using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexTaxi.Domain.Entity
{
    [Table("Card",Schema ="dbo")]
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

        public ICollection<User> Users { get; set;}
    }
}
