using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.Database.Entities
{
    [Table("LoaiSan")]
    public class LoaiSan
    {
        [Column("MALOAI"), Key]
        public string maloai { get; set;  }

        [Column("TENLOAI")]
        public string tenloai { get; set;  }

        [Column("DONGIA_GIO")]
        public decimal dongiagio {  get; set; }

        public override string ToString()
        {
            return tenloai;
        }
    }
}
