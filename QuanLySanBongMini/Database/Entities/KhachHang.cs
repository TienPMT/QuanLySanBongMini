using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.Database.Entities
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Column("MAKH"), Key]
        public string makh { get; set; }

        [Column("HOTEN")]
        public string hoten { get; set; }

        [Column("GIOITINH")]
        public string gioitinh { get; set;  }

        [Column("SDT")]
        public string SDT { get; set; }
    }
}
