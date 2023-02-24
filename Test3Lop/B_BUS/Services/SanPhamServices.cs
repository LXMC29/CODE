using A_DAL.IRepositories;
using A_DAL.Models;
using A_DAL.Repositories;
using B_BUS.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class SanPhamServices : ISanPhamServices
    {
        ISanPhamRepositories repositories;
        public SanPhamServices()
        {
            repositories = new SanPhamRepositories();
        }

        public List<SanPham> GetAll()
        {
            List<SanPham> lstPham = new List<SanPham>();
            //Viết 1 câu LINQ để gán giá trị cho từng prop của SPView
            lstPham =
                (from x in repositories.GetAll()
                 select x).ToList();
            //Để hiển thị sản phẩm thì có càng nhiều bảng tham gia thì join vào càng nhiều

            return lstPham;
        }

        public string SuaSanPham(Guid Id, SanPham sanPham)
        {
            if (repositories.SuaSanPham(sanPham, Id))
            {
                return "Sửa thành công";
            }
            else return "Thất Bại";
        }

        public string ThemSanPham(SanPham sanPham)
        {
            if (repositories.ThemSanPham(sanPham))
            {
                return "Thêm thành công";
            }
            else return "Thất Bại";
        }

        public string XoaSanPham(Guid Id)
        {
            if (repositories.XoaSanPham(Id))
            {
                return "Xóa thành công";
            }
            else return "Thất Bại";
        }
    }
}
