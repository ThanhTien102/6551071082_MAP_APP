
using System;
using System.Linq;
using System.Windows.Forms;
using LAB1.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1.KhachHang
{
    public partial class FormThemKhachHang : Form
    {
        private static readonly string[] GioiTinhMacDinh = { "Nam", "Nữ" };
        private static readonly string[] QuocTichMacDinh = { "Việt Nam" };

        public FormThemKhachHang()
        {
            InitializeComponent();

            Text = "Thêm mới khách hàng";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AcceptButton = btnThemMoi;
            CancelButton = btnThoat;

            txtMaKhachHang.MaxLength = 5;
            txtTenKhachHang.MaxLength = 50;
            txtSoDienThoai.MaxLength = 10;
            txtCccd.MaxLength = 12;

            txtSoDienThoai.KeyPress += ChiChoNhapSo;
        }

        private void FormThemKhachHang_Load(object? sender, EventArgs e)
        {
            cbGioiTinh.Items.Clear();
            cbGioiTinh.Items.AddRange(GioiTinhMacDinh);
            cbGioiTinh.SelectedIndex = 0;

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

                cbQuocTich.Items.Clear();
                cbQuocTich.Items.AddRange(
                    dsQuocTich.Count > 0
                        ? dsQuocTich.Cast<object>().ToArray()
                        : QuocTichMacDinh.Cast<object>().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải danh sách quốc tịch: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                cbQuocTich.Items.Clear();
                cbQuocTich.Items.AddRange(QuocTichMacDinh);
            }

            if (cbQuocTich.Items.Count > 0)
                cbQuocTich.SelectedIndex = 0;

            txtMaKhachHang.Focus();
        }

        private void btnThemMoi_Click(object? sender, EventArgs e)
        {
            string maKH = txtMaKhachHang.Text.Trim().ToUpper();
            string tenKH = txtTenKhachHang.Text.Trim();
            string sdt = txtSoDienThoai.Text.Trim();
            string cccd = txtCccd.Text.Trim();
            string quocTich = cbQuocTich.Text.Trim();
            string gioiTinh = cbGioiTinh.Text.Trim();

            if (maKH.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập mã khách hàng.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMaKhachHang.Focus();
                return;
            }

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

                var tonTai = db.KhachHangs.FirstOrDefault(k => k.MaKh == maKH);

                if (tonTai != null)
                {
                    if (tonTai.DaXoa != true)
                    {
                        MessageBox.Show(
                            "Mã khách hàng đã tồn tại. Vui lòng nhập mã khác.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        txtMaKhachHang.Focus();
                        return;
                    }

                    var traLoi = MessageBox.Show(
                        $"Mã khách hàng {maKH} từng bị xóa trước đây.\n" +
                        "Bạn có muốn khôi phục khách hàng này với thông tin vừa nhập không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (traLoi != DialogResult.Yes)
                        return;

                    tonTai.TenKh = tenKH;
                    tonTai.Sdt = sdt.Length == 0 ? null : sdt;
                    tonTai.CccdPassport = cccd;
                    tonTai.QuocTich = quocTich;
                    tonTai.GioiTinh = gioiTinh;
                    tonTai.DaXoa = false;
                }
                else
                {
                    db.KhachHangs.Add(new LAB1.Models.KhachHang
                    {
                        MaKh = maKH,
                        TenKh = tenKH,
                        Sdt = sdt.Length == 0 ? null : sdt,
                        CccdPassport = cccd,
                        QuocTich = quocTich,
                        GioiTinh = gioiTinh,
                        DaXoa = false
                    });
                }

                int result = db.SaveChanges();

                if (result > 0)
                {
                    MessageBox.Show(
                        "Thêm khách hàng thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "Không thể thêm khách hàng.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm khách hàng: " +
                    (ex.InnerException?.Message ?? ex.Message),
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm khách hàng: " + ex.Message,
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
