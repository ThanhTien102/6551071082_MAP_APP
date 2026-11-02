
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using LAB1.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1.DichVu
{
    public partial class FormSuaDichVu : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? MaDichVu { get; set; }

        public FormSuaDichVu()
        {
            InitializeComponent();

            Text = "Cập nhật thông tin dịch vụ";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AcceptButton = btnCapNhat;
            CancelButton = btnThoat;

            txtTenDichVu.MaxLength = 20;

            txtSoLuongConLai.KeyPress += ChiChoNhapSo;
        }

        private void FormSuaDichVu_Load(object? sender, EventArgs e)
        {
            string? ma = MaDichVu;

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show(
                    "Chưa xác định được dịch vụ cần cập nhật.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnCapNhat.Enabled = false;
                return;
            }

            Text = "Cập nhật dịch vụ " + ma;

            try
            {
                using var db = new HotelManagementContext();

                var dsLoai = db.DichVus
                    .AsNoTracking()
                    .Select(d => d.LoaiDv)
                    .Where(l => l != null && l != "")
                    .Distinct()
                    .OrderBy(l => l)
                    .ToList();

                var thongTin = db.DichVus
                    .AsNoTracking()
                    .Where(d => d.MaDv == ma && d.DaXoa != true)
                    .Select(d => new
                    {
                        d.TenDv,
                        d.LoaiDv,
                        d.DonGia,
                        d.SlconLai
                    })
                    .FirstOrDefault();

                if (thongTin == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy dịch vụ " + ma + ".",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    btnCapNhat.Enabled = false;
                    return;
                }

                if (!dsLoai.Contains(thongTin.LoaiDv))
                    dsLoai.Add(thongTin.LoaiDv);

                cbLoaiDichVu.Items.Clear();
                cbLoaiDichVu.Items.AddRange(dsLoai.Cast<object>().ToArray());

                txtMaDichVu.Text = ma;
                txtTenDichVu.Text = thongTin.TenDv;
                cbLoaiDichVu.SelectedItem = thongTin.LoaiDv;
                txtDonGia.Text = thongTin.DonGia.ToString("0.##");
                txtSoLuongConLai.Text = thongTin.SlconLai?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải thông tin dịch vụ: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnCapNhat.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object? sender, EventArgs e)
        {
            string? ma = MaDichVu;

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show(
                    "Chưa xác định được dịch vụ cần cập nhật.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string tenDV = txtTenDichVu.Text.Trim();
            string loaiDV = cbLoaiDichVu.Text.Trim();

            if (tenDV.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập tên dịch vụ.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTenDichVu.Focus();
                return;
            }

            if (loaiDV.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn loại dịch vụ.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cbLoaiDichVu.Focus();
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia)
                || donGia < 0)
            {
                MessageBox.Show(
                    "Đơn giá không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            int? slConLai = null;
            string slNhap = txtSoLuongConLai.Text.Trim();

            if (slNhap.Length > 0)
            {
                if (!int.TryParse(slNhap, out int sl) || sl < -1)
                {
                    MessageBox.Show(
                        "Số lượng còn lại không hợp lệ! Nhập -1 nếu không giới hạn.",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    txtSoLuongConLai.Focus();
                    return;
                }

                slConLai = sl;
            }

            try
            {
                using var db = new HotelManagementContext();

                var dichVu = db.DichVus.FirstOrDefault(
                    d => d.MaDv == ma && d.DaXoa != true);

                if (dichVu == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy dịch vụ cần cập nhật.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                dichVu.TenDv = tenDV;
                dichVu.LoaiDv = loaiDV;
                dichVu.DonGia = donGia;
                dichVu.SlconLai = slConLai;

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

        private void ChiChoNhapSo(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '-')
                e.Handled = true;
        }
    }
}
