using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olx.Domain.Entity
{
    [Table("Product",Schema ="dbo")]
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProductId")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }

        [Column("CatalogId")]
        [ForeignKey("CatalogId")]
        public int CatalogId { get; set; }

        [Column("SellerId")]
        [ForeignKey("SellerId")]
        public int SellerId { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }
        //*******************
        public Catalog Catalog { get; set; }
        public User User { get; set; }
        public ICollection<Product> Products { get; set;}
    }
}
