
namespace LAB1.ChiTietTienNghi
{
    partial class FormDanhSachChiTietTienNghi
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dtgDanhSachTienNghiTheoLoaiPhong;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblTenLoaiPhong;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnThoat;

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
            dtgDanhSachTienNghiTheoLoaiPhong = new DataGridView();
            lblTieuDe = new Label();
            lblTenLoaiPhong = new Label();
            btnThemMoi = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachTienNghiTheoLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // dtgDanhSachTienNghiTheoLoaiPhong
            // 
            dtgDanhSachTienNghiTheoLoaiPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDanhSachTienNghiTheoLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachTienNghiTheoLoaiPhong.Location = new Point(12, 110);
            dtgDanhSachTienNghiTheoLoaiPhong.Name = "dtgDanhSachTienNghiTheoLoaiPhong";
            dtgDanhSachTienNghiTheoLoaiPhong.RowHeadersWidth = 51;
            dtgDanhSachTienNghiTheoLoaiPhong.Size = new Size(776, 470);
            dtgDanhSachTienNghiTheoLoaiPhong.TabIndex = 0;
            dtgDanhSachTienNghiTheoLoaiPhong.CellClick += dtgDanhSachTienNghiTheoLoaiPhong_CellClick;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.Red;
            lblTieuDe.Location = new Point(150, 20);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(500, 31);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "DANH SÁCH TIỆN NGHI HIỆN CÓ";
            // 
            // lblTenLoaiPhong
            // 
            lblTenLoaiPhong.AutoSize = true;
            lblTenLoaiPhong.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            lblTenLoaiPhong.ForeColor = Color.Blue;
            lblTenLoaiPhong.Location = new Point(12, 68);
            lblTenLoaiPhong.Name = "lblTenLoaiPhong";
            lblTenLoaiPhong.Size = new Size(194, 29);
            lblTenLoaiPhong.TabIndex = 2;
            lblTenLoaiPhong.Text = "Tên loại phòng";
            // 
            // btnThemMoi
            // 
            btnThemMoi.Anchor = AnchorStyles.Bottom;
            btnThemMoi.BackColor = Color.Moccasin;
            btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F);
            btnThemMoi.Location = new Point(227, 592);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(137, 52);
            btnThemMoi.TabIndex = 16;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Bottom;
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Location = new Point(435, 592);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 52);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormDanhSachChiTietTienNghi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 656);
            Controls.Add(btnThoat);
            Controls.Add(btnThemMoi);
            Controls.Add(lblTenLoaiPhong);
            Controls.Add(lblTieuDe);
            Controls.Add(dtgDanhSachTienNghiTheoLoaiPhong);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormDanhSachChiTietTienNghi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý các tiện nghi theo loại phòng";
            Load += FormDanhSachChiTietTienNghi_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachTienNghiTheoLoaiPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
