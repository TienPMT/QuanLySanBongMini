using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanBongMini.DTOs
{
    public class NhanVienDTO
    {
        public string MaNhanVien { get; set; }
        public string HoTenNhanVien { get; set;  }
        public string GioiTinh { get; set;  }

        public DateTime NgaySinh { get; set; }
        public string SDT { get; set;  }
        public decimal LuongCB { get; set;  }
        public string Email { get; set;  }
        public int MaChucVu { get; set;  }
        public string TenChucVu { get; set;  }
    }
}
