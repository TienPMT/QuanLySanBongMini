using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QuanLySanBongMini.Database;
// using QuanLySanBongMini.Database.Entities; // Bỏ nếu không dùng trực tiếp class Entities

namespace QuanLySanBongMini
{
    public partial class ucTaiKhoan : UserControl
    {
        public string MaNhanVienToLoad { get; set; }

        public ucTaiKhoan()
        {
            InitializeComponent();
        }

        private void ucTaiKhoan_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.MaNhanVienToLoad))
            {
                LoadByMaNV(this.MaNhanVienToLoad);
            }
        }

        public void LoadByMaNV(string maNV)
        {
            this.MaNhanVienToLoad = maNV;
            txt_MaNV.Text = maNV;

            // 1. Xóa trắng dữ liệu cũ trước khi load
            ClearData();

            if (string.IsNullOrEmpty(maNV)) return;

            try
            {
                using (var db = new QL_SANBONG_MINIDatacontext())
                {
                    // 2. Tối ưu truy vấn: Dùng AsNoTracking() vì chỉ đọc dữ liệu để hiển thị
                    var nv = db.NhanViens
                               .AsNoTracking()
                               .Include(n => n.tencv) // Đảm bảo load bảng liên kết ChucVu
                               .FirstOrDefault(n => n.manv == maNV);

                    if (nv == null)
                    {
                        MessageBox.Show($"Không tìm thấy nhân viên: {maNV}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // 3. Gán dữ liệu (Bỏ Reflection, gán trực tiếp)
                    txt_HoTen.Text = nv.hoten ?? string.Empty;
                    txt_SDT.Text = nv.sdt ?? string.Empty;
                    txt_ChucVu.Text = nv.tencv?.tencv ?? string.Empty; // Null conditional operator
                    txt_GioiTinh.Text = nv.gioitinh ?? string.Empty;

                    
                    // 4. Load ảnh
                    LoadEmployeeImage(maNV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadEmployeeImage(string maNV)
        {
            // 5. Giải phóng ảnh cũ để tránh tràn bộ nhớ
            if (pic_NhanVien.Image != null)
            {
                pic_NhanVien.Image.Dispose();
                pic_NhanVien.Image = null;
            }

            // Danh sách các thư mục có thể chứa ảnh
            var folderCandidates = new List<string>
            {
                Path.Combine(Application.StartupPath, "Images"),      // Ưu tiên thư mục chuẩn
                Path.Combine(Application.StartupPath, "Img", "Nhân viên"),
                Path.Combine(Application.StartupPath, "img")
            };

            // Các đuôi file hỗ trợ
            string[] extensions = { ".jpg", ".png", ".jpeg" };

            foreach (var folder in folderCandidates)
            {
                if (!Directory.Exists(folder)) continue;

                foreach (var ext in extensions)
                {
                    string fullPath = Path.Combine(folder, maNV + ext);
                    if (File.Exists(fullPath))
                    {
                        // 6. Dùng FileStream để KHÔNG khóa file ảnh trên ổ cứng
                        using (var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                        {
                            pic_NhanVien.Image = Image.FromStream(fs);
                            pic_NhanVien.SizeMode = PictureBoxSizeMode.Zoom;
                        }
                        return; // Tìm thấy và load xong thì thoát luôn
                    }
                }
            }

            // Nếu không tìm thấy ảnh nào -> Để trống hoặc set ảnh mặc định
            pic_NhanVien.Image = null;
            // pic_NhanVien.Image = Properties.Resources.DefaultUser; // Gợi ý: Nên có ảnh mặc định
        }

        private void ClearData()
        {
            txt_HoTen.Clear();
            txt_SDT.Clear();
            txt_ChucVu.Clear();
            txt_GioiTinh.Clear();
         
            if (pic_NhanVien.Image != null)
            {
                pic_NhanVien.Image.Dispose();
                pic_NhanVien.Image = null;
            }
        }
    }
}