using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.Database.Entities
{
    [Table("ChiTietHoaDon")]
    public class ChiTietHoaDon
    {
        [Column("MAHD", Order = 0), Key, ForeignKey("hoadon")]
        public int mahd { get; set; }

        [Column("MASP", Order = 1), Key, ForeignKey("sanpham")]
        public string masp { get; set; }

        [Column("SOLUONG")]
        public int soluong { get; set; }

        [Column("DONGIA")]
        public decimal dongia { get; set; }

        public virtual HoaDonDichVu hoadon { get; set; }

        public virtual SanPham sanpham {  get; set; }
    }
}
