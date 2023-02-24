using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepositories
{
    public interface ISanPhamRepositories
    {
        bool ThemSanPham(SanPham sanPham);
        bool SuaSanPham(SanPham sanPham, Guid Id);
        bool XoaSanPham(Guid Id);
        SanPham GetById(Guid Id);//Phương thức tìm sản phẩm theo ID
        List<SanPham> GetAll();
    }
}
