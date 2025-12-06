using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.Database.Entities
{
    [Table("ChiTietPhieuNhap")]
    public class ChiTietPhieuNhap
    {
        [Column("MAPN"), Key]
        public int MaPN { get; set; }
        [Column("MASP"), ForeignKey("sanpham")]
        public string MaSP { get; set; }
        [Column("SOLUONG")]
        public int SoLuong { get; set; }
        [Column("DONGIA_NHAP")]
        public decimal DonGia { get; set; }

        public virtual SanPham sanpham { get; set; }
    }
}
