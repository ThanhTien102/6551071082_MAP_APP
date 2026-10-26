using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;

namespace LAB1.Models;

// File riêng để cấu hình kết nối, tránh mất cấu hình khi sinh lại Model.
public partial class HotelManagementContext
{
    private const string ConnectionString =
        "Server=.;Database=HotelManagement;Trusted_Connection=True;TrustServerCertificate=True;";

    public HotelManagementContext()
    {
    }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}
