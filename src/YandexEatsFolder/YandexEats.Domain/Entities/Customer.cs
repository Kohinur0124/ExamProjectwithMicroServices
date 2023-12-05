using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexEats.Domain.Entities
{
    [Table("Customer",Schema ="dbo")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CustomerId")]
        public int Id { get; set; }
        [Column("UserId")]
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
        [Column("LastName")]
        public string LastName { get; set; }
        [Column("CardId")]
        [ForeignKey("CardId")]
        public int CardId { get; set; }
       
        public User? User { get; set; }
        public Card? Card { get; set; }
    }
}
