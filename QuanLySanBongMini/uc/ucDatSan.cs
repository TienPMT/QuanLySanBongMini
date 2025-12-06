using QuanLySanBongMini.Database;
using QuanLySanBongMini.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace QuanLySanBongMini
{
    public partial class ucDatSan : UserControl
    {
        // Mã nhân viên đã đăng nhập
        public string MaNV_logged;
        //khởi tạo biến lock semaphore
        SemaphoreSlim _lock = new SemaphoreSlim(1, 1);

        //Khởi tạo biến chứa ảnh của sân 5 và sân 7
        static int thumbWidth = 100;
        static int thumbHeight = 70;
        ImageList imglst = new ImageList();

        //Khởi tạo biến để load vào combobox
        List<int> GioChoi = new List<int>() { 30, 60, 90, 120, 150, 180, 210, 240, 270, 300, 330, 360 };

        public ucDatSan()
        {
            InitializeComponent();
        }

        public ucDatSan(string maNhanVien): this()
        {
            MaNV_logged = maNhanVien;
        }

        private async Task<(int maphieu, string makh, string masan,DateTime ngaybatdau, 
            DateTime ngayhientai, DateTime ngaycaidat, int thoigianchoi, double tongtien,
            double tiencoc, string trangthai, bool isValid)> 
            getInput()
        {
            //Khởi tạo tên biến và gán giá trị
            int maphieu = 0;
            string strMaPhieu = txtMaPhieuDat.Text;
            if (!string.IsNullOrEmpty(strMaPhieu))
            {
                maphieu = int.Parse(strMaPhieu);
            }

            string sdt = txtSDTKH.Text.Trim();
            string masan = txtMaSan.Text.Trim();
            int thoigianchoi = int.Parse(cbbGioChoi.Text);
            string makh = string.Empty;

            DateTime ngaybatdau = dtpNgayDat.Value.Date;
            ngaybatdau = ngaybatdau.Date.AddHours(dtpGioDat.Value.Hour).AddMinutes(dtpGioDat.Value.Minute);
            DateTime ngayhientai = DateTime.Now;
            DateTime ngaycaidat = ngaybatdau.AddMinutes(thoigianchoi);

            double tongtien = 0;

            double tiencoc = 0;
            double tiencoctmp = 0;
            bool tiencocisnotnull = double.TryParse(txtTienCoc.Text, out tiencoctmp);
            
            string trangthai = cbbTrangThai.Text.Trim();

            bool isValid = true;
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                await _lock.WaitAsync();

                KhachHang khachHang = await db.KhachHangs.FirstOrDefaultAsync(k => k.SDT == sdt);
                if(khachHang == null)
                {
                    MessageBox.Show("Khách hàng chưa được đăng ký");
                    isValid = false;
                }
                else
                {
                    makh = khachHang.makh;
                }

                //lấy thông tin sân bóng
                SanBong sanbong = await db.SanBongs.FirstOrDefaultAsync(s=>s.masan == masan);

                //Check xung đột giờ đặt sân
                if (await isConflict(ngaybatdau,ngaycaidat,masan))
                {
                    isValid = false;
                }
                else if (sanbong == null)
                {
                    //Xử lý sân bóng
                    MessageBox.Show("Sân bóng không tồn tại");
                    isValid = false;
                }
                else if (string.IsNullOrEmpty(sdt))
                {
                    //Xử lý số điện thoại của khách hàng
                    MessageBox.Show("Không được để trống số điện thoại");
                    isValid = false;
                }
                else if (string.IsNullOrEmpty(masan))
                {
                    //Xử lý mã sân
                    MessageBox.Show("Vui lòng chọn sân đăng ký bên phải");
                    isValid = false;
                }
                else if (thoigianchoi < 0)
                {
                    //Xử lý thời gian chơi
                    MessageBox.Show("Vui lòng chọn thời gian chơi");
                    isValid = false;
                }
                else if (tiencocisnotnull)
                {
                    //Xử lý tiền cọc
                    tiencoc += tiencoctmp;
                }
                else if (string.IsNullOrEmpty(trangthai))
                {
                    //Xử lý trạng thái
                    MessageBox.Show("Vui lòng chọn trạng thái phiếu đặt");
                    isValid = false;
                }
                else if (string.IsNullOrEmpty(txtTongTien.Text))
                {
                    MessageBox.Show("Tổng tiền chưa được tính");
                    isValid = false;
                }

                //lấy giá theo loại sân
                LoaiSan ls = await db.LoaiSans.FirstOrDefaultAsync(s => s.maloai == sanbong.maloai);
                if (ls == null)
                {
                    MessageBox.Show("Lỗi loại sân");
                    isValid = false;
                }

                //Tính tổng tiền
                tongtien = double.Parse(txtTongTien.Text);
                if(tiencoc > tongtien)
                {
                    MessageBox.Show($"Tiền cọc lớn hơn tổng tiền phải trả, trả lại khách {tongtien - tiencoc}");
                }
            }
            

            _lock.Release();
                //Trả về input
            return (maphieu, makh, masan, ngaybatdau, ngayhientai, 
                ngaycaidat, thoigianchoi, tongtien, 
                    tiencoc, trangthai, isValid);
        }

        private async Task<bool> isConflict(DateTime batdau, DateTime ketthuc, string masan)
        {
            bool isValid = false;
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                var phieuTrung = await db.PhieuDatSans
                                .Where(p => p.masan == masan &&
                                            p.thoigianbatdau < ketthuc &&
                                            p.thoigiancaidat > batdau &&
                                            p.trangthai != "Đã hủy")
                                .FirstOrDefaultAsync();
                if(phieuTrung != null)
                {
                    isValid = true;
                }
            }
            return isValid;
        }

        private bool CheckNgayDat(DateTime ngaybatdau, DateTime  ngayhientai)
        {
            bool isValid = true;

            if ((int)(ngaybatdau - ngayhientai).TotalDays >= 7)
            {
                MessageBox.Show("Ngày đặt không được lớn hơn ngày hiện tại quá 7 ngày");
                isValid = false;
            }
            else if (ngaybatdau <= ngayhientai)
            {
                //Xử lý ngày đặt
                MessageBox.Show("Ngày đặt phải lớn hơn ngày giờ hiện tại");
                isValid = false;
            }
            return isValid;
        }

        private async void ucDatSan_Load(object sender, EventArgs e)
        {
            txtMaPhieuDat.Enabled = false;
            txtMaSan.Enabled = false;
            txtTongTien.Enabled = false;

            //Format ngày đặt
            dtpNgayDat.Format = DateTimePickerFormat.Short;
            dtpNgayDat.ShowUpDown = false;

            //Format thời gian đặt
            dtpGioDat.Format = DateTimePickerFormat.Custom;
            dtpGioDat.CustomFormat = "HH:mm";  // 24-hour format
            dtpGioDat.ShowUpDown = true;

            dtpNgayDat.Value = DateTime.Now;
            dtpGioDat.Value = DateTime.Now;
            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now.AddDays(1);

            //Load phiếu đặt sân
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                List<PhieuDatSan> phieuDatSans = await db.PhieuDatSans.ToListAsync();
                Load_PhieuDatSan(phieuDatSans);
            }
            lvSanBong.MultiSelect = false;

            Load_cbbGioChoi();
            Load_cbbTrangThai();
            Load_Image();
            Load_SanBong();
            await CapNhatTrangThaiPhieu();
            ClearForm();
        }

        private void Load_PhieuDatSan(List<PhieuDatSan> phieuDatSans)
        {
            phieuDatSans.OrderByDescending(s => s.thoigianbatdau).ToList();
            dgvPhieuDatSan.AutoGenerateColumns = false;
            dgvPhieuDatSan.DataSource = phieuDatSans;
        }

        //kiểm tra thay đổi trạng thái
        private async Task CapNhatTrangThaiPhieu()
        {
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                List<PhieuDatSan> capnhat = await db.PhieuDatSans.Where(p => p.trangthai == "Đã đặt").ToListAsync();
                if (capnhat != null)
                {
                    DateTime ngayhientai = DateTime.Now;
                    foreach (PhieuDatSan phieuDatSan in capnhat)
                    {
                        SanBong sanBong = await db.SanBongs.FirstOrDefaultAsync(s => s.masan == phieuDatSan.masan);
                        if (phieuDatSan.thoigiancaidat <= ngayhientai)
                        {
                            phieuDatSan.trangthai = "Đã hoàn thành";
                            if (sanBong != null)
                            {
                                sanBong.tinhtrang = "Trống";
                            }
                        }
                        else if (phieuDatSan.thoigianbatdau < ngayhientai && phieuDatSan.thoigiancaidat > ngayhientai)
                        {
                            sanBong.tinhtrang = "Hoạt động";
                        }
                        await db.SaveChangesAsync();
                    }
                }
            }
        }

        private void ClearForm()
        {
            txtMaPhieuDat.Clear();
            txtMaSan.Clear();
            txtTongTien.Clear();
            txtTienCoc.Clear();
            txtSDTKH.Clear();
            cbbTrangThai.SelectedIndex = 0;
            cbbGioChoi.SelectedIndex = 1;
            dtpNgayDat.Value = DateTime.Now;
            dtpGioDat.Value = DateTime.Now;
            dtpNgayDat.Enabled = true;
            dtpGioDat.Enabled = true;
            cbbGioChoi.Enabled = true;
            txtTienCoc.Enabled = true;
        }

        private void Load_cbbTrangThai()
        {
            cbbTrangThai.Items.Add("Đã đặt");
            cbbTrangThai.Items.Add("Đã hoàn thành");
            cbbTrangThai.Items.Add("Đã hủy");
        }
        private void Load_cbbGioChoi()
        {
            foreach(int item in  GioChoi)
            {
                cbbGioChoi.Items.Add(item);
            }
            cbbGioChoi.SelectedIndex = 0;
        }
        private void Load_Image()
        {
            imglst.ImageSize = new Size(thumbWidth, thumbHeight);
            imglst.ColorDepth = ColorDepth.Depth32Bit;
            imglst.Images.Add("SAN5", Properties.Resources.San5);
            imglst.Images.Add("SAN7", Properties.Resources.San7);
        }

        private async void Load_SanBong()
        {
            // Lưu mã sân đang chọn để khôi phục
            string selectedMaSan = lvSanBong.SelectedItems.Count > 0
                ? lvSanBong.SelectedItems[0].Text : null;

            // Xóa dữ liệu cũ
            lvSanBong.Items.Clear();
            lvSanBong.Columns.Clear(); // Xóa cột cũ (nếu có)

            // CẤU HÌNH LISTVIEW
            lvSanBong.View = View.Details;
            lvSanBong.FullRowSelect = true;
            lvSanBong.GridLines = true;
            lvSanBong.MultiSelect = false;

            // THÊM CỘT (rất quan trọng!)
            lvSanBong.Columns.Add("", 100);
            lvSanBong.Columns.Add("Mã sân", 72);
            lvSanBong.Columns.Add("Tên sân", 100);
            lvSanBong.Columns.Add("Trạng thái", 70);

            // Dùng ảnh nhỏ bên trái
            lvSanBong.SmallImageList = imglst;

            // LẤY DỮ LIỆU
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                //chỉ load các sân trống hoặc sân đang hoạt động
                var sanBongs = await db.SanBongs.Where(s=>s.tinhtrang != "Bảo dưỡng").ToListAsync();

                foreach (var item in sanBongs)
                {
                    string imgkey = item.maloai.Trim().ToUpper();

                    // TẠO ITEM VỚI MẢNG DỮ LIỆU
                    var lvi = new ListViewItem(new string[]
                    {
                        "",
                        item.masan,         // Cột 0
                        item.tensan,        // Cột 1
                        item.tinhtrang      // Cột 2
                    });

                    // Gán ảnh (nếu có)
                    if (imglst.Images.ContainsKey(imgkey))
                    {
                        lvi.ImageKey = imgkey;
                    }

                    lvSanBong.Items.Add(lvi);
                }
            }
        }

        private async void lvSanBong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanBong.SelectedItems.Count == 0)
            {
                return;
            }

            var selectedItem = lvSanBong.SelectedItems[0];
            string masan = selectedItem.SubItems[1].Text;

            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                SanBong sanBong = await db.SanBongs.FirstOrDefaultAsync(s => s.masan == masan);
                if (sanBong == null)
                {
                    MessageBox.Show("Sân không tồn tại");
                    return;
                }
                txtMaSan.Text = sanBong.masan;
            }
        }

        private void txtSDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbGioChoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbbTrangThai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private async void btnTim_Click(object sender, EventArgs e)
        {
            string keyword = txtTimMPD.Text;
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                if (string.IsNullOrEmpty(keyword))
                {
                    List<PhieuDatSan> phieuDatSans = await db.PhieuDatSans.ToListAsync();
                    Load_PhieuDatSan(phieuDatSans);
                }
                else
                {
                    int key = int.Parse(keyword);
                    List<PhieuDatSan> phieuDatSans = await db.PhieuDatSans.Where(p => p.maphieu == key).ToListAsync();
                    Load_PhieuDatSan(phieuDatSans);
                }
            }
        }

        private void txtTimMPD_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            string currentText = txtBox.Text;
            int currentCursorPos = txtBox.SelectionStart;
            string onlyDigitText = new string(
                currentText.Where(c => char.IsDigit(c)).ToArray()
                );
            if (onlyDigitText != currentText)
            {
                txtBox.Text = onlyDigitText;
                txtBox.SelectionStart = Math.Min(currentCursorPos, onlyDigitText.Length);
            }
        }

        private void txtTimMPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void btnLoc_Click(object sender, EventArgs e)
        {
            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;
            start = dtpStart.Value;
            end = dtpEnd.Value.AddSeconds(1);
            if (start > end)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                return;
            }

            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                List<PhieuDatSan> phieuDatSans = await db.PhieuDatSans.
                    Where(p => p.thoigianbatdau >= start && p.thoigiancaidat <= end).
                    ToListAsync();
                Load_PhieuDatSan(phieuDatSans);
            }
        }

        private void dgvPhieuDatSan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private async void dgvPhieuDatSan_SelectionChanged(object sender, EventArgs e)
        {
            //Lấy giá trị từ row được chọn trong bảng datagridview
            DataGridViewRow curRow = dgvPhieuDatSan.CurrentRow;
            string maphieu = curRow.Cells["maphieu"].Value.ToString();
            string makh = curRow.Cells["makh"].Value.ToString();
            string masan = curRow.Cells["masan"].Value.ToString();
            DateTime ngaydat = DateTime.Parse(curRow.Cells["ngaydat"].Value.ToString());
            DateTime ngaybatdau = DateTime.Parse(curRow.Cells["batdau"].Value.ToString());
            DateTime ngaycaidat = DateTime.Parse(curRow.Cells["ketthuc"].Value.ToString());
            int thoigianchoi = 0;
            double tongtien = double.Parse(curRow.Cells["tongtien"].Value.ToString());
            double tiencoc = double.Parse(curRow.Cells["tiencoc"].Value.ToString());
            string trangthai = curRow.Cells["trangthai"].Value.ToString();
            KhachHang kh;

            //Xử lý dữ liệu
            thoigianchoi = (int)(ngaycaidat - ngaybatdau).TotalMinutes;
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                kh = await db.KhachHangs.FirstOrDefaultAsync(k => k.makh == makh);
            }

            //Đưa dữ liệu lên form thông tin phiếu
            txtMaPhieuDat.Text = maphieu;
            txtSDTKH.Text = kh.SDT;
            txtMaSan.Text = masan;
            dtpNgayDat.Text = ngaybatdau.ToString();
            dtpGioDat.Text = ngaybatdau.ToString();
            cbbGioChoi.Text = thoigianchoi.ToString();
            txtTongTien.Text = tongtien.ToString();
            txtTienCoc.Text = tiencoc.ToString();
            cbbTrangThai.Text = trangthai;

            //Vô hiệu hóa Form

            dtpNgayDat.Enabled = false;
            dtpGioDat.Enabled = false;
            cbbGioChoi.Enabled = false;
            txtTienCoc.Enabled = false;
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                List<PhieuDatSan> phieuDatSans = await db.PhieuDatSans.ToListAsync();
                Load_PhieuDatSan(phieuDatSans);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        //Thêm phiếu đặt sân vào csdl
        private async void btnThem_Click(object sender, EventArgs e)
        {
            var input = await getInput();
            input.isValid = CheckNgayDat(input.ngaybatdau, input.ngayhientai);
            if (!input.isValid)
            {
                return;
            }

            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                PhieuDatSan insertPhieuDat = new PhieuDatSan()
                {
                    
                    manv = MaNV_logged,
                    makh = input.makh,
                    masan = input.masan,
                    thoigianbatdau = input.ngaybatdau,
                    thoigiancaidat = input.ngaycaidat,
                    ngaydat = input.ngayhientai,
                    tongtiensan = (decimal)input.tongtien,
                    tiencoc = (decimal)input.tiencoc,
                    trangthai = input.trangthai
                };
                await _lock.WaitAsync();
                try
                {
                    db.PhieuDatSans.Add(insertPhieuDat);
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                    return;
                }
                finally
                {
                    _lock.Release();
                }
                MessageBox.Show("Thêm thành công");
            }
        }

        private async void TinhTongTien()
        {
            int thoigianchoi = int.Parse(cbbGioChoi.Text);
            double tongtien = 0;
            string masan = txtMaSan.Text;
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                SanBong sanbong = await db.SanBongs.FirstOrDefaultAsync(s => s.masan == masan);
                if (sanbong == null)
                {
                    return;
                }
                if(sanbong.tinhtrang ==  "Hoạt động")
                {
                    return;
                }
                //lấy giá theo loại sân
                LoaiSan ls = await db.LoaiSans.FirstOrDefaultAsync(s => s.maloai == sanbong.maloai);
                if (ls == null)
                {
                    MessageBox.Show("Lỗi loại sân");
                    return;
                }//Tính tổng tiền
                double thoigianchoitheogio = (double)thoigianchoi / 60;
                tongtien += (double)ls.dongiagio * thoigianchoitheogio;

                txtTongTien.Text = tongtien.ToString();
            }
        }

        private void cbbGioChoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void txtMaSan_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaSan.Text))
            {
                TinhTongTien();
            }
        }

        //-Cập nhât: chỉ cho cập nhật sân cùng loại, cập nhật số điện thoại
        //của khách hàng và cập nhật trạng thái
        //-Những cập nhật khác như mã nhân viên, tiền cọc, ngày giờ đặt,
        //thời gian chơi và mã phiếu đặt sẽ bị từ chối hoặc không cập nhật
        private async void btnCapNhat_Click(object sender, EventArgs e)
        {
            var input = await getInput();
            if (!input.isValid)
            {
                return;
            }
            using(var db = new QL_SANBONG_MINIDatacontext())
            {
                PhieuDatSan updatedPhieu = await db.PhieuDatSans.FirstOrDefaultAsync(p => p.maphieu == input.maphieu);



                if (!await isConflict(input.ngaybatdau,input.ngaycaidat, input.masan))
                {
                    SanBong curSan = await db.SanBongs.FirstOrDefaultAsync(s => s.masan == updatedPhieu.masan);
                    SanBong updateSan = await db.SanBongs.FirstOrDefaultAsync(s => s.masan == input.masan);
                    if (curSan.maloai != updateSan.maloai)
                    {
                        MessageBox.Show("Sân được đổi phải cùng loại sân trước đó ");
                        return;
                    }
                }
                await _lock.WaitAsync();
                try
                {
                    updatedPhieu.makh = input.makh;
                    updatedPhieu.masan = input.masan;
                    updatedPhieu.trangthai = input.trangthai;
                    updatedPhieu.tiencoc = (decimal)input.tiencoc;
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                    return;
                }
                finally
                {
                    _lock.Release();
                }
                MessageBox.Show("Cập nhật thành công");
            }
        }
    }
}
