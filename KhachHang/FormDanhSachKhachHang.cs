
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using LAB1.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1.KhachHang
{
    public partial class FormDanhSachKhachHang : Form
    {
        private readonly Image _iconKhachHang = LAB1.Properties.Resources.KhachHang;
        private readonly Image _iconSua = LAB1.Properties.Resources.edit;
        private readonly Image _iconXoa = LAB1.Properties.Resources.delete;

        public FormDanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void FormDanhSachKhachHang_Load(object? sender, EventArgs e)
        {
            CauHinhLuoi();
            LoadKhachHang();
        }

        private void CauHinhLuoi()
        {
            if (dtgDanhSachKhachHang.Columns.Count > 0)
                return;

            dtgDanhSachKhachHang.ReadOnly = true;
            dtgDanhSachKhachHang.AllowUserToAddRows = false;
            dtgDanhSachKhachHang.AllowUserToDeleteRows = false;
            dtgDanhSachKhachHang.AllowUserToResizeRows = false;
            dtgDanhSachKhachHang.MultiSelect = false;
            dtgDanhSachKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDanhSachKhachHang.RowHeadersVisible = false;
            dtgDanhSachKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDanhSachKhachHang.RowTemplate.Height = 40;

            dtgDanhSachKhachHang.Columns.Add(
                TaoCotAnh("colIcon", "", _iconKhachHang, 50));
            dtgDanhSachKhachHang.Columns.Add(TaoCotChu("MaKH", "Mã KH", 55));
            dtgDanhSachKhachHang.Columns.Add(TaoCotChu("TenKH", "Tên khách hàng", 130));
            dtgDanhSachKhachHang.Columns.Add(TaoCotChu("SDT", "Số điện thoại", 80));
            dtgDanhSachKhachHang.Columns.Add(TaoCotChu("CCCD", "CCCD/Passport", 90));
            dtgDanhSachKhachHang.Columns.Add(TaoCotChu("QuocTich", "Quốc tịch", 80));
            dtgDanhSachKhachHang.Columns.Add(TaoCotChu("GioiTinh", "Giới tính", 55));
            dtgDanhSachKhachHang.Columns.Add(
                TaoCotAnh("colSua", "Sửa", _iconSua, 50));
            dtgDanhSachKhachHang.Columns.Add(
                TaoCotAnh("colXoa", "Xóa", _iconXoa, 50));
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

        private static DataGridViewTextBoxColumn TaoCotChu(
            string ten, string tieuDe, float trongSo)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = ten,
                HeaderText = tieuDe,
                FillWeight = trongSo,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
        }

        private void LoadKhachHang()
        {
            try
            {
                using var db = new HotelManagementContext();

                var dsKhachHang = db.KhachHangs
                    .AsNoTracking()
                    .Where(k => k.DaXoa != true)
                    .OrderBy(k => k.MaKh)
                    .Select(k => new
                    {
                        k.MaKh,
                        k.TenKh,
                        k.Sdt,
                        k.CccdPassport,
                        k.QuocTich,
                        k.GioiTinh
                    })
                    .ToList();

                dtgDanhSachKhachHang.Rows.Clear();

                foreach (var k in dsKhachHang)
                {
                    dtgDanhSachKhachHang.Rows.Add(
                        _iconKhachHang,
                        k.MaKh,
                        k.TenKh,
                        k.Sdt ?? "",
                        k.CccdPassport,
                        k.QuocTich,
                        k.GioiTinh,
                        _iconSua,
                        _iconXoa);
                }

                LocTheoTuKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải danh sách khách hàng: " + ex.Message,
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

            dtgDanhSachKhachHang.CurrentCell = null;

            foreach (DataGridViewRow row in dtgDanhSachKhachHang.Rows)
            {
                string ma = row.Cells["MaKH"].Value?.ToString() ?? "";
                string ten = row.Cells["TenKH"].Value?.ToString() ?? "";
                string sdt = row.Cells["SDT"].Value?.ToString() ?? "";
                string cccd = row.Cells["CCCD"].Value?.ToString() ?? "";

                row.Visible = keyword.Length == 0
                    || ma.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                    || ten.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                    || sdt.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                    || cccd.Contains(keyword, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void btnThemMoi_Click(object? sender, EventArgs e)
        {
            using (var formThemKhachHang = new FormThemKhachHang())
            {
                formThemKhachHang.ShowDialog(this);
            }

            LoadKhachHang();
        }

        private void dtgDanhSachKhachHang_CellClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string? maKH = dtgDanhSachKhachHang.Rows[e.RowIndex]
                .Cells["MaKH"].Value?.ToString();

            if (string.IsNullOrEmpty(maKH))
                return;

            string tenCot = dtgDanhSachKhachHang.Columns[e.ColumnIndex].Name;

            if (tenCot == "colSua")
            {
                using (var formSua = new FormSuaKhachHang())
                {
                    formSua.MaKhachHang = maKH;
                    formSua.ShowDialog(this);
                }

                LoadKhachHang();
            }
            else if (tenCot == "colXoa")
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa khách hàng {maKH} không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    XoaKhachHang(maKH);
                    LoadKhachHang();
                }
            }
        }

        private void XoaKhachHang(string maKH)
        {
            try
            {
                using var db = new HotelManagementContext();

                var khachHang = db.KhachHangs.FirstOrDefault(
                    k => k.MaKh == maKH && k.DaXoa != true);

                if (khachHang == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy khách hàng để xóa.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                bool dangCoPhieuThue = db.PhieuThues.Any(
                    p => p.MaKh == maKH && p.DaXoa != true);

                if (dangCoPhieuThue)
                {
                    MessageBox.Show(
                        $"Khách hàng {maKH} đang có phiếu thuê nên không thể xóa.",
                        "Không thể xóa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                khachHang.DaXoa = true;
                db.SaveChanges();

                MessageBox.Show(
                    "Đã xóa khách hàng thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi xóa khách hàng: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXuatExcel_Click(object? sender, EventArgs e)
        {
            var cacDong = dtgDanhSachKhachHang.Rows.Cast<DataGridViewRow>()
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
                hopLuu.Title = "Xuất danh sách khách hàng";
                hopLuu.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                hopLuu.FileName =
                    $"DanhSachKhachHang_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

                if (hopLuu.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("Danh sách khách hàng");

                        string[] tieuDe =
                        {
                            "Mã khách hàng", "Tên khách hàng", "Số điện thoại",
                            "CCCD/Passport", "Quốc tịch", "Giới tính"
                        };

                        for (int c = 0; c < tieuDe.Length; c++)
                            ws.Cell(1, c + 1).Value = tieuDe[c];

                        ws.Row(1).Style.Font.Bold = true;

                        string[] tenCot =
                        {
                            "MaKH", "TenKH", "SDT", "CCCD", "QuocTich", "GioiTinh"
                        };

                        for (int i = 0; i < cacDong.Count; i++)
                        {
                            for (int c = 0; c < tenCot.Length; c++)
                            {
                                ws.Cell(i + 2, c + 1).Value =
                                    cacDong[i].Cells[tenCot[c]].Value?.ToString() ?? "";
                            }
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
