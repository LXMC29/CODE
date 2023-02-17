namespace C_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvSanPham = new System.Windows.Forms.DataGridView();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvSanPham
            // 
            this.DgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSanPham.ColumnHeadersHeight = 29;
            this.DgvSanPham.Location = new System.Drawing.Point(28, 236);
            this.DgvSanPham.Name = "DgvSanPham";
            this.DgvSanPham.RowHeadersWidth = 51;
            this.DgvSanPham.RowTemplate.Height = 29;
            this.DgvSanPham.Size = new System.Drawing.Size(382, 188);
            this.DgvSanPham.TabIndex = 0;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(168, 118);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(216, 27);
            this.txtMa.TabIndex = 1;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(168, 177);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(216, 27);
            this.txtTen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(269, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lý Sản Phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(573, 115);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(143, 58);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(573, 219);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(141, 58);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(573, 321);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(141, 62);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.DgvSanPham);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DgvSanPham;
        private TextBox txtMa;
        private TextBox txtTen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}