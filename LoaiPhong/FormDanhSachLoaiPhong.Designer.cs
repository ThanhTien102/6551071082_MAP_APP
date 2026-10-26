
namespace LAB1.LoaiPhong
{
    partial class FormDanhSachLoaiPhong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dtgDanhSachLoaiPhong;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.PictureBox pictureBox1;

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
            dtgDanhSachLoaiPhong = new DataGridView();
            btnXuatExcel = new Button();
            btnThemMoi = new Button();
            txtTimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachLoaiPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgDanhSachLoaiPhong
            // 
            dtgDanhSachLoaiPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDanhSachLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachLoaiPhong.Location = new Point(12, 66);
            dtgDanhSachLoaiPhong.Name = "dtgDanhSachLoaiPhong";
            dtgDanhSachLoaiPhong.RowHeadersWidth = 51;
            dtgDanhSachLoaiPhong.Size = new Size(924, 605);
            dtgDanhSachLoaiPhong.TabIndex = 9;
            dtgDanhSachLoaiPhong.CellClick += dtgDanhSachLoaiPhong_CellClick;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuatExcel.BackColor = Color.DarkTurquoise;
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnXuatExcel.Location = new Point(546, 12);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(167, 37);
            btnXuatExcel.TabIndex = 7;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMoi.BackColor = Color.LightPink;
            btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnThemMoi.Location = new Point(747, 12);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(167, 37);
            btnThemMoi.TabIndex = 10;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 13F);
            txtTimKiem.Location = new Point(105, 17);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(187, 32);
            txtTimKiem.TabIndex = 5;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LAB1.Properties.Resources.search;
            pictureBox1.Location = new Point(60, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormDanhSachLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 683);
            Controls.Add(dtgDanhSachLoaiPhong);
            Controls.Add(btnThemMoi);
            Controls.Add(btnXuatExcel);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Name = "FormDanhSachLoaiPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thông tin loại phòng";
            Load += FormDanhSachLoaiPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachLoaiPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
