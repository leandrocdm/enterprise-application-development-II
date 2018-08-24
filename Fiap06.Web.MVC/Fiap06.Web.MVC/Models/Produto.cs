using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.Models
{
    public class Produto
    {
        [Key]
        [Column("Id")]
        public int ProdutolId { get; set; }
        [Required]
        [MaxLength(20)]
        [MinLength(1)]
        public string Nome { get; set; }
    }
}