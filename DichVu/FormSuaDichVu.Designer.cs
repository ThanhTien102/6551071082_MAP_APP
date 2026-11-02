
namespace LAB1.DichVu
{
    partial class FormSuaDichVu
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaDichVu;
        private System.Windows.Forms.Label lblMaDichVu;
        private System.Windows.Forms.ComboBox cbLoaiDichVu;
        private System.Windows.Forms.Label lblLoaiDichVu;
        private System.Windows.Forms.TextBox txtSoLuongConLai;
        private System.Windows.Forms.Label lblSoLuongConLai;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.Label lblTenDichVu;

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
            lblTieuDe = new Label();
            btnThoat = new Button();
            btnCapNhat = new Button();
            panel1 = new Panel();
            txtMaDichVu = new TextBox();
            lblMaDichVu = new Label();
            cbLoaiDichVu = new ComboBox();
            lblLoaiDichVu = new Label();
            txtSoLuongConLai = new TextBox();
            lblSoLuongConLai = new Label();
            txtDonGia = new TextBox();
            lblDonGia = new Label();
            txtTenDichVu = new TextBox();
            lblTenDichVu = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(192, 64, 0);
            lblTieuDe.Location = new Point(72, 31);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(404, 31);
            lblTieuDe.TabIndex = 18;
            lblTieuDe.Text = "Cập nhật thông tin dịch vụ";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Location = new Point(297, 490);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Moccasin;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 12F);
            btnCapNhat.Location = new Point(97, 490);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(137, 59);
            btnCapNhat.TabIndex = 16;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMaDichVu);
            panel1.Controls.Add(lblMaDichVu);
            panel1.Controls.Add(cbLoaiDichVu);
            panel1.Controls.Add(lblLoaiDichVu);
            panel1.Controls.Add(txtSoLuongConLai);
            panel1.Controls.Add(lblSoLuongConLai);
            panel1.Controls.Add(txtDonGia);
            panel1.Controls.Add(lblDonGia);
            panel1.Controls.Add(txtTenDichVu);
            panel1.Controls.Add(lblTenDichVu);
            panel1.Location = new Point(21, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 370);
            panel1.TabIndex = 15;
            // 
            // txtMaDichVu
            // 
            txtMaDichVu.BackColor = SystemColors.Control;
            txtMaDichVu.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaDichVu.Location = new Point(198, 29);
            txtMaDichVu.Name = "txtMaDichVu";
            txtMaDichVu.ReadOnly = true;
            txtMaDichVu.Size = new Size(275, 30);
            txtMaDichVu.TabIndex = 1;
            txtMaDichVu.TabStop = false;
            // 
            // lblMaDichVu
            // 
            lblMaDichVu.AutoSize = true;
            lblMaDichVu.Font = new Font("Microsoft Sans Serif", 13F);
            lblMaDichVu.Location = new Point(76, 29);
            lblMaDichVu.Name = "lblMaDichVu";
            lblMaDichVu.Size = new Size(109, 26);
            lblMaDichVu.TabIndex = 0;
            lblMaDichVu.Text = "Mã dịch vụ";
            // 
            // cbLoaiDichVu
            // 
            cbLoaiDichVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiDichVu.Font = new Font("Microsoft Sans Serif", 12F);
            cbLoaiDichVu.FormattingEnabled = true;
            cbLoaiDichVu.Location = new Point(198, 160);
            cbLoaiDichVu.Name = "cbLoaiDichVu";
            cbLoaiDichVu.Size = new Size(275, 28);
            cbLoaiDichVu.TabIndex = 5;
            // 
            // lblLoaiDichVu
            // 
            lblLoaiDichVu.AutoSize = true;
            lblLoaiDichVu.Font = new Font("Microsoft Sans Serif", 13F);
            lblLoaiDichVu.Location = new Point(72, 160);
            lblLoaiDichVu.Name = "lblLoaiDichVu";
            lblLoaiDichVu.Size = new Size(113, 26);
            lblLoaiDichVu.TabIndex = 4;
            lblLoaiDichVu.Text = "Loại dịch vụ";
            // 
            // txtSoLuongConLai
            // 
            txtSoLuongConLai.Font = new Font("Microsoft Sans Serif", 12F);
            txtSoLuongConLai.Location = new Point(198, 290);
            txtSoLuongConLai.Name = "txtSoLuongConLai";
            txtSoLuongConLai.Size = new Size(275, 30);
            txtSoLuongConLai.TabIndex = 9;
            // 
            // lblSoLuongConLai
            // 
            lblSoLuongConLai.AutoSize = true;
            lblSoLuongConLai.Font = new Font("Microsoft Sans Serif", 13F);
            lblSoLuongConLai.Location = new Point(29, 290);
            lblSoLuongConLai.Name = "lblSoLuongConLai";
            lblSoLuongConLai.Size = new Size(156, 26);
            lblSoLuongConLai.TabIndex = 8;
            lblSoLuongConLai.Text = "Số lượng còn lại";
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Microsoft Sans Serif", 12F);
            txtDonGia.Location = new Point(198, 225);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(275, 30);
            txtDonGia.TabIndex = 7;
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Font = new Font("Microsoft Sans Serif", 13F);
            lblDonGia.Location = new Point(105, 225);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(80, 26);
            lblDonGia.TabIndex = 6;
            lblDonGia.Text = "Đơn giá";
            // 
            // txtTenDichVu
            // 
            txtTenDichVu.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenDichVu.Location = new Point(198, 95);
            txtTenDichVu.Name = "txtTenDichVu";
            txtTenDichVu.Size = new Size(275, 30);
            txtTenDichVu.TabIndex = 3;
            // 
            // lblTenDichVu
            // 
            lblTenDichVu.AutoSize = true;
            lblTenDichVu.Font = new Font("Microsoft Sans Serif", 13F);
            lblTenDichVu.Location = new Point(71, 95);
            lblTenDichVu.Name = "lblTenDichVu";
            lblTenDichVu.Size = new Size(114, 26);
            lblTenDichVu.TabIndex = 2;
            lblTenDichVu.Text = "Tên dịch vụ";
            // 
            // FormSuaDichVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 580);
            Controls.Add(lblTieuDe);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(panel1);
            Name = "FormSuaDichVu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cập nhật dịch vụ";
            Load += FormSuaDichVu_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
