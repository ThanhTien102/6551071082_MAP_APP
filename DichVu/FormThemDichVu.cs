
using System;
using System.Linq;
using System.Windows.Forms;
using LAB1.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1.DichVu
{
    public partial class FormThemDichVu : Form
    {
        private static readonly string[] LoaiDichVuMacDinh =
        {
            "Thức uống", "Đồ ăn", "Dịch vụ"
        };

        public FormThemDichVu()
        {
            InitializeComponent();

            Text = "Thêm mới dịch vụ";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AcceptButton = btnThemMoi;
            CancelButton = btnThoat;

            txtMaDichVu.MaxLength = 5;
            txtTenDichVu.MaxLength = 20;

            txtSoLuongConLai.KeyPress += ChiChoNhapSo;
        }

        private void FormThemDichVu_Load(object? sender, EventArgs e)
        {
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

                cbLoaiDichVu.Items.Clear();
                cbLoaiDichVu.Items.AddRange(
                    dsLoai.Count > 0
                        ? dsLoai.Cast<object>().ToArray()
                        : LoaiDichVuMacDinh.Cast<object>().ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải loại dịch vụ: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                cbLoaiDichVu.Items.Clear();
                cbLoaiDichVu.Items.AddRange(LoaiDichVuMacDinh);
            }

            if (cbLoaiDichVu.Items.Count > 0)
                cbLoaiDichVu.SelectedIndex = 0;

            txtMaDichVu.Focus();
        }

        private void btnThemMoi_Click(object? sender, EventArgs e)
        {
            string maDV = txtMaDichVu.Text.Trim().ToUpper();
            string tenDV = txtTenDichVu.Text.Trim();
            string loaiDV = cbLoaiDichVu.Text.Trim();

            if (maDV.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập mã dịch vụ.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMaDichVu.Focus();
                return;
            }

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

                var tonTai = db.DichVus.FirstOrDefault(d => d.MaDv == maDV);

                if (tonTai != null)
                {
                    if (tonTai.DaXoa != true)
                    {
                        MessageBox.Show(
                            "Mã dịch vụ đã tồn tại. Vui lòng nhập mã khác.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        txtMaDichVu.Focus();
                        return;
                    }

                    var traLoi = MessageBox.Show(
                        $"Mã dịch vụ {maDV} từng bị xóa trước đây.\n" +
                        "Bạn có muốn khôi phục dịch vụ này với thông tin vừa nhập không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (traLoi != DialogResult.Yes)
                        return;

                    tonTai.TenDv = tenDV;
                    tonTai.LoaiDv = loaiDV;
                    tonTai.DonGia = donGia;
                    tonTai.SlconLai = slConLai;
                    tonTai.DaXoa = false;
                }
                else
                {
                    db.DichVus.Add(new LAB1.Models.DichVu
                    {
                        MaDv = maDV,
                        TenDv = tenDV,
                        LoaiDv = loaiDV,
                        DonGia = donGia,
                        SlconLai = slConLai,
                        DaXoa = false
                    });
                }

                int result = db.SaveChanges();

                if (result > 0)
                {
                    MessageBox.Show(
                        "Thêm dịch vụ thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "Không thể thêm dịch vụ.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm dịch vụ: " +
                    (ex.InnerException?.Message ?? ex.Message),
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm dịch vụ: " + ex.Message,
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
