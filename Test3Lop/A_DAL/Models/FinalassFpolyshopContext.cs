using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.Models;

public partial class FinalassFpolyshopContext : DbContext
{
    public FinalassFpolyshopContext()
    {
    }

    public FinalassFpolyshopContext(DbContextOptions<FinalassFpolyshopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietSp> ChiTietSps { get; set; }

    public virtual DbSet<ChucVu> ChucVus { get; set; }

    public virtual DbSet<CuaHang> CuaHangs { get; set; }

    public virtual DbSet<DongSp> DongSps { get; set; }

    public virtual DbSet<GioHang> GioHangs { get; set; }

    public virtual DbSet<GioHangChiTiet> GioHangChiTiets { get; set; }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<MauSac> MauSacs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<Nsx> Nsxes { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-51CTS9F\\SQLEXPRESS;Initial Catalog=FINALASS_FPOLYSHOP;Integrated Security=True;Integrated Security=True;trusted_connection=true;encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietSp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChiTietS__3214EC07873319B7");

            entity.ToTable("ChiTietSP");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.GiaBan)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.GiaNhap)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.IdDongSp).HasColumnName("IdDongSP");
            entity.Property(e => e.IdSp).HasColumnName("IdSP");
            entity.Property(e => e.MoTa).HasMaxLength(50);
            entity.Property(e => e.NamBh).HasColumnName("NamBH");

            entity.HasOne(d => d.IdDongSpNavigation).WithMany(p => p.ChiTietSps)
                .HasForeignKey(d => d.IdDongSp)
                .HasConstraintName("FK__ChiTietSP__IdDon__2A164134");

            entity.HasOne(d => d.IdMauSacNavigation).WithMany(p => p.ChiTietSps)
                .HasForeignKey(d => d.IdMauSac)
                .HasConstraintName("FK__ChiTietSP__IdMau__29221CFB");

            entity.HasOne(d => d.IdNsxNavigation).WithMany(p => p.ChiTietSps)
                .HasForeignKey(d => d.IdNsx)
                .HasConstraintName("FK__ChiTietSP__IdNsx__282DF8C2");

            entity.HasOne(d => d.IdSpNavigation).WithMany(p => p.ChiTietSps)
                .HasForeignKey(d => d.IdSp)
                .HasConstraintName("FK__ChiTietSP__IdSP__2739D489");
        });

        modelBuilder.Entity<ChucVu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ChucVu__3214EC073F4337D1");

            entity.ToTable("ChucVu");

            entity.HasIndex(e => e.Ma, "UQ__ChucVu__3214CC9ECAF80D9E").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<CuaHang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CuaHang__3214EC0796D78FA5");

            entity.ToTable("CuaHang");

            entity.HasIndex(e => e.Ma, "UQ__CuaHang__3214CC9E93F22263").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.QuocGia).HasMaxLength(50);
            entity.Property(e => e.Ten).HasMaxLength(50);
            entity.Property(e => e.ThanhPho).HasMaxLength(50);
        });

        modelBuilder.Entity<DongSp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DongSP__3214EC079E518941");

            entity.ToTable("DongSP");

            entity.HasIndex(e => e.Ma, "UQ__DongSP__3214CC9EAA731AAF").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(30);
        });

        modelBuilder.Entity<GioHang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GioHang__3214EC072D85E9A1");

            entity.ToTable("GioHang");

            entity.HasIndex(e => e.Ma, "UQ__GioHang__3214CC9E7B7EAC77").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.IdKh).HasColumnName("IdKH");
            entity.Property(e => e.IdNv).HasColumnName("IdNV");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NgayTao).HasColumnType("date");
            entity.Property(e => e.NgayThanhToan).HasColumnType("date");
            entity.Property(e => e.Sdt)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TenNguoiNhan).HasMaxLength(50);
            entity.Property(e => e.TinhTrang).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdKhNavigation).WithMany(p => p.GioHangs)
                .HasForeignKey(d => d.IdKh)
                .HasConstraintName("FK__GioHang__IdKH__25518C17");
        });

        modelBuilder.Entity<GioHangChiTiet>(entity =>
        {
            entity.HasKey(e => new { e.IdGioHang, e.IdChiTietSp }).HasName("PK_GioHangCT");

            entity.ToTable("GioHangChiTiet");

            entity.Property(e => e.IdChiTietSp).HasColumnName("IdChiTietSP");
            entity.Property(e => e.DonGia)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");
            entity.Property(e => e.DonGiaKhiGiam)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");

            entity.HasOne(d => d.IdChiTietSpNavigation).WithMany(p => p.GioHangChiTiets)
                .HasForeignKey(d => d.IdChiTietSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK2_IdChiTietSP");

            entity.HasOne(d => d.IdGioHangNavigation).WithMany(p => p.GioHangChiTiets)
                .HasForeignKey(d => d.IdGioHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK1_IdGioHang");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HoaDon__3214EC0705A9A880");

            entity.ToTable("HoaDon");

            entity.HasIndex(e => e.Ma, "UQ__HoaDon__3214CC9E6D121475").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.IdKh).HasColumnName("IdKH");
            entity.Property(e => e.IdNv).HasColumnName("IdNV");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NgayNhan).HasColumnType("date");
            entity.Property(e => e.NgayShip).HasColumnType("date");
            entity.Property(e => e.NgayTao).HasColumnType("date");
            entity.Property(e => e.NgayThanhToan).HasColumnType("date");
            entity.Property(e => e.Sdt)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TenNguoiNhan).HasMaxLength(50);
            entity.Property(e => e.TinhTrang).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdKhNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdKh)
                .HasConstraintName("FK__HoaDon__IdKH__245D67DE");

            entity.HasOne(d => d.IdNvNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.IdNv)
                .HasConstraintName("FK__HoaDon__IdNV__2645B050");
        });

        modelBuilder.Entity<HoaDonChiTiet>(entity =>
        {
            entity.HasKey(e => new { e.IdHoaDon, e.IdChiTietSp }).HasName("PK_HoaDonCT");

            entity.ToTable("HoaDonChiTiet");

            entity.Property(e => e.IdChiTietSp).HasColumnName("IdChiTietSP");
            entity.Property(e => e.DonGia)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(20, 0)");

            entity.HasOne(d => d.IdChiTietSpNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdChiTietSp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK2");

            entity.HasOne(d => d.IdHoaDonNavigation).WithMany(p => p.HoaDonChiTiets)
                .HasForeignKey(d => d.IdHoaDon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK1");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__KhachHan__3214EC074EE9BDBF");

            entity.ToTable("KhachHang");

            entity.HasIndex(e => e.Ma, "UQ__KhachHan__3214CC9E745409EB").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.Ho).HasMaxLength(30);
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MatKhau).IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.QuocGia).HasMaxLength(50);
            entity.Property(e => e.Sdt)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TenDem).HasMaxLength(30);
            entity.Property(e => e.ThanhPho).HasMaxLength(50);
        });

        modelBuilder.Entity<MauSac>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MauSac__3214EC0728393C59");

            entity.ToTable("MauSac");

            entity.HasIndex(e => e.Ma, "UQ__MauSac__3214CC9E1E9F32E2").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(30);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NhanVien__3214EC07CC3C18DD");

            entity.ToTable("NhanVien");

            entity.HasIndex(e => e.Ma, "UQ__NhanVien__3214CC9E7A92F766").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.Ho).HasMaxLength(30);
            entity.Property(e => e.IdCh).HasColumnName("IdCH");
            entity.Property(e => e.IdCv).HasColumnName("IdCV");
            entity.Property(e => e.IdGuiBc).HasColumnName("IdGuiBC");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MatKhau).IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("date");
            entity.Property(e => e.Sdt)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(30);
            entity.Property(e => e.TenDem).HasMaxLength(30);
            entity.Property(e => e.TrangThai).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IdChNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.IdCh)
                .HasConstraintName("FK__NhanVien__IdCH__2180FB33");

            entity.HasOne(d => d.IdCvNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.IdCv)
                .HasConstraintName("FK__NhanVien__IdCV__22751F6C");

            entity.HasOne(d => d.IdGuiBcNavigation).WithMany(p => p.InverseIdGuiBcNavigation)
                .HasForeignKey(d => d.IdGuiBc)
                .HasConstraintName("FK__NhanVien__IdGuiB__236943A5");
        });

        modelBuilder.Entity<Nsx>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NSX__3214EC07DE4BF902");

            entity.ToTable("NSX");

            entity.HasIndex(e => e.Ma, "UQ__NSX__3214CC9E45636C81").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(30);
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SanPham__3214EC072DEC7135");

            entity.ToTable("SanPham");

            entity.HasIndex(e => e.Ma, "UQ__SanPham__3214CC9E6B1FC4C6").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ten).HasMaxLength(30);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
