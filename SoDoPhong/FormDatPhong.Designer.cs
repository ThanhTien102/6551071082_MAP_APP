
namespace LAB1.SoDoPhong
{
    partial class FormDatPhong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panelKhachHang;
        private System.Windows.Forms.Label lblTieuDeKhachHang;
        private System.Windows.Forms.Label lblHoVaTen;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label lblCccd;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblQuocTich;
        private System.Windows.Forms.TextBox txtQuocTich;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Panel panelPhong;
        private System.Windows.Forms.Label lblTieuDePhong;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Label lblGioDen;
        private System.Windows.Forms.ComboBox cbGioDen;
        private System.Windows.Forms.ComboBox cbDangGioDen;
        private System.Windows.Forms.Label lblGioDi;
        private System.Windows.Forms.ComboBox cbGioDi;
        private System.Windows.Forms.ComboBox cbDangGioDi;
        private System.Windows.Forms.Label lblPhongTrong;
        private System.Windows.Forms.DataGridView dtgDanhSachPhongTrong;
        private System.Windows.Forms.Label lblPhongDaChon;
        private System.Windows.Forms.DataGridView dtgDanhSachPhongDaChon;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnHuy;

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
            panelKhachHang = new Panel();
            cbGioiTinh = new ComboBox();
            lblGioiTinh = new Label();
            txtQuocTich = new TextBox();
            lblQuocTich = new Label();
            txtSoDienThoai = new TextBox();
            lblSoDienThoai = new Label();
            txtCCCD = new TextBox();
            lblCccd = new Label();
            txtHoVaTen = new TextBox();
            lblHoVaTen = new Label();
            lblTieuDeKhachHang = new Label();
            panelPhong = new Panel();
            dtgDanhSachPhongDaChon = new DataGridView();
            dtgDanhSachPhongTrong = new DataGridView();
            lblPhongDaChon = new Label();
            lblPhongTrong = new Label();
            cbDangGioDi = new ComboBox();
            cbGioDi = new ComboBox();
            cbDangGioDen = new ComboBox();
            cbGioDen = new ComboBox();
            lblGioDi = new Label();
            lblGioDen = new Label();
            dtpNgayKT = new DateTimePicker();
            dtpNgayBD = new DateTimePicker();
            lblNgayKetThuc = new Label();
            lblNgayBatDau = new Label();
            lblTieuDePhong = new Label();
            btnDatPhong = new Button();
            btnHuy = new Button();
            panelKhachHang.SuspendLayout();
            panelPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhongDaChon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhongTrong).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 17F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(192, 0, 192);
            lblTieuDe.Location = new Point(0, 14);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(1200, 32);
            lblTieuDe.TabIndex = 0;
            lblTieuDe.Text = "ĐẶT PHÒNG";
            lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelKhachHang
            // 
            panelKhachHang.Controls.Add(cbGioiTinh);
            panelKhachHang.Controls.Add(lblGioiTinh);
            panelKhachHang.Controls.Add(txtQuocTich);
            panelKhachHang.Controls.Add(lblQuocTich);
            panelKhachHang.Controls.Add(txtSoDienThoai);
            panelKhachHang.Controls.Add(lblSoDienThoai);
            panelKhachHang.Controls.Add(txtCCCD);
            panelKhachHang.Controls.Add(lblCccd);
            panelKhachHang.Controls.Add(txtHoVaTen);
            panelKhachHang.Controls.Add(lblHoVaTen);
            panelKhachHang.Controls.Add(lblTieuDeKhachHang);
            panelKhachHang.Location = new Point(12, 55);
            panelKhachHang.Name = "panelKhachHang";
            panelKhachHang.Size = new Size(460, 525);
            panelKhachHang.TabIndex = 1;
            // 
            // lblTieuDeKhachHang
            // 
            lblTieuDeKhachHang.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblTieuDeKhachHang.ForeColor = Color.FromArgb(192, 0, 0);
            lblTieuDeKhachHang.Location = new Point(0, 12);
            lblTieuDeKhachHang.Name = "lblTieuDeKhachHang";
            lblTieuDeKhachHang.Size = new Size(460, 29);
            lblTieuDeKhachHang.TabIndex = 0;
            lblTieuDeKhachHang.Text = "Thông tin khách hàng";
            lblTieuDeKhachHang.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.AutoSize = true;
            lblHoVaTen.Font = new Font("Microsoft Sans Serif", 13F);
            lblHoVaTen.Location = new Point(4, 78);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(177, 26);
            lblHoVaTen.TabIndex = 1;
            lblHoVaTen.Text = "Họ và tên";
            lblHoVaTen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Font = new Font("Microsoft Sans Serif", 12F);
            txtHoVaTen.Location = new Point(205, 75);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(235, 30);
            txtHoVaTen.TabIndex = 2;
            // 
            // lblCccd
            // 
            lblCccd.AutoSize = true;
            lblCccd.Font = new Font("Microsoft Sans Serif", 13F);
            lblCccd.Location = new Point(4, 128);
            lblCccd.Name = "lblCccd";
            lblCccd.Size = new Size(177, 26);
            lblCccd.TabIndex = 3;
            lblCccd.Text = "Số CCCD/Passport";
            lblCccd.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCCCD
            // 
            txtCCCD.Font = new Font("Microsoft Sans Serif", 12F);
            txtCCCD.Location = new Point(205, 125);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(235, 30);
            txtCCCD.TabIndex = 4;
            txtCCCD.TextChanged += txtCCCD_TextChanged;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.AutoSize = true;
            lblSoDienThoai.Font = new Font("Microsoft Sans Serif", 13F);
            lblSoDienThoai.Location = new Point(4, 178);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(177, 26);
            lblSoDienThoai.TabIndex = 5;
            lblSoDienThoai.Text = "Số điện thoại";
            lblSoDienThoai.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Microsoft Sans Serif", 12F);
            txtSoDienThoai.Location = new Point(205, 175);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(235, 30);
            txtSoDienThoai.TabIndex = 6;
            txtSoDienThoai.KeyPress += txtSoDienThoai_KeyPress;
            // 
            // lblQuocTich
            // 
            lblQuocTich.AutoSize = true;
            lblQuocTich.Font = new Font("Microsoft Sans Serif", 13F);
            lblQuocTich.Location = new Point(4, 228);
            lblQuocTich.Name = "lblQuocTich";
            lblQuocTich.Size = new Size(177, 26);
            lblQuocTich.TabIndex = 7;
            lblQuocTich.Text = "Quốc tịch";
            lblQuocTich.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtQuocTich
            // 
            txtQuocTich.Font = new Font("Microsoft Sans Serif", 12F);
            txtQuocTich.Location = new Point(205, 225);
            txtQuocTich.Name = "txtQuocTich";
            txtQuocTich.Size = new Size(235, 30);
            txtQuocTich.TabIndex = 8;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Microsoft Sans Serif", 13F);
            lblGioiTinh.Location = new Point(4, 278);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(177, 26);
            lblGioiTinh.TabIndex = 9;
            lblGioiTinh.Text = "Giới tính";
            lblGioiTinh.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbGioiTinh
            // 
            cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGioiTinh.Font = new Font("Microsoft Sans Serif", 12F);
            cbGioiTinh.FormattingEnabled = true;
            cbGioiTinh.Location = new Point(205, 275);
            cbGioiTinh.Name = "cbGioiTinh";
            cbGioiTinh.Size = new Size(235, 33);
            cbGioiTinh.TabIndex = 10;
            // 
            // panelPhong
            // 
            panelPhong.Controls.Add(dtgDanhSachPhongDaChon);
            panelPhong.Controls.Add(dtgDanhSachPhongTrong);
            panelPhong.Controls.Add(lblPhongDaChon);
            panelPhong.Controls.Add(lblPhongTrong);
            panelPhong.Controls.Add(cbDangGioDi);
            panelPhong.Controls.Add(cbGioDi);
            panelPhong.Controls.Add(cbDangGioDen);
            panelPhong.Controls.Add(cbGioDen);
            panelPhong.Controls.Add(lblGioDi);
            panelPhong.Controls.Add(lblGioDen);
            panelPhong.Controls.Add(dtpNgayKT);
            panelPhong.Controls.Add(dtpNgayBD);
            panelPhong.Controls.Add(lblNgayKetThuc);
            panelPhong.Controls.Add(lblNgayBatDau);
            panelPhong.Controls.Add(lblTieuDePhong);
            panelPhong.Location = new Point(476, 55);
            panelPhong.Name = "panelPhong";
            panelPhong.Size = new Size(712, 525);
            panelPhong.TabIndex = 2;
            // 
            // lblTieuDePhong
            // 
            lblTieuDePhong.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblTieuDePhong.ForeColor = Color.FromArgb(192, 0, 0);
            lblTieuDePhong.Location = new Point(0, 12);
            lblTieuDePhong.Name = "lblTieuDePhong";
            lblTieuDePhong.Size = new Size(712, 29);
            lblTieuDePhong.TabIndex = 0;
            lblTieuDePhong.Text = "Thông tin phòng";
            lblTieuDePhong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNgayBatDau
            // 
            lblNgayBatDau.Font = new Font("Microsoft Sans Serif", 12F);
            lblNgayBatDau.Location = new Point(28, 78);
            lblNgayBatDau.Name = "lblNgayBatDau";
            lblNgayBatDau.Size = new Size(110, 26);
            lblNgayBatDau.TabIndex = 1;
            lblNgayBatDau.Text = "Ngày bắt đầu";
            lblNgayBatDau.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpNgayBD
            // 
            dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            dtpNgayBD.Font = new Font("Microsoft Sans Serif", 12F);
            dtpNgayBD.Format = DateTimePickerFormat.Custom;
            dtpNgayBD.Location = new Point(145, 74);
            dtpNgayBD.Name = "dtpNgayBD";
            dtpNgayBD.Size = new Size(250, 30);
            dtpNgayBD.TabIndex = 2;
            dtpNgayBD.ValueChanged += dtpNgayBD_ValueChanged;
            // 
            // lblNgayKetThuc
            // 
            lblNgayKetThuc.Font = new Font("Microsoft Sans Serif", 12F);
            lblNgayKetThuc.Location = new Point(28, 124);
            lblNgayKetThuc.Name = "lblNgayKetThuc";
            lblNgayKetThuc.Size = new Size(110, 26);
            lblNgayKetThuc.TabIndex = 3;
            lblNgayKetThuc.Text = "Ngày kết thúc";
            lblNgayKetThuc.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpNgayKT
            // 
            dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            dtpNgayKT.Font = new Font("Microsoft Sans Serif", 12F);
            dtpNgayKT.Format = DateTimePickerFormat.Custom;
            dtpNgayKT.Location = new Point(145, 120);
            dtpNgayKT.Name = "dtpNgayKT";
            dtpNgayKT.Size = new Size(250, 30);
            dtpNgayKT.TabIndex = 4;
            dtpNgayKT.ValueChanged += ThayDoiThoiGian;
            // 
            // lblGioDen
            // 
            lblGioDen.Font = new Font("Microsoft Sans Serif", 12F);
            lblGioDen.Location = new Point(420, 80);
            lblGioDen.Name = "lblGioDen";
            lblGioDen.Size = new Size(62, 26);
            lblGioDen.TabIndex = 5;
            lblGioDen.Text = "Giờ đến";
            lblGioDen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbGioDen
            // 
            cbGioDen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGioDen.Font = new Font("Microsoft Sans Serif", 12F);
            cbGioDen.FormattingEnabled = true;
            cbGioDen.Location = new Point(490, 76);
            cbGioDen.Name = "cbGioDen";
            cbGioDen.Size = new Size(90, 33);
            cbGioDen.TabIndex = 6;
            cbGioDen.SelectedIndexChanged += ThayDoiThoiGian;
            // 
            // cbDangGioDen
            // 
            cbDangGioDen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDangGioDen.Font = new Font("Microsoft Sans Serif", 12F);
            cbDangGioDen.FormattingEnabled = true;
            cbDangGioDen.Items.AddRange(new object[] { "AM", "PM" });
            cbDangGioDen.Location = new Point(590, 76);
            cbDangGioDen.Name = "cbDangGioDen";
            cbDangGioDen.Size = new Size(60, 33);
            cbDangGioDen.TabIndex = 7;
            cbDangGioDen.SelectedIndexChanged += ThayDoiThoiGian;
            // 
            // lblGioDi
            // 
            lblGioDi.Font = new Font("Microsoft Sans Serif", 12F);
            lblGioDi.Location = new Point(420, 126);
            lblGioDi.Name = "lblGioDi";
            lblGioDi.Size = new Size(62, 26);
            lblGioDi.TabIndex = 8;
            lblGioDi.Text = "Giờ đi";
            lblGioDi.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbGioDi
            // 
            cbGioDi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGioDi.Font = new Font("Microsoft Sans Serif", 12F);
            cbGioDi.FormattingEnabled = true;
            cbGioDi.Location = new Point(490, 122);
            cbGioDi.Name = "cbGioDi";
            cbGioDi.Size = new Size(90, 33);
            cbGioDi.TabIndex = 9;
            cbGioDi.SelectedIndexChanged += ThayDoiThoiGian;
            // 
            // cbDangGioDi
            // 
            cbDangGioDi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDangGioDi.Font = new Font("Microsoft Sans Serif", 12F);
            cbDangGioDi.FormattingEnabled = true;
            cbDangGioDi.Items.AddRange(new object[] { "AM", "PM" });
            cbDangGioDi.Location = new Point(590, 122);
            cbDangGioDi.Name = "cbDangGioDi";
            cbDangGioDi.Size = new Size(60, 33);
            cbDangGioDi.TabIndex = 10;
            cbDangGioDi.SelectedIndexChanged += ThayDoiThoiGian;
            // 
            // lblPhongTrong
            // 
            lblPhongTrong.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblPhongTrong.ForeColor = Color.Green;
            lblPhongTrong.Location = new Point(12, 175);
            lblPhongTrong.Name = "lblPhongTrong";
            lblPhongTrong.Size = new Size(290, 27);
            lblPhongTrong.TabIndex = 11;
            lblPhongTrong.Text = "Danh sách phòng trống";
            lblPhongTrong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtgDanhSachPhongTrong
            // 
            dtgDanhSachPhongTrong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachPhongTrong.Location = new Point(12, 208);
            dtgDanhSachPhongTrong.Name = "dtgDanhSachPhongTrong";
            dtgDanhSachPhongTrong.RowHeadersWidth = 51;
            dtgDanhSachPhongTrong.Size = new Size(290, 300);
            dtgDanhSachPhongTrong.TabIndex = 12;
            dtgDanhSachPhongTrong.CellClick += dtgDanhSachPhongTrong_CellClick;
            // 
            // lblPhongDaChon
            // 
            lblPhongDaChon.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblPhongDaChon.ForeColor = Color.Green;
            lblPhongDaChon.Location = new Point(312, 175);
            lblPhongDaChon.Name = "lblPhongDaChon";
            lblPhongDaChon.Size = new Size(388, 27);
            lblPhongDaChon.TabIndex = 13;
            lblPhongDaChon.Text = "Danh sách phòng đã chọn";
            lblPhongDaChon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtgDanhSachPhongDaChon
            // 
            dtgDanhSachPhongDaChon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachPhongDaChon.Location = new Point(312, 208);
            dtgDanhSachPhongDaChon.Name = "dtgDanhSachPhongDaChon";
            dtgDanhSachPhongDaChon.RowHeadersWidth = 51;
            dtgDanhSachPhongDaChon.Size = new Size(388, 300);
            dtgDanhSachPhongDaChon.TabIndex = 14;
            dtgDanhSachPhongDaChon.CellClick += dtgDanhSachPhongDaChon_CellClick;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = SystemColors.ActiveCaption;
            btnDatPhong.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            btnDatPhong.ForeColor = Color.ForestGreen;
            btnDatPhong.Location = new Point(846, 596);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(160, 48);
            btnDatPhong.TabIndex = 3;
            btnDatPhong.Text = "Đặt trước";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // btnHuy
            // 
            btnHuy.Font = new Font("Microsoft Sans Serif", 13F);
            btnHuy.Location = new Point(1022, 596);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(160, 48);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormDatPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnHuy;
            ClientSize = new Size(1200, 660);
            Controls.Add(btnHuy);
            Controls.Add(btnDatPhong);
            Controls.Add(panelPhong);
            Controls.Add(panelKhachHang);
            Controls.Add(lblTieuDe);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDatPhong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Đặt phòng trước";
            Load += FormDatPhong_Load;
            panelKhachHang.ResumeLayout(false);
            panelKhachHang.PerformLayout();
            panelPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhongDaChon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhongTrong).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}
