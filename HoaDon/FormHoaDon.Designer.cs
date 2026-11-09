namespace LAB1.HoaDon
{
    partial class FormHoaDon
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dtgDichVuDaDung = new DataGridView();
            txtTienThuePhong = new TextBox();
            label2 = new Label();
            dtpNgayHD = new DateTimePicker();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            lbTongTriGia = new Label();
            txtTenNV = new TextBox();
            txtSoNgayThuePhong = new TextBox();
            txtTenLP = new TextBox();
            txtMaPhong = new TextBox();
            txtMaHoaDon = new TextBox();
            txtTenKH = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            LabelNgayHD = new Label();
            LabelTenKH = new Label();
            Printer = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDichVuDaDung).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Printer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(dtgDichVuDaDung);
            panel1.Controls.Add(txtTienThuePhong);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpNgayHD);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lbTongTriGia);
            panel1.Controls.Add(txtTenNV);
            panel1.Controls.Add(txtSoNgayThuePhong);
            panel1.Controls.Add(txtTenLP);
            panel1.Controls.Add(txtMaPhong);
            panel1.Controls.Add(txtMaHoaDon);
            panel1.Controls.Add(txtTenKH);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(LabelNgayHD);
            panel1.Controls.Add(LabelTenKH);
            panel1.Controls.Add(Printer);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(836, 668);
            panel1.TabIndex = 0;
            // 
            // dtgDichVuDaDung
            // 
            dtgDichVuDaDung.AllowUserToAddRows = false;
            dtgDichVuDaDung.AllowUserToDeleteRows = false;
            dtgDichVuDaDung.AllowUserToResizeColumns = false;
            dtgDichVuDaDung.AllowUserToResizeRows = false;
            dtgDichVuDaDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDichVuDaDung.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dtgDichVuDaDung.BackgroundColor = Color.White;
            dtgDichVuDaDung.BorderStyle = BorderStyle.None;
            dtgDichVuDaDung.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgDichVuDaDung.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgDichVuDaDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgDichVuDaDung.ColumnHeadersHeight = 40;
            dtgDichVuDaDung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgDichVuDaDung.DefaultCellStyle = dataGridViewCellStyle2;
            dtgDichVuDaDung.EnableHeadersVisualStyles = false;
            dtgDichVuDaDung.Location = new Point(25, 329);
            dtgDichVuDaDung.Name = "dtgDichVuDaDung";
            dtgDichVuDaDung.ReadOnly = true;
            dtgDichVuDaDung.RowHeadersVisible = false;
            dtgDichVuDaDung.RowHeadersWidth = 40;
            dtgDichVuDaDung.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgDichVuDaDung.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dtgDichVuDaDung.RowTemplate.Height = 25;
            dtgDichVuDaDung.RowTemplate.ReadOnly = true;
            dtgDichVuDaDung.RowTemplate.Resizable = DataGridViewTriState.False;
            dtgDichVuDaDung.ScrollBars = ScrollBars.Horizontal;
            dtgDichVuDaDung.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dtgDichVuDaDung.Size = new Size(785, 221);
            dtgDichVuDaDung.TabIndex = 60;
            // 
            // txtTienThuePhong
            // 
            txtTienThuePhong.BackColor = Color.White;
            txtTienThuePhong.BorderStyle = BorderStyle.None;
            txtTienThuePhong.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTienThuePhong.ForeColor = Color.Red;
            txtTienThuePhong.Location = new Point(205, 294);
            txtTienThuePhong.Name = "txtTienThuePhong";
            txtTienThuePhong.ReadOnly = true;
            txtTienThuePhong.Size = new Size(220, 29);
            txtTienThuePhong.TabIndex = 59;
            txtTienThuePhong.Text = "0 ngày";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 294);
            label2.Name = "label2";
            label2.Size = new Size(165, 28);
            label2.TabIndex = 58;
            label2.Text = "Tiền thuê phòng";
            // 
            // dtpNgayHD
            // 
            dtpNgayHD.CalendarForeColor = SystemColors.ButtonHighlight;
            dtpNgayHD.Enabled = false;
            dtpNgayHD.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNgayHD.Format = DateTimePickerFormat.Short;
            dtpNgayHD.Location = new Point(205, 164);
            dtpNgayHD.Name = "dtpNgayHD";
            dtpNgayHD.Size = new Size(189, 30);
            dtpNgayHD.TabIndex = 57;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = LAB1.Properties.Resources.heart;
            pictureBox2.Location = new Point(530, 623);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 56;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(206, 607);
            label8.Name = "label8";
            label8.Size = new Size(323, 46);
            label8.TabIndex = 55;
            label8.Text = "Cảm ơn quý khách!";
            // 
            // lbTongTriGia
            // 
            lbTongTriGia.AutoSize = true;
            lbTongTriGia.BackColor = Color.White;
            lbTongTriGia.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTongTriGia.ForeColor = Color.FromArgb(213, 176, 32);
            lbTongTriGia.Location = new Point(19, 553);
            lbTongTriGia.Name = "lbTongTriGia";
            lbTongTriGia.Size = new Size(142, 35);
            lbTongTriGia.TabIndex = 54;
            lbTongTriGia.Text = "Tổng tiền: ";
            // 
            // txtTenNV
            // 
            txtTenNV.BackColor = Color.White;
            txtTenNV.BorderStyle = BorderStyle.None;
            txtTenNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenNV.Location = new Point(170, 247);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.ReadOnly = true;
            txtTenNV.Size = new Size(199, 27);
            txtTenNV.TabIndex = 51;
            txtTenNV.Text = "Họ tên nhân viên";
            // 
            // txtSoNgayThuePhong
            // 
            txtSoNgayThuePhong.BackColor = Color.White;
            txtSoNgayThuePhong.BorderStyle = BorderStyle.None;
            txtSoNgayThuePhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSoNgayThuePhong.Location = new Point(595, 247);
            txtSoNgayThuePhong.Name = "txtSoNgayThuePhong";
            txtSoNgayThuePhong.ReadOnly = true;
            txtSoNgayThuePhong.Size = new Size(151, 27);
            txtSoNgayThuePhong.TabIndex = 50;
            txtSoNgayThuePhong.Text = "0 ngày";
            // 
            // txtTenLP
            // 
            txtTenLP.BackColor = Color.White;
            txtTenLP.BorderStyle = BorderStyle.None;
            txtTenLP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenLP.Location = new Point(595, 206);
            txtTenLP.Name = "txtTenLP";
            txtTenLP.ReadOnly = true;
            txtTenLP.Size = new Size(151, 27);
            txtTenLP.TabIndex = 49;
            txtTenLP.Text = "Phòng đơn";
            // 
            // txtMaPhong
            // 
            txtMaPhong.BackColor = Color.White;
            txtMaPhong.BorderStyle = BorderStyle.None;
            txtMaPhong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaPhong.Location = new Point(595, 126);
            txtMaPhong.Name = "txtMaPhong";
            txtMaPhong.ReadOnly = true;
            txtMaPhong.Size = new Size(72, 27);
            txtMaPhong.TabIndex = 48;
            txtMaPhong.Text = "P000";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.BackColor = Color.White;
            txtMaHoaDon.BorderStyle = BorderStyle.None;
            txtMaHoaDon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaHoaDon.Location = new Point(170, 207);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.ReadOnly = true;
            txtMaHoaDon.Size = new Size(72, 27);
            txtMaHoaDon.TabIndex = 47;
            txtMaHoaDon.Text = "Số HD";
            // 
            // txtTenKH
            // 
            txtTenKH.BackColor = Color.White;
            txtTenKH.BorderStyle = BorderStyle.None;
            txtTenKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenKH.Location = new Point(150, 127);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.ReadOnly = true;
            txtTenKH.Size = new Size(201, 27);
            txtTenKH.TabIndex = 46;
            txtTenKH.Text = "Tên khách hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 246);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 45;
            label4.Text = "Nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 206);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 44;
            label3.Text = "Số hóa đơn:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(456, 246);
            label7.Name = "label7";
            label7.Size = new Size(90, 28);
            label7.TabIndex = 43;
            label7.Text = "Số ngày:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(457, 205);
            label6.Name = "label6";
            label6.Size = new Size(120, 28);
            label6.TabIndex = 42;
            label6.Text = "Loại phòng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(466, 124);
            label5.Name = "label5";
            label5.Size = new Size(111, 28);
            label5.TabIndex = 41;
            label5.Text = "Mã phòng:";
            // 
            // LabelNgayHD
            // 
            LabelNgayHD.AutoSize = true;
            LabelNgayHD.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelNgayHD.Location = new Point(20, 166);
            LabelNgayHD.Name = "LabelNgayHD";
            LabelNgayHD.Size = new Size(179, 28);
            LabelNgayHD.TabIndex = 40;
            LabelNgayHD.Text = "Ngày lập hóa đơn:";
            // 
            // LabelTenKH
            // 
            LabelTenKH.AutoSize = true;
            LabelTenKH.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelTenKH.Location = new Point(20, 126);
            LabelTenKH.Name = "LabelTenKH";
            LabelTenKH.Size = new Size(124, 28);
            LabelTenKH.TabIndex = 39;
            LabelTenKH.Text = "Khách hàng:";
            // 
            // Printer
            // 
            Printer.Cursor = Cursors.Hand;
            Printer.Image = LAB1.Properties.Resources.printer;
            Printer.Location = new Point(776, 11);
            Printer.Name = "Printer";
            Printer.Size = new Size(56, 48);
            Printer.SizeMode = PictureBoxSizeMode.StretchImage;
            Printer.TabIndex = 38;
            Printer.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(346, 11);
            label1.Name = "label1";
            label1.Size = new Size(183, 48);
            label1.TabIndex = 1;
            label1.Text = "Hóa đơn";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = LAB1.Properties.Resources.pictureIconNoneBackGroundResize55;
            pictureBox1.Location = new Point(25, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 670);
            Controls.Add(panel1);
            Name = "FormHoaDon";
            Text = "InPhiếu hóa đơn khách hàng";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDichVuDaDung).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Printer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtTenNV;
        private TextBox txtSoNgayThuePhong;
        private TextBox txtTenLP;
        private TextBox txtMaPhong;
        private TextBox txtMaHoaDon;
        private TextBox txtTenKH;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label LabelNgayHD;
        private Label LabelTenKH;
        private PictureBox Printer;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label8;
        private Label lbTongTriGia;
        private DateTimePicker dtpNgayHD;
        private TextBox txtTienThuePhong;
        private Label label2;
        private DataGridView dtgDichVuDaDung;
    }
}
