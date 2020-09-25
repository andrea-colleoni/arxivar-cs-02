using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace esercizio_04.Models
{
    [Table("Ordine")]
    public class Ordine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NumeroOrdine { get; set; }
        [Required]
        [StringLength(100)]
        public string Cliente { get; set; }
        public DateTime DataOrdine { get; set; }

        public virtual List<RigaOrdine> RigheOrdine { get; set; }
    }
}