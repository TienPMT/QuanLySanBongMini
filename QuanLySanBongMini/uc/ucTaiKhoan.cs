using System;
using System.Data.Entity;
using System.Drawing;
using System.IO; // Thư viện quan trọng
using System.Linq;
using System.Windows.Forms;
using QuanLySanBongMini.Database;

namespace QuanLySanBongMini
{
    public partial class ucTaiKhoan : UserControl
    {
        // Biến lưu mã NV để dùng lại
        private string _currentMaNV;

        public ucTaiKhoan()
        {
            InitializeComponent();
        }

        // Hàm này Main_Form sẽ gọi mỗi khi nhấn nút "Tài khoản"
        public void LoadByMaNV(string maNV)
        {
            _currentMaNV = maNV;
            txt_MaNV.Text = maNV;

            if (string.IsNullOrEmpty(maNV)) return;

            try
            {
                using (var db = new QL_SANBONG_MINIDatacontext())
                {
                    var nv = db.NhanViens
                               .AsNoTracking()
                               .Include(n => n.tencv)
                               .FirstOrDefault(n => n.manv == maNV);

                    if (nv == null) return;

                    // 1. Load thông tin chữ
                    txt_HoTen.Text = nv.hoten ?? "";
                    txt_SDT.Text = nv.sdt ?? "";
                    txt_ChucVu.Text = nv.tencv?.tencv ?? "";
                    txt_GioiTinh.Text = nv.gioitinh ?? "";

                    // 2. Load Hình Ảnh (An toàn)
                    LoadAvatarSafe(nv.HinhAnhNV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // --- HÀM LOAD ẢNH AN TOÀN (KHÔNG KHÓA FILE) ---
        private void LoadAvatarSafe(string tenFile)
        {
            // Reset ảnh cũ
            if (pic_NhanVien.Image != null)
            {
                pic_NhanVien.Image.Dispose();
                pic_NhanVien.Image = null;
            }

            if (string.IsNullOrEmpty(tenFile)) return;

            // Logic tìm đường dẫn (Ưu tiên thư mục bin/Debug)
            string baseDir = AppDomain.CurrentDomain.BaseDirectory; // bin/Debug
            string path1 = Path.Combine(baseDir, "Img", "NhanVien", tenFile);

            // Backup: Tìm lùi ra thư mục project (dành cho lúc Dev)
            string projectDir = Path.GetFullPath(Path.Combine(baseDir, @"..\..\"));
            string path2 = Path.Combine(projectDir, "Img", "NhanVien", tenFile);

            string finalPath = null;
            if (File.Exists(path1)) finalPath = path1;
            else if (File.Exists(path2)) finalPath = path2;

            if (finalPath != null)
            {
                try
                {
                    // QUAN TRỌNG: Dùng FileStream để đọc, sau đó đóng luồng ngay
                    using (FileStream fs = new FileStream(finalPath, FileMode.Open, FileAccess.Read))
                    {
                        pic_NhanVien.Image = Image.FromStream(fs);
                        pic_NhanVien.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch
                {
                    // Nếu ảnh lỗi thì bỏ qua, không crash
                }
            }
        }
    }
}