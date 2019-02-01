namespace WebFormCases2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DepartAndEmp : DbContext
    {
        public DepartAndEmp()
            : base("name=DepartAndEmp1")
        {
        }

        public virtual DbSet<Department> departments { get; set; }
        public virtual DbSet<Employee> employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(e => e.employees)
                .WithOptional(e => e.department)
                .HasForeignKey(e => e.department_id);
        }
    }
}
