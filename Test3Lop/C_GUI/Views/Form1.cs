using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using System.Windows.Forms.Design.Behavior;

namespace C_GUI
{
    public partial class Form1 : Form
    {
        ISanPhamServices sanPhamServices;
        public Form1()
        {
            InitializeComponent();
            sanPhamServices = new SanPhamServices();
            //Cần chức năng gì thì gọi ra thông Service
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDgv();
        }
        private void LoadDgv()
        {
            int stt = 1;
            Type type= typeof(SanPham);
            DgvSanPham.ColumnCount= 4;//Hiển thị bao nhiểu cột tự cấu hình
            DgvSanPham.Columns[0].Name = "STT";
            DgvSanPham.Columns[1].Name = "ID";
            DgvSanPham.Columns[2].Name = "Ma";
            DgvSanPham.Columns[3].Name = "Ten";
            DgvSanPham.Rows.Clear();
            foreach(var x in sanPhamServices.GetAll())
            {
                DgvSanPham.Rows.Add(stt++,x.Id,x.Ma,x.Ten);
            }
        }
        private void Them()
        {
                var sanpham = new SanPhamServices();
                //sanpham.Id = Guid.NewGuid();
                //sanpham.Ma = txtMa.Text;
                //sanpham.Ten = txtTen.Text;
        }
        private void Xoa()
        {
            //sanPhamServices.XoaSanPham();
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            //sanPhamServices.ThemSanPham(txtTen.Text);
            LoadDgv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //sanPhamServices.XoaSanPham(SanPham);
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}