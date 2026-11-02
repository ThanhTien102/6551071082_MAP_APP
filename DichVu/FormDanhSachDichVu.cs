
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using LAB1.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1.DichVu
{
    public partial class FormDanhSachDichVu : Form
    {
        private readonly Image _iconDichVu = LAB1.Properties.Resources.DichVu;
        private readonly Image _iconSua = LAB1.Properties.Resources.edit;
        private readonly Image _iconXoa = LAB1.Properties.Resources.delete;

        public FormDanhSachDichVu()
        {
            InitializeComponent();
        }

        private void FormDanhSachDichVu_Load(object? sender, EventArgs e)
        {
            CauHinhLuoi();
            LoadDichVu();
        }

        private void CauHinhLuoi()
        {
            if (dtgDanhSachDichVu.Columns.Count > 0)
                return;

            dtgDanhSachDichVu.ReadOnly = true;
            dtgDanhSachDichVu.AllowUserToAddRows = false;
            dtgDanhSachDichVu.AllowUserToDeleteRows = false;
            dtgDanhSachDichVu.AllowUserToResizeRows = false;
            dtgDanhSachDichVu.MultiSelect = false;
            dtgDanhSachDichVu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDanhSachDichVu.RowHeadersVisible = false;
            dtgDanhSachDichVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDanhSachDichVu.RowTemplate.Height = 40;

            dtgDanhSachDichVu.Columns.Add(TaoCotAnh("colIcon", "", _iconDichVu, 50));
            dtgDanhSachDichVu.Columns.Add("MaDV", "Mã dịch vụ");
            dtgDanhSachDichVu.Columns.Add("TenDV", "Tên dịch vụ");
            dtgDanhSachDichVu.Columns.Add("LoaiDV", "Loại dịch vụ");
            dtgDanhSachDichVu.Columns.Add("DonGia", "Đơn giá");
            dtgDanhSachDichVu.Columns.Add("SLConLai", "Số lượng còn lại");
            dtgDanhSachDichVu.Columns.Add(TaoCotAnh("colSua", "Sửa", _iconSua, 50));
            dtgDanhSachDichVu.Columns.Add(TaoCotAnh("colXoa", "Xóa", _iconXoa, 50));

            var cotDonGia = dtgDanhSachDichVu.Columns["DonGia"];
            if (cotDonGia != null)
            {
                cotDonGia.DefaultCellStyle.Format = "N0";
                cotDonGia.DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }
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

        private void LoadDichVu()
        {
            try
            {
                using var db = new HotelManagementContext();

                var dsDichVu = db.DichVus
                    .AsNoTracking()
                    .Where(d => d.DaXoa != true)
                    .OrderBy(d => d.MaDv)
                    .Select(d => new
                    {
                        d.MaDv,
                        d.TenDv,
                        d.LoaiDv,
                        d.DonGia,
                        d.SlconLai
                    })
                    .ToList();

                dtgDanhSachDichVu.Rows.Clear();

                foreach (var d in dsDichVu)
                {
                    dtgDanhSachDichVu.Rows.Add(
                        _iconDichVu,
                        d.MaDv,
                        d.TenDv,
                        d.LoaiDv,
                        d.DonGia,
                        d.SlconLai,
                        _iconSua,
                        _iconXoa);
                }

                LocTheoTuKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải danh sách dịch vụ: " + ex.Message,
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

            dtgDanhSachDichVu.CurrentCell = null;

            foreach (DataGridViewRow row in dtgDanhSachDichVu.Rows)
            {
                string ma = row.Cells["MaDV"].Value?.ToString() ?? "";
                string ten = row.Cells["TenDV"].Value?.ToString() ?? "";
                string loai = row.Cells["LoaiDV"].Value?.ToString() ?? "";

                row.Visible = keyword.Length == 0
                    || ma.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                    || ten.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                    || loai.Contains(keyword, StringComparison.OrdinalIgnoreCase);
            }
        }

        private void btnThemMoi_Click(object? sender, EventArgs e)
        {
            using (var formThemDichVu = new FormThemDichVu())
            {
                formThemDichVu.ShowDialog(this);
            }

            LoadDichVu();
        }

        private void dtgDanhSachDichVu_CellClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var dong = dtgDanhSachDichVu.Rows[e.RowIndex];
            string? maDV = dong.Cells["MaDV"].Value?.ToString();

            if (string.IsNullOrEmpty(maDV))
                return;

            string tenCot = dtgDanhSachDichVu.Columns[e.ColumnIndex].Name;

            if (tenCot == "colSua")
            {
                using (var formSua = new FormSuaDichVu())
                {
                    formSua.MaDichVu = maDV;
                    formSua.ShowDialog(this);
                }

                LoadDichVu();
            }
            else if (tenCot == "colXoa")
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa dịch vụ {maDV} không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    XoaDichVu(maDV);
                    LoadDichVu();
                }
            }
        }

        private void XoaDichVu(string maDV)
        {
            try
            {
                using var db = new HotelManagementContext();

                var dichVu = db.DichVus.FirstOrDefault(
                    d => d.MaDv == maDV && d.DaXoa != true);

                if (dichVu == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy dịch vụ để xóa.",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                bool dangDuocSuDung = db.Ctdvs.Any(
                    c => c.MaDv == maDV && c.DaXoa != true);

                if (dangDuocSuDung)
                {
                    MessageBox.Show(
                        $"Dịch vụ {maDV} đã được sử dụng trong hóa đơn nên không thể xóa.",
                        "Không thể xóa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                dichVu.DaXoa = true;
                db.SaveChanges();

                MessageBox.Show(
                    "Đã xóa dịch vụ thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi xóa dịch vụ: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnXuatExcel_Click(object? sender, EventArgs e)
        {
            var cacDong = dtgDanhSachDichVu.Rows.Cast<DataGridViewRow>()
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
                hopLuu.Title = "Xuất danh sách dịch vụ";
                hopLuu.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                hopLuu.FileName =
                    $"DanhSachDichVu_{DateTime.Now:yyyyMMdd_HHmm}.xlsx";

                if (hopLuu.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add("Danh sách dịch vụ");

                        string[] tenCot =
                        {
                            "MaDV", "TenDV", "LoaiDV", "DonGia", "SLConLai"
                        };
                        string[] tieuDe =
                        {
                            "Mã dịch vụ", "Tên dịch vụ", "Loại dịch vụ",
                            "Đơn giá", "Số lượng còn lại"
                        };

                        for (int c = 0; c < tenCot.Length; c++)
                            ws.Cell(1, c + 1).Value = tieuDe[c];

                        ws.Row(1).Style.Font.Bold = true;

                        for (int i = 0; i < cacDong.Count; i++)
                        {
                            for (int c = 0; c < tenCot.Length; c++)
                            {
                                var o = ws.Cell(i + 2, c + 1);
                                object? giaTri = cacDong[i].Cells[tenCot[c]].Value;

                                switch (giaTri)
                                {
                                    case decimal d:
                                        o.Value = d;
                                        o.Style.NumberFormat.Format = "#,##0";
                                        break;

                                    case int n:
                                        o.Value = n;
                                        break;

                                    default:
                                        o.Value = giaTri?.ToString() ?? "";
                                        break;
                                }
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
