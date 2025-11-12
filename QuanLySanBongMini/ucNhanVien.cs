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
                dsNhanVien = await db.NhanViens

                    .Select(nv => new NhanVienDTO()
                    {
                        MaNhanVien = nv.manv,
                        HoTenNhanVien = nv.hoten,
                        GioiTinh = nv.gioitinh,
                        NgaySinh = nv.ngaysinh,
                        LuongCB = nv.luongcb,
                        Email = nv.email,
                        SDT = nv.sdt,
                        ChucVu = nv.tencv.tencv
                    }).ToListAsync();

                if (dsNhanVien == null || dsNhanVien.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu nhân viên!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            gridQuanLyNhanVien.DataSource = dsNhanVien;
            gridQuanLyNhanVien.ClearSelection();
            
        }

        private void gridQuanLyNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridQuanLyNhanVien.SelectedCells.Count > 0)
            {
                DataGridViewRow selected = gridQuanLyNhanVien.SelectedRows[0];

                string MaNV= selected.Cells["MaNhanVien"].Value.ToString();
                string HoTen= selected.Cells["HoTen"].Value.ToString();
                string GioiTinh = selected.Cells["GioiTinh"].Value.ToString();
                string NgaySinh = selected.Cells["NgaySinh"].Value.ToString();
                string Email = selected.Cells["Email"].Value.ToString();
                string SoDienThoai = selected.Cells["SDT"].Value.ToString();
                string ChucVu = selected.Cells["ChucVu"].Value.ToString();

                object LuongCoBan = selected.Cells["LuongCB"].Value;
                decimal luong = Convert.ToDecimal(LuongCoBan);


                txtMaNV.Text = MaNV;
                txtHoTen.Text = HoTen;
                txtGioiTinh.Text = GioiTinh;
                txtNgaySinh.Text = NgaySinh;
                txtEmail.Text = Email;
                txtSoDienThoai.Text = SoDienThoai;
                txtLuongCoBan.Text = luong.ToString("F0");
                txtChucVu.Text = ChucVu;
            }
        }
    }
}

