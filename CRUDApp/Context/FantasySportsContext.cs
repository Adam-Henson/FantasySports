using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CRUDApp.Models;
using System.Reflection;
using FantasySports.Models;

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

        public virtual DbSet<ArizonaCardinals> ArizonaCardinals { get; set; }
        public virtual DbSet<FantasyFootball> FantasyFootball { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=FantasySports;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArizonaCardinals>(entity =>
            {
                entity.HasKey(e => e.TeamId)
                    .HasName("PK_ArizonaCardinalsss");

                entity.Property(e => e.MyTeam)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Score)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SeasonRecord)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Versus)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            

            modelBuilder.Entity<FantasyFootball>(entity =>
            {
                entity.HasKey(e => e.TeamId);

                entity.ToTable("FantasyFootball");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
