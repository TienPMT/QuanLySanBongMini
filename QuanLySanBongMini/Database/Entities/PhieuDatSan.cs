using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.Database.Entities
{
    [Table("PhieuDatSan")]
    public class PhieuDatSan
    {
        [Column("MAPHIEU"), Key]
        public int maphieu { get; set; }

        [Column("MAKH"), ForeignKey("tenkh")]
        public string makh { get; set;  }

        [Column("MANV"), ForeignKey("tennv")]
        public string manv { get; set; }

        [Column("MASAN"), ForeignKey("sanbong")]
        public string masan { get; set;  }

        [Column("THOIGIANBATDAU")]
        public DateTime thoigianbatdau { get; set; }

        [Column("THOIGIANCAIDAT")]
        public DateTime thoigiancaidat { get; set; }

        [Column("NGAYDAT")]
        public DateTime ngaydat { get; set; }

        [Column("TONGTIENSAN")]
        public decimal tongtiensan {  get; set; }

        [Column("TIENCOC")]
        public decimal tiencoc {  get; set; }

        [Column("TRANGTHAI")]
        public string trangthai {  get; set; }

        public virtual KhachHang tenkh { get; set; }

        public virtual NhanVien tennv { get; set;  }
        
        public virtual SanBong sanbong { get; set; }
    }
}
