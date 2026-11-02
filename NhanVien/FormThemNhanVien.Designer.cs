
namespace LAB1.NhanVien
{
    partial class FormThemNhanVien
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label lblTenNhanVien;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.Label lblCccd;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTieuDe = new Label();
            btnThoat = new Button();
            btnThemMoi = new Button();
            panel1 = new Panel();
            txtMaNhanVien = new TextBox();
            lblMaNhanVien = new Label();
            txtTenNhanVien = new TextBox();
            lblTenNhanVien = new Label();
            cbChucVu = new ComboBox();
            lblChucVu = new Label();
            txtLuong = new TextBox();
            lblLuong = new Label();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            txtSoDienThoai = new TextBox();
            lblSoDienThoai = new Label();
            txtCccd = new TextBox();
            lblCccd = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblNgaySinh = new Label();
            cbGioiTinh = new ComboBox();
            lblGioiTinh = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(192, 64, 0);
            lblTieuDe.Location = new Point(165, 25);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(430, 31);
            lblTieuDe.TabIndex = 18;
            lblTieuDe.Text = "Thêm mới thông tin nhân viên";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Location = new Point(400, 455);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 21;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.Moccasin;
            btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F);
            btnThemMoi.Location = new Point(200, 455);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(137, 59);
            btnThemMoi.TabIndex = 20;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMaNhanVien);
            panel1.Controls.Add(lblMaNhanVien);
            panel1.Controls.Add(txtTenNhanVien);
            panel1.Controls.Add(lblTenNhanVien);
            panel1.Controls.Add(cbChucVu);
            panel1.Controls.Add(lblChucVu);
            panel1.Controls.Add(txtLuong);
            panel1.Controls.Add(lblLuong);
            panel1.Controls.Add(txtDiaChi);
            panel1.Controls.Add(lblDiaChi);
            panel1.Controls.Add(txtSoDienThoai);
            panel1.Controls.Add(lblSoDienThoai);
            panel1.Controls.Add(txtCccd);
            panel1.Controls.Add(lblCccd);
            panel1.Controls.Add(dtpNgaySinh);
            panel1.Controls.Add(lblNgaySinh);
            panel1.Controls.Add(cbGioiTinh);
            panel1.Controls.Add(lblGioiTinh);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Location = new Point(21, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 340);
            panel1.TabIndex = 15;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaNhanVien.Location = new Point(175, 20);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(170, 30);
            txtMaNhanVien.TabIndex = 1;
            // 
            // lblMaNhanVien
            // 
            lblMaNhanVien.AutoSize = true;
            lblMaNhanVien.Font = new Font("Microsoft Sans Serif", 13F);
            lblMaNhanVien.Location = new Point(14, 20);
            lblMaNhanVien.Name = "lblMaNhanVien";
            lblMaNhanVien.Size = new Size(141, 26);
            lblMaNhanVien.TabIndex = 0;
            lblMaNhanVien.Text = "Mã nhân viên";
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenNhanVien.Location = new Point(175, 80);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(170, 30);
            txtTenNhanVien.TabIndex = 5;
            // 
            // lblTenNhanVien
            // 
            lblTenNhanVien.AutoSize = true;
            lblTenNhanVien.Font = new Font("Microsoft Sans Serif", 13F);
            lblTenNhanVien.Location = new Point(6, 80);
            lblTenNhanVien.Name = "lblTenNhanVien";
            lblTenNhanVien.Size = new Size(149, 26);
            lblTenNhanVien.TabIndex = 4;
            lblTenNhanVien.Text = "Tên nhân viên";
            // 
            // cbChucVu
            // 
            cbChucVu.Font = new Font("Microsoft Sans Serif", 12F);
            cbChucVu.FormattingEnabled = true;
            cbChucVu.Location = new Point(175, 140);
            cbChucVu.Name = "cbChucVu";
            cbChucVu.Size = new Size(170, 28);
            cbChucVu.TabIndex = 9;
            // 
            // lblChucVu
            // 
            lblChucVu.AutoSize = true;
            lblChucVu.Font = new Font("Microsoft Sans Serif", 13F);
            lblChucVu.Location = new Point(78, 140);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(86, 26);
            lblChucVu.TabIndex = 8;
            lblChucVu.Text = "Chức vụ";
            // 
            // txtLuong
            // 
            txtLuong.Font = new Font("Microsoft Sans Serif", 12F);
            txtLuong.Location = new Point(175, 200);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(170, 30);
            txtLuong.TabIndex = 13;
            // 
            // lblLuong
            // 
            lblLuong.AutoSize = true;
            lblLuong.Font = new Font("Microsoft Sans Serif", 13F);
            lblLuong.Location = new Point(78, 200);
            lblLuong.Name = "lblLuong";
            lblLuong.Size = new Size(53, 26);
            lblLuong.TabIndex = 12;
            lblLuong.Text = "Lương";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Microsoft Sans Serif", 12F);
            txtDiaChi.Location = new Point(175, 260);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(170, 30);
            txtDiaChi.TabIndex = 17;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Microsoft Sans Serif", 13F);
            lblDiaChi.Location = new Point(86, 260);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(68, 26);
            lblDiaChi.TabIndex = 16;
            lblDiaChi.Text = "Địa chỉ";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 12F);
            txtSoDienThoai.Location = new Point(520, 20);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(170, 30);
            txtSoDienThoai.TabIndex = 3;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Microsoft Sans Serif", 13F);
            lblSoDienThoai.Location = new Point(366, 20);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(140, 26);
            lblSoDienThoai.TabIndex = 2;
            lblSoDienThoai.Text = "Số điện thoại";
            // 
            // txtCccd
            // 
            txtCccd.Font = new Font("Microsoft Sans Serif", 12F);
            txtCccd.Location = new Point(520, 80);
            txtCccd.Name = "txtCccd";
            txtCccd.Size = new Size(170, 30);
            txtCccd.TabIndex = 7;
            // 
            // lblCccd
            // 
            lblCccd.AutoSize = true;
            lblCccd.Font = new Font("Microsoft Sans Serif", 13F);
            lblCccd.Location = new Point(447, 80);
            lblCccd.Name = "lblCccd";
            lblCccd.Size = new Size(47, 26);
            lblCccd.TabIndex = 6;
            lblCccd.Text = "CCCD";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Font = new Font("Microsoft Sans Serif", 12F);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(520, 140);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(170, 30);
            dtpNgaySinh.TabIndex = 11;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Microsoft Sans Serif", 13F);
            lblNgaySinh.Location = new Point(409, 140);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(99, 26);
            lblNgaySinh.TabIndex = 10;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGioiTinh.Font = new Font("Microsoft Sans Serif", 12F);
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Location = new Point(520, 200);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(170, 28);
            cbGioiTinh.TabIndex = 15;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Microsoft Sans Serif", 13F);
            lblGioiTinh.Location = new Point(425, 200);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(83, 26);
            lblGioiTinh.TabIndex = 14;
            lblGioiTinh.Text = "Giới tính";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F);
            txtEmail.Location = new Point(520, 260);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(170, 30);
            txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 13F);
            lblEmail.Location = new Point(453, 260);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(55, 26);
            lblEmail.TabIndex = 18;
            lblEmail.Text = "Email";
            // 
            // FormThemNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 540);
            Controls.Add(lblTieuDe);
            Controls.Add(btnThoat);
            Controls.Add(btnThemMoi);
            Controls.Add(panel1);
            Name = "FormThemNhanVien";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm mới nhân viên";
            Load += FormThemNhanVien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
