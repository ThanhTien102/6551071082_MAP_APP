namespace LAB1.PhieuThue
{
    partial class FormSuaChiTietPhieuThue
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label lbMaCTDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTrangThaiCTDP;
        private System.Windows.Forms.Button btnCapNhat;
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
            lbMaCTDP = new Label();
            label1 = new Label();
            cbTrangThaiCTDP = new ComboBox();
            btnCapNhat = new Button();
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
            lbTieuDe.Size = new Size(220, 29);
            lbTieuDe.TabIndex = 0;
            lbTieuDe.Text = "Cập nhật trạng thái";
            // 
            // lbMaCTDP
            // 
            lbMaCTDP.AutoSize = true;
            lbMaCTDP.Font = new Font("Microsoft Sans Serif", 11F);
            lbMaCTDP.Location = new Point(20, 65);
            lbMaCTDP.Name = "lbMaCTDP";
            lbMaCTDP.Size = new Size(200, 20);
            lbMaCTDP.TabIndex = 1;
            lbMaCTDP.Text = "Cập nhật trạng thái CTDP";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 11F);
            label1.Location = new Point(20, 110);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 2;
            label1.Text = "Trạng thái:";
            // 
            // cbTrangThaiCTDP
            // 
            cbTrangThaiCTDP.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrangThaiCTDP.Font = new Font("Microsoft Sans Serif", 11F);
            cbTrangThaiCTDP.FormattingEnabled = true;
            cbTrangThaiCTDP.Items.AddRange(new object[] { "Đã đặt", "Đang thuê", "Đã thanh toán" });
            cbTrangThaiCTDP.Location = new Point(130, 106);
            cbTrangThaiCTDP.Name = "cbTrangThaiCTDP";
            cbTrangThaiCTDP.Size = new Size(260, 26);
            cbTrangThaiCTDP.TabIndex = 3;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.LightPink;
            btnCapNhat.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnCapNhat.Location = new Point(140, 165);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(140, 40);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.LightGray;
            btnThoat.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnThoat.Location = new Point(300, 165);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 40);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // FormSuaChiTietPhieuThue
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 230);
            Controls.Add(lbTieuDe);
            Controls.Add(lbMaCTDP);
            Controls.Add(label1);
            Controls.Add(cbTrangThaiCTDP);
            Controls.Add(btnCapNhat);
            Controls.Add(btnThoat);
            Name = "FormSuaChiTietPhieuThue";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sửa chi tiết phiếu thuê";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
