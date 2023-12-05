using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace YandexEats.Domain.Entities
{
    [Table("Users",Schema ="dbo")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("UserId")]
        public int Id { get; set; }

        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Column("Password")]
        public string Password {  get; set; }

        [Column("Role")]
        public string Role { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
