using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication17.Models
{
    public partial class Movie_1Context : DbContext
    {
        public Movie_1Context()
        {
        }

        public Movie_1Context(DbContextOptions<Movie_1Context> abc)
            : base(abc)
        {
        }
        public virtual DbSet<Cinema> Cinema { get; set; }
        public virtual DbSet<Movie1> Movie1 { get; set; }

       
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer(@"Server=DESKTOP-7N6I9F8\SQLEXPRESS;Database=Movie.1;Trusted_Connection=True; User ID=sa; Password=hamu;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cinema>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HallNo).HasColumnName("Hall_No");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Movie1>(entity =>
            {
                entity.ToTable("Movie.1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Actor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Actress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Director)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Language)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Producer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseDate)
                    .HasColumnName("Release_Date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Writer)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
