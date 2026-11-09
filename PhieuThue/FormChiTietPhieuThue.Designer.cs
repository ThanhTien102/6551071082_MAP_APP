namespace LAB1.PhieuThue
{
    partial class FormChiTietPhieuThue
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lbSoPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHoTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbThoiGianLP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbHoTenNV;
        private System.Windows.Forms.DataGridView dtgDanhSachCTPT;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lbSoPhieu = new Label();
            label1 = new Label();
            lbHoTenKH = new Label();
            label2 = new Label();
            lbThoiGianLP = new Label();
            label3 = new Label();
            lbHoTenNV = new Label();
            dtgDanhSachCTPT = new DataGridView();
            btnThoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachCTPT).BeginInit();
            SuspendLayout();
            // 
            // lbSoPhieu
            // 
            lbSoPhieu.AutoSize = true;
            lbSoPhieu.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSoPhieu.ForeColor = Color.Teal;
            lbSoPhieu.Location = new Point(20, 15);
            lbSoPhieu.Name = "lbSoPhieu";
            lbSoPhieu.Size = new Size(220, 29);
            lbSoPhieu.TabIndex = 0;
            lbSoPhieu.Text = "Chi tiết phiếu thuê";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label1.Location = new Point(20, 60);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 1;
            label1.Text = "Khách hàng:";
            // 
            // lbHoTenKH
            // 
            lbHoTenKH.AutoSize = true;
            lbHoTenKH.Font = new Font("Microsoft Sans Serif", 11F);
            lbHoTenKH.Location = new Point(150, 60);
            lbHoTenKH.Name = "lbHoTenKH";
            lbHoTenKH.Size = new Size(60, 20);
            lbHoTenKH.TabIndex = 2;
            lbHoTenKH.Text = "...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label2.Location = new Point(380, 60);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "Ngày lập:";
            // 
            // lbThoiGianLP
            // 
            lbThoiGianLP.AutoSize = true;
            lbThoiGianLP.Font = new Font("Microsoft Sans Serif", 11F);
            lbThoiGianLP.Location = new Point(480, 60);
            lbThoiGianLP.Name = "lbThoiGianLP";
            lbThoiGianLP.Size = new Size(60, 20);
            lbThoiGianLP.TabIndex = 4;
            lbThoiGianLP.Text = "...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label3.Location = new Point(650, 60);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 5;
            label3.Text = "Nhân viên lập:";
            // 
            // lbHoTenNV
            // 
            lbHoTenNV.AutoSize = true;
            lbHoTenNV.Font = new Font("Microsoft Sans Serif", 11F);
            lbHoTenNV.Location = new Point(800, 60);
            lbHoTenNV.Name = "lbHoTenNV";
            lbHoTenNV.Size = new Size(60, 20);
            lbHoTenNV.TabIndex = 6;
            lbHoTenNV.Text = "...";
            // 
            // dtgDanhSachCTPT
            // 
            dtgDanhSachCTPT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhSachCTPT.Location = new Point(20, 100);
            dtgDanhSachCTPT.Name = "dtgDanhSachCTPT";
            dtgDanhSachCTPT.RowHeadersWidth = 51;
            dtgDanhSachCTPT.Size = new Size(940, 430);
            dtgDanhSachCTPT.TabIndex = 7;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LightGray;
            btnThoat.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnThoat.Location = new Point(840, 545);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 40);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // FormChiTietPhieuThue
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 600);
            Controls.Add(lbSoPhieu);
            Controls.Add(label1);
            Controls.Add(lbHoTenKH);
            Controls.Add(label2);
            Controls.Add(lbThoiGianLP);
            Controls.Add(label3);
            Controls.Add(lbHoTenNV);
            Controls.Add(dtgDanhSachCTPT);
            Controls.Add(btnThoat);
            Name = "FormChiTietPhieuThue";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chi tiết phiếu thuê";
            ((System.ComponentModel.ISupportInitialize)dtgDanhSachCTPT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
