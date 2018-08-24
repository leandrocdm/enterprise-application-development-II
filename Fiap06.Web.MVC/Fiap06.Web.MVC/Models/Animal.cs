using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Models
{
    [Table("TAnimal")]
    public class Animal
    {
        [Column("Id")]
        public int AnimalId { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(1)]
        public string Nome { get; set; }
        [Required]
        public string Raca { get; set; }
        [Required]
        public bool Castrado { get; set; }
        [Required]
        public float Peso { get; set; }
    }
}