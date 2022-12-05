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

                entity.Property(e => e.Week1Points).HasColumnName("Week 1 Points");

                entity.Property(e => e.Week2Points).HasColumnName("Week 2 Points");

                entity.Property(e => e.Week3Points).HasColumnName("Week 3 Points");

                entity.Property(e => e.Week4Points).HasColumnName("Week 4 Points");

                entity.Property(e => e.Week5Points).HasColumnName("Week 5 Points");

                entity.Property(e => e.Week6Points).HasColumnName("Week 6 Points");

                entity.Property(e => e.Week7Points).HasColumnName("Week 7 Points");

                entity.Property(e => e.Week8Points).HasColumnName("Week 8 Points");

                entity.Property(e => e.Week9Points).HasColumnName("Week 9 Points");

                entity.Property(e => e.Week10Points).HasColumnName("Week 10 Points");

                entity.Property(e => e.Week11Points).HasColumnName("Week 11 Points");

                entity.Property(e => e.Week12Points).HasColumnName("Week 12 Points");

                entity.Property(e => e.Week13Points).HasColumnName("Week 13 Points");

                entity.Property(e => e.Week14Points).HasColumnName("Week 14 Points");

                entity.Property(e => e.Week15Points).HasColumnName("Week 15 Points");

                entity.Property(e => e.Week16Points).HasColumnName("Week 16 Points");

                entity.Property(e => e.Week17Points).HasColumnName("Week 17 Points");

                entity.Property(e => e.Week18Points).HasColumnName("Week 18 Points");

                entity.Property(e => e.PlayerPoints).HasColumnName("Player Points");

                entity.Property(e => e.PlayerGuess).HasColumnName("Player Guess");

                entity.ToTable("FantasyFootball");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
