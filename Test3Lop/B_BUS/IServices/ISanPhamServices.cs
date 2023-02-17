using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface ISanPhamServices
    {
        string ThemSanPham(SanPham sanPham);
        string SuaSanPham(Guid Id, SanPham sanPham);
        string XoaSanPham(Guid Id);
        List<SanPham> GetAll();
    }
}
