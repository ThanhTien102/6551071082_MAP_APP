
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LAB1.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1.ChiTietTienNghi
{
    public partial class FormDanhSachChiTietTienNghi : Form
    {
        private readonly Image _iconTienNghi = LAB1.Properties.Resources.TienNghi;
        private readonly Image _iconSua = LAB1.Properties.Resources.edit;
        private readonly Image _iconXoa = LAB1.Properties.Resources.delete;

        private string maLPH = string.Empty;
        private string tenLoaiPhong = string.Empty;

        public FormDanhSachChiTietTienNghi()
        {
            InitializeComponent();
        }

        public FormDanhSachChiTietTienNghi(string maLPH, string tenLoaiPhong) : this()
        {
            this.maLPH = maLPH;
            this.tenLoaiPhong = tenLoaiPhong;
        }

        private void FormDanhSachChiTietTienNghi_Load(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maLPH))
            {
                MessageBox.Show(
                    "Không xác định được loại phòng!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                Close();
                return;
            }

            lblTenLoaiPhong.Text = $"Loại phòng: {tenLoaiPhong} ({maLPH})";
            CauHinhLuoi();
            LoadChiTietTienNghi();
        }

        private void CauHinhLuoi()
        {
            if (dtgDanhSachTienNghiTheoLoaiPhong.Columns.Count > 0)
                return;

            dtgDanhSachTienNghiTheoLoaiPhong.ReadOnly = true;
            dtgDanhSachTienNghiTheoLoaiPhong.AllowUserToAddRows = false;
            dtgDanhSachTienNghiTheoLoaiPhong.AllowUserToDeleteRows = false;
            dtgDanhSachTienNghiTheoLoaiPhong.AllowUserToResizeRows = false;
            dtgDanhSachTienNghiTheoLoaiPhong.MultiSelect = false;
            dtgDanhSachTienNghiTheoLoaiPhong.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dtgDanhSachTienNghiTheoLoaiPhong.RowHeadersVisible = false;
            dtgDanhSachTienNghiTheoLoaiPhong.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dtgDanhSachTienNghiTheoLoaiPhong.RowTemplate.Height = 36;

            dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add(
                TaoCotAnh("colIcon", "", _iconTienNghi, 50));

            var cotMaTN = new DataGridViewTextBoxColumn
            {
                Name = "MaTN",
                HeaderText = "Mã tiện nghi",
                Visible = false
            };
            dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add(cotMaTN);

            dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add("TenTN", "Tên tiện nghi");
            dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add("SL", "Số lượng");
            dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add("GhiChu", "Ghi chú");

            dtgDanhSachTienNghiTheoLoaiPhong.Columns["TenTN"]!.FillWeight = 45;
            dtgDanhSachTienNghiTheoLoaiPhong.Columns["SL"]!.FillWeight = 15;
            dtgDanhSachTienNghiTheoLoaiPhong.Columns["GhiChu"]!.FillWeight = 40;
            dtgDanhSachTienNghiTheoLoaiPhong.Columns["SL"]!.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add(
                TaoCotAnh("colSua", "Sửa", _iconSua, 50));
            dtgDanhSachTienNghiTheoLoaiPhong.Columns.Add(
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

        private void LoadChiTietTienNghi()
        {
            try
            {
                using var db = new HotelManagementContext();

                var danhSach = db.Cttns
                    .AsNoTracking()
                    .Where(c => c.MaLph == maLPH
                        && c.DaXoa != true
                        && c.MaTnNavigation.DaXoa != true)
                    .OrderBy(c => c.MaTn)
                    .Select(c => new
                    {
                        c.MaTn,
                        c.MaTnNavigation.TenTn,
                        c.Sl
                    })
                    .ToList();

                dtgDanhSachTienNghiTheoLoaiPhong.Rows.Clear();

                foreach (var tn in danhSach)
                {
                    int soLuong = tn.Sl ?? 0;
                    bool dungDuoc = soLuong >= 1;

                    int viTri = dtgDanhSachTienNghiTheoLoaiPhong.Rows.Add(
                        _iconTienNghi,
                        tn.MaTn,
                        tn.TenTn,
                        soLuong,
                        dungDuoc
                            ? "Có thể sử dụng tốt"
                            : "Đang không sử dụng được",
                        _iconSua,
                        _iconXoa);

                    if (!dungDuoc)
                    {
                        dtgDanhSachTienNghiTheoLoaiPhong
                            .Rows[viTri].Cells["GhiChu"].Style.ForeColor = Color.Red;
                    }
                }

                dtgDanhSachTienNghiTheoLoaiPhong.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi tải tiện nghi của loại phòng: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dtgDanhSachTienNghiTheoLoaiPhong_CellClick(
            object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var dong = dtgDanhSachTienNghiTheoLoaiPhong.Rows[e.RowIndex];
            string? maTN = dong.Cells["MaTN"].Value?.ToString();
            string tenTN = dong.Cells["TenTN"].Value?.ToString() ?? "";

            if (string.IsNullOrEmpty(maTN))
                return;

            string tenCot =
                dtgDanhSachTienNghiTheoLoaiPhong.Columns[e.ColumnIndex].Name;

            if (tenCot == "colSua")
            {
                int.TryParse(dong.Cells["SL"].Value?.ToString(), out int sl);

                using (var formSua =
                    new FormSuaChiTietTienNghi(maLPH, maTN, tenTN, sl))
                {
                    if (formSua.ShowDialog(this) == DialogResult.OK)
                        LoadChiTietTienNghi();
                }

                return;
            }

            if (tenCot == "colXoa")
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa tiện nghi '{tenTN}' khỏi loại phòng này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    XoaChiTietTienNghi(maTN);
                    LoadChiTietTienNghi();
                }
            }
        }

        private void XoaChiTietTienNghi(string maTN)
        {
            try
            {
                using var db = new HotelManagementContext();

                var chiTiet = db.Cttns.FirstOrDefault(
                    c => c.MaLph == maLPH && c.MaTn == maTN && c.DaXoa != true);

                if (chiTiet == null)
                {
                    MessageBox.Show(
                        "Không tìm thấy tiện nghi cần xóa!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                chiTiet.DaXoa = true;
                db.SaveChanges();

                MessageBox.Show(
                    "Đã xóa tiện nghi khỏi loại phòng thành công!",
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

        private void btnThemMoi_Click(object? sender, EventArgs e)
        {
            using (var formThem = new FormThemChiTietTienNghi(maLPH))
            {
                formThem.ShowDialog(this);
            }

            LoadChiTietTienNghi();
        }

        private void btnThoat_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
