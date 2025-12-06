using QuanLySanBongMini.Database;
using QuanLySanBongMini.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini
{
    
    public partial class ucBanHang : UserControl
    {
        // Context kết nối CSDL
        QL_SANBONG_MINIDatacontext db = new QL_SANBONG_MINIDatacontext();

        // List lưu giỏ hàng tạm thời
        List<CartItem> gioHang = new List<CartItem>();

        // Mã nhân viên đang thao tác (được truyền từ Main_Form)
        private string _maNV = "NV001";

        // QR settings
        private string baseQrUrl = "https://api.vietqr.io/image/970422-0376512878-1bFsY0C.jpg?amount={0}&addInfo={1}"; // MB Bank, tài khoản 0376512878

        public ucBanHang()
        {
            InitializeComponent();
        }

        // Hàm để Main_Form gọi, truyền mã nhân viên vào
        public void SetNhanVien(string maNV)
        {
            _maNV = maNV;
        }

        // Hàm load lại dữ liệu (Refresh)
        public void ReloadData()
        {
            LoadSanPhamLenGiaoDien();
        }

        private void ucBanHang_Load(object sender, EventArgs e)
        {
            // Cấu hình DataGridView không tự sinh cột rác
            gridGioHang.AutoGenerateColumns = false;

            // Map dữ liệu vào các cột (Đảm bảo propertyName khớp class CartItem)
            if (gridGioHang.Columns["TenSP"] != null) gridGioHang.Columns["TenSP"].DataPropertyName = "TenSP";
            if (gridGioHang.Columns["SoLuong"] != null) gridGioHang.Columns["SoLuong"].DataPropertyName = "SoLuong";
            if (gridGioHang.Columns["DonGia"] != null) gridGioHang.Columns["DonGia"].DataPropertyName = "DonGia";
            if (gridGioHang.Columns["ThanhTien"] != null) gridGioHang.Columns["ThanhTien"].DataPropertyName = "ThanhTien";

            // Sự kiện nút
            btn_Mua.Click += Btn_Mua_Click;
            btn_Huy.Click += Btn_Huy_Click;

            LoadSanPhamLenGiaoDien();
        }

        // ================== 1. HIỂN THỊ CARD SẢN PHẨM ==================
        private void LoadSanPhamLenGiaoDien()
        {
            // Reset các panel chứa card
            flp_DoUong.Controls.Clear();
            flp_DoAn.Controls.Clear();
            flp_DoDung.Controls.Clear();

            // Refresh lại context để lấy số tồn kho mới nhất
            using (var freshDb = new QL_SANBONG_MINIDatacontext())
            {
                var listSP = freshDb.SanPhams.ToList();

                foreach (var sp in listSP)
                {
                    Panel card = TaoCardSanPham(sp);

                    // Phân loại vào Tab tương ứng dựa trên LoaiSP (1, 2, 3)
                    if (sp.loaiSP == 1) flp_DoUong.Controls.Add(card);
                    else if (sp.loaiSP == 2) flp_DoAn.Controls.Add(card);
                    else if (sp.loaiSP == 3) flp_DoDung.Controls.Add(card);
                }
            }
        }

        private Panel TaoCardSanPham(SanPham sp)
        {
            // 1. Panel Card
            Panel pnl = new Panel();
            pnl.Size = new Size(160, 220);
            pnl.Margin = new Padding(10);
            pnl.BorderStyle = BorderStyle.FixedSingle;

            bool hetHang = sp.soluongton <= 0;
            pnl.BackColor = hetHang ? Color.LightGray : Color.White;

            // 2. Hình ảnh
            PictureBox pb = new PictureBox();
            pb.Size = new Size(140, 120);
            pb.Location = new Point(10, 10);
            pb.SizeMode = PictureBoxSizeMode.Zoom;


            LoadProductImage(pb, sp.HinhAnhSP);

            // Nếu hết hàng thì hiện nhãn đè lên
            if (hetHang)
            {
                Label lblOut = new Label();
                lblOut.Text = "HẾT HÀNG";
                lblOut.ForeColor = Color.White;
                lblOut.BackColor = Color.Red;
                lblOut.AutoSize = true;
                lblOut.Location = new Point(35, 50);
                pb.Controls.Add(lblOut);
            }
            else
            {
                // Chỉ gán sự kiện click nếu còn hàng
                pb.Click += (s, e) => ThemVaoGio(sp);
                pnl.Click += (s, e) => ThemVaoGio(sp);
            }

            // 3. Tên SP
            Label lblTen = new Label();
            lblTen.Text = sp.tensp;
            lblTen.Location = new Point(5, 135);
            lblTen.Size = new Size(150, 30);
            lblTen.Font = new Font("Arial", 9, FontStyle.Bold);
            lblTen.TextAlign = ContentAlignment.MiddleCenter;

            // 4. Giá
            Label lblGia = new Label();
            lblGia.Text = string.Format("{0:N0} VNĐ", sp.dongiaban);
            lblGia.Location = new Point(5, 165);
            lblGia.Size = new Size(150, 30);
            lblGia.Font = new Font("Arial", 9, FontStyle.Bold);
            lblGia.ForeColor = Color.Red;
            lblGia.TextAlign = ContentAlignment.MiddleCenter;

            // 5. Tồn kho
            Label lblTon = new Label();
            lblTon.Text = "Kho: " + sp.soluongton;
            lblTon.Location = new Point(5, 200);
            lblTon.Size = new Size(150, 15);
            lblTon.Font = new Font("Arial", 8, FontStyle.Italic);
            lblTon.TextAlign = ContentAlignment.MiddleCenter;

            pnl.Controls.Add(pb);
            pnl.Controls.Add(lblTen);
            pnl.Controls.Add(lblGia);
            pnl.Controls.Add(lblTon);

            return pnl;
        }

        private void LoadProductImage(PictureBox pb, string hinhAnhSP)
        {
            // Đường dẫn đến thư mục gốc của project
            string projectRoot = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\"));
            // Danh sách các thư mục có thể chứa ảnh
            var folderCandidates = new List<string>
            {
                Path.Combine(projectRoot, "Images"),
                Path.Combine(projectRoot, "Img"),
                Path.Combine(projectRoot, "Img", "Sản phẩm"),
                Path.Combine(projectRoot, "img")
            };

            // Nếu không có tên file trong database, dùng no-image
            string imageName = string.IsNullOrEmpty(hinhAnhSP) ? "no-image" : Path.GetFileNameWithoutExtension(hinhAnhSP);

            // Các đuôi file hỗ trợ
            string[] extensions = { ".jpg", ".png", ".jpeg", ".gif" };
            string imagePath = null;

            foreach (var folder in folderCandidates)
            {
                if (!Directory.Exists(folder)) continue;

                foreach (var ext in extensions)
                {
                    string fullPath = Path.Combine(folder, imageName + ext);
                    if (File.Exists(fullPath))
                    {
                        imagePath = fullPath;
                        break;
                    }
                }
                if (imagePath != null) break;
            }

            if (imagePath != null)
            {
                try
                {
                    // Sử dụng Image.FromFile để đơn giản hóa, hoặc giữ FileStream nếu cần tránh khóa file
                    pb.Image = Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    pb.BackColor = Color.LightGray;
                    pb.Image = null;
                    Console.WriteLine("Lỗi tải ảnh: " + ex.Message);
                }
            }
            else
            {
                // Nếu không tìm thấy, hiển thị màu nền thay thế
                pb.BackColor = Color.LightGray;
                pb.Image = null;
            }
        }

        // ================== 2. XỬ LÝ GIỎ HÀNG ==================
        private void ThemVaoGio(SanPham sp)
        {
            var item = gioHang.FirstOrDefault(x => x.MaSP == sp.masp);

            if (item != null)
            {
                if (item.SoLuong + 1 > sp.soluongton)
                {
                    MessageBox.Show("Số lượng trong kho không đủ!", "Cảnh báo");
                    return;
                }
                item.SoLuong++;
            }
            else
            {
                gioHang.Add(new CartItem
                {
                    MaSP = sp.masp,
                    TenSP = sp.tensp,
                    DonGia = sp.dongiaban,
                    SoLuong = 1,
                    SoLuongTonKho = sp.soluongton
                });
            }
            CapNhatGridGioHang();
        }

        private void CapNhatGridGioHang()
        {
            gridGioHang.DataSource = null;
            gridGioHang.DataSource = gioHang;

            // Cập nhật số thứ tự
            for (int i = 0; i < gridGioHang.Rows.Count; i++)
            {
                gridGioHang.Rows[i].Cells["STT"].Value = (i + 1).ToString();
            }

            decimal tong = gioHang.Sum(x => x.ThanhTien);
            txt_TongThanhToan.Text = string.Format("{0:N0} VNĐ", tong);
        }

        private void Btn_Huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa giỏ hàng?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gioHang.Clear();
                CapNhatGridGioHang();
            }
        }

        // ================== 3. THANH TOÁN (MUA) ==================
        private void Btn_Mua_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0) return;

            // Validate mã nhân viên trước khi thực hiện
            if (string.IsNullOrEmpty(_maNV))
            {
                MessageBox.Show("Mã nhân viên chưa được thiết lập. Vui lòng đăng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chọn phương thức thanh toán
            string message = "Chọn phương thức thanh toán:\n- Tiền mặt: Nhấn OK\n- Chuyển khoản: Nhấn Cancel";
            DialogResult choice = MessageBox.Show(message, "Phương thức thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            bool isTienMat = (choice == DialogResult.OK);
            bool isChuyenKhoan = (choice == DialogResult.Cancel);

            if (!isTienMat && !isChuyenKhoan)
            {
                return; // User closed without choosing
            }

            decimal tongTien = gioHang.Sum(x => x.ThanhTien);
            string trangThai = isTienMat ? "Đã thanh toán" : "Chờ thanh toán";

            try
            {
                using (var transactionDb = new QL_SANBONG_MINIDatacontext())
                {
                    // Kiểm tra mã nhân viên tồn tại
                    var nhanVien = transactionDb.NhanViens.FirstOrDefault(nv => nv.manv == _maNV);
                    if (nhanVien == null)
                    {
                        MessageBox.Show("Mã nhân viên không tồn tại trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // A. Tạo hóa đơn
                    HoaDonDichVu hd = new HoaDonDichVu();
                    hd.manv = _maNV;
                    hd.ngaylap = DateTime.Now;
                    hd.tongtien = tongTien;
                    hd.trangthai = trangThai;

                    transactionDb.HoaDonDichVus.Add(hd);
                    transactionDb.SaveChanges(); // Lưu để lấy ID tự tăng (MAHD)

                    // B. Lưu chi tiết & Trừ kho
                    string noiDungHoaDon = $"HÓA ĐƠN #{hd.mahd}\nNV: {_maNV}\n------------------\n";

                    foreach (var item in gioHang)
                    {
                        // Lưu chi tiết
                        ChiTietHoaDon ct = new ChiTietHoaDon();
                        ct.mahd = hd.mahd;
                        ct.masp = item.MaSP;
                        ct.soluong = item.SoLuong;
                        ct.dongia = item.DonGia;
                        transactionDb.ChiTietHoaDons.Add(ct);

                        // Trừ kho
                        var spDb = transactionDb.SanPhams.FirstOrDefault(p => p.masp == item.MaSP);
                        if (spDb != null)
                        {
                            if (spDb.soluongton < item.SoLuong)
                            {
                                throw new Exception($"Sản phẩm {item.TenSP} không đủ hàng trong kho.");
                            }
                            spDb.soluongton -= item.SoLuong;
                        }
                        else
                        {
                            throw new Exception($"Không tìm thấy sản phẩm {item.TenSP} trong kho.");
                        }

                        noiDungHoaDon += $"{item.TenSP} x{item.SoLuong} = {item.ThanhTien:N0}\n";
                    }

                    transactionDb.SaveChanges(); // Commit tất cả thay đổi

                    // C. Xử lý theo phương thức
                    noiDungHoaDon += "------------------\n";
                    noiDungHoaDon += $"TỔNG: {hd.tongtien:N0} VNĐ";

                    if (isTienMat)
                    {
                        // In hóa đơn ngay
                        InHoaDon(noiDungHoaDon, (int)hd.mahd);
                    }
                    else if (isChuyenKhoan)
                    {
                        // Hiển thị QR trong 30s
                        HienThiQRChuyenKhoan((int)hd.mahd, tongTien, noiDungHoaDon, transactionDb);
                    }

                    // D. Reset
                    gioHang.Clear();
                    CapNhatGridGioHang();
                    LoadSanPhamLenGiaoDien(); // Vẽ lại card để cập nhật màu xám cho món hết hàng
                }
            }
            catch (Exception ex)
            {
                // Log inner exception để debug (có thể hiển thị chi tiết hơn trong development)
                string innerError = ex.InnerException != null ? $"\nChi tiết: {ex.InnerException.Message}" : "";
                MessageBox.Show($"Lỗi thanh toán: {ex.Message}{innerError}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InHoaDon(string noiDung, int maHD)
        {
            // Giả sử in hóa đơn bằng MessageBox (có thể thay bằng PrintDocument sau)
            MessageBox.Show(noiDung + "\n\n(Đã in hóa đơn thành công!)", $"In hóa đơn {maHD}");
        }

        private void HienThiQRChuyenKhoan(int maHD, decimal amount, string noiDungHoaDon, QL_SANBONG_MINIDatacontext dbContext)
        {
            // Tạo form hiển thị QR
            Form qrForm = new Form();
            qrForm.Text = $"QR Chuyển khoản - Hóa đơn {maHD}";
            qrForm.Size = new Size(400, 500);
            qrForm.StartPosition = FormStartPosition.CenterParent;
            qrForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            qrForm.MaximizeBox = false;
            qrForm.MinimizeBox = false;

            // PictureBox cho QR
            PictureBox pbQR = new PictureBox();
            pbQR.Size = new Size(300, 300);
            pbQR.Location = new Point(50, 20);
            pbQR.SizeMode = PictureBoxSizeMode.Zoom;
            pbQR.BorderStyle = BorderStyle.FixedSingle;

            // Label thông tin
            Label lblInfo = new Label();
            lblInfo.Text = $"Quét QR để chuyển {amount:N0} VNĐ\nThời gian: 30 giây";
            lblInfo.Location = new Point(50, 330);
            lblInfo.Size = new Size(300, 40);
            lblInfo.TextAlign = ContentAlignment.MiddleCenter;
            lblInfo.Font = new Font("Arial", 10, FontStyle.Bold);

            // ProgressBar cho countdown (optional)
            ProgressBar progress = new ProgressBar();
            progress.Location = new Point(50, 380);
            progress.Size = new Size(300, 20);
            progress.Maximum = 30;
            progress.Value = 30;

            qrForm.Controls.Add(pbQR);
            qrForm.Controls.Add(lblInfo);
            qrForm.Controls.Add(progress);

            // Tạo QR URL
            string addInfo = Uri.EscapeDataString($"Thanh toán hóa đơn {maHD} - Quản lý sân bóng mini");
            string qrUrl = string.Format(baseQrUrl, amount.ToString("N0").Replace(",", ""), addInfo);
            pbQR.ImageLocation = qrUrl;
            pbQR.LoadCompleted += (s, e) => { /* QR loaded */ };

            // Timer cho 30s (sử dụng System.Windows.Forms.Timer)
            int timeLeft = 30;
            System.Windows.Forms.Timer uiTimer = new System.Windows.Forms.Timer();
            uiTimer.Interval = 1000;
            uiTimer.Tick += (s, e) =>
            {
                timeLeft--;
                lblInfo.Text = $"Quét QR để chuyển {amount:N0} VNĐ\nThời gian còn lại: {timeLeft} giây";
                progress.Value = Math.Max(0, timeLeft);
                if (timeLeft <= 0)
                {
                    uiTimer.Stop();
                    qrForm.Close();
                }
            };
            uiTimer.Start();

            // Event khi form close
            qrForm.FormClosed += (s, e) =>
            {
                uiTimer.Stop();
                // Cập nhật trạng thái hóa đơn thành "Đã thanh toán"
                var hd = dbContext.HoaDonDichVus.FirstOrDefault(h => h.mahd == maHD);
                if (hd != null)
                {
                    hd.trangthai = "Đã thanh toán";
                    dbContext.SaveChanges();
                }
                // In hóa đơn
                InHoaDon(noiDungHoaDon, maHD);
            };

            qrForm.ShowDialog(this);
        }
    }
}