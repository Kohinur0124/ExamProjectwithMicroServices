using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YandexEats.Domain.Entities
{
    [Table("Foods", Schema = "dbo")]
    public class Foods
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("FoodId")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Desc")]
        public string Desc { get; set; }

        [ForeignKey("CatalogId")]
        [Column("CatalogId")]
        public int CatalogId { get; set; }

        [ForeignKey("ResturauntId")]
        [Column("ResturauntId")]
        public int ResturauntId { get; set; }

        [Column("Portion")]
        public string Portion { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }

        public ICollection<Basket> Baskets { get; set; }
        public Catalog? Catalog { get; set; }
        public Restaurant? Restaurant { get; set; }

    }
}
