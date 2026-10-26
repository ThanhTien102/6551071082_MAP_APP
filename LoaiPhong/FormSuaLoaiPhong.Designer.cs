
namespace LAB1.LoaiPhong
{
    partial class FormSuaLoaiPhong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Label lblTieuDe;

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
            btnThoat = new Button();
            btnCapNhat = new Button();
            panel1 = new Panel();
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
            lblTieuDe = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Location = new Point(336, 519);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Moccasin;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 12F);
            btnCapNhat.Location = new Point(136, 519);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(137, 59);
            btnCapNhat.TabIndex = 12;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // panel1
            // 
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
            panel1.Location = new Point(48, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 375);
            panel1.TabIndex = 11;
            // 
            // txtGiaGio
            // 
            txtGiaGio.Font = new Font("Microsoft Sans Serif", 12F);
            txtGiaGio.Location = new Point(208, 308);
            txtGiaGio.Name = "txtGiaGio";
            txtGiaGio.Size = new Size(275, 30);
            txtGiaGio.TabIndex = 9;
            // 
            // lblGiaGio
            // 
            lblGiaGio.AutoSize = true;
            lblGiaGio.Font = new Font("Microsoft Sans Serif", 13F);
            lblGiaGio.Location = new Point(112, 312);
            lblGiaGio.Name = "lblGiaGio";
            lblGiaGio.Size = new Size(81, 26);
            lblGiaGio.TabIndex = 8;
            lblGiaGio.Text = "Giá giờ";
            // 
            // txtGiaNgay
            // 
            txtGiaNgay.Font = new Font("Microsoft Sans Serif", 12F);
            txtGiaNgay.Location = new Point(208, 244);
            txtGiaNgay.Name = "txtGiaNgay";
            txtGiaNgay.Size = new Size(275, 30);
            txtGiaNgay.TabIndex = 7;
            // 
            // lblGiaNgay
            // 
            lblGiaNgay.AutoSize = true;
            lblGiaNgay.Font = new Font("Microsoft Sans Serif", 13F);
            lblGiaNgay.Location = new Point(94, 244);
            lblGiaNgay.Name = "lblGiaNgay";
            lblGiaNgay.Size = new Size(99, 26);
            lblGiaNgay.TabIndex = 6;
            lblGiaNgay.Text = "Giá ngày";
            // 
            // txtSoNguoiToiDa
            // 
            txtSoNguoiToiDa.Font = new Font("Microsoft Sans Serif", 12F);
            txtSoNguoiToiDa.Location = new Point(208, 179);
            txtSoNguoiToiDa.Name = "txtSoNguoiToiDa";
            txtSoNguoiToiDa.Size = new Size(275, 30);
            txtSoNguoiToiDa.TabIndex = 5;
            // 
            // lblSoNguoiToiDa
            // 
            lblSoNguoiToiDa.AutoSize = true;
            lblSoNguoiToiDa.Font = new Font("Microsoft Sans Serif", 13F);
            lblSoNguoiToiDa.Location = new Point(39, 179);
            lblSoNguoiToiDa.Name = "lblSoNguoiToiDa";
            lblSoNguoiToiDa.Size = new Size(157, 26);
            lblSoNguoiToiDa.TabIndex = 4;
            lblSoNguoiToiDa.Text = "Số người tối đa";
            // 
            // txtSoGiuong
            // 
            txtSoGiuong.Font = new Font("Microsoft Sans Serif", 12F);
            txtSoGiuong.Location = new Point(208, 110);
            txtSoGiuong.Name = "txtSoGiuong";
            txtSoGiuong.Size = new Size(275, 30);
            txtSoGiuong.TabIndex = 3;
            // 
            // lblSoGiuong
            // 
            lblSoGiuong.AutoSize = true;
            lblSoGiuong.Font = new Font("Microsoft Sans Serif", 13F);
            lblSoGiuong.Location = new Point(81, 110);
            lblSoGiuong.Name = "lblSoGiuong";
            lblSoGiuong.Size = new Size(110, 26);
            lblSoGiuong.TabIndex = 2;
            lblSoGiuong.Text = "Số giường";
            // 
            // txtTenLP
            // 
            txtTenLP.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenLP.Location = new Point(208, 45);
            txtTenLP.Name = "txtTenLP";
            txtTenLP.Size = new Size(275, 30);
            txtTenLP.TabIndex = 1;
            // 
            // lblTenLoaiPhong
            // 
            lblTenLoaiPhong.AutoSize = true;
            lblTenLoaiPhong.Font = new Font("Microsoft Sans Serif", 13F);
            lblTenLoaiPhong.Location = new Point(39, 45);
            lblTenLoaiPhong.Name = "lblTenLoaiPhong";
            lblTenLoaiPhong.Size = new Size(154, 26);
            lblTenLoaiPhong.TabIndex = 0;
            lblTenLoaiPhong.Text = "Tên loại phòng";
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(192, 64, 0);
            lblTieuDe.Location = new Point(113, 49);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(395, 31);
            lblTieuDe.TabIndex = 14;
            lblTieuDe.Text = "Cập nhật thông tin loại phòng";
            // 
            // FormSuaLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 626);
            Controls.Add(lblTieuDe);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(panel1);
            Name = "FormSuaLoaiPhong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cập nhật thông tin loại phòng";
            Load += FormSuaLoaiPhong_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
