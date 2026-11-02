
using System;
using System.Linq;
using System.Windows.Forms;
using LAB1.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1.NhanVien
{
    public partial class FormThemNhanVien : Form
    {
        private static readonly string[] ChucVuMacDinh =
        {
            "Quản lý", "Tiếp tân", "Bảo vệ", "Nhân viên vệ sinh"
        };

        private static readonly string[] GioiTinhMacDinh = { "Nam", "Nữ" };

        public FormThemNhanVien()
        {
            InitializeComponent();

            Text = "Thêm mới nhân viên";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AcceptButton = btnThemMoi;
            CancelButton = btnThoat;

            txtMaNhanVien.MaxLength = 5;
            txtTenNhanVien.MaxLength = 50;
            txtLuong.MaxLength = 15;
            txtSoDienThoai.MaxLength = 10;
            txtCccd.MaxLength = 12;
            txtDiaChi.MaxLength = 100;
            txtEmail.MaxLength = 100;

            txtSoDienThoai.KeyPress += ChiChoNhapSo;
            txtCccd.KeyPress += ChiChoNhapSo;
            txtLuong.KeyPress += ChiChoNhapSo;

            dtpNgaySinh.Value = DateTime.Today.AddYears(-20);
            dtpNgaySinh.MaxDate = DateTime.Today;
        }

        private void FormThemNhanVien_Load(object? sender, EventArgs e)
        {
            cbGioiTinh.Items.Clear();
            cbGioiTinh.Items.AddRange(GioiTinhMacDinh);
            cbGioiTinh.SelectedIndex = 0;

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

                cbChucVu.Items.Clear();
                cbChucVu.Items.AddRange(
                    dsChucVu.Count > 0
                        ? dsChucVu.Cast<object>().ToArray()
                        : ChucVuMacDinh.Cast<object>().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách chức vụ: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                cbChucVu.Items.Clear();
                cbChucVu.Items.AddRange(ChucVuMacDinh);
            }

            if (cbChucVu.Items.Count > 0)
                cbChucVu.SelectedIndex = 0;

            txtMaNhanVien.Focus();
        }

        private void btnThemMoi_Click(object? sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text.Trim().ToUpper();
            string tenNV = txtTenNhanVien.Text.Trim();
            string chucVu = cbChucVu.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string cccd = txtCccd.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string email = txtEmail.Text.Trim();
            string gioiTinh = cbGioiTinh.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value.Date;

            if (maNV.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập mã nhân viên.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMaNhanVien.Focus();
                return;
            }

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

                var tonTai = db.NhanViens.FirstOrDefault(n => n.MaNv == maNV);

                if (tonTai != null)
                {
                    if (tonTai.DaXoa != true)
                    {
                        MessageBox.Show(
                            "Mã nhân viên đã tồn tại. Vui lòng nhập mã khác.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        txtMaNhanVien.Focus();
                        return;
                    }

                    var traLoi = MessageBox.Show(
                        $"Mã nhân viên {maNV} từng bị xóa trước đây.\n" +
                        "Bạn có muốn khôi phục nhân viên này với thông tin vừa nhập không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (traLoi != DialogResult.Yes)
                        return;

                    tonTai.TenNv = tenNV;
                    tonTai.ChucVu = chucVu;
                    tonTai.Luong = luong;
                    tonTai.Sdt = sdt;
                    tonTai.Cccd = cccd;
                    tonTai.NgaySinh = DateOnly.FromDateTime(ngaySinh);
                    tonTai.GioiTinh = gioiTinh;
                    tonTai.DiaChi = diaChi;
                    tonTai.Email = email.Length == 0 ? null : email;
                    tonTai.DaXoa = false;
                }
                else
                {
                    db.NhanViens.Add(new LAB1.Models.NhanVien
                    {
                        MaNv = maNV,
                        TenNv = tenNV,
                        ChucVu = chucVu,
                        Luong = luong,
                        Sdt = sdt,
                        Cccd = cccd,
                        NgaySinh = DateOnly.FromDateTime(ngaySinh),
                        GioiTinh = gioiTinh,
                        DiaChi = diaChi,
                        Email = email.Length == 0 ? null : email,
                        DaXoa = false
                    });
                }

                int result = db.SaveChanges();

                if (result > 0)
                {
                    MessageBox.Show(
                        "Thêm nhân viên thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "Không thể thêm nhân viên.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm nhân viên: " +
                    (ex.InnerException?.Message ?? ex.Message),
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm nhân viên: " + ex.Message,
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
