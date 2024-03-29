﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YandexTaxi.Domain.Entity
{
    [Table("Taxi", Schema = "dbo")]
    public class Taxi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("TaxiId")]
        public int Id { get; set; }

        [Column("UserId")]
        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [Column("Mark")]
        public float Mark { get; set; }

        [Column("MarkCount")]
        public float MarkCount { get; set; }

        public User? User { get; set; }
        public ICollection<Order>? Order { get; set; }
        public ICollection<Car>? Cars { get; set; }
    }
}
