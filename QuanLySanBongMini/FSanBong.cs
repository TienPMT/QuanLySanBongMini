using QuanLySanBongMini.Database;
using QuanLySanBongMini.Database.Entities;
using QuanLySanBongMini.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLySanBongMini
{
    public partial class FSanBong : Form
    {
        //khởi tạo biến lock semaphore
        SemaphoreSlim _lock = new SemaphoreSlim(1,1);

        //Khởi tạo biến chứa ảnh của sân 5 và sân 7
        static int thumbWidth = 100;
        static int thumbHeight = 70;
        ImageList imglst = new ImageList();

        public FSanBong()
        {
            InitializeComponent();
        }

        //tạo mã sân tự động dựa trên số lượng của từng loại sân
        private async Task<string> TaoMaSan(string maloai)
        {
            string masan = maloai + "-";
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                List<SanBong> sanBongs = await db.SanBongs.
                    Where(s => s.maloai == maloai).
                    ToListAsync();
                int quantity = sanBongs.Count+1;

                if (quantity > 10)
                {
                    masan += quantity.ToString();
                }
                else
                {
                    masan += "0" + quantity.ToString();
                }
                if(await db.SanBongs.FirstOrDefaultAsync(s=>s.masan==masan) != null)
                {
                    masan = "SAN-00";
                }
            }
            return masan;
        }

        //lấy giá trị nhập liệu
        private (string tensan, string maloai, string tinhtrang, bool isValid) getInput()
        {
            string tensan = txtTenSan.Text;
            var loaisan = cbbLoaiSan.SelectedItem as LoaiSan;
            string maloai = string.Empty;
            string tinhtrang = cbbTinhTrang.Text;
            bool isvalid = true;
            if (string.IsNullOrEmpty(tensan))
            {
                MessageBox.Show("Không được đê trống tên sân");
                isvalid = false;
            }
            else if (string.IsNullOrEmpty(tinhtrang))
            {
                MessageBox.Show("Vui lòng chọn trạng thái sân");
                isvalid = false;
            }
            else if (loaisan == null)
            {
                MessageBox.Show("Vui lòng chọn loại sân");
                isvalid = false;
            }
            else
            {
                maloai = loaisan.maloai;
            }
            return (tensan, maloai, tinhtrang, isvalid);
        }

        private async void FSanBong_Load(object sender, EventArgs e)
        {
            using (var db  = new QL_SANBONG_MINIDatacontext())
            {
                List<PhieuDatSan> phieuDatSans = await db.PhieuDatSans.ToListAsync();
                Load_PhieuDatSan(phieuDatSans);
            }
            lvSanBong.MultiSelect = false;
            await LoadCombobox_LoaiSan();
            Load_TinhTrang();
            Load_Image();
            Load_SanBong();
        }

        private void Load_PhieuDatSan(List<PhieuDatSan> phieuDatSans)
        {
            txtMaSan.Enabled = false;
            phieuDatSans.OrderByDescending(s => s.thoigianbatdau);
            dgvPhieuDatSan.AutoGenerateColumns = false;
            dgvPhieuDatSan.DataSource = phieuDatSans;
        }

        private async Task LoadCombobox_LoaiSan()
        {
            cbbLoaiSan.Items.Clear();
            using(var db = new QL_SANBONG_MINIDatacontext())
            {
                List<LoaiSan> ls = await db.LoaiSans.ToListAsync();
                foreach(LoaiSan l in ls)
                {
                    cbbLoaiSan.Items.Add(l);
                }
                cbbLoaiSan.SelectedIndex = 0;
            }
        }

        private void Load_TinhTrang()
        {
            cbbTinhTrang.Items.Clear();
            cbbTinhTrang.Items.Add("Trống");
            cbbTinhTrang.Items.Add("Hoạt động");
            cbbTinhTrang.Items.Add("Bảo dưỡng");
            cbbTinhTrang.SelectedIndex = 0;
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
            lvSanBong.Columns.Add("Mã sân", 75);
            lvSanBong.Columns.Add("Tên sân", 150);
            lvSanBong.Columns.Add("Trạng thái", 75);

            // Dùng ảnh nhỏ bên trái
            lvSanBong.SmallImageList = imglst;

            // LẤY DỮ LIỆU
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                var sanBongs = await db.SanBongs.ToListAsync();

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

        private void cbbLoaiSan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbbTinhTrang_KeyPress(object sender, KeyPressEventArgs e)
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
                    List<PhieuDatSan> phieuDatSans = await db.PhieuDatSans.Where(p=>p.maphieu == key).ToListAsync();
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
            end = dtpEnd.Value;
            if(start > end)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                return;
            }

            using(var db = new QL_SANBONG_MINIDatacontext())
            {
                List<PhieuDatSan> phieuDatSans = await db.PhieuDatSans.
                    Where(p => p.thoigianbatdau >= start && p.thoigiancaidat <= end).
                    ToListAsync();
                Load_PhieuDatSan(phieuDatSans);
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            var input = getInput();
            if (!input.isValid)
            {
                return;
            }
            string masanmoi = await TaoMaSan(input.maloai);

            using(var db = new QL_SANBONG_MINIDatacontext())
            {
                if(await db.SanBongs.FirstOrDefaultAsync(s=>s.masan == masanmoi) != null)
                {
                    MessageBox.Show("Mã sân đã tồn tại");
                    return;
                }
                SanBong insertedSan = new SanBong()
                {
                    masan = masanmoi,
                    tensan = input.tensan,
                    maloai = input.maloai,
                    tinhtrang = "Trống"
                };

                await _lock.WaitAsync();
                try
                {
                    db.SanBongs.Add(insertedSan);
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
                finally
                {
                    _lock.Release();
                }
                MessageBox.Show("Thêm thành công");
                Load_SanBong();
            }
            ClearForm();
        }

        private async void btnCapNhat_Click(object sender, EventArgs e)
        {
            string masan = txtMaSan.Text;
            if (string.IsNullOrEmpty(masan))
            {
                MessageBox.Show("Mã sân bị trống");
                return;
            }

            var input = getInput();
            if (!input.isValid)
            {
                return;
            }

            
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                SanBong updatedSan = await db.SanBongs.FirstOrDefaultAsync(s => s.masan == masan);
                if (updatedSan == null)
                {
                    MessageBox.Show("Mã sân không tồn tại");
                    return;
                }

                await _lock.WaitAsync();
                try
                {
                    updatedSan.tensan = input.tensan;
                    updatedSan.maloai = input.maloai;
                    updatedSan.tinhtrang = input.tinhtrang;
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
                finally
                {
                    _lock.Release();
                }
                MessageBox.Show("Cập nhật thành công");
                Load_SanBong();
            }
            ClearForm();
        }
        private void ClearForm()
        {
            txtMaSan.Clear();
            txtTenSan.Clear();
            cbbLoaiSan.SelectedIndex = -1;
            cbbTinhTrang.SelectedIndex = -1;
        }

        //Khi chọn trong listview sân bóng sẽ push giá trị của Sân lên form thông tin
        private async void lvSanBong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanBong.SelectedItems.Count == 0)
            {
                ClearForm();
                return;
            }

            var selectedItem = lvSanBong.SelectedItems[0];
            string masan = selectedItem.SubItems[1].Text;

            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                SanBong sanBong = await db.SanBongs.FirstOrDefaultAsync(s=>s.masan == masan);
                if(sanBong == null)
                {
                    MessageBox.Show("Sân không tồn tại");
                    return;
                }
                LoaiSan l = await db.LoaiSans.FirstOrDefaultAsync(ls => ls.maloai == sanBong.maloai);
                txtMaSan.Text = sanBong.masan;
                txtTenSan.Text = sanBong.tensan;
                cbbTinhTrang.Text = sanBong.tinhtrang;

                if (l != null)
                {
                    for (int i = 0; i < cbbLoaiSan.Items.Count; i++)
                    {
                        if (cbbLoaiSan.Items[i] is LoaiSan ls && ls.maloai == l.maloai)
                        {
                            cbbLoaiSan.SelectedIndex = i;
                            break;
                        }
                    }
                }
                else
                {
                    cbbLoaiSan.SelectedIndex = -1;
                }
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {

            string masan = txtMaSan.Text;
            if (string.IsNullOrEmpty(masan))
            {
                MessageBox.Show("Mã sân bị trống");
                return;
            }

            var input = getInput();
            if (!input.isValid)
            {
                return;
            }

            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                SanBong deletedSan = await db.SanBongs.FirstOrDefaultAsync(s => s.masan == masan);
                if (deletedSan == null)
                {
                    MessageBox.Show("Mã sân không tồn tại");
                    return;
                }

                await _lock.WaitAsync();
                try
                {
                    db.SanBongs.Remove(deletedSan);
                    await db.SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
                finally
                {
                    _lock.Release();
                }
                MessageBox.Show("Xóa thành công");
                Load_SanBong();
            }
            ClearForm();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                List<PhieuDatSan> phieuDatSans = await db.PhieuDatSans.ToListAsync();
                Load_PhieuDatSan(phieuDatSans);
            }
        }
    }
}
