using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Admin.Model
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        public virtual DbSet<DANHMUC> DANHMUCs { get; set; }
        public virtual DbSet<DONHANG> DONHANGs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<ROLE> ROLES { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOANQUANTRI> TAIKHOANQUANTRIs { get; set; }
        public virtual DbSet<TRANGTHAIDONHANG> TRANGTHAIDONHANGs { get; set; }
        public virtual DbSet<VIEWCHITIET> VIEWCHITIETs { get; set; }
        public virtual DbSet<VIEWDONHANG> VIEWDONHANGs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIETDONHANG>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DONHANG>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DONHANG>()
                .HasMany(e => e.CHITIETDONHANGs)
                .WithRequired(e => e.DONHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.MatKhau)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ROLE>()
                .HasMany(e => e.TAIKHOANQUANTRIs)
                .WithRequired(e => e.ROLE1)
                .HasForeignKey(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.HinhAnh)
                .IsFixedLength();

            modelBuilder.Entity<SANPHAM>()
                .HasMany(e => e.CHITIETDONHANGs)
                .WithRequired(e => e.SANPHAM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAIKHOANQUANTRI>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<TAIKHOANQUANTRI>()
                .Property(e => e.MatKhau)
                .IsFixedLength();

            modelBuilder.Entity<TRANGTHAIDONHANG>()
                .HasMany(e => e.DONHANGs)
                .WithOptional(e => e.TRANGTHAIDONHANG)
                .HasForeignKey(e => e.TrangThai);

            modelBuilder.Entity<VIEWCHITIET>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VIEWCHITIET>()
                .Property(e => e.HinhAnh)
                .IsFixedLength();

            modelBuilder.Entity<VIEWDONHANG>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
