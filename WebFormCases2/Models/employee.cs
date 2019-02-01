namespace WebFormCases2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("employee")]
    public partial class Employee
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int salary { get; set; }

        public int? department_id { get; set; }

        public virtual Department department { get; set; }
    }
}
