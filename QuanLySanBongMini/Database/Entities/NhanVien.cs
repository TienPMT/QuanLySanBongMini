using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.Database.Entities
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Column("MANV"), Key]
        [Required]
        public string manv { get; set; }

        [Column("HOTEN")]
        [Required]
        public string hoten { get; set; }

        [Column("GIOITINH")]
        [Required]
        public string gioitinh { get; set; }

        [Column("NGAYSINH")]
        public DateTime ngaysinh { get; set; }

        [Column("SDT")]
        [Required]
        public string sdt { get; set; }

        [Column("LUONG_CO_BAN")]
        public decimal luongcb { get; set;  }

        [Column("EMAIL")]
        public string email { get; set;  }

        [Column("MACV"), ForeignKey("tencv")]
        [Required]
        public int macv { get; set; }

        [Column("HINHANH_NV")]
        public string HinhAnhNV { get; set; }

        public virtual ChucVu tencv { get; set; }
    }
}