using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QUANLY_KARAOKE_PROJECT.Model
{
    public partial class KaraokeContextDB : DbContext
    {
        public KaraokeContextDB()
            : base("name=KaraokeContextDB")
        {
        }

        public virtual DbSet<DAT_PHONG> DAT_PHONG { get; set; }
        public virtual DbSet<HOA_DON> HOA_DON { get; set; }
        public virtual DbSet<HOA_DON_SAN_PHAM> HOA_DON_SAN_PHAM { get; set; }
        public virtual DbSet<KHACH_HANG> KHACH_HANG { get; set; }
        public virtual DbSet<LOAI_PHONG> LOAI_PHONG { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<SAN_PHAM> SAN_PHAM { get; set; }
        public virtual DbSet<THONG_TIN_QUAN> THONG_TIN_QUAN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DAT_PHONG>()
                .Property(e => e.IDDatPhong)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.IDHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.IDDatPhong)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .Property(e => e.NgayGioTao)
                .IsUnicode(false);

            modelBuilder.Entity<HOA_DON>()
                .HasMany(e => e.HOA_DON_SAN_PHAM)
                .WithRequired(e => e.HOA_DON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOA_DON_SAN_PHAM>()
                .Property(e => e.IDHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<KHACH_HANG>()
                .Property(e => e.DiaChi)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.TenPhong)
                .IsUnicode(false);

            modelBuilder.Entity<SAN_PHAM>()
                .HasMany(e => e.HOA_DON_SAN_PHAM)
                .WithRequired(e => e.SAN_PHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THONG_TIN_QUAN>()
                .Property(e => e.SDT)
                .IsFixedLength();
        }
    }
}
