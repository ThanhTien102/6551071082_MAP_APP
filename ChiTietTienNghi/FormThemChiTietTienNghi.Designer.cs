
namespace LAB1.ChiTietTienNghi
{
    partial class FormThemChiTietTienNghi
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTenTienNghi;
        private System.Windows.Forms.ComboBox cbTenTN;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnThemMoi;
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
            cbTenTN = new ComboBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            btnThemMoi = new Button();
            btnThoat = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.FromArgb(192, 64, 0);
            lblTieuDe.Location = new Point(29, 31);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(534, 31);
            lblTieuDe.TabIndex = 18;
            lblTieuDe.Text = "Thêm mới tiện nghi cho loại phòng";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtSoLuong);
            panel1.Controls.Add(lblSoLuong);
            panel1.Controls.Add(cbTenTN);
            panel1.Controls.Add(lblTenTienNghi);
            panel1.Location = new Point(21, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 200);
            panel1.TabIndex = 15;
            // 
            // lblTenTienNghi
            // 
            lblTenTienNghi.AutoSize = true;
            lblTenTienNghi.Font = new Font("Microsoft Sans Serif", 13F);
            lblTenTienNghi.Location = new Point(94, 28);
            lblTenTienNghi.Name = "lblTenTienNghi";
            lblTenTienNghi.Size = new Size(125, 26);
            lblTenTienNghi.TabIndex = 0;
            lblTenTienNghi.Text = "Tên tiện nghi";
            // 
            // cbTenTN
            // 
            cbTenTN.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTenTN.Font = new Font("Microsoft Sans Serif", 12F);
            cbTenTN.FormattingEnabled = true;
            cbTenTN.Location = new Point(230, 25);
            cbTenTN.Name = "cbTenTN";
            cbTenTN.Size = new Size(275, 33);
            cbTenTN.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Font = new Font("Microsoft Sans Serif", 13F);
            lblSoLuong.Location = new Point(94, 105);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(98, 26);
            lblSoLuong.TabIndex = 2;
            lblSoLuong.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Microsoft Sans Serif", 12F);
            txtSoLuong.Location = new Point(230, 102);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(275, 30);
            txtSoLuong.TabIndex = 3;
            // 
            // btnThemMoi
            // 
            btnThemMoi.BackColor = Color.Moccasin;
            btnThemMoi.Font = new Font("Microsoft Sans Serif", 12F);
            btnThemMoi.Location = new Point(161, 340);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(137, 59);
            btnThemMoi.TabIndex = 16;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = false;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Location = new Point(361, 340);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(137, 59);
            btnThoat.TabIndex = 17;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormThemChiTietTienNghi
            // 
            AcceptButton = btnThemMoi;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnThoat;
            ClientSize = new Size(610, 445);
            Controls.Add(lblTieuDe);
            Controls.Add(panel1);
            Controls.Add(btnThemMoi);
            Controls.Add(btnThoat);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormThemChiTietTienNghi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm tiện nghi cho loại phòng";
            Load += FormThemChiTietTienNghi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
