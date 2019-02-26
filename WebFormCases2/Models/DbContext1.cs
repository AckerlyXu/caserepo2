namespace WebFormCases2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbContext1 : DbContext
    {
        public DbContext1()
            : base("name=DbContext11")
        {
        }

        public virtual DbSet<Entity1> Entity1 { get; set; }
        public virtual DbSet<First> Firsts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<First>()
                .Property(e => e.amount)
                .HasPrecision(10, 2);
        }
    }
}
