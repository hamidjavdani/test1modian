using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace pmService.Models
{
    public partial class MaznetModel : DbContext
    {
        public MaznetModel()
            : base("name=MaznetModel")
        {
        }

        public virtual DbSet<Tbl_Derakht_Tajhizat> Tbl_Derakht_Tajhizat { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
