using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface IChiTietSPRepositories
    {
        bool ThemChiTietPham(ChiTietSp chiTietSp);
        bool SuaChiTietSanPham(ChiTietSp chiTietSp, Guid Id);
        bool XoaChiTietSanPham(ChiTietSp chiTietSp,Guid Id);
        ChiTietSp GetById(ChiTietSp chiTietSp,Guid Id);//Phương thức tìm sản phẩm theo ID
        List<ChiTietSp> GetAll();
    }
}
