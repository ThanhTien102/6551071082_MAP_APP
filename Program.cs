
using System;
using System.Windows.Forms;
using LAB1.DangNhap;

namespace LAB1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (var formDangNhap = new FormDangNhap())
            {
                if (formDangNhap.ShowDialog() != DialogResult.OK)
                    return;
            }

            Application.Run(new FormMain());
        }
    }
}
