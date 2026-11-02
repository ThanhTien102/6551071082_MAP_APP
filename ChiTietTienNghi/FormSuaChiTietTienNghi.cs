
using System;
using System.Linq;
using System.Windows.Forms;
using LAB1.Models;

namespace LAB1.ChiTietTienNghi
{
    public partial class FormSuaChiTietTienNghi : Form
    {
        private readonly string maLPH = string.Empty;
        private readonly string maTN = string.Empty;
        private readonly string tenTN = string.Empty;
        private readonly int soLuongHienTai;

        public FormSuaChiTietTienNghi()
        {
            InitializeComponent();
        }

        public FormSuaChiTietTienNghi(
            string maLPH, string maTN, string tenTN, int soLuong) : this()
        {
            this.maLPH = maLPH;
            this.maTN = maTN;
            this.tenTN = tenTN;
            soLuongHienTai = soLuong;
        }

        private void FormSuaChiTietTienNghi_Load(object? sender, EventArgs e)
        {
            txtSoLuong.MaxLength = 4;
            txtSoLuong.KeyPress += ChiNhapSo;

            if (string.IsNullOrEmpty(maLPH) || string.IsNullOrEmpty(maTN))
            {
                MessageBox.Show(
                    "Không xác định được tiện nghi cần cập nhật!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
                Close();
                return;
            }

            txtTenTN.Text = tenTN;
            txtSoLuong.Text = soLuongHienTai.ToString();
            txtSoLuong.Focus();
            txtSoLuong.SelectAll();
        }

        private void ChiNhapSo(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnCapNhat_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập số lượng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuongMoi)
                || soLuongMoi < 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập số hợp lệ!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtSoLuong.Focus();
                return;
            }

            try
            {
                using var db = new HotelManagementContext();

                var chiTiet = db.Cttns.FirstOrDefault(
                    c => c.MaLph == maLPH && c.MaTn == maTN && c.DaXoa != true);

                if (chiTiet == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy tiện nghi cần cập nhật!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    DialogResult = DialogResult.Cancel;
                    Close();
                    return;
                }

                chiTiet.Sl = soLuongMoi;
                db.SaveChanges();

                MessageBox.Show(
                    "Cập nhật tiện nghi thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi cập nhật tiện nghi: " + ex.Message,
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
