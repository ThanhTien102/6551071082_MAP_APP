
namespace LAB1
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTenKhachSan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTenNguoiDung;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnSoDoPhong;
        private System.Windows.Forms.Button btnQuanLyPhong;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            labelTenKhachSan = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lblTenNguoiDung = new Label();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            panelMain = new Panel();
            panel4 = new Panel();
            button13 = new Button();
            btnTrangChu = new Button();
            button5 = new Button();
            button4 = new Button();
            button7 = new Button();
            button6 = new Button();
            btnQuanLyPhong = new Button();
            button12 = new Button();
            button11 = new Button();
            btnSoDoPhong = new Button();
            button9 = new Button();
            button10 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(labelTenKhachSan);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1498, 92);
            panel1.TabIndex = 0;
            // 
            // labelTenKhachSan
            // 
            labelTenKhachSan.AutoSize = true;
            labelTenKhachSan.BackColor = Color.Transparent;
            labelTenKhachSan.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            labelTenKhachSan.ForeColor = Color.LightSalmon;
            labelTenKhachSan.Location = new Point(66, 19);
            labelTenKhachSan.Name = "labelTenKhachSan";
            labelTenKhachSan.Size = new Size(243, 41);
            labelTenKhachSan.TabIndex = 1;
            labelTenKhachSan.Text = "Hotel Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LAB1.Properties.Resources.Menu;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSeaGreen;
            panel2.Controls.Add(lblTenNguoiDung);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(linkLabel1);
            panel2.Location = new Point(1, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 198);
            panel2.TabIndex = 1;
            // 
            // lblTenNguoiDung
            // 
            lblTenNguoiDung.AutoSize = true;
            lblTenNguoiDung.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            lblTenNguoiDung.Location = new Point(28, 159);
            lblTenNguoiDung.Name = "lblTenNguoiDung";
            lblTenNguoiDung.Size = new Size(76, 26);
            lblTenNguoiDung.TabIndex = 2;
            lblTenNguoiDung.Text = "label1";
            lblTenNguoiDung.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = LAB1.Properties.Resources.user;
            pictureBox2.Location = new Point(101, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 108);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 13F);
            linkLabel1.ForeColor = Color.MidnightBlue;
            linkLabel1.Location = new Point(4, 11);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(111, 26);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng xuất";
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.Honeydew;
            panelMain.Location = new Point(312, 105);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1184, 791);
            panelMain.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.AutoScroll = true;
            panel4.BackColor = Color.DarkCyan;
            panel4.Controls.Add(button13);
            panel4.Controls.Add(btnTrangChu);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(btnQuanLyPhong);
            panel4.Controls.Add(button12);
            panel4.Controls.Add(button11);
            panel4.Controls.Add(btnSoDoPhong);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(button10);
            panel4.Location = new Point(1, 289);
            panel4.Name = "panel4";
            panel4.Size = new Size(304, 607);
            panel4.TabIndex = 4;
            // 
            // button13
            // 
            button13.BackColor = Color.DarkCyan;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Microsoft Sans Serif", 13F);
            button13.ForeColor = SystemColors.ButtonHighlight;
            button13.Image = LAB1.Properties.Resources.MenuThongKe;
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(0, 556);
            button13.Name = "button13";
            button13.Size = new Size(285, 45);
            button13.TabIndex = 11;
            button13.Text = "Thống kê";
            button13.UseVisualStyleBackColor = false;
            // 
            // btnTrangChu
            // 
            btnTrangChu.BackColor = Color.DarkCyan;
            btnTrangChu.FlatAppearance.BorderSize = 0;
            btnTrangChu.FlatStyle = FlatStyle.Flat;
            btnTrangChu.Font = new Font("Microsoft Sans Serif", 13F);
            btnTrangChu.ForeColor = SystemColors.ButtonHighlight;
            btnTrangChu.Image = LAB1.Properties.Resources.MenuTrangChu;
            btnTrangChu.ImageAlign = ContentAlignment.MiddleLeft;
            btnTrangChu.Location = new Point(0, 0);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(285, 51);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang chủ";
            btnTrangChu.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkCyan;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 13F);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Image = LAB1.Properties.Resources.MenuQuanLyTaiKhoan;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 506);
            button5.Name = "button5";
            button5.Size = new Size(285, 45);
            button5.TabIndex = 10;
            button5.Text = "Danh sách tài khoản";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkCyan;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 13F);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Image = LAB1.Properties.Resources.MenuLoaiPhong;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 156);
            button4.Name = "button4";
            button4.Size = new Size(285, 45);
            button4.TabIndex = 3;
            button4.Text = "Loại phòng";
            button4.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkCyan;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft Sans Serif", 13F);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Image = LAB1.Properties.Resources.MenuQuanLyNhanVien;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 456);
            button7.Name = "button7";
            button7.Size = new Size(285, 45);
            button7.TabIndex = 9;
            button7.Text = "Danh sách nhân viên";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkCyan;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 13F);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Image = LAB1.Properties.Resources.MenuQuanLyKhachHang;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 406);
            button6.Name = "button6";
            button6.Size = new Size(285, 45);
            button6.TabIndex = 8;
            button6.Text = "Danh sách khách hàng";
            button6.UseVisualStyleBackColor = false;
            // 
            // btnQuanLyPhong
            // 
            btnQuanLyPhong.BackColor = Color.DarkCyan;
            btnQuanLyPhong.FlatAppearance.BorderSize = 0;
            btnQuanLyPhong.FlatStyle = FlatStyle.Flat;
            btnQuanLyPhong.Font = new Font("Microsoft Sans Serif", 13F);
            btnQuanLyPhong.ForeColor = SystemColors.ButtonHighlight;
            btnQuanLyPhong.Image = LAB1.Properties.Resources.MenuPhong;
            btnQuanLyPhong.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuanLyPhong.Location = new Point(0, 106);
            btnQuanLyPhong.Name = "btnQuanLyPhong";
            btnQuanLyPhong.Size = new Size(285, 45);
            btnQuanLyPhong.TabIndex = 2;
            btnQuanLyPhong.Text = "Phòng";
            btnQuanLyPhong.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.DarkCyan;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Microsoft Sans Serif", 13F);
            button12.ForeColor = SystemColors.ButtonHighlight;
            button12.Image = LAB1.Properties.Resources.MenuTienNghi;
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(0, 356);
            button12.Name = "button12";
            button12.Size = new Size(285, 45);
            button12.TabIndex = 7;
            button12.Text = "Danh sách tiện nghi";
            button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.DarkCyan;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Microsoft Sans Serif", 13F);
            button11.ForeColor = SystemColors.ButtonHighlight;
            button11.Image = LAB1.Properties.Resources.MenuQuanLyDichVu;
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(0, 306);
            button11.Name = "button11";
            button11.Size = new Size(285, 45);
            button11.TabIndex = 6;
            button11.Text = "Danh sách dịch vụ";
            button11.UseVisualStyleBackColor = false;
            // 
            // btnSoDoPhong
            // 
            btnSoDoPhong.AllowDrop = true;
            btnSoDoPhong.BackColor = Color.DarkCyan;
            btnSoDoPhong.FlatAppearance.BorderSize = 0;
            btnSoDoPhong.FlatStyle = FlatStyle.Flat;
            btnSoDoPhong.Font = new Font("Microsoft Sans Serif", 13F);
            btnSoDoPhong.ForeColor = SystemColors.ButtonHighlight;
            btnSoDoPhong.Image = LAB1.Properties.Resources.MenuSoDoPhong;
            btnSoDoPhong.ImageAlign = ContentAlignment.MiddleLeft;
            btnSoDoPhong.Location = new Point(0, 56);
            btnSoDoPhong.Name = "btnSoDoPhong";
            btnSoDoPhong.Size = new Size(285, 45);
            btnSoDoPhong.TabIndex = 1;
            btnSoDoPhong.Text = "Sơ đồ phòng";
            btnSoDoPhong.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkCyan;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Microsoft Sans Serif", 13F);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Image = LAB1.Properties.Resources.MenuDatPhong;
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(0, 206);
            button9.Name = "button9";
            button9.Size = new Size(285, 45);
            button9.TabIndex = 4;
            button9.Text = "Danh sách đặt phòng";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.DarkCyan;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Microsoft Sans Serif", 13F);
            button10.ForeColor = SystemColors.ButtonHighlight;
            button10.Image = LAB1.Properties.Resources.MenuDanhSachHoaDon;
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(0, 256);
            button10.Name = "button10";
            button10.Size = new Size(285, 45);
            button10.TabIndex = 5;
            button10.Text = "Danh sách hóa đơn";
            button10.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1500, 900);
            Controls.Add(panel4);
            Controls.Add(panelMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1200, 700);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trang chủ - Hotel Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
