using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTOs
{
    public class ThongKeHoaDonDTO
    {
        public DateTime NgayLap { get; set; }
        public string HoTenKhachHang { get; set; }
        public int MaPhieuDatSan { get; set; }
        public string MaSan { get; set; }
        public decimal TongTien { get; set; }
    }
}
