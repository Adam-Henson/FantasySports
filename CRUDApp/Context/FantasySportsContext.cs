using CRUDApp.Models;
using Microsoft.EntityFrameworkCore;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CRUDApp.Context
{
    public partial class FantasySportsContext : DbContext
    {

        public FantasySportsContext()
        {

        }

        public FantasySportsContext(DbContextOptions<FantasySportsContext> options)
            : base(options)
        {

        }


        public virtual DbSet<Football> Football { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Football>(entity =>
            {
                entity.HasKey(e => e.TeamId);

                entity.Property(e => e.Versus)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SeasonRecord)
                    .IsRequired()
                    .HasMaxLength(255);
            });




            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
