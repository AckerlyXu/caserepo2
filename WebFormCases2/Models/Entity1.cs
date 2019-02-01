namespace WebFormCases2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Entity1
    {
        public int id { get; set; }

        public DateTime? mydate { get; set; }

        [StringLength(50)]
        public string name { get; set; }
    }
}
