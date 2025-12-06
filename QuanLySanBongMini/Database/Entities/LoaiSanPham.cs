using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.Database.Entities
{
    [Table("LoaiSanPham")]
    public class LoaiSanPham
    {
        [Column("MALOAI"),Key]
        public int maloaisp { get; set; }
        [Column("TENLOAI")]
        public string tenloaisp { get; set; }
    }
}
