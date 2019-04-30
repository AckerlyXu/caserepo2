namespace ConsoleApp1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using MvcCases.Models;

    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=DbContext")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
