namespace BookShop.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBConnection : DbContext
    {
        public DBConnection()
            : base("name=DBConnection")
        {
        }

        public virtual DbSet<CHITIETDATHANG> CHITIETDATHANGs { get; set; }
        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<CHITIETKM> CHITIETKMs { get; set; }
        public virtual DbSet<CHITIETPHIEUNHAP> CHITIETPHIEUNHAPs { get; set; }
        public virtual DbSet<CHUDE> CHUDEs { get; set; }
        public virtual DbSet<DATHANG> DATHANGs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<NHAXUATBAN> NHAXUATBANs { get; set; }
        public virtual DbSet<PHANQUYEN> PHANQUYENs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TACGIA> TACGIAs { get; set; }
        public virtual DbSet<VIETSACH> VIETSACHes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHUDE>()
                .HasMany(e => e.SACHes)
                .WithOptional(e => e.CHUDE)
                .HasForeignKey(e => e.ID_CHUDE);

            modelBuilder.Entity<DATHANG>()
                .Property(e => e.SDTKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DATHANG>()
                .HasMany(e => e.CHITIETDATHANGs)
                .WithRequired(e => e.DATHANG)
                .HasForeignKey(e => e.ID_DH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOADON>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.HOADON)
                .HasForeignKey(e => e.ID_HD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHUYENMAI>()
                .HasMany(e => e.CHITIETKMs)
                .WithRequired(e => e.KHUYENMAI)
                .HasForeignKey(e => e.ID_KM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.HOADONs)
                .WithOptional(e => e.NHANVIEN)
                .HasForeignKey(e => e.ID_NV);

            modelBuilder.Entity<NHAXUATBAN>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAXUATBAN>()
                .Property(e => e.FAX)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHAXUATBAN>()
                .HasMany(e => e.PHIEUNHAPs)
                .WithOptional(e => e.NHAXUATBAN)
                .HasForeignKey(e => e.ID_NXB);

            modelBuilder.Entity<NHAXUATBAN>()
                .HasMany(e => e.SACHes)
                .WithOptional(e => e.NHAXUATBAN)
                .HasForeignKey(e => e.ID_NXB);

            modelBuilder.Entity<PHANQUYEN>()
                .HasMany(e => e.NHANVIENs)
                .WithOptional(e => e.PHANQUYEN)
                .HasForeignKey(e => e.ID_QUYEN);

            modelBuilder.Entity<PHIEUNHAP>()
                .HasMany(e => e.CHITIETPHIEUNHAPs)
                .WithRequired(e => e.PHIEUNHAP)
                .HasForeignKey(e => e.ID_PN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SACH>()
                .Property(e => e.BIA)
                .IsUnicode(false);

            modelBuilder.Entity<SACH>()
                .Property(e => e.KHO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.CHITIETHOADONs)
                .WithRequired(e => e.SACH)
                .HasForeignKey(e => e.ID_SACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.CHITIETKMs)
                .WithRequired(e => e.SACH)
                .HasForeignKey(e => e.ID_SACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.CHITIETPHIEUNHAPs)
                .WithRequired(e => e.SACH)
                .HasForeignKey(e => e.ID_SACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SACH>()
                .HasMany(e => e.VIETSACHes)
                .WithRequired(e => e.SACH)
                .HasForeignKey(e => e.ID_SACH)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TACGIA>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TACGIA>()
                .HasMany(e => e.VIETSACHes)
                .WithRequired(e => e.TACGIA)
                .HasForeignKey(e => e.ID_TACGIA)
                .WillCascadeOnDelete(false);
        }
    }
}
