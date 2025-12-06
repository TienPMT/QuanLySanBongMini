using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTOs
{
    public class PhieuDatSanDTO
    {
        public int MaPhieu { get; set; }
        public string MaKH { get; set; }
        public string MaNV { get; set; }
        public string MaSan { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianCaiDat { get; set; }
        public DateTime NgayDat { get; set; }
        public decimal TongTienSan { get; set; }
        public decimal TienCoc { get; set; }
        public string TrangThai { get; set; }
    }
}
