using System;
using System.Collections.Generic;

namespace A_DAL.Models;

public partial class CuaHang
{
    public Guid Id { get; set; }

    public string? Ma { get; set; }

    public string? Ten { get; set; }

    public string? DiaChi { get; set; }

    public string? ThanhPho { get; set; }

    public string? QuocGia { get; set; }

    public virtual ICollection<NhanVien> NhanViens { get; } = new List<NhanVien>();
}
