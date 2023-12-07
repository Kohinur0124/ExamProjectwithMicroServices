using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Domain.Entities
{
    [Table("Basket",Schema ="dbo")]
    public class Basket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("BasketId")]
        public int Id { get; set; }
        [ForeignKey("UserId")]
        [Column("UserId")]
        public int UserId { get; set; }
        [ForeignKey("FoodId")]
        [Column("FoodId")]
        public int FoodId { get; set; }

        [Column("Count")]
        public int Count { get; set; }

        [Column("Status")]
        public string Status { get; set; }

        public User? User { get; set; }
        public Foods? Food { get; set; }
    }
}
