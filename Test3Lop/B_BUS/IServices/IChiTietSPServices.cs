using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.IServices
{
    public interface IChiTietSPServices
    {
        string ThemChiTietSanPham(ChiTietSp chiTietSp);
        string SuaChiTietSanPham(Guid Id, ChiTietSp chiTietSp);
        string XoaChiTietSanPham(Guid Id, ChiTietSp chiTietSp);
        List<ChiTietSp> GetAll();
    }
}
