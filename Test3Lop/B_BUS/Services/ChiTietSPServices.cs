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
    public class ChiTietSPServices : IChiTietSPServices
    {
        IChiTietSPRepositories repositories;
        public ChiTietSPServices()
        {
            repositories= new ChiTietSPRepositories();
        }
        public List<ChiTietSp> GetAll()
        {
            List<ChiTietSp> lstPham = new List<ChiTietSp>();
            //Viết 1 câu LINQ để gán giá trị cho từng prop của SPView
            lstPham =
                (from x in repositories.GetAll()
                 select x).ToList();
            //Để hiển thị sản phẩm thì có càng nhiều bảng tham gia thì join vào càng nhiều

            return lstPham;
        }

        public string SuaChiTietSanPham(Guid Id, ChiTietSp chiTietSp)
        {
            if (repositories.SuaChiTietSanPham(chiTietSp, Id))
            {
                return "Sửa thành công";
            }
            else return "Thất Bại";
        }

        public string ThemChiTietSanPham(ChiTietSp chiTietSp)
        {
            if (repositories.ThemChiTietPham(chiTietSp))
            {
                return "Thêm thành công";
            }
            else return "Thất Bại";
        }

        public string XoaChiTietSanPham(Guid Id, ChiTietSp chiTietSp)
        {
            if (repositories.XoaChiTietSanPham(chiTietSp, Id))
            {
                return "Xóa thành công";
            }
            else return "Thất Bại";
        }
    }
}
