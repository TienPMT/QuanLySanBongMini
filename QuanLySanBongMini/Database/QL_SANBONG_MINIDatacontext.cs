using QuanLySanBongMini.Database.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.Database
{
    public class QL_SANBONG_MINIDatacontext : DbContext
    {
        public QL_SANBONG_MINIDatacontext() : base("Server= DESKTOP-S9NUQEL\\TIENPM; Database= QL_SANBONG_MINI1; User ID= sa; Password= 123")
        {

        }

        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<HoaDonDichVu> HoaDonDichVus { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<LoaiSan> LoaiSans { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhieuDatSan> PhieuDatSans { get; set; }
        public DbSet<SanBong> SanBongs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public DbSet<PhieuNhapHang> PhieuNhapHangs { get; set; }
    }
}

