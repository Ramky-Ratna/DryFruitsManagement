using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DryFruiltsDataService.Models
{
    public partial class DRYFRUITSSERVICESMDFContext : DbContext
    {
        public DRYFRUITSSERVICESMDFContext()
        {
        }

        public DRYFRUITSSERVICESMDFContext(DbContextOptions<DRYFRUITSSERVICESMDFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProductType> ProductType { get; set; }
        public virtual DbSet<TblProducts> TblProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=F:\\DryFruitsManagement\\DryFruiltsDataService\\DryFruitsServices.mdf;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__ProductT__516F03B5D23BE5B0");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.ProductTypeText)
                    .HasColumnName("ProductTypeText")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblProducts>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__TblProdu__B40CC6CD6AC8BE06");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ProductName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductTypeText)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
