namespace MvcCases.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AdminDbcontext : DbContext
    {
        public AdminDbcontext()
            : base("name=AdminDbcontext")
        {
        }
        public virtual DbSet<AdminSection_GEN> AdminSection_GENs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
