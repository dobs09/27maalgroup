using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Indtast27Mål.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Indtast27Mål.Data
{
    public partial class MålDbContext : DbContext
    {
        public MålDbContext()
        {
        }

        public MålDbContext(DbContextOptions<MålDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EgeMål> EgeMål { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=EGE0-SQL2019-01\\TOBIAS;Initial Catalog=Tobias;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<EgeMål>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Indikator)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.Hvad)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.Dato)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.Hvorfor)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.Initiativer)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.Kategori)
                    .HasMaxLength(250)
                    .IsFixedLength();

                entity.Property(e => e.SenesteDanmark).HasColumnName("Seneste_Danmark");

                entity.Property(e => e.SenesteEgedal).HasColumnName("Seneste_Egedal");

                entity.Property(e => e.StatusDanmark).HasColumnName("Status_Danmark");

                entity.Property(e => e.StatusEgedal).HasColumnName("Status_Egedal");
            });

           
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
