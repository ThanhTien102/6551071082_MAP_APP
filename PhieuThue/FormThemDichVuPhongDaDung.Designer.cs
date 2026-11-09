namespace LAB1.PhieuThue
{
    partial class FormThemDichVuPhongDaDung
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label lbSoCTPhieu;
        private System.Windows.Forms.Label lbSoPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTenDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lbThanhTien;
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
            label1 = new Label();
            cbTenDV = new ComboBox();
            label2 = new Label();
            txtMaDV = new TextBox();
            label3 = new Label();
            txtDonGia = new TextBox();
            label4 = new Label();
            txtSoLuong = new TextBox();
            lbThanhTien = new Label();
            btnThemDV = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lbTieuDe
            // 
            lbTieuDe.AutoSize = true;
            lbTieuDe.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTieuDe.ForeColor = Color.Teal;
            lbTieuDe.Location = new Point(20, 15);
            lbTieuDe.Name = "lbTieuDe";
            lbTieuDe.Size = new Size(200, 29);
            lbTieuDe.TabIndex = 0;
            lbTieuDe.Text = "Thêm dịch vụ phòng";
            // 
            // lbSoCTPhieu
            // 
            lbSoCTPhieu.AutoSize = true;
            lbSoCTPhieu.Font = new Font("Microsoft Sans Serif", 11F);
            lbSoCTPhieu.Location = new Point(20, 60);
            lbSoCTPhieu.Name = "lbSoCTPhieu";
            lbSoCTPhieu.Size = new Size(100, 20);
            lbSoCTPhieu.TabIndex = 1;
            lbSoCTPhieu.Text = "Mã CTDP:";
            // 
            // lbSoPhong
            // 
            lbSoPhong.AutoSize = true;
            lbSoPhong.Font = new Font("Microsoft Sans Serif", 11F);
            lbSoPhong.Location = new Point(20, 90);
            lbSoPhong.Name = "lbSoPhong";
            lbSoPhong.Size = new Size(90, 20);
            lbSoPhong.TabIndex = 2;
            lbSoPhong.Text = "Số phòng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F);
            label1.Location = new Point(20, 130);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên dịch vụ:";
            // 
            // cbTenDV
            // 
            cbTenDV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTenDV.Font = new Font("Microsoft Sans Serif", 11F);
            cbTenDV.FormattingEnabled = true;
            cbTenDV.Location = new Point(140, 126);
            cbTenDV.Name = "cbTenDV";
            cbTenDV.Size = new Size(300, 26);
            cbTenDV.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11F);
            label2.Location = new Point(20, 170);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 5;
            label2.Text = "Mã dịch vụ:";
            // 
            // txtMaDV
            // 
            txtMaDV.Font = new Font("Microsoft Sans Serif", 11F);
            txtMaDV.Location = new Point(140, 166);
            txtMaDV.Name = "txtMaDV";
            txtMaDV.ReadOnly = true;
            txtMaDV.Size = new Size(170, 24);
            txtMaDV.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F);
            label3.Location = new Point(20, 210);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 7;
            label3.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Microsoft Sans Serif", 11F);
            txtDonGia.Location = new Point(140, 206);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(170, 24);
            txtDonGia.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F);
            label4.Location = new Point(20, 250);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 9;
            label4.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Microsoft Sans Serif", 11F);
            txtSoLuong.Location = new Point(140, 246);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(170, 24);
            txtSoLuong.TabIndex = 10;
            // 
            // lbThanhTien
            // 
            lbThanhTien.AutoSize = true;
            lbThanhTien.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lbThanhTien.ForeColor = Color.FromArgb(213, 176, 32);
            lbThanhTien.Location = new Point(20, 290);
            lbThanhTien.Name = "lbThanhTien";
            lbThanhTien.Size = new Size(130, 24);
            lbThanhTien.TabIndex = 11;
            lbThanhTien.Text = "Thành tiền: 0";
            // 
            // btnThemDV
            // 
            btnThemDV.BackColor = Color.LightPink;
            btnThemDV.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnThemDV.Location = new Point(180, 330);
            btnThemDV.Name = "btnThemDV";
            btnThemDV.Size = new Size(130, 40);
            btnThemDV.TabIndex = 12;
            btnThemDV.Text = "Thêm";
            btnThemDV.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LightGray;
            btnThoat.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnThoat.Location = new Point(330, 330);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 40);
            btnThoat.TabIndex = 13;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // FormThemDichVuPhongDaDung
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 390);
            Controls.Add(lbTieuDe);
            Controls.Add(lbSoCTPhieu);
            Controls.Add(lbSoPhong);
            Controls.Add(label1);
            Controls.Add(cbTenDV);
            Controls.Add(label2);
            Controls.Add(txtMaDV);
            Controls.Add(label3);
            Controls.Add(txtDonGia);
            Controls.Add(label4);
            Controls.Add(txtSoLuong);
            Controls.Add(lbThanhTien);
            Controls.Add(btnThemDV);
            Controls.Add(btnThoat);
            Name = "FormThemDichVuPhongDaDung";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm dịch vụ phòng đã dùng";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
