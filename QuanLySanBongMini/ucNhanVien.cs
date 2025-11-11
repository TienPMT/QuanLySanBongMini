using QuanLySanBongMini.Database;
using QuanLySanBongMini.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini
{
    public partial class ucNhanVien : UserControl
    {
        public ucNhanVien()
        {
            InitializeComponent();
        }

        private async void ucNhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVienDTO> dsNhanVien;
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                dsNhanVien = await db.NhanViens.Select(nv => new NhanVienDTO()
                {
                    MaNhanVien = nv.manv,
                    HoTenNhanVien = nv.hoten,
                    GioiTinh = nv.gioitinh,
                    SDT = nv.sdt,
                    ChucVu = nv.tencv.tencv
                }).ToListAsync();
            }

            QuanLyNhanVienReport src = new QuanLyNhanVienReport();
            src.SetDataSource(dsNhanVien);

            srcQuanLyNhanVien.ReportSource = src;
        }
    }
}
