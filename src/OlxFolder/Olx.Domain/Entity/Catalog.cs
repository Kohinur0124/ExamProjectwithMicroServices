using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olx.Domain.Entity
{
    [Table("Catalog",Schema ="dbo")]
    public class Catalog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CatalogId")]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
