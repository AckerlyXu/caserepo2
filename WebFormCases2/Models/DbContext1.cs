namespace WebFormCases2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbContext1 : DbContext
    {
        public DbContext1()
            : base("name=DbContext1")
        {
        }

        public virtual DbSet<Entity1> Entity1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
