namespace LAB1.PhieuThue
{
    partial class FormDanhSachPhieuThue
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.DataGridView dtgDanhSachPhieuThue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            txtTimKiem = new TextBox();
            btnXuatExcel = new Button();
            btnDatPhong = new Button();
            dtgDanhSachPhieuThue = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhieuThue).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(93, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(138, 29);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(250, 32);
            txtTimKiem.TabIndex = 1;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.DarkTurquoise;
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExcel.Location = new Point(746, 29);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(190, 46);
            btnXuatExcel.TabIndex = 2;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.LightPink;
            btnDatPhong.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatPhong.Location = new Point(952, 29);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(180, 46);
            btnDatPhong.TabIndex = 3;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            // 
            // dtgDanhSachPhieuThue
            // 
            dtgDanhSachPhieuThue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachPhieuThue.Location = new Point(13, 118);
            dtgDanhSachPhieuThue.Name = "dtgDanhSachPhieuThue";
            dtgDanhSachPhieuThue.RowHeadersWidth = 51;
            dtgDanhSachPhieuThue.Size = new Size(1187, 624);
            dtgDanhSachPhieuThue.TabIndex = 4;
            // 
            // FormDanhSachPhieuThue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 756);
            Controls.Add(dtgDanhSachPhieuThue);
            Controls.Add(btnDatPhong);
            Controls.Add(btnXuatExcel);
            Controls.Add(txtTimKiem);
            Controls.Add(pictureBox1);
            Name = "FormDanhSachPhieuThue";
            Text = "Danh sách phiếu thuê";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachPhieuThue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
