namespace LAB1.ThongKe
{
    partial class FormBaoCaoThongKe
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnXemThongKe;
        private System.Windows.Forms.Panel pnlKpiPhong;
        private System.Windows.Forms.Label lbKpiPhongTitle;
        private System.Windows.Forms.Label lbKpiPhong;
        private System.Windows.Forms.Panel pnlKpiDichVu;
        private System.Windows.Forms.Label lbKpiDichVuTitle;
        private System.Windows.Forms.Label lbKpiDichVu;
        private System.Windows.Forms.Panel pnlKpiSoPhong;
        private System.Windows.Forms.Label lbKpiSoPhongTitle;
        private System.Windows.Forms.Label lbKpiSoPhong;
        private System.Windows.Forms.Panel panelTop3;
        private System.Windows.Forms.Label lbTopLoaiPhongDT;
        private System.Windows.Forms.Label lbTopLoaiPhongDat;
        private System.Windows.Forms.Label lbTopDichVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picPieDichVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picBarDoanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picBarSoPhong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelTop = new Panel();
            label1 = new Label();
            dtpTuNgay = new DateTimePicker();
            label2 = new Label();
            dtpDenNgay = new DateTimePicker();
            btnXemThongKe = new Button();
            pnlKpiPhong = new Panel();
            lbKpiPhongTitle = new Label();
            lbKpiPhong = new Label();
            pnlKpiDichVu = new Panel();
            lbKpiDichVuTitle = new Label();
            lbKpiDichVu = new Label();
            pnlKpiSoPhong = new Panel();
            lbKpiSoPhongTitle = new Label();
            lbKpiSoPhong = new Label();
            panelTop3 = new Panel();
            lbTopLoaiPhongDT = new Label();
            lbTopLoaiPhongDat = new Label();
            lbTopDichVu = new Label();
            label3 = new Label();
            picPieDichVu = new PictureBox();
            label4 = new Label();
            picBarDoanhThu = new PictureBox();
            label5 = new Label();
            picBarSoPhong = new PictureBox();
            panelTop.SuspendLayout();
            pnlKpiPhong.SuspendLayout();
            pnlKpiDichVu.SuspendLayout();
            pnlKpiSoPhong.SuspendLayout();
            panelTop3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPieDichVu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBarDoanhThu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBarSoPhong).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(238, 230, 243);
            panelTop.Controls.Add(label1);
            panelTop.Controls.Add(dtpTuNgay);
            panelTop.Controls.Add(label2);
            panelTop.Controls.Add(dtpDenNgay);
            panelTop.Controls.Add(btnXemThongKe);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1212, 80);
            panelTop.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(90, 60, 110);
            label1.Location = new Point(20, 28);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 0;
            label1.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Font = new Font("Microsoft Sans Serif", 12F);
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(115, 24);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(190, 30);
            dtpTuNgay.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(90, 60, 110);
            label2.Location = new Point(335, 28);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 2;
            label2.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Font = new Font("Microsoft Sans Serif", 12F);
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(440, 24);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(190, 30);
            dtpDenNgay.TabIndex = 3;
            // 
            // btnXemThongKe
            // 
            btnXemThongKe.BackColor = Color.LightPink;
            btnXemThongKe.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnXemThongKe.Location = new Point(660, 18);
            btnXemThongKe.Name = "btnXemThongKe";
            btnXemThongKe.Size = new Size(180, 44);
            btnXemThongKe.TabIndex = 4;
            btnXemThongKe.Text = "Xem thống kê";
            btnXemThongKe.UseVisualStyleBackColor = false;
            // 
            // pnlKpiPhong
            // 
            pnlKpiPhong.BackColor = Color.FromArgb(232, 106, 106);
            pnlKpiPhong.Controls.Add(lbKpiPhongTitle);
            pnlKpiPhong.Controls.Add(lbKpiPhong);
            pnlKpiPhong.Location = new Point(20, 95);
            pnlKpiPhong.Name = "pnlKpiPhong";
            pnlKpiPhong.Size = new Size(370, 90);
            pnlKpiPhong.TabIndex = 1;
            // 
            // lbKpiPhongTitle
            // 
            lbKpiPhongTitle.AutoSize = true;
            lbKpiPhongTitle.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lbKpiPhongTitle.ForeColor = Color.White;
            lbKpiPhongTitle.Location = new Point(15, 12);
            lbKpiPhongTitle.Name = "lbKpiPhongTitle";
            lbKpiPhongTitle.Size = new Size(190, 22);
            lbKpiPhongTitle.TabIndex = 0;
            lbKpiPhongTitle.Text = "Doanh thu thuê phòng";
            // 
            // lbKpiPhong
            // 
            lbKpiPhong.AutoSize = true;
            lbKpiPhong.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lbKpiPhong.ForeColor = Color.White;
            lbKpiPhong.Location = new Point(15, 45);
            lbKpiPhong.Name = "lbKpiPhong";
            lbKpiPhong.Size = new Size(60, 31);
            lbKpiPhong.TabIndex = 1;
            lbKpiPhong.Text = "0";
            // 
            // pnlKpiDichVu
            // 
            pnlKpiDichVu.BackColor = Color.FromArgb(143, 191, 90);
            pnlKpiDichVu.Controls.Add(lbKpiDichVuTitle);
            pnlKpiDichVu.Controls.Add(lbKpiDichVu);
            pnlKpiDichVu.Location = new Point(410, 95);
            pnlKpiDichVu.Name = "pnlKpiDichVu";
            pnlKpiDichVu.Size = new Size(370, 90);
            pnlKpiDichVu.TabIndex = 2;
            // 
            // lbKpiDichVuTitle
            // 
            lbKpiDichVuTitle.AutoSize = true;
            lbKpiDichVuTitle.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lbKpiDichVuTitle.ForeColor = Color.White;
            lbKpiDichVuTitle.Location = new Point(15, 12);
            lbKpiDichVuTitle.Name = "lbKpiDichVuTitle";
            lbKpiDichVuTitle.Size = new Size(190, 22);
            lbKpiDichVuTitle.TabIndex = 0;
            lbKpiDichVuTitle.Text = "Doanh thu dịch vụ";
            // 
            // lbKpiDichVu
            // 
            lbKpiDichVu.AutoSize = true;
            lbKpiDichVu.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lbKpiDichVu.ForeColor = Color.White;
            lbKpiDichVu.Location = new Point(15, 45);
            lbKpiDichVu.Name = "lbKpiDichVu";
            lbKpiDichVu.Size = new Size(60, 31);
            lbKpiDichVu.TabIndex = 1;
            lbKpiDichVu.Text = "0";
            // 
            // pnlKpiSoPhong
            // 
            pnlKpiSoPhong.BackColor = Color.FromArgb(179, 157, 219);
            pnlKpiSoPhong.Controls.Add(lbKpiSoPhongTitle);
            pnlKpiSoPhong.Controls.Add(lbKpiSoPhong);
            pnlKpiSoPhong.Location = new Point(800, 95);
            pnlKpiSoPhong.Name = "pnlKpiSoPhong";
            pnlKpiSoPhong.Size = new Size(370, 90);
            pnlKpiSoPhong.TabIndex = 3;
            // 
            // lbKpiSoPhongTitle
            // 
            lbKpiSoPhongTitle.AutoSize = true;
            lbKpiSoPhongTitle.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lbKpiSoPhongTitle.ForeColor = Color.White;
            lbKpiSoPhongTitle.Location = new Point(15, 12);
            lbKpiSoPhongTitle.Name = "lbKpiSoPhongTitle";
            lbKpiSoPhongTitle.Size = new Size(150, 22);
            lbKpiSoPhongTitle.TabIndex = 0;
            lbKpiSoPhongTitle.Text = "Số phòng đặt";
            // 
            // lbKpiSoPhong
            // 
            lbKpiSoPhong.AutoSize = true;
            lbKpiSoPhong.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lbKpiSoPhong.ForeColor = Color.White;
            lbKpiSoPhong.Location = new Point(15, 45);
            lbKpiSoPhong.Name = "lbKpiSoPhong";
            lbKpiSoPhong.Size = new Size(30, 31);
            lbKpiSoPhong.TabIndex = 1;
            lbKpiSoPhong.Text = "0";
            // 
            // panelTop3
            // 
            panelTop3.BackColor = Color.FromArgb(243, 230, 245);
            panelTop3.Controls.Add(lbTopLoaiPhongDT);
            panelTop3.Controls.Add(lbTopLoaiPhongDat);
            panelTop3.Controls.Add(lbTopDichVu);
            panelTop3.Location = new Point(20, 200);
            panelTop3.Name = "panelTop3";
            panelTop3.Size = new Size(370, 240);
            panelTop3.TabIndex = 4;
            // 
            // lbTopLoaiPhongDT
            // 
            lbTopLoaiPhongDT.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold);
            lbTopLoaiPhongDT.ForeColor = Color.FromArgb(60, 140, 120);
            lbTopLoaiPhongDT.Location = new Point(10, 12);
            lbTopLoaiPhongDT.Name = "lbTopLoaiPhongDT";
            lbTopLoaiPhongDT.Size = new Size(350, 66);
            lbTopLoaiPhongDT.TabIndex = 0;
            lbTopLoaiPhongDT.Text = "Loại phòng doanh thu cao nhất";
            // 
            // lbTopLoaiPhongDat
            // 
            lbTopLoaiPhongDat.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold);
            lbTopLoaiPhongDat.ForeColor = Color.FromArgb(60, 140, 120);
            lbTopLoaiPhongDat.Location = new Point(10, 88);
            lbTopLoaiPhongDat.Name = "lbTopLoaiPhongDat";
            lbTopLoaiPhongDat.Size = new Size(350, 66);
            lbTopLoaiPhongDat.TabIndex = 1;
            lbTopLoaiPhongDat.Text = "Loại phòng được đặt nhiều nhất";
            // 
            // lbTopDichVu
            // 
            lbTopDichVu.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Bold);
            lbTopDichVu.ForeColor = Color.FromArgb(60, 140, 120);
            lbTopDichVu.Location = new Point(10, 164);
            lbTopDichVu.Name = "lbTopDichVu";
            lbTopDichVu.Size = new Size(350, 66);
            lbTopDichVu.TabIndex = 2;
            lbTopDichVu.Text = "Dịch vụ doanh thu cao nhất";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(90, 60, 110);
            label3.Location = new Point(20, 455);
            label3.Name = "label3";
            label3.Size = new Size(220, 22);
            label3.TabIndex = 5;
            label3.Text = "Các dịch vụ được sử dụng";
            // 
            // picPieDichVu
            // 
            picPieDichVu.BackColor = Color.White;
            picPieDichVu.BorderStyle = BorderStyle.FixedSingle;
            picPieDichVu.Location = new Point(20, 482);
            picPieDichVu.Name = "picPieDichVu";
            picPieDichVu.Size = new Size(370, 250);
            picPieDichVu.TabIndex = 6;
            picPieDichVu.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(90, 60, 110);
            label4.Location = new Point(410, 200);
            label4.Name = "label4";
            label4.Size = new Size(220, 22);
            label4.TabIndex = 7;
            label4.Text = "Doanh thu thuê phòng";
            // 
            // picBarDoanhThu
            // 
            picBarDoanhThu.BackColor = Color.White;
            picBarDoanhThu.BorderStyle = BorderStyle.FixedSingle;
            picBarDoanhThu.Location = new Point(410, 228);
            picBarDoanhThu.Name = "picBarDoanhThu";
            picBarDoanhThu.Size = new Size(760, 212);
            picBarDoanhThu.TabIndex = 8;
            picBarDoanhThu.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(90, 60, 110);
            label5.Location = new Point(410, 455);
            label5.Name = "label5";
            label5.Size = new Size(190, 22);
            label5.TabIndex = 9;
            label5.Text = "Số phòng được đặt";
            // 
            // picBarSoPhong
            // 
            picBarSoPhong.BackColor = Color.White;
            picBarSoPhong.BorderStyle = BorderStyle.FixedSingle;
            picBarSoPhong.Location = new Point(410, 482);
            picBarSoPhong.Name = "picBarSoPhong";
            picBarSoPhong.Size = new Size(760, 250);
            picBarSoPhong.TabIndex = 10;
            picBarSoPhong.TabStop = false;
            // 
            // FormBaoCaoThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 756);
            Controls.Add(picBarSoPhong);
            Controls.Add(label5);
            Controls.Add(picBarDoanhThu);
            Controls.Add(label4);
            Controls.Add(picPieDichVu);
            Controls.Add(label3);
            Controls.Add(panelTop3);
            Controls.Add(pnlKpiSoPhong);
            Controls.Add(pnlKpiDichVu);
            Controls.Add(pnlKpiPhong);
            Controls.Add(panelTop);
            Name = "FormBaoCaoThongKe";
            Text = "Báo cáo thống kê kinh doanh";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            pnlKpiPhong.ResumeLayout(false);
            pnlKpiPhong.PerformLayout();
            pnlKpiDichVu.ResumeLayout(false);
            pnlKpiDichVu.PerformLayout();
            pnlKpiSoPhong.ResumeLayout(false);
            pnlKpiSoPhong.PerformLayout();
            panelTop3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPieDichVu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBarDoanhThu).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBarSoPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
