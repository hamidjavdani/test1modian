namespace pmService.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SmModel : DbContext
    {
        public SmModel()
            : base("name=SmModel")
        {
        }

        public virtual DbSet<ViewPardakhtMN> ViewPardakhtMNs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ViewPardakhtMN>()
                .Property(e => e.Idrow)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ViewPardakhtMN>()
                .Property(e => e.pardakhti)
                .HasPrecision(18, 0);
        }
    }
}
