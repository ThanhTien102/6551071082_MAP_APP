
using System;
using System.Linq;
using System.Windows.Forms;
using LAB1.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1.TienNghi
{
    public partial class FormThemTienNghi : Form
    {
        public FormThemTienNghi()
        {
            InitializeComponent();

            Text = "Thêm mới tiện nghi";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AcceptButton = btnThemMoi;
            CancelButton = btnThoat;

            txtMaTienNghi.MaxLength = 5;
            txtTenTienNghi.MaxLength = 50;
        }

        private void FormThemTienNghi_Load(object? sender, EventArgs e)
        {
            txtMaTienNghi.Focus();
        }

        private void btnThemMoi_Click(object? sender, EventArgs e)
        {
            string maTN = txtMaTienNghi.Text.Trim().ToUpper();
            string tenTN = txtTenTienNghi.Text.Trim();

            if (maTN.Length == 0)
            {
                MessageBox.Show(
                    "Vui lòng nhập mã tiện nghi.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMaTienNghi.Focus();
                return;
            }

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

                var tonTai = db.TienNghis.FirstOrDefault(t => t.MaTn == maTN);

                if (tonTai != null)
                {
                    if (tonTai.DaXoa != true)
                    {
                        MessageBox.Show(
                            "Mã tiện nghi đã tồn tại. Vui lòng nhập mã khác.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        txtMaTienNghi.Focus();
                        return;
                    }

                    var traLoi = MessageBox.Show(
                        $"Mã tiện nghi {maTN} từng bị xóa trước đây.\n" +
                        "Bạn có muốn khôi phục tiện nghi này với thông tin vừa nhập không?",
                        "Xác nhận",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (traLoi != DialogResult.Yes)
                        return;

                    tonTai.TenTn = tenTN;
                    tonTai.DaXoa = false;
                }
                else
                {
                    db.TienNghis.Add(new LAB1.Models.TienNghi
                    {
                        MaTn = maTN,
                        TenTn = tenTN,
                        DaXoa = false
                    });
                }

                int result = db.SaveChanges();

                if (result > 0)
                {
                    MessageBox.Show(
                        "Thêm tiện nghi thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "Không thể thêm tiện nghi.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm tiện nghi: " +
                    (ex.InnerException?.Message ?? ex.Message),
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi thêm tiện nghi: " + ex.Message,
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
