
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using LAB1.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1.KhachHang
{
    public partial class FormSuaKhachHang : Form
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string? MaKhachHang { get; set; }

        public FormSuaKhachHang()
        {
            InitializeComponent();

            Text = "Cập nhật khách hàng";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AcceptButton = btnCapNhat;
            CancelButton = btnThoat;

            txtTenKhachHang.MaxLength = 50;
            txtSoDienThoai.MaxLength = 10;
            txtCccd.MaxLength = 12;

            txtSoDienThoai.KeyPress += ChiChoNhapSo;
        }

        private void FormSuaKhachHang_Load(object? sender, EventArgs e)
        {
            string? ma = MaKhachHang;

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show(
                    "Chưa xác định được khách hàng cần cập nhật.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnCapNhat.Enabled = false;
                return;
            }

            Text = "Cập nhật khách hàng " + ma;

            try
            {
                using var db = new HotelManagementContext();

                var dsQuocTich = db.KhachHangs
                    .AsNoTracking()
                    .Select(k => k.QuocTich)
                    .Where(q => q != null && q != "")
                    .Distinct()
                    .OrderBy(q => q)
                    .ToList();

                var dsGioiTinh = db.KhachHangs
                    .AsNoTracking()
                    .Select(k => k.GioiTinh)
                    .Where(g => g != null && g != "")
                    .Distinct()
                    .OrderBy(g => g)
                    .ToList();

                var thongTin = db.KhachHangs
                    .AsNoTracking()
                    .Where(k => k.MaKh == ma && k.DaXoa != true)
                    .Select(k => new
                    {
                        k.TenKh,
                        k.Sdt,
                        k.CccdPassport,
                        k.QuocTich,
                        k.GioiTinh
                    })
                    .FirstOrDefault();

                if (thongTin == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy khách hàng " + ma + ".",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    btnCapNhat.Enabled = false;
                    return;
                }

                if (!dsQuocTich.Contains(thongTin.QuocTich))
                    dsQuocTich.Add(thongTin.QuocTich);

                if (!dsGioiTinh.Contains(thongTin.GioiTinh))
                    dsGioiTinh.Add(thongTin.GioiTinh);

                cbQuocTich.Items.Clear();
                cbQuocTich.Items.AddRange(dsQuocTich.Cast<object>().ToArray());

                cbGioiTinh.Items.Clear();
                cbGioiTinh.Items.AddRange(dsGioiTinh.Cast<object>().ToArray());

                txtMaKhachHang.Text = ma;
                txtTenKhachHang.Text = thongTin.TenKh;
                txtSoDienThoai.Text = thongTin.Sdt ?? "";
                txtCccd.Text = thongTin.CccdPassport;
                cbQuocTich.SelectedItem = thongTin.QuocTich;
                cbGioiTinh.SelectedItem = thongTin.GioiTinh;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải thông tin khách hàng: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                btnCapNhat.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object? sender, EventArgs e)
        {
            string? ma = MaKhachHang;

            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show(
                    "Chưa xác định được khách hàng cần cập nhật.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string tenKH = txtTenKhachHang.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string cccd = txtCccd.Text.Trim();
            string quocTich = cbQuocTich.Text.Trim();
            string gioiTinh = cbGioiTinh.Text.Trim();

            if (tenKH.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập tên khách hàng.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtTenKhachHang.Focus();
                return;
            }

            if (cccd.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập CCCD/Passport.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCccd.Focus();
                return;
            }

            if (sdt.Length > 0 && !ChiGomChuSo(sdt, 10))
            {
                MessageBox.Show(
                    "Số điện thoại không hợp lệ! Vui lòng nhập đúng 10 chữ số.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            if (quocTich.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn quốc tịch.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cbQuocTich.Focus();
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

            try
            {
                using var db = new HotelManagementContext();

                var khachHang = db.KhachHangs.FirstOrDefault(
                    k => k.MaKh == ma && k.DaXoa != true);

                if (khachHang == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy khách hàng cần cập nhật.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                khachHang.TenKh = tenKH;
                khachHang.Sdt = sdt.Length == 0 ? null : sdt;
                khachHang.CccdPassport = cccd;
                khachHang.QuocTich = quocTich;
                khachHang.GioiTinh = gioiTinh;

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

        private static bool ChiGomChuSo(string value, int doDai)
        {
            return value.Length == doDai && value.All(char.IsDigit);
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
