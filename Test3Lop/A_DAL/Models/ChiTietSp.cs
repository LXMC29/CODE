using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class ChiTietSp
{
    public Guid Id { get; set; }

    public Guid? IdSp { get; set; }

    public Guid? IdNsx { get; set; }

    public Guid? IdMauSac { get; set; }

    public Guid? IdDongSp { get; set; }

    public int? NamBh { get; set; }

    public string? MoTa { get; set; }

    public int? SoLuongTon { get; set; }

    public decimal? GiaNhap { get; set; }

    public decimal? GiaBan { get; set; }

    public virtual ICollection<GioHangChiTiet> GioHangChiTiets { get; } = new List<GioHangChiTiet>();

    public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; } = new List<HoaDonChiTiet>();

    public virtual DongSp? IdDongSpNavigation { get; set; }

    public virtual MauSac? IdMauSacNavigation { get; set; }

    public virtual Nsx? IdNsxNavigation { get; set; }

    public virtual SanPham? IdSpNavigation { get; set; }
}
