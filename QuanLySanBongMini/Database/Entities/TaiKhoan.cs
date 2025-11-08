using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.Database.Entities
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        [Column("MANV"), ForeignKey("username")]
        public string manv { get; set;  }

        [Column("PASSWORD")]
        public string password { get; set;  }
        public virtual NhanVien username { get; set; }
    }
}
