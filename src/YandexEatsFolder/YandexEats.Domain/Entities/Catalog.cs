using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YandexEats.Domain.Entities
{
    [Table("Catalog", Schema = "dbo")]
    public class Catalog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CatalogId")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Desc")]
        public string Desc { get; set; }

        public ICollection<Foods> Foods { get; set; }

    }
}
