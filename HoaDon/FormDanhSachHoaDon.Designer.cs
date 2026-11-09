namespace LAB1.HoaDon
{
    partial class FormDanhSachHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dtgDanhSachHoaDon = new DataGridView();
            txtTimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            btnXuatExcel = new Button();
            dtpNgayLap = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachHoaDon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgDanhSachHoaDon
            // 
            dtgDanhSachHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachHoaDon.Location = new Point(13, 118);
            dtgDanhSachHoaDon.Margin = new Padding(3, 4, 3, 4);
            dtgDanhSachHoaDon.Name = "dtgDanhSachHoaDon";
            dtgDanhSachHoaDon.RowHeadersWidth = 51;
            dtgDanhSachHoaDon.RowTemplate.Height = 24;
            dtgDanhSachHoaDon.Size = new Size(1187, 624);
            dtgDanhSachHoaDon.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(138, 29);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(187, 32);
            txtTimKiem.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LAB1.Properties.Resources.search;
            pictureBox1.Location = new Point(93, 22);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(39, 46);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.BackColor = Color.DarkTurquoise;
            btnXuatExcel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXuatExcel.Location = new Point(946, 29);
            btnXuatExcel.Margin = new Padding(3, 4, 3, 4);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(167, 46);
            btnXuatExcel.TabIndex = 28;
            btnXuatExcel.Text = "Xuất file Excel";
            btnXuatExcel.UseVisualStyleBackColor = false;
            // 
            // dtpNgayLap
            // 
            dtpNgayLap.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayLap.Location = new Point(450, 29);
            dtpNgayLap.Margin = new Padding(3, 4, 3, 4);
            dtpNgayLap.Name = "dtpNgayLap";
            dtpNgayLap.Size = new Size(361, 32);
            dtpNgayLap.TabIndex = 29;
            // 
            // FormDanhSachHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 756);
            Controls.Add(dtpNgayLap);
            Controls.Add(btnXuatExcel);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Controls.Add(dtgDanhSachHoaDon);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDanhSachHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách hóa đơn";
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachHoaDon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dtgDanhSachHoaDon;
        private TextBox txtTimKiem;
        private PictureBox pictureBox1;
        private Button btnXuatExcel;
        private DateTimePicker dtpNgayLap;
    }
}
