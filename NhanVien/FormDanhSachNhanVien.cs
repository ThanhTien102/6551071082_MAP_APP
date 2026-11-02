
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using LAB1.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1.NhanVien
{
    public partial class FormDanhSachNhanVien : Form
    {
        private readonly Image _iconNhanVien = LAB1.Properties.Resources.NhanVien;
        private readonly Image _iconSua = LAB1.Properties.Resources.edit;
        private readonly Image _iconXoa = LAB1.Properties.Resources.delete;

        public FormDanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void FormDanhSachNhanVien_Load(object? sender, EventArgs e)
        {
            CauHinhLuoi();
            LoadNhanVien();
        }

        private void CauHinhLuoi()
        {
            if (dtgDanhSachNhanVien.Columns.Count > 0)
                return;

            dtgDanhSachNhanVien.ReadOnly = true;
            dtgDanhSachNhanVien.AllowUserToAddRows = false;
            dtgDanhSachNhanVien.AllowUserToDeleteRows = false;
            dtgDanhSachNhanVien.AllowUserToResizeRows = false;
            dtgDanhSachNhanVien.MultiSelect = false;
            dtgDanhSachNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDanhSachNhanVien.RowHeadersVisible = false;
            dtgDanhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dtgDanhSachNhanVien.RowTemplate.Height = 40;

            dtgDanhSachNhanVien.Columns.Add(
                TaoCotAnh("colIcon", "", _iconNhanVien, 50));
            dtgDanhSachNhanVien.Columns.Add(TaoCotChu("MaNV", "Mã NV", 70));
            dtgDanhSachNhanVien.Columns.Add(TaoCotChu("TenNV", "Tên nhân viên", 140));
            dtgDanhSachNhanVien.Columns.Add(TaoCotChu("ChucVu", "Chức vụ", 100));
            dtgDanhSachNhanVien.Columns.Add(TaoCotChu("Luong", "Lương", 90));
            dtgDanhSachNhanVien.Columns.Add(TaoCotChu("SDT", "Số điện thoại", 95));
            dtgDanhSachNhanVien.Columns.Add(TaoCotChu("CCCD", "CCCD", 100));
            dtgDanhSachNhanVien.Columns.Add(TaoCotChu("NgaySinh", "Ngày sinh", 90));
            dtgDanhSachNhanVien.Columns.Add(TaoCotChu("GioiTinh", "Giới tính", 70));
            dtgDanhSachNhanVien.Columns.Add(TaoCotChuAn("DiaChi", "Địa chỉ", 180));
            dtgDanhSachNhanVien.Columns.Add(TaoCotChuAn("Email", "Email", 180));
            dtgDanhSachNhanVien.Columns.Add(
                TaoCotAnh("colSua", "Sửa", _iconSua, 50));
            dtgDanhSachNhanVien.Columns.Add(
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
            string ten, string tieuDe, int doRong)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = ten,
                HeaderText = tieuDe,
                Width = doRong,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
        }

        private static DataGridViewTextBoxColumn TaoCotChuAn(
            string ten, string tieuDe, int doRong)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = ten,
                HeaderText = tieuDe,
                Width = doRong,
                Visible = false,
                SortMode = DataGridViewColumnSortMode.NotSortable
            };
        }

        private void LoadNhanVien()
        {
            try
            {
                using var db = new HotelManagementContext();

                var dsNhanVien = db.NhanViens
                    .AsNoTracking()
                    .Where(n => n.DaXoa != true)
                    .OrderBy(n => n.MaNv)
                    .Select(n => new
                    {
                        n.MaNv,
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
                    .ToList();

                dtgDanhSachNhanVien.Rows.Clear();

                foreach (var n in dsNhanVien)
                {
                    dtgDanhSachNhanVien.Rows.Add(
                        _iconNhanVien,
                        n.MaNv,
                        n.TenNv,
                        n.ChucVu,
                        n.Luong.ToString("N0"),
                        n.Sdt,
                        n.Cccd,
                        n.NgaySinh.ToString("dd/MM/yyyy"),
                        n.GioiTinh,
                        n.DiaChi,
                        n.Email ?? "",
                        _iconSua,
                        _iconXoa);
                }

                LocTheoTuKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải danh sách nhân viên: " + ex.Message,
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

            dtgDanhSachNhanVien.CurrentCell = null;

            foreach (DataGridViewRow row in dtgDanhSachNhanVien.Rows)
            {
                string ma = row.Cells["MaNV"].Value?.ToString() ?? "";
                string ten = row.Cells["TenNV"].Value?.ToString() ?? "";
                string chucVu = row.Cells["ChucVu"].Value?.ToString() ?? "";
                string sdt = row.Cells["SDT"].Value?.ToString() ?? "";
                string cccd = row.Cells["CCCD"].Value?.ToString() ?? "";

                row.Visible = keyword.Length == 0
                    || ma.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                    || ten.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                    || chucVu.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                    || sdt.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                    || cccd.Contains(keyword, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void btnThemMoi_Click(object? sender, EventArgs e)
        {
            using (var formThemNhanVien = new FormThemNhanVien())
            {
                formThemNhanVien.ShowDialog(this);
            }

            LoadNhanVien();
        }

        private void dtgDanhSachNhanVien_CellClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string? maNV = dtgDanhSachNhanVien.Rows[e.RowIndex]
                .Cells["MaNV"].Value?.ToString();

            if (string.IsNullOrEmpty(maNV))
                return;

            string tenCot = dtgDanhSachNhanVien.Columns[e.ColumnIndex].Name;

            if (tenCot == "colSua")
            {
                using (var formSua = new FormSuaNhanVien())
                {
                    formSua.MaNhanVien = maNV;
                    formSua.ShowDialog(this);
                }

                LoadNhanVien();
            }
            else if (tenCot == "colXoa")
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa nhân viên {maNV} không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    XoaNhanVien(maNV);
                    LoadNhanVien();
                }
            }
        }

        private void XoaNhanVien(string maNV)
        {
            try
            {
                using var db = new HotelManagementContext();

                var nhanVien = db.NhanViens.FirstOrDefault(
                    n => n.MaNv == maNV && n.DaXoa != true);

                if (nhanVien == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy nhân viên để xóa.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                bool dangDuocSuDung =
                    db.PhieuThues.Any(p => p.MaNv == maNV && p.DaXoa != true)
                    || db.HoaDons.Any(h => h.MaNv == maNV && h.DaXoa != true)
                    || db.TaiKhoans.Any(t => t.MaNv == maNV && t.DaXoa != true);

                if (dangDuocSuDung)
                {
                    MessageBox.Show(
                        $"Nhân viên {maNV} đang được sử dụng (phiếu thuê, hóa đơn " +
                        "hoặc tài khoản) nên không thể xóa.",
                        "Không thể xóa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                nhanVien.DaXoa = true;
                db.SaveChanges();

                MessageBox.Show(
                    "Đã xóa nhân viên thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi xóa nhân viên: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXuatExcel_Click(object? sender, EventArgs e)
        {
            var cacDong = dtgDanhSachNhanVien.Rows.Cast<DataGridViewRow>()
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
                hopLuu.Title = "Xuất danh sách nhân viên";
                hopLuu.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                hopLuu.FileName =
                    $"DanhSachNhanVien_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

                if (hopLuu.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("Danh sách nhân viên");

                        string[] tieuDe =
                        {
                            "Mã nhân viên", "Tên nhân viên", "Chức vụ", "Lương",
                            "Số điện thoại", "CCCD", "Ngày sinh", "Giới tính",
                            "Địa chỉ", "Email"
                        };

                        string[] tenCot =
                        {
                            "MaNV", "TenNV", "ChucVu", "Luong", "SDT", "CCCD",
                            "NgaySinh", "GioiTinh", "DiaChi", "Email"
                        };

                        for (int c = 0; c < tieuDe.Length; c++)
                            ws.Cell(1, c + 1).Value = tieuDe[c];

                        ws.Row(1).Style.Font.Bold = true;

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
