using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _07_ef_forms
{
    [Table("Citta")]
    public class Citta
    {
        [Key]
        public string Nome { get; set; }
        public string Provincia { get; set; }
        public string Regione { get; set; }

        [ForeignKey("Regione")]
        public virtual Regione OggettoRegione { get; set; }
        public float? Estensione { get; set; }
        public float? Popolazione { get; set; }
    }
}
