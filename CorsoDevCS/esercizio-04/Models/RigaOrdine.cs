using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace esercizio_04.Models
{
    [Table("RigaOrdine")]
    public class RigaOrdine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int NumeroOrdine { get; set; }
        [JsonIgnore]
        [ForeignKey("NumeroOrdine")]
        public virtual Ordine Ordine { get; set; }
        [Required]
        [StringLength(100)]
        public string Prodotto { get; set; }
        [Required]
        public int Quantita { get; set; }
        [Required]
        public decimal PrezzoUnitario { get; set; }
    }
}