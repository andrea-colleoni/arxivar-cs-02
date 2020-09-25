namespace _06_ef
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Persone")]
    public partial class Persone
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        [Required]
        [StringLength(30)]
        public string Cognome { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? AltezzaInCm { get; set; }

        public double? PesoInKg { get; set; }

        public DateTime? DataNascita { get; set; }
        [NotMapped]
        public string SoloNelProgramma { get; set; }
    }
}
