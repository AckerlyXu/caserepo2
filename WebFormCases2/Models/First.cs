namespace WebFormCases2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("First")]
    public partial class First
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Info { get; set; }

        public decimal? amount { get; set; }
    }
}
