namespace _09_web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_top3_products
    {
        [Key]
        [Column(Order = 0)]
        public int ProductID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string ProductNumber { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool MakeFlag { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "money")]
        public decimal ListPrice { get; set; }

        [StringLength(5)]
        public string Size { get; set; }

        public long? rank { get; set; }
    }
}
