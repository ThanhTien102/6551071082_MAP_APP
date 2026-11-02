
namespace LAB1.KhachHang
{
    partial class FormThemKhachHang
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtCccd;
        private System.Windows.Forms.Label lblCccd;
        private System.Windows.Forms.ComboBox cbQuocTich;
        private System.Windows.Forms.Label lblQuocTich;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label lblGioiTinh;

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
            txtMaKhachHang = new TextBox();
            lblMaKhachHang = new Label();
            txtTenKhachHang = new TextBox();
            lblTenKhachHang = new Label();
            txtSoDienThoai = new TextBox();
            lblSoDienThoai = new Label();
            txtCccd = new TextBox();
            lblCccd = new Label();
            cbQuocTich = new ComboBox();
            lblQuocTich = new Label();
            cbGioiTinh = new ComboBox();
            lblGioiTinh = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(192, 64, 0);
            lblTieuDe.Location = new Point(64, 31);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(420, 31);
            lblTieuDe.TabIndex = 18;
            lblTieuDe.Text = "Thêm mới thông tin khách hàng";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Location = new Point(297, 540);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.Moccasin;
            btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F);
            btnThemMoi.Location = new Point(97, 540);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(137, 59);
            btnThemMoi.TabIndex = 16;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMaKhachHang);
            panel1.Controls.Add(lblMaKhachHang);
            panel1.Controls.Add(txtTenKhachHang);
            panel1.Controls.Add(lblTenKhachHang);
            panel1.Controls.Add(txtSoDienThoai);
            panel1.Controls.Add(lblSoDienThoai);
            panel1.Controls.Add(txtCccd);
            panel1.Controls.Add(lblCccd);
            panel1.Controls.Add(cbQuocTich);
            panel1.Controls.Add(lblQuocTich);
            panel1.Controls.Add(cbGioiTinh);
            panel1.Controls.Add(lblGioiTinh);
            panel1.Location = new Point(21, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 420);
            panel1.TabIndex = 15;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaKhachHang.Location = new Point(198, 29);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(275, 30);
            txtMaKhachHang.TabIndex = 1;
            // 
            // lblMaKhachHang
            // 
            lblMaKhachHang.AutoSize = true;
            lblMaKhachHang.Font = new Font("Microsoft Sans Serif", 13F);
            lblMaKhachHang.Location = new Point(39, 29);
            lblMaKhachHang.Name = "lblMaKhachHang";
            lblMaKhachHang.Size = new Size(151, 26);
            lblMaKhachHang.TabIndex = 0;
            lblMaKhachHang.Text = "Mã khách hàng";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenKhachHang.Location = new Point(198, 94);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(275, 30);
            txtTenKhachHang.TabIndex = 3;
            // 
            // lblTenKhachHang
            // 
            lblTenKhachHang.AutoSize = true;
            lblTenKhachHang.Font = new Font("Microsoft Sans Serif", 13F);
            lblTenKhachHang.Location = new Point(32, 94);
            lblTenKhachHang.Name = "lblTenKhachHang";
            lblTenKhachHang.Size = new Size(158, 26);
            lblTenKhachHang.TabIndex = 2;
            lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 12F);
            txtSoDienThoai.Location = new Point(198, 159);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(275, 30);
            txtSoDienThoai.TabIndex = 5;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Microsoft Sans Serif", 13F);
            lblSoDienThoai.Location = new Point(36, 159);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(147, 26);
            lblSoDienThoai.TabIndex = 4;
            lblSoDienThoai.Text = "Số điện thoại";
            // 
            // txtCccd
            // 
            txtCccd.Font = new Font("Microsoft Sans Serif", 12F);
            txtCccd.Location = new Point(198, 224);
            txtCccd.Name = "txtCccd";
            txtCccd.Size = new Size(275, 30);
            txtCccd.TabIndex = 7;
            // 
            // lblCccd
            // 
            lblCccd.AutoSize = true;
            lblCccd.Font = new Font("Microsoft Sans Serif", 13F);
            lblCccd.Location = new Point(24, 224);
            lblCccd.Name = "lblCccd";
            lblCccd.Size = new Size(128, 26);
            lblCccd.TabIndex = 6;
            lblCccd.Text = "CCCD/Passport";
            // 
            // cbQuocTich
            // 
            cbQuocTich.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQuocTich.Font = new Font("Microsoft Sans Serif", 12F);
            cbQuocTich.FormattingEnabled = true;
            cbQuocTich.Location = new Point(198, 289);
            cbQuocTich.Name = "cbQuocTich";
            cbQuocTich.Size = new Size(275, 28);
            cbQuocTich.TabIndex = 9;
            // 
            // lblQuocTich
            // 
            lblQuocTich.AutoSize = true;
            lblQuocTich.Font = new Font("Microsoft Sans Serif", 13F);
            lblQuocTich.Location = new Point(85, 289);
            lblQuocTich.Name = "lblQuocTich";
            lblQuocTich.Size = new Size(101, 26);
            lblQuocTich.TabIndex = 8;
            lblQuocTich.Text = "Quốc tịch";
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGioiTinh.Font = new Font("Microsoft Sans Serif", 12F);
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Location = new Point(198, 354);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(275, 28);
            cbGioiTinh.TabIndex = 11;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Microsoft Sans Serif", 13F);
            lblGioiTinh.Location = new Point(100, 354);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(86, 26);
            lblGioiTinh.TabIndex = 10;
            lblGioiTinh.Text = "Giới tính";
            // 
            // FormThemKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 630);
            Controls.Add(lblTieuDe);
            Controls.Add(btnThoat);
            Controls.Add(btnThemMoi);
            Controls.Add(panel1);
            Name = "FormThemKhachHang";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm mới khách hàng";
            Load += FormThemKhachHang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
