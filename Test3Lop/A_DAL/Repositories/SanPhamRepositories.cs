using A_DAL.IRepositories;
using A_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repositories
{
    public class SanPhamRepositories : ISanPhamRepositories
    {
        FinalassFpolyshopContext context;
        public SanPhamRepositories()
        {
            context = new FinalassFpolyshopContext();
        }


        public List<SanPham> GetAll()
        {
            return context.SanPhams.ToList();
        }

        public SanPham GetById(Guid Id)
        {
            var ketqua = context.SanPhams.Find(Id);
            return ketqua;
        }

        public bool SuaSanPham(SanPham sanPham, Guid Id)
        {
            try
            {
                var ketqua = context.SanPhams.Find(Id);
                ketqua.Ten = sanPham.Ten;
                ketqua.Ma = sanPham.Ma;
                context.SaveChanges();
                return true;
            }catch(Exception) { return false; }
        }

        public bool ThemSanPham(SanPham sanPham)
        {
            try
            {
                context.SanPhams.Add(sanPham);
                context.SaveChanges();
                return true;
            }catch(Exception) { return false; }
        }

        public bool XoaSanPham(Guid Id)
        {
            try
            {
                var ketqua = context.SanPhams.Find(Id);
                context.SanPhams.Remove(ketqua);
                context.SaveChanges();
                return true;
            }catch(Exception) { return false; }
        }
    }
}
