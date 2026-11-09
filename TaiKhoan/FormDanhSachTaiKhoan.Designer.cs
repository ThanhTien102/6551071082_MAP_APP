namespace LAB1.TaiKhoan
{
    partial class FormDanhSachTaiKhoan
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.DataGridView dtgDanhSachTaiKhoan;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimKiem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnThemMoi = new Button();
            dtgDanhSachTaiKhoan = new DataGridView();
            btnXuatExcel = new Button();
            txtTimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachTaiKhoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.LightPink;
            btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMoi.Location = new Point(779, 11);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(167, 37);
            btnThemMoi.TabIndex = 30;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            // 
            // dtgDanhSachTaiKhoan
            // 
            dtgDanhSachTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachTaiKhoan.Location = new Point(12, 61);
            dtgDanhSachTaiKhoan.Name = "dtgDanhSachTaiKhoan";
            dtgDanhSachTaiKhoan.RowHeadersWidth = 51;
            dtgDanhSachTaiKhoan.RowTemplate.Height = 24;
            dtgDanhSachTaiKhoan.Size = new Size(955, 593);
            dtgDanhSachTaiKhoan.TabIndex = 29;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.DarkTurquoise;
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExcel.Location = new Point(549, 11);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(167, 37);
            btnXuatExcel.TabIndex = 28;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(73, 16);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(187, 32);
            txtTimKiem.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LAB1.Properties.Resources.search;
            pictureBox1.Location = new Point(28, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 37);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // FormDanhSachTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 666);
            Controls.Add(btnThemMoi);
            Controls.Add(dtgDanhSachTaiKhoan);
            Controls.Add(btnXuatExcel);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Name = "FormDanhSachTaiKhoan";
            Text = "FormDanhSachTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachTaiKhoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
