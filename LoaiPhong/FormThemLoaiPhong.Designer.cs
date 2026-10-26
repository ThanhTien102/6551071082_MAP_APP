
namespace LAB1.LoaiPhong
{
    partial class FormThemLoaiPhong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaLoaiPhong;
        private System.Windows.Forms.Label lblMaLoaiPhong;
        private System.Windows.Forms.TextBox txtGiaGio;
        private System.Windows.Forms.Label lblGiaGio;
        private System.Windows.Forms.TextBox txtGiaNgay;
        private System.Windows.Forms.Label lblGiaNgay;
        private System.Windows.Forms.TextBox txtSoNguoiToiDa;
        private System.Windows.Forms.Label lblSoNguoiToiDa;
        private System.Windows.Forms.TextBox txtSoGiuong;
        private System.Windows.Forms.Label lblSoGiuong;
        private System.Windows.Forms.TextBox txtTenLP;
        private System.Windows.Forms.Label lblTenLoaiPhong;

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
            txtMaLoaiPhong = new TextBox();
            lblMaLoaiPhong = new Label();
            txtGiaGio = new TextBox();
            lblGiaGio = new Label();
            txtGiaNgay = new TextBox();
            lblGiaNgay = new Label();
            txtSoNguoiToiDa = new TextBox();
            lblSoNguoiToiDa = new Label();
            txtSoGiuong = new TextBox();
            lblSoGiuong = new Label();
            txtTenLP = new TextBox();
            lblTenLoaiPhong = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(192, 64, 0);
            lblTieuDe.Location = new Point(72, 31);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(404, 31);
            lblTieuDe.TabIndex = 18;
            lblTieuDe.Text = "Thêm mới thông tin loại phòng";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Location = new Point(297, 548);
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
            btnThemMoi.Location = new Point(97, 548);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(137, 59);
            btnThemMoi.TabIndex = 16;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMaLoaiPhong);
            panel1.Controls.Add(lblMaLoaiPhong);
            panel1.Controls.Add(txtGiaGio);
            panel1.Controls.Add(lblGiaGio);
            panel1.Controls.Add(txtGiaNgay);
            panel1.Controls.Add(lblGiaNgay);
            panel1.Controls.Add(txtSoNguoiToiDa);
            panel1.Controls.Add(lblSoNguoiToiDa);
            panel1.Controls.Add(txtSoGiuong);
            panel1.Controls.Add(lblSoGiuong);
            panel1.Controls.Add(txtTenLP);
            panel1.Controls.Add(lblTenLoaiPhong);
            panel1.Location = new Point(21, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 439);
            panel1.TabIndex = 15;
            // 
            // txtMaLoaiPhong
            // 
            txtMaLoaiPhong.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaLoaiPhong.Location = new Point(198, 29);
            txtMaLoaiPhong.Name = "txtMaLoaiPhong";
            txtMaLoaiPhong.Size = new Size(275, 30);
            txtMaLoaiPhong.TabIndex = 1;
            // 
            // lblMaLoaiPhong
            // 
            lblMaLoaiPhong.AutoSize = true;
            lblMaLoaiPhong.Font = new Font("Microsoft Sans Serif", 13F);
            lblMaLoaiPhong.Location = new Point(29, 29);
            lblMaLoaiPhong.Name = "lblMaLoaiPhong";
            lblMaLoaiPhong.Size = new Size(148, 26);
            lblMaLoaiPhong.TabIndex = 0;
            lblMaLoaiPhong.Text = "Mã loại phòng";
            // 
            // txtGiaGio
            // 
            txtGiaGio.Font = new Font("Microsoft Sans Serif", 12F);
            txtGiaGio.Location = new Point(198, 358);
            txtGiaGio.Name = "txtGiaGio";
            txtGiaGio.Size = new Size(275, 30);
            txtGiaGio.TabIndex = 11;
            // 
            // lblGiaGio
            // 
            lblGiaGio.AutoSize = true;
            lblGiaGio.Font = new Font("Microsoft Sans Serif", 13F);
            lblGiaGio.Location = new Point(102, 362);
            lblGiaGio.Name = "lblGiaGio";
            lblGiaGio.Size = new Size(81, 26);
            lblGiaGio.TabIndex = 10;
            lblGiaGio.Text = "Giá giờ";
            // 
            // txtGiaNgay
            // 
            txtGiaNgay.Font = new Font("Microsoft Sans Serif", 12F);
            txtGiaNgay.Location = new Point(198, 294);
            txtGiaNgay.Name = "txtGiaNgay";
            txtGiaNgay.Size = new Size(275, 30);
            txtGiaNgay.TabIndex = 9;
            // 
            // lblGiaNgay
            // 
            lblGiaNgay.AutoSize = true;
            lblGiaNgay.Font = new Font("Microsoft Sans Serif", 13F);
            lblGiaNgay.Location = new Point(84, 294);
            lblGiaNgay.Name = "lblGiaNgay";
            lblGiaNgay.Size = new Size(99, 26);
            lblGiaNgay.TabIndex = 8;
            lblGiaNgay.Text = "Giá ngày";
            // 
            // txtSoNguoiToiDa
            // 
            txtSoNguoiToiDa.Font = new Font("Microsoft Sans Serif", 12F);
            txtSoNguoiToiDa.Location = new Point(198, 229);
            txtSoNguoiToiDa.Name = "txtSoNguoiToiDa";
            txtSoNguoiToiDa.Size = new Size(275, 30);
            txtSoNguoiToiDa.TabIndex = 7;
            // 
            // lblSoNguoiToiDa
            // 
            lblSoNguoiToiDa.AutoSize = true;
            lblSoNguoiToiDa.Font = new Font("Microsoft Sans Serif", 13F);
            lblSoNguoiToiDa.Location = new Point(29, 229);
            lblSoNguoiToiDa.Name = "lblSoNguoiToiDa";
            lblSoNguoiToiDa.Size = new Size(157, 26);
            lblSoNguoiToiDa.TabIndex = 6;
            lblSoNguoiToiDa.Text = "Số người tối đa";
            // 
            // txtSoGiuong
            // 
            txtSoGiuong.Font = new Font("Microsoft Sans Serif", 12F);
            txtSoGiuong.Location = new Point(198, 160);
            txtSoGiuong.Name = "txtSoGiuong";
            txtSoGiuong.Size = new Size(275, 30);
            txtSoGiuong.TabIndex = 5;
            // 
            // lblSoGiuong
            // 
            lblSoGiuong.AutoSize = true;
            lblSoGiuong.Font = new Font("Microsoft Sans Serif", 13F);
            lblSoGiuong.Location = new Point(71, 160);
            lblSoGiuong.Name = "lblSoGiuong";
            lblSoGiuong.Size = new Size(110, 26);
            lblSoGiuong.TabIndex = 4;
            lblSoGiuong.Text = "Số giường";
            // 
            // txtTenLP
            // 
            txtTenLP.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenLP.Location = new Point(198, 95);
            txtTenLP.Name = "txtTenLP";
            txtTenLP.Size = new Size(275, 30);
            txtTenLP.TabIndex = 3;
            // 
            // lblTenLoaiPhong
            // 
            lblTenLoaiPhong.AutoSize = true;
            lblTenLoaiPhong.Font = new Font("Microsoft Sans Serif", 13F);
            lblTenLoaiPhong.Location = new Point(29, 95);
            lblTenLoaiPhong.Name = "lblTenLoaiPhong";
            lblTenLoaiPhong.Size = new Size(154, 26);
            lblTenLoaiPhong.TabIndex = 2;
            lblTenLoaiPhong.Text = "Tên loại phòng";
            // 
            // FormThemLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 639);
            Controls.Add(lblTieuDe);
            Controls.Add(btnThoat);
            Controls.Add(btnThemMoi);
            Controls.Add(panel1);
            Name = "FormThemLoaiPhong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm mới loại phòng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
