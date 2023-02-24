using A_DAL.IRepositories;
using A_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class ChiTietSPRepositories : IChiTietSPRepositories
    {
        FinalassFpolyshopContext context;
        public ChiTietSPRepositories()
        {
            context= new FinalassFpolyshopContext();
        }

        public List<ChiTietSp> GetAll()
        {
            return context.ChiTietSps.ToList();
        }

        public ChiTietSp GetById(ChiTietSp chiTietSp, Guid Id)
        {
            var ketqua = context.ChiTietSps.Find(Id);
            return ketqua;
        }

        public bool SuaChiTietSanPham(ChiTietSp chiTietSp, Guid Id)
        {
            try
            {
                var ketqua = context.ChiTietSps.Find(Id);
                ketqua.NamBh = chiTietSp.NamBh;
                ketqua.GiaNhap = chiTietSp.GiaNhap;
                ketqua.GiaBan = chiTietSp.GiaBan;
                ketqua.MoTa = chiTietSp.MoTa;
                context.SaveChanges();
                return true;
            }catch(Exception ex) { return false; }
        }

        public bool ThemChiTietPham(ChiTietSp chiTietSp)
        {
            try
            {
                context.ChiTietSps.Add(chiTietSp);
                return true;
            }catch(Exception ex) { return false; }
        }

        public bool XoaChiTietSanPham(ChiTietSp chiTietSp, Guid Id)
        {
            try
            {
                var ketqua = context.ChiTietSps.Find(Id);
                context.SaveChanges();
                return true;
            }catch(Exception ex) { return false; }

        }
    }
}
