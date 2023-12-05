using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Domain.Entities
{
    [Table("Restaurant" , Schema ="dbo")]
    public class Restaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("RestaurantId")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("UserId")]

        public int UserId { get; set; }

        [Column("CardId")]
        
        public int RestaurantId { get;}

        public User? User { get; set; }
        public ICollection<Card> Cards { get; set; }
        public ICollection<Foods> Foods { get; set; }
    }
}
