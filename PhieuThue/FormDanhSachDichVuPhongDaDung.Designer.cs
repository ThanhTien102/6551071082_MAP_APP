namespace LAB1.PhieuThue
{
    partial class FormDanhSachDichVuPhongDaDung
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label lbSoCTPhieu;
        private System.Windows.Forms.Label lbSoPhong;
        private System.Windows.Forms.DataGridView dtgDanhSachDichVu;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lbTieuDe = new Label();
            lbSoCTPhieu = new Label();
            lbSoPhong = new Label();
            dtgDanhSachDichVu = new DataGridView();
            btnThemDV = new Button();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachDichVu).BeginInit();
            SuspendLayout();
            // 
            // lbTieuDe
            // 
            lbTieuDe.AutoSize = true;
            lbTieuDe.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTieuDe.ForeColor = Color.Teal;
            lbTieuDe.Location = new Point(20, 15);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(250, 29);
            lbTieuDe.TabIndex = 0;
            lbTieuDe.Text = "Dịch vụ phòng đã dùng";
            // 
            // lbSoCTPhieu
            // 
            lbSoCTPhieu.AutoSize = true;
            lbSoCTPhieu.Font = new Font("Microsoft Sans Serif", 11F);
            lbSoCTPhieu.Location = new Point(20, 60);
            lbSoCTPhieu.Name = "lbSoCTPhieu";
            lbSoCTPhieu.Size = new Size(130, 20);
            lbSoCTPhieu.TabIndex = 1;
            lbSoCTPhieu.Text = "Mã chi tiết phiếu:";
            // 
            // lbSoPhong
            // 
            lbSoPhong.AutoSize = true;
            lbSoPhong.Font = new Font("Microsoft Sans Serif", 11F);
            lbSoPhong.Location = new Point(330, 60);
            lbSoPhong.Name = "lbSoPhong";
            lbSoPhong.Size = new Size(90, 20);
            lbSoPhong.TabIndex = 2;
            lbSoPhong.Text = "Số phòng:";
            // 
            // dtgDanhSachDichVu
            // 
            dtgDanhSachDichVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachDichVu.Location = new Point(20, 95);
            dtgDanhSachDichVu.Name = "dtgDanhSachDichVu";
            dtgDanhSachDichVu.RowHeadersWidth = 51;
            dtgDanhSachDichVu.RowTemplate.Height = 32;
            dtgDanhSachDichVu.Size = new Size(700, 330);
            dtgDanhSachDichVu.TabIndex = 3;
            // 
            // btnThemDV
            // 
            btnThemDV.BackColor = Color.LightPink;
            btnThemDV.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnThemDV.Location = new Point(440, 445);
            btnThemDV.Name = "btnThemDV";
            btnThemDV.Size = new Size(150, 40);
            btnThemDV.TabIndex = 4;
            btnThemDV.Text = "Thêm dịch vụ";
            btnThemDV.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LightGray;
            btnThoat.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnThoat.Location = new Point(610, 445);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 40);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // FormDanhSachDichVuPhongDaDung
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 500);
            Controls.Add(lbTieuDe);
            Controls.Add(lbSoCTPhieu);
            Controls.Add(lbSoPhong);
            Controls.Add(dtgDanhSachDichVu);
            Controls.Add(btnThemDV);
            Controls.Add(btnThoat);
            Name = "FormDanhSachDichVuPhongDaDung";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Danh sách dịch vụ phòng đã dùng";
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachDichVu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
