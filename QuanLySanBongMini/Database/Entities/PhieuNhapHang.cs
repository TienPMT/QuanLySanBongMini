using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.Database.Entities
{
    [Table("PhieuNhapHang")]
    public class PhieuNhapHang
    {
        [Column("MAPN"), Key]
        public int MaPN { get; set; }
        [Column("MANV"), ForeignKey("nhanvien")]
        public string MaNV { get; set; }
        [Column("NGAYNHAP")]
        public DateTime NgayNhap{ get; set; }
        [Column("TONGTIEN_NHAP")]
        public decimal TongTIen { get; set; }

        public virtual NhanVien nhanvien { get; set; }
    }
}
