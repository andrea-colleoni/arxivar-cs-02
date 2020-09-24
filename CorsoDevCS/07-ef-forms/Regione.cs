using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace _07_ef_forms
{
    [Table("Regione")]
    public class Regione
    {
        [Key]
        public string Nome { get; set; }
        public AreaGeografica AreaGeografica { get; set; }
        public string Paese { get; set; }
    }
}
