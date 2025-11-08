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
        public string manv { get; set; }

        [Column("HOTEN")]
        public string hoten { get; set; }

        [Column("GIOITINH")]
        public string gioitinh { get; set; }

        [Column("SDT")]
        public string sdt { get; set;  }

        [Column("MACV"), ForeignKey("tencv")]
        public int macv { get; set; }

        public virtual ChucVu tencv { get; set; }
    }
}
