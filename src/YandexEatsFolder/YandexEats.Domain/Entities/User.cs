using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace YandexEats.Domain.Entities
{
    [Table("Users", Schema = "dbo")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("UserId")]
        public int Id { get; set; }

        [Column("PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Column("Password")]
        public string Password { get; set; }

        [Column("Role")]
        public string Role { get; set; }

        public ICollection<Customer> Customers { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
        public ICollection<Basket> Baskets { get; set; }

    }
}
