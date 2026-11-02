
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using LAB1.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1.NhanVien
{
    public partial class FormSuaNhanVien : Form
    {
        private static readonly string[] GioiTinhMacDinh = { "Nam", "Nữ" };

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? MaNhanVien { get; set; }

        public FormSuaNhanVien()
        {
            InitializeComponent();

            Text = "Cập nhật nhân viên";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AcceptButton = btnCapNhat;
            CancelButton = btnThoat;

            txtTenNhanVien.MaxLength = 50;
            txtLuong.MaxLength = 15;
            txtSoDienThoai.MaxLength = 10;
            txtCccd.MaxLength = 12;
            txtDiaChi.MaxLength = 100;
            txtEmail.MaxLength = 100;

            txtSoDienThoai.KeyPress += ChiChoNhapSo;
            txtCccd.KeyPress += ChiChoNhapSo;
            txtLuong.KeyPress += ChiChoNhapSo;

            dtpNgaySinh.MaxDate = DateTime.Today;
        }

        private void FormSuaNhanVien_Load(object? sender, EventArgs e)
        {
            string? ma = MaNhanVien;

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show(
                    "Chưa xác định được nhân viên cần cập nhật.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnCapNhat.Enabled = false;
                return;
            }

            Text = "Cập nhật nhân viên " + ma;

            try
            {
                using var db = new HotelManagementContext();

                var dsChucVu = db.NhanViens
                    .AsNoTracking()
                    .Select(n => n.ChucVu)
                    .Where(c => c != null && c != "")
                    .Distinct()
                    .OrderBy(c => c)
                    .ToList();

                var dsGioiTinh = db.NhanViens
                    .AsNoTracking()
                    .Select(n => n.GioiTinh)
                    .Where(g => g != null && g != "")
                    .Distinct()
                    .OrderBy(g => g)
                    .ToList();

                var thongTin = db.NhanViens
                    .AsNoTracking()
                    .Where(n => n.MaNv == ma && n.DaXoa != true)
                    .Select(n => new
                    {
                        n.TenNv,
                        n.ChucVu,
                        n.Luong,
                        n.Sdt,
                        n.Cccd,
                        n.NgaySinh,
                        n.GioiTinh,
                        n.DiaChi,
                        n.Email
                    })
                    .FirstOrDefault();

                if (thongTin == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy nhân viên " + ma + ".",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    btnCapNhat.Enabled = false;
                    return;
                }

                if (!dsChucVu.Contains(thongTin.ChucVu))
                    dsChucVu.Add(thongTin.ChucVu);

                if (!dsGioiTinh.Contains(thongTin.GioiTinh))
                    dsGioiTinh.Add(thongTin.GioiTinh);

                cbChucVu.Items.Clear();
                cbChucVu.Items.AddRange(dsChucVu.Cast<object>().ToArray());

                cbGioiTinh.Items.Clear();
                cbGioiTinh.Items.AddRange(dsGioiTinh.Cast<object>().ToArray());

                txtMaNhanVien.Text = ma;
                txtTenNhanVien.Text = thongTin.TenNv;
                cbChucVu.Text = thongTin.ChucVu;
                txtLuong.Text = thongTin.Luong.ToString("0.##");
                txtSoDienThoai.Text = thongTin.Sdt;
                txtCccd.Text = thongTin.Cccd;
                dtpNgaySinh.Value = thongTin.NgaySinh
                    .ToDateTime(TimeOnly.MinValue);
                cbGioiTinh.SelectedItem = thongTin.GioiTinh;
                txtDiaChi.Text = thongTin.DiaChi;
                txtEmail.Text = thongTin.Email ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải thông tin nhân viên: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnCapNhat.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object? sender, EventArgs e)
        {
            string? ma = MaNhanVien;

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show(
                    "Chưa xác định được nhân viên cần cập nhật.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string tenNV = txtTenNhanVien.Text.Trim();
            string chucVu = cbChucVu.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string cccd = txtCccd.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();
            string gioiTinh = cbGioiTinh.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value.Date;

            if (tenNV.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập tên nhân viên.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTenNhanVien.Focus();
                return;
            }

            if (chucVu.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn chức vụ.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cbChucVu.Focus();
                return;
            }

            if (!decimal.TryParse(txtLuong.Text.Trim(), out decimal luong)
                || luong < 0)
            {
                MessageBox.Show(
                    "Lương không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtLuong.Focus();
                return;
            }

            if (!(sdt.Length == 9 || sdt.Length == 10) || !sdt.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Số điện thoại không hợp lệ! Vui lòng nhập 9 hoặc 10 chữ số.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            if (cccd.Length < 9 || cccd.Length > 12 || !cccd.All(char.IsDigit))
            {
                MessageBox.Show(
                    "CCCD không hợp lệ! Vui lòng nhập từ 9 đến 12 chữ số.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCccd.Focus();
                return;
            }

            if (ngaySinh.Year < 1900)
            {
                MessageBox.Show(
                    "Ngày sinh không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }

            if (gioiTinh.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn giới tính.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cbGioiTinh.Focus();
                return;
            }

            if (diaChi.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập địa chỉ.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }

            if (email.Length > 0 && !EmailHopLe(email))
            {
                MessageBox.Show(
                    "Email không hợp lệ!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            try
            {
                using var db = new HotelManagementContext();

                var nhanVien = db.NhanViens.FirstOrDefault(
                    n => n.MaNv == ma && n.DaXoa != true);

                if (nhanVien == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy nhân viên cần cập nhật.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                nhanVien.TenNv = tenNV;
                nhanVien.ChucVu = chucVu;
                nhanVien.Luong = luong;
                nhanVien.Sdt = sdt;
                nhanVien.Cccd = cccd;
                nhanVien.NgaySinh = DateOnly.FromDateTime(ngaySinh);
                nhanVien.GioiTinh = gioiTinh;
                nhanVien.DiaChi = diaChi;
                nhanVien.Email = email.Length == 0 ? null : email;

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

        private static bool EmailHopLe(string email)
        {
            int at = email.IndexOf('@');
            return at > 0
                && email.IndexOf('.', at + 1) > at + 1
                && !email.Contains(' ');
        }

        private void btnThoat_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ChiChoNhapSo(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
