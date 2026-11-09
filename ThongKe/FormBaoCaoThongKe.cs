using System.Drawing.Drawing2D;
using LAB1.Models;
using Microsoft.EntityFrameworkCore;

namespace LAB1.ThongKe
{
    public partial class FormBaoCaoThongKe : Form
    {
        private sealed class DongPhieu
        {
            public string MaCtdp { get; set; } = "";
            public decimal ThanhTien { get; set; }
            public string TenLph { get; set; } = "";
        }

        private sealed class DongDichVu
        {
            public string TenDv { get; set; } = "";
            public int Sl { get; set; }
            public decimal Tien { get; set; }
        }

        private List<(string Ten, decimal GiaTri)> _barDoanhThu = new();
        private List<(string Ten, decimal GiaTri)> _barSoPhong = new();
        private List<(string Ten, int SoLan)> _pieDichVu = new();

        private static readonly Color[] MauBieuDo =
        {
            Color.FromArgb(91, 155, 213),
            Color.FromArgb(237, 125, 49),
            Color.FromArgb(112, 173, 71),
            Color.FromArgb(255, 192, 0),
            Color.FromArgb(165, 105, 189),
            Color.FromArgb(0, 176, 240),
            Color.FromArgb(192, 80, 77),
            Color.FromArgb(128, 128, 128)
        };

        public FormBaoCaoThongKe()
        {
            InitializeComponent();

            Load += FormBaoCaoThongKe_Load;
            btnXemThongKe.Click += btnXemThongKe_Click;
            picPieDichVu.Paint += picPieDichVu_Paint;
            picBarDoanhThu.Paint += picBarDoanhThu_Paint;
            picBarSoPhong.Paint += picBarSoPhong_Paint;
        }

        private void FormBaoCaoThongKe_Load(object? sender, EventArgs e)
        {
            try
            {
                using var db = new HotelManagementContext();
                var cacNgay = db.HoaDons
                    .AsNoTracking()
                    .Where(h => h.DaXoa != true && h.NgHd != null)
                    .Select(h => h.NgHd!.Value)
                    .ToList();

                if (cacNgay.Count > 0)
                {
                    dtpTuNgay.Value = cacNgay.Min();
                    dtpDenNgay.Value = cacNgay.Max();
                }
                else
                {
                    dtpTuNgay.Value = DateTime.Today.AddMonths(-1);
                    dtpDenNgay.Value = DateTime.Today;
                }
            }
            catch
            {
                dtpTuNgay.Value = DateTime.Today.AddMonths(-1);
                dtpDenNgay.Value = DateTime.Today;
            }

            XemThongKe();
        }

        private void btnXemThongKe_Click(object? sender, EventArgs e) => XemThongKe();

        private void XemThongKe()
        {
            DateTime tuNgay = dtpTuNgay.Value.Date;
            DateTime denNgay = dtpDenNgay.Value.Date;

            if (denNgay < tuNgay)
            {
                MessageBox.Show("Đến ngày phải lớn hơn hoặc bằng từ ngày.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime denNgayExclusive = denNgay.AddDays(1);

            try
            {
                using var db = new HotelManagementContext();

                var phieu = (from h in db.HoaDons.AsNoTracking()
                             join c in db.Ctdps on h.MaCtdp equals c.MaCtdp
                             join p in db.Phongs on c.MaPh equals p.MaPh
                             join l in db.LoaiPhongs on p.MaLph equals l.MaLph
                             where h.DaXoa != true
                                && h.NgHd >= tuNgay
                                && h.NgHd < denNgayExclusive
                             select new DongPhieu
                             {
                                 MaCtdp = c.MaCtdp,
                                 ThanhTien = c.ThanhTien ?? 0m,
                                 TenLph = l.TenLph
                             }).ToList();
                phieu = phieu.GroupBy(x => x.MaCtdp).Select(g => g.First()).ToList();

                var dichVu = (from h in db.HoaDons.AsNoTracking()
                              join c in db.Ctdps on h.MaCtdp equals c.MaCtdp
                              join v in db.Ctdvs on c.MaCtdp equals v.MaCtdp
                              join d in db.DichVus on v.MaDv equals d.MaDv
                              where h.DaXoa != true
                                 && h.NgHd >= tuNgay
                                 && h.NgHd < denNgayExclusive
                                 && v.DaXoa != true
                              select new DongDichVu
                              {
                                  TenDv = d.TenDv,
                                  Sl = v.Sl,
                                  Tien = v.ThanhTien ?? (v.Sl * d.DonGia)
                              }).ToList();

                decimal doanhThuPhong = phieu.Sum(x => x.ThanhTien);
                decimal doanhThuDichVu = dichVu.Sum(x => x.Tien);
                int soPhong = phieu.Count;

                lbKpiPhong.Text = DinhDangTien(doanhThuPhong);
                lbKpiDichVu.Text = DinhDangTien(doanhThuDichVu);
                lbKpiSoPhong.Text = soPhong.ToString();

                var theoLoaiPhong = phieu
                    .GroupBy(x => x.TenLph)
                    .Select(g => new
                    {
                        Ten = g.Key,
                        DoanhThu = g.Sum(x => x.ThanhTien),
                        SoLan = g.Count()
                    })
                    .OrderByDescending(x => x.DoanhThu)
                    .ToList();

                var topLoaiDT = theoLoaiPhong.FirstOrDefault();
                lbTopLoaiPhongDT.Text = topLoaiDT == null
                    ? "Loại phòng doanh thu cao nhất\nKhông có dữ liệu"
                    : "Loại phòng doanh thu cao nhất\n" + topLoaiDT.Ten
                        + " (" + DinhDangTien(topLoaiDT.DoanhThu) + ")";

                var topLoaiDat = theoLoaiPhong.OrderByDescending(x => x.SoLan).FirstOrDefault();
                lbTopLoaiPhongDat.Text = topLoaiDat == null
                    ? "Loại phòng được đặt nhiều nhất\nKhông có dữ liệu"
                    : "Loại phòng được đặt nhiều nhất\n" + topLoaiDat.Ten
                        + " (" + topLoaiDat.SoLan + " lượt)";

                var theoDichVu = dichVu
                    .GroupBy(x => x.TenDv)
                    .Select(g => new { Ten = g.Key, Tien = g.Sum(x => x.Tien) })
                    .OrderByDescending(x => x.Tien)
                    .FirstOrDefault();
                lbTopDichVu.Text = theoDichVu == null
                    ? "Dịch vụ doanh thu cao nhất\nKhông có dữ liệu"
                    : "Dịch vụ doanh thu cao nhất\n" + theoDichVu.Ten
                        + " (" + DinhDangTien(theoDichVu.Tien) + ")";

                _barDoanhThu = theoLoaiPhong
                    .Select(x => (x.Ten, x.DoanhThu))
                    .ToList();
                _barSoPhong = theoLoaiPhong
                    .OrderBy(x => x.Ten)
                    .Select(x => (x.Ten, (decimal)x.SoLan))
                    .ToList();

                _pieDichVu = dichVu
                    .GroupBy(x => x.TenDv)
                    .Select(g => (g.Key, g.Sum(x => x.Sl)))
                    .OrderByDescending(x => x.Item2)
                    .ToList();
                if (_pieDichVu.Count > 6)
                {
                    var khac = _pieDichVu.Skip(6).Sum(x => x.Item2);
                    _pieDichVu = _pieDichVu.Take(6).ToList();
                    _pieDichVu.Add(("Khác", khac));
                }

                picPieDichVu.Invalidate();
                picBarDoanhThu.Invalidate();
                picBarSoPhong.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lập báo cáo thống kê: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string DinhDangTien(decimal tien) => tien.ToString("N0") + " VND";

        private static string DinhDangTruc(decimal giaTri)
        {
            if (giaTri >= 1_000_000_000m)
                return (giaTri / 1_000_000_000m).ToString("0.#") + " tỷ";
            if (giaTri >= 1_000_000m)
                return (giaTri / 1_000_000m).ToString("0.#") + " tr";
            if (giaTri >= 1_000m)
                return (giaTri / 1_000m).ToString("0.#") + " K";
            return giaTri.ToString("0");
        }

        private void picPieDichVu_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var r = picPieDichVu.ClientRectangle;

            if (_pieDichVu.Count == 0 || _pieDichVu.Sum(x => x.SoLan) <= 0)
            {
                VeKhongCoDuLieu(g, r);
                return;
            }

            int le = 10;
            int duongKinh = Math.Min(r.Height - 2 * le, (int)(r.Width * 0.5));
            var hinhTron = new Rectangle(le, (r.Height - duongKinh) / 2, duongKinh, duongKinh);

            double tong = _pieDichVu.Sum(x => x.SoLan);
            float gocBatDau = 0f;
            var soLuongMau = new List<(Color Mau, string Nhan)>();
            for (int i = 0; i < _pieDichVu.Count; i++)
            {
                float goc = (float)(_pieDichVu[i].SoLan / tong * 360.0);
                var mau = MauBieuDo[i % MauBieuDo.Length];
                using var co = new SolidBrush(mau);
                g.FillPie(co, hinhTron, gocBatDau, goc);
                using var vien = new Pen(Color.White, 1.5f);
                g.DrawPie(vien, hinhTron, gocBatDau, goc);
                soLuongMau.Add((mau, _pieDichVu[i].Ten + " (" + _pieDichVu[i].SoLan + ")"));
                gocBatDau += goc;
            }

            int x = hinhTron.Right + 18;
            int y = le + 5;
            using var font = new Font("Microsoft Sans Serif", 9F);
            foreach (var (mau, nhan) in soLuongMau)
            {
                using var chuThich = new SolidBrush(mau);
                g.FillRectangle(chuThich, x, y + 4, 14, 14);
                using var chu = new SolidBrush(Color.FromArgb(60, 60, 60));
                g.DrawString(nhan, font, chu, x + 20, y);
                y += 26;
            }
        }

        private void picBarDoanhThu_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            VeBieuDoCot(e.Graphics, picBarDoanhThu.ClientRectangle,
                _barDoanhThu, Color.FromArgb(91, 155, 213), laTien: true);
        }

        private void picBarSoPhong_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            VeBieuDoCot(e.Graphics, picBarSoPhong.ClientRectangle,
                _barSoPhong, Color.FromArgb(179, 157, 219), laTien: false);
        }

        private void VeKhongCoDuLieu(Graphics g, Rectangle r)
        {
            using var font = new Font("Microsoft Sans Serif", 10F, FontStyle.Italic);
            using var chu = new SolidBrush(Color.Gray);
            using var dinhDang = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString("Không có dữ liệu trong khoảng thời gian này",
                font, chu, r, dinhDang);
        }

        private static void VeBieuDoCot(Graphics g, Rectangle r,
            List<(string Ten, decimal GiaTri)> duLieu, Color mau, bool laTien)
        {
            if (duLieu.Count == 0 || duLieu.All(x => x.GiaTri <= 0))
            {
                using var font = new Font("Microsoft Sans Serif", 10F, FontStyle.Italic);
                using var chu = new SolidBrush(Color.Gray);
                using var dinhDang = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                g.DrawString("Không có dữ liệu trong khoảng thời gian này",
                    font, chu, r, dinhDang);
                return;
            }

            const int leTrai = 78;
            const int lePhai = 18;
            const int leTren = 22;
            const int leDuoi = 48;
            int vungRong = r.Width - leTrai - lePhai;
            int vungCao = r.Height - leTren - leDuoi;
            if (vungRong <= 0 || vungCao <= 0) return;

            decimal giaTriLonNhat = duLieu.Max(x => x.GiaTri);
            const int soVach = 5;

            using var fontTruc = new Font("Microsoft Sans Serif", 8.5F);
            using var fontNhan = new Font("Microsoft Sans Serif", 9F);
            using var fontGiaTri = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Bold);
            using var butTruc = new Pen(Color.FromArgb(180, 180, 180), 1f);
            using var chuTruc = new SolidBrush(Color.FromArgb(90, 90, 90));

            using var dinhDangPhai = new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Center
            };
            using var dinhDangGiua = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Near
            };

            for (int i = 0; i <= soVach; i++)
            {
                decimal giaTri = giaTriLonNhat * i / soVach;
                int y = leTren + vungCao - (int)(vungCao * i / (double)soVach);
                g.DrawLine(butTruc, leTrai, y, leTrai + vungRong, y);

                string nhan = laTien ? DinhDangTruc(giaTri) : giaTri.ToString("0");
                g.DrawString(nhan, fontTruc, chuTruc,
                    new RectangleF(0, y - 9, leTrai - 8, 18), dinhDangPhai);
            }

            int khoangCach = vungRong / duLieu.Count;
            int doRongCot = Math.Max(18, Math.Min(70, (int)(khoangCach * 0.55)));

            using var co = new SolidBrush(mau);
            using var vienCot = new Pen(Color.FromArgb(70, 70, 70), 1f);

            for (int i = 0; i < duLieu.Count; i++)
            {
                int chieuCao = (int)Math.Round(vungCao * (double)(duLieu[i].GiaTri / giaTriLonNhat));
                int x = leTrai + i * khoangCach + (khoangCach - doRongCot) / 2;
                int y = leTren + vungCao - chieuCao;
                var cot = new Rectangle(x, y, doRongCot, chieuCao);
                g.FillRectangle(co, cot);
                g.DrawRectangle(vienCot, cot);

                string nhanGiaTri = laTien
                    ? duLieu[i].GiaTri.ToString("N0")
                    : duLieu[i].GiaTri.ToString("N0");
                g.DrawString(nhanGiaTri, fontGiaTri, chuTruc,
                    new RectangleF(x - 30, y - 18, doRongCot + 60, 16), dinhDangGiua);

                var vungNhan = new RectangleF(leTrai + i * khoangCach, leTren + vungCao + 6,
                    khoangCach, leDuoi - 8);
                using var dinhDangCat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Near,
                    FormatFlags = StringFormatFlags.NoWrap,
                    Trimming = StringTrimming.EllipsisCharacter
                };
                g.DrawString(duLieu[i].Ten, fontNhan, chuTruc, vungNhan, dinhDangCat);
            }

            g.DrawLine(new Pen(Color.FromArgb(140, 140, 140), 1.2f),
                leTrai, leTren + vungCao, leTrai + vungRong, leTren + vungCao);
        }
    }
}
