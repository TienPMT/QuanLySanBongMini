using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.Database.Entities
{
    [Table("ChucVu")]
    public class ChucVu
    {
        [Column("MACV"), Key]
        public int macv { get; set;  }

        [Column("TENCV")]
        public string tencv { get; set;  }
    }
}
