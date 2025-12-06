using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using QuanLySanBongMini.Database;

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

            ClearData();

            if (string.IsNullOrEmpty(maNV)) return;

            try
            {
                using (var db = new QL_SANBONG_MINIDatacontext())
                {
                    var nv = db.NhanViens
                               .AsNoTracking()
                               .Include(n => n.tencv) // Đảm bảo load bảng liên kết ChucVu
                               .FirstOrDefault(n => n.manv == maNV);

                    if (nv == null)
                    {
                        MessageBox.Show($"Không tìm thấy nhân viên: {maNV}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    txt_HoTen.Text = nv.hoten ?? string.Empty;
                    txt_SDT.Text = nv.sdt ?? string.Empty;
                    txt_ChucVu.Text = nv.tencv?.tencv ?? string.Empty; // Null conditional operator
                    txt_GioiTinh.Text = nv.gioitinh ?? string.Empty;

                    
                    LoadEmployeeImage(nv.HinhAnhNV, maNV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SỬA: Thêm tham số hinhAnhNV từ database
        private void LoadEmployeeImage(string hinhAnhNV, string maNV)
        {
            if (pic_NhanVien.Image != null)
            {
                pic_NhanVien.Image.Dispose();
                pic_NhanVien.Image = null;
            }

            // Đường dẫn đến thư mục gốc của project
            string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\\"));
            // Danh sách các thư mục có thể chứa ảnh
            var folderCandidates = new List<string>
            {
                Path.Combine(projectRoot, "Images"),
                Path.Combine(projectRoot, "Img"),
                Path.Combine(projectRoot, "Img", "Nhân viên"),
                Path.Combine(projectRoot, "img")
            };

            // Các đuôi file hỗ trợ
            string[] extensions = { ".jpg", ".png", ".jpeg" };
            string imagePath = null;

            // ƯU TIÊN 1: Tìm theo tên file trong database (nếu có)
            if (!string.IsNullOrEmpty(hinhAnhNV))
            {
                string imageNameFromDB = Path.GetFileNameWithoutExtension(hinhAnhNV);
                
                foreach (var folder in folderCandidates)
                {
                    if (!Directory.Exists(folder)) continue;

                    foreach (var ext in extensions)
                    {
                        string fullPath = Path.Combine(folder, imageNameFromDB + ext);
                        if (File.Exists(fullPath))
                        {
                            imagePath = fullPath;
                            break;
                        }
                    }
                    if (imagePath != null) break;
                }
            }

            // ƯU TIÊN 2: Tìm theo mã nhân viên (fallback)
            if (imagePath == null)
            {
                foreach (var folder in folderCandidates)
                {
                    if (!Directory.Exists(folder)) continue;

                    foreach (var ext in extensions)
                    {
                        string fullPath = Path.Combine(folder, maNV + ext);
                        if (File.Exists(fullPath))
                        {
                            imagePath = fullPath;
                            break;
                        }
                    }
                    if (imagePath != null) break;
                }
            }

            // Nếu tìm thấy ảnh, tải ảnh. Ngược lại, set ảnh mặc định hoặc để trống.
            if (imagePath != null)
            {
                try
                {
                    // Sử dụng Image.FromFile để đơn giản hóa, hoặc giữ FileStream nếu cần tránh khóa file
                    pic_NhanVien.Image = Image.FromFile(imagePath);
                    pic_NhanVien.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu không thể tải ảnh
                    pic_NhanVien.Image = null;
                    pic_NhanVien.BackColor = Color.LightGray;
                    Console.WriteLine("Lỗi tải ảnh: " + ex.Message);
                }
            }
            else
            {
                // Nếu không tìm thấy ảnh nào -> Để trống hoặc set ảnh mặc định
                pic_NhanVien.Image = null;
                pic_NhanVien.BackColor = Color.LightGray;
                // pic_NhanVien.Image = Properties.Resources.DefaultUser; // Gợi ý: Nên có ảnh mặc định
            }
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