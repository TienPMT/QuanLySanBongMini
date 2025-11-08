using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.Database.Entities
{
    [Table("SanBong")]
    public class SanBong
    {
        [Column("MASAN"), Key]
        public string masan { get; set;  }

        [Column("TENSAN")]
        public string tensan { get; set;  }

        [Column("MALOAI"), ForeignKey("TenSan")]
        public string maloai { get; set;  }

        [Column("TINHTRANG")]
        public string tinhtrang { get; set; }

        public virtual LoaiSan TenSan { get; set; }
    }
}
