using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CRUDApp.Models;
using System.Reflection;

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
        public virtual DbSet<Bears> Bears { get; set; }
        public virtual DbSet<Bengals> Bengals { get; set; }
        public virtual DbSet<Bills> Bills { get; set; }
        public virtual DbSet<Broncos> Broncos { get; set; }
        public virtual DbSet<Browns> Browns { get; set; }
        public virtual DbSet<Buccaneers> Buccaneers { get; set; }
        public virtual DbSet<Cardinals> Cardinals { get; set; }
        public virtual DbSet<Chargers> Chargers { get; set; }
        public virtual DbSet<Chiefs> Chiefs { get; set; }
        public virtual DbSet<Colts> Colts { get; set; }
        public virtual DbSet<Commanders> Commanders { get; set; }
        public virtual DbSet<Cowboys> Cowboys { get; set; }
        public virtual DbSet<Dolphins> Dolphins { get; set; }
        public virtual DbSet<Eagles> Eagles { get; set; }
        public virtual DbSet<Falcons> Falcons { get; set; }
        public virtual DbSet<Giants> Giants { get; set; }
        public virtual DbSet<Jaguars> Jaguars { get; set; }
        public virtual DbSet<Jets> Jets { get; set; }
        public virtual DbSet<Lions> Lions { get; set; }
        public virtual DbSet<Packers> Packers { get; set; }
        public virtual DbSet<Panthers> Panthers { get; set; }
        public virtual DbSet<Patriots> Patriots { get; set; }
        public virtual DbSet<Raiders> Raiders { get; set; }
        public virtual DbSet<Rams> Rams { get; set; }
        public virtual DbSet<Ravens> Ravens { get; set; }
        public virtual DbSet<Saints> Saints { get; set; }
        public virtual DbSet<Seahawks> Seahawks { get; set; }
        public virtual DbSet<Steelers> Steelers { get; set; }
        public virtual DbSet<Texans> Texans { get; set; }
        public virtual DbSet<Titans> Titans { get; set; }
        public virtual DbSet<Vikings> Vikings { get; set; }
        public virtual DbSet<_49Ers> _49Ers { get; set; }

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

            modelBuilder.Entity<Bears>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Bengals>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Bills>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Broncos>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Browns>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Buccaneers>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Cardinals>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Chargers>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Chiefs>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Colts>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Commanders>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Cowboys>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Dolphins>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Eagles>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Falcons>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Giants>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Jaguars>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Jets>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Lions>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Packers>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Panthers>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Patriots>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Raiders>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Rams>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Ravens>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Saints>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Seahawks>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Steelers>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Texans>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Titans>(entity =>
            {
                entity.HasKey(e => e.TeamId);
            });

            modelBuilder.Entity<Vikings>(entity =>
            {
                entity.HasKey(e => e.TeamId)
                    .HasName("PK_Vikings");
            });

            modelBuilder.Entity<_49Ers>(entity =>
            {
                entity.HasKey(e => e.TeamId);

                entity.ToTable("49'ers");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
