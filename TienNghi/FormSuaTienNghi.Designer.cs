
namespace LAB1.TienNghi
{
    partial class FormSuaTienNghi
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaTienNghi;
        private System.Windows.Forms.Label lblMaTienNghi;
        private System.Windows.Forms.TextBox txtTenTienNghi;
        private System.Windows.Forms.Label lblTenTienNghi;

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
            txtMaTienNghi = new TextBox();
            lblMaTienNghi = new Label();
            txtTenTienNghi = new TextBox();
            lblTenTienNghi = new Label();
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
            lblTieuDe.Text = "Cập nhật thông tin tiện nghi";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.GradientActiveCaption;
            btnThoat.Font = new Font("Microsoft Sans Serif", 12F);
            btnThoat.Location = new Point(297, 330);
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
            btnCapNhat.Location = new Point(97, 330);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(137, 59);
            btnCapNhat.TabIndex = 16;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMaTienNghi);
            panel1.Controls.Add(lblMaTienNghi);
            panel1.Controls.Add(txtTenTienNghi);
            panel1.Controls.Add(lblTenTienNghi);
            panel1.Location = new Point(21, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 190);
            panel1.TabIndex = 15;
            // 
            // txtMaTienNghi
            // 
            txtMaTienNghi.BackColor = SystemColors.Control;
            txtMaTienNghi.Font = new Font("Microsoft Sans Serif", 12F);
            txtMaTienNghi.Location = new Point(198, 29);
            txtMaTienNghi.Name = "txtMaTienNghi";
            txtMaTienNghi.ReadOnly = true;
            txtMaTienNghi.Size = new Size(275, 30);
            txtMaTienNghi.TabIndex = 1;
            txtMaTienNghi.TabStop = false;
            // 
            // lblMaTienNghi
            // 
            lblMaTienNghi.AutoSize = true;
            lblMaTienNghi.Font = new Font("Microsoft Sans Serif", 13F);
            lblMaTienNghi.Location = new Point(65, 29);
            lblMaTienNghi.Name = "lblMaTienNghi";
            lblMaTienNghi.Size = new Size(120, 26);
            lblMaTienNghi.TabIndex = 0;
            lblMaTienNghi.Text = "Mã tiện nghi";
            // 
            // txtTenTienNghi
            // 
            txtTenTienNghi.Font = new Font("Microsoft Sans Serif", 12F);
            txtTenTienNghi.Location = new Point(198, 95);
            txtTenTienNghi.Name = "txtTenTienNghi";
            txtTenTienNghi.Size = new Size(275, 30);
            txtTenTienNghi.TabIndex = 3;
            // 
            // lblTenTienNghi
            // 
            lblTenTienNghi.AutoSize = true;
            lblTenTienNghi.Font = new Font("Microsoft Sans Serif", 13F);
            lblTenTienNghi.Location = new Point(60, 95);
            lblTenTienNghi.Name = "lblTenTienNghi";
            lblTenTienNghi.Size = new Size(125, 26);
            lblTenTienNghi.TabIndex = 2;
            lblTenTienNghi.Text = "Tên tiện nghi";
            // 
            // FormSuaTienNghi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 420);
            Controls.Add(lblTieuDe);
            Controls.Add(btnThoat);
            Controls.Add(btnCapNhat);
            Controls.Add(panel1);
            Name = "FormSuaTienNghi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cập nhật tiện nghi";
            Load += FormSuaTienNghi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
