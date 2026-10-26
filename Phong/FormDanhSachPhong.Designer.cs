
namespace LAB1.Phong
{
    partial class FormDanhSachPhong
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dtgDanhSachPhong;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnThemMoiPhong;
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
            dtgDanhSachPhong = new DataGridView();
            btnXuatExcel = new Button();
            btnThemMoiPhong = new Button();
            txtTimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgDanhSachPhong
            // 
            dtgDanhSachPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDanhSachPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachPhong.Location = new Point(12, 72);
            dtgDanhSachPhong.Name = "dtgDanhSachPhong";
            dtgDanhSachPhong.RowHeadersWidth = 51;
            dtgDanhSachPhong.Size = new Size(1015, 615);
            dtgDanhSachPhong.TabIndex = 4;
            dtgDanhSachPhong.CellClick += dtgDanhSachPhong_CellClick;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnXuatExcel.BackColor = Color.DarkTurquoise;
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnXuatExcel.Location = new Point(560, 12);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(167, 37);
            btnXuatExcel.TabIndex = 2;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            btnXuatExcel.Click += btnXuatExcel_Click;
            // 
            // btnThemMoiPhong
            // 
            btnThemMoiPhong.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMoiPhong.BackColor = Color.MediumSpringGreen;
            btnThemMoiPhong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnThemMoiPhong.Location = new Point(803, 12);
            btnThemMoiPhong.Name = "btnThemMoiPhong";
            btnThemMoiPhong.Size = new Size(188, 37);
            btnThemMoiPhong.TabIndex = 3;
            btnThemMoiPhong.Text = "Thêm mới phòng";
            btnThemMoiPhong.UseVisualStyleBackColor = false;
            btnThemMoiPhong.Click += btnThemMoiPhong_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 13F);
            txtTimKiem.Location = new Point(130, 12);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(187, 32);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LAB1.Properties.Resources.search;
            pictureBox1.Location = new Point(85, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormDanhSachPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 699);
            Controls.Add(dtgDanhSachPhong);
            Controls.Add(btnThemMoiPhong);
            Controls.Add(btnXuatExcel);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Name = "FormDanhSachPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý thông tin phòng";
            Load += FormDanhSachPhong_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
