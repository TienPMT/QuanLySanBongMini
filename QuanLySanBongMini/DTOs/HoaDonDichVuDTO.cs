using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTOs
{
    public class HoaDonDichVuDTO
    {
        public int MaHD { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayLap { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }
    }
}
