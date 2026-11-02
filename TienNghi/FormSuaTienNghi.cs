
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using LAB1.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1.TienNghi
{
    public partial class FormSuaTienNghi : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? MaTienNghi { get; set; }

        public FormSuaTienNghi()
        {
            InitializeComponent();

            Text = "Cập nhật thông tin tiện nghi";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AcceptButton = btnCapNhat;
            CancelButton = btnThoat;

            txtTenTienNghi.MaxLength = 50;
        }

        private void FormSuaTienNghi_Load(object? sender, EventArgs e)
        {
            string? ma = MaTienNghi;

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show(
                    "Chưa xác định được tiện nghi cần cập nhật.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnCapNhat.Enabled = false;
                return;
            }

            Text = "Cập nhật tiện nghi " + ma;

            try
            {
                using var db = new HotelManagementContext();

                var thongTin = db.TienNghis
                    .AsNoTracking()
                    .Where(t => t.MaTn == ma && t.DaXoa != true)
                    .Select(t => new { t.TenTn })
                    .FirstOrDefault();

                if (thongTin == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy tiện nghi " + ma + ".",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    btnCapNhat.Enabled = false;
                    return;
                }

                txtMaTienNghi.Text = ma;
                txtTenTienNghi.Text = thongTin.TenTn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải thông tin tiện nghi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnCapNhat.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object? sender, EventArgs e)
        {
            string? ma = MaTienNghi;

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show(
                    "Chưa xác định được tiện nghi cần cập nhật.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string tenTN = txtTenTienNghi.Text.Trim();

            if (tenTN.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập tên tiện nghi.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTenTienNghi.Focus();
                return;
            }

            try
            {
                using var db = new HotelManagementContext();

                var tienNghi = db.TienNghis.FirstOrDefault(
                    t => t.MaTn == ma && t.DaXoa != true);

                if (tienNghi == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy tiện nghi cần cập nhật.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                tienNghi.TenTn = tenTN;

                int rows = db.SaveChanges();

                if (rows > 0)
                {
                    MessageBox.Show(
                        "Cập nhật thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "Thông tin không thay đổi nên không có gì để cập nhật.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(
                    "Lỗi khi cập nhật: " +
                    (ex.InnerException?.Message ?? ex.Message),
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi cập nhật: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
