
namespace LAB1.ChiTietTienNghi
{
    partial class FormSuaChiTietTienNghi
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTenTienNghi;
        private System.Windows.Forms.TextBox txtTenTN;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;

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
            panel1 = new Panel();
            lblTenTienNghi = new Label();
            txtTenTN = new TextBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            btnCapNhat = new Button();
            btnThoat = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(192, 64, 0);
            lblTieuDe.Location = new Point(21, 30);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(503, 29);
            lblTieuDe.TabIndex = 18;
            lblTieuDe.Text = "Cập nhật thông tin tiện nghi của loại phòng";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(lblSoLuong);
            panel1.Controls.Add(txtTenTN);
            panel1.Controls.Add(lblTenTienNghi);
            panel1.Location = new Point(21, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 210);
            panel1.TabIndex = 15;
            // 
            // lblTenTienNghi
            // 
            lblTenTienNghi.AutoSize = true;
            lblTenTienNghi.Font = new Font("Microsoft Sans Serif", 13F);
            lblTenTienNghi.Location = new Point(30, 30);
            lblTenTienNghi.Name = "lblTenTienNghi";
            lblTenTienNghi.Size = new Size(125, 26);
            lblTenTienNghi.TabIndex = 0;
            lblTenTienNghi.Text = "Tên tiện nghi";
            // 
            // txtTenTN
            // 
            txtTenTN.BackColor = SystemColors.Control;
            txtTenTN.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenTN.Location = new Point(170, 27);
            txtTenTN.Name = "txtTenTN";
            txtTenTN.ReadOnly = true;
            txtTenTN.Size = new Size(300, 30);
            txtTenTN.TabIndex = 1;
            txtTenTN.TabStop = false;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Microsoft Sans Serif", 13F);
            lblSoLuong.Location = new Point(30, 110);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(98, 26);
            lblSoLuong.TabIndex = 2;
            lblSoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Microsoft Sans Serif", 12F);
            txtSoLuong.Location = new Point(170, 107);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(300, 30);
            txtSoLuong.TabIndex = 3;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.Moccasin;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 12F);
            btnCapNhat.Location = new Point(97, 340);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(137, 59);
            btnCapNhat.TabIndex = 16;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Location = new Point(297, 340);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormSuaChiTietTienNghi
            // 
            AcceptButton = btnCapNhat;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(548, 430);
            Controls.Add(lblTieuDe);
            Controls.Add(panel1);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThoat);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSuaChiTietTienNghi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cập nhật tiện nghi của loại phòng";
            Load += FormSuaChiTietTienNghi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
