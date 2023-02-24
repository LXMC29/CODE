using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using System.Windows.Forms.Design.Behavior;

namespace C_GUI
{
    public partial class FrmSanPham : Form
    {
        ISanPhamServices sanPhamServices;
        private Guid idSanPham;
        public FrmSanPham()
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
            Type type = typeof(A_DAL.Models.SanPham);
            DgvSanPham.ColumnCount= 3;//Hiển thị bao nhiểu cột tự cấu hình
            DgvSanPham.Columns[0].Name = "ID";
            DgvSanPham.Columns[1].Name = "Ma";
            DgvSanPham.Columns[2].Name = "Ten";
            DgvSanPham.Rows.Clear();
            foreach(var x in sanPhamServices.GetAll())
            {
                DgvSanPham.Rows.Add(x.Id,x.Ma,x.Ten);
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
            SanPham sanPham = new SanPham();
            sanPham.Ten = txtTen.Text;
            sanPham.Ma= txtMa.Text;
            if (MessageBox.Show("Bạn Có Chắc Chắn Thêm Không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(sanPhamServices.ThemSanPham(sanPham));
            }
            LoadDgv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn Có Chắc Chắn Xóa Không?","Xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                MessageBox.Show(sanPhamServices.XoaSanPham(idSanPham));
            }
            LoadDgv();
        }

        private void txtMa_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex ;
            idSanPham = Guid.Parse(DgvSanPham.Rows[rowindex].Cells[0].Value.ToString());
            txtMa.Text = DgvSanPham.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTen.Text = DgvSanPham.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SanPham sanPham = new SanPham();
            sanPham.Ten = txtTen.Text;
            sanPham.Ma = txtMa.Text;
            if (MessageBox.Show("Bạn Có Chắc Chắn Sửa Không?", "Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(sanPhamServices.SuaSanPham(idSanPham, sanPham));
            }
            LoadDgv();
        }
    }
}