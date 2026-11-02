
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using LAB1.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1.TienNghi
{
    public partial class FormDanhSachTienNghi : Form
    {
        private readonly Image _iconTienNghi = LAB1.Properties.Resources.TienNghi;
        private readonly Image _iconSua = LAB1.Properties.Resources.edit;
        private readonly Image _iconXoa = LAB1.Properties.Resources.delete;

        public FormDanhSachTienNghi()
        {
            InitializeComponent();
        }

        private void FormDanhSachTienNghi_Load(object? sender, EventArgs e)
        {
            CauHinhLuoi();
            LoadTienNghi();
        }

        private void CauHinhLuoi()
        {
            if (dtgDanhSachTienNghi.Columns.Count > 0)
                return;

            dtgDanhSachTienNghi.ReadOnly = true;
            dtgDanhSachTienNghi.AllowUserToAddRows = false;
            dtgDanhSachTienNghi.AllowUserToDeleteRows = false;
            dtgDanhSachTienNghi.AllowUserToResizeRows = false;
            dtgDanhSachTienNghi.MultiSelect = false;
            dtgDanhSachTienNghi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDanhSachTienNghi.RowHeadersVisible = false;
            dtgDanhSachTienNghi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDanhSachTienNghi.RowTemplate.Height = 40;

            dtgDanhSachTienNghi.Columns.Add(TaoCotAnh("colIcon", "", _iconTienNghi, 50));
            dtgDanhSachTienNghi.Columns.Add("MaTN", "Mã tiện nghi");
            dtgDanhSachTienNghi.Columns.Add("TenTN", "Tên tiện nghi");
            dtgDanhSachTienNghi.Columns.Add(TaoCotAnh("colSua", "Sửa", _iconSua, 50));
            dtgDanhSachTienNghi.Columns.Add(TaoCotAnh("colXoa", "Xóa", _iconXoa, 50));
        }

        private static DataGridViewImageColumn TaoCotAnh(
            string ten, string tieuDe, Image anh, int doRong)
        {
            return new DataGridViewImageColumn
            {
                Name = ten,
                HeaderText = tieuDe,
                Image = anh,
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.None,
                Width = doRong,
                Resizable = DataGridViewTriState.False,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
        }

        private void LoadTienNghi()
        {
            try
            {
                using var db = new HotelManagementContext();

                var dsTienNghi = db.TienNghis
                    .AsNoTracking()
                    .Where(t => t.DaXoa != true)
                    .OrderBy(t => t.MaTn)
                    .Select(t => new { t.MaTn, t.TenTn })
                    .ToList();

                dtgDanhSachTienNghi.Rows.Clear();

                foreach (var t in dsTienNghi)
                {
                    dtgDanhSachTienNghi.Rows.Add(
                        _iconTienNghi,
                        t.MaTn,
                        t.TenTn,
                        _iconSua,
                        _iconXoa);
                }

                LocTheoTuKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải danh sách tiện nghi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object? sender, EventArgs e)
        {
            LocTheoTuKhoa();
        }

        private void LocTheoTuKhoa()
        {
            string keyword = txtTimKiem.Text.Trim();

            dtgDanhSachTienNghi.CurrentCell = null;

            foreach (DataGridViewRow row in dtgDanhSachTienNghi.Rows)
            {
                string ma = row.Cells["MaTN"].Value?.ToString() ?? "";
                string ten = row.Cells["TenTN"].Value?.ToString() ?? "";

                row.Visible = keyword.Length == 0
                    || ma.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                    || ten.Contains(keyword, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void btnThemMoi_Click(object? sender, EventArgs e)
        {
            using (var formThemTienNghi = new FormThemTienNghi())
            {
                formThemTienNghi.ShowDialog(this);
            }

            LoadTienNghi();
        }

        private void dtgDanhSachTienNghi_CellClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string? maTN =
                dtgDanhSachTienNghi.Rows[e.RowIndex].Cells["MaTN"].Value?.ToString();

            if (string.IsNullOrEmpty(maTN))
                return;

            string tenCot = dtgDanhSachTienNghi.Columns[e.ColumnIndex].Name;

            if (tenCot == "colSua")
            {
                using (var formSua = new FormSuaTienNghi())
                {
                    formSua.MaTienNghi = maTN;
                    formSua.ShowDialog(this);
                }

                LoadTienNghi();
            }
            else if (tenCot == "colXoa")
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa tiện nghi {maTN} không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    XoaTienNghi(maTN);
                    LoadTienNghi();
                }
            }
        }

        private void XoaTienNghi(string maTN)
        {
            try
            {
                using var db = new HotelManagementContext();

                var tienNghi = db.TienNghis.FirstOrDefault(
                    t => t.MaTn == maTN && t.DaXoa != true);

                if (tienNghi == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy tiện nghi để xóa.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                bool dangDuocSuDung = db.Cttns.Any(
                    c => c.MaTn == maTN && c.DaXoa != true);

                if (dangDuocSuDung)
                {
                    MessageBox.Show(
                        $"Tiện nghi {maTN} đang được gán cho loại phòng nên không thể xóa.",
                        "Không thể xóa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                tienNghi.DaXoa = true;
                db.SaveChanges();

                MessageBox.Show(
                    "Đã xóa tiện nghi thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi xóa tiện nghi: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXuatExcel_Click(object? sender, EventArgs e)
        {
            var cacDong = dtgDanhSachTienNghi.Rows.Cast<DataGridViewRow>()
                .Where(r => r.Visible && !r.IsNewRow)
                .ToList();

            if (cacDong.Count == 0)
            {
                MessageBox.Show(
                    "Không có dữ liệu để xuất!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using (var hopLuu = new SaveFileDialog())
            {
                hopLuu.Title = "Xuất danh sách tiện nghi";
                hopLuu.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                hopLuu.FileName =
                    $"DanhSachTienNghi_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

                if (hopLuu.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("Danh sách tiện nghi");

                        ws.Cell(1, 1).Value = "Mã tiện nghi";
                        ws.Cell(1, 2).Value = "Tên tiện nghi";
                        ws.Row(1).Style.Font.Bold = true;

                        for (int i = 0; i < cacDong.Count; i++)
                        {
                            ws.Cell(i + 2, 1).Value =
                                cacDong[i].Cells["MaTN"].Value?.ToString() ?? "";
                            ws.Cell(i + 2, 2).Value =
                                cacDong[i].Cells["TenTN"].Value?.ToString() ?? "";
                        }

                        ws.Columns().AdjustToContents();
                        wb.SaveAs(hopLuu.FileName);
                    }

                    var traLoi = MessageBox.Show(
                        "Xuất dữ liệu thành công!\nBạn có muốn mở file ngay không?",
                        "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);

                    if (traLoi == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(
                            new System.Diagnostics.ProcessStartInfo(hopLuu.FileName)
                            {
                                UseShellExecute = true
                            });
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show(
                        "Không ghi được file. Có thể file đang được mở trong Excel, " +
                        "hãy đóng lại rồi thử lần nữa.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Lỗi khi xuất Excel: " + ex.Message,
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
