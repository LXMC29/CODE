using B_BUS.IServices;
using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_GUI.Views
{
    public partial class FrmChiTietSP : Form
    {
        IChiTietSPServices services;
        ISanPhamServices sanPhamServices;
        public FrmChiTietSP()
        {
            InitializeComponent();
            services = new ChiTietSPServices();
            sanPhamServices= new SanPhamServices();
        }

        private void ChiTietSP_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }
        private void LoadDgv()
        {
            int stt = 1;
            //Type type = typeof(A_DAL.Models.ChiTietSp);
            dgvChiTietSp.ColumnCount = 6;//Hiển thị bao nhiểu cột tự cấu hình
            dgvChiTietSp.Columns[0].Name = "IDSP";
            dgvChiTietSp.Columns[1].Name = "MoTa";
            dgvChiTietSp.Columns[2].Name = "SoLuongTon";
            dgvChiTietSp.Columns[3].Name = "GiaNhap";
            dgvChiTietSp.Columns[4].Name = "GiaBan";
            dgvChiTietSp.Columns[5].Name = "GiaTriTonKho";
            dgvChiTietSp.Rows.Clear();
            foreach (var x in services.GetAll())
            {
                dgvChiTietSp.Rows.Add(x.IdSp, x.MoTa, x.SoLuongTon,x.GiaNhap,x.GiaBan);
            }
        }

    }
}
