
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LAB1.DangNhap;

namespace LAB1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            HienThiThongTinNguoiDung();

            Load += FormMain_Load;

            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            btnTrangChu.Click += btnTrangChu_Click;
            btnSoDoPhong.Click += btnSoDoPhong_Click;
            btnQuanLyPhong.Click += btnQuanLyPhong_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button9.Click += button9_Click;
            button10.Click += button10_Click;
            button11.Click += button11_Click;
            button12.Click += button12_Click;
            button13.Click += button13_Click;
        }

        private void linkLabel1_LinkClicked(
            object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show(
                "Bạn có chắc muốn đăng xuất?",
                "Đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            Hide();

            using (var formLogin = new FormDangNhap())
            {
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    HienThiThongTinNguoiDung();
                    HienThiTrangChu();
                    Show();
                }
                else
                {
                    Close();
                }
            }
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HienThiTrangChu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formCon = new LAB1.TaiKhoan.FormDanhSachTaiKhoan();

            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;

            XoaNoiDungPanelMain();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadFormCon(new LAB1.LoaiPhong.FormDanhSachLoaiPhong());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadFormCon(new LAB1.NhanVien.FormDanhSachNhanVien());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadFormCon(new LAB1.KhachHang.FormDanhSachKhachHang());
        }

        private void btnQuanLyPhong_Click(object sender, EventArgs e)
        {
            LoadFormCon(new LAB1.Phong.FormDanhSachPhong());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            LoadFormCon(new LAB1.TienNghi.FormDanhSachTienNghi());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            LoadFormCon(new LAB1.DichVu.FormDanhSachDichVu());
        }

        private void btnSoDoPhong_Click(object sender, EventArgs e)
        {
            Form formCon = new LAB1.SoDoPhong.FormSoDoPhong();

            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;

            panelMain.Controls.Clear();
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LoadFormCon(new LAB1.PhieuThue.FormDanhSachPhieuThue());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LoadFormCon(new LAB1.HoaDon.FormDanhSachHoaDon());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            LoadFormCon(new LAB1.ThongKe.FormBaoCaoThongKe());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            HienThiTrangChu();
        }

        private void HienThiThongTinNguoiDung()
        {
            lblTenNguoiDung.Text = FormDangNhap.TenNV_DangNhap;
            lblTenNguoiDung.Left =
                (panel2.Width - lblTenNguoiDung.PreferredWidth) / 2;
        }

        private void XoaNoiDungPanelMain()
        {
            foreach (Control c in panelMain.Controls.Cast<Control>().ToList())
            {
                panelMain.Controls.Remove(c);
                c.Dispose();
            }
        }

        private void LoadFormCon(Form formCon)
        {
            XoaNoiDungPanelMain();
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            panelMain.Controls.Add(formCon);
            formCon.Show();
        }

        private void LoadUserControl(UserControl uc)
        {
            XoaNoiDungPanelMain();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
            uc.BringToFront();
        }

        private void HienThiTrangChu()
        {
            if (panelMain.Controls.Count == 1 && panelMain.Controls[0] is FormTrangChu)
                return;

            LoadUserControl(new FormTrangChu());
        }

        private void HienThiDangPhatTrien(string tenChucNang)
        {
            XoaNoiDungPanelMain();

            panelMain.Controls.Add(new Label
            {
                Dock = DockStyle.Fill,
                Text = tenChucNang + Environment.NewLine
                    + "(chức năng đang được xây dựng)",
                Font = new Font(
                    "Microsoft Sans Serif", 16F, FontStyle.Italic),
                ForeColor = Color.DarkCyan,
                TextAlign = ContentAlignment.MiddleCenter
            });
        }
    }
}
