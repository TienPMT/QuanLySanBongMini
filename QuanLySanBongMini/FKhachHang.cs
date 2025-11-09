using QuanLySanBongMini.Database;
using QuanLySanBongMini.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini
{
    public partial class FKhachHang : Form
    {
        SemaphoreSlim _lock = new SemaphoreSlim(1,1);
        public FKhachHang()
        {
            InitializeComponent();
        }

        private (string makh, string tenkh, string gioitinh, string  sdt, bool isValid) getInput()
        {
            string makh = txtMaKH.Text;
            string tenkh = txtTenKH.Text;
            string gioitinh = "";
            bool isValid = true;
            List<RadioButton> rad = grbThongTin.Controls.OfType<RadioButton>().Where(x => x.Checked).ToList();
            foreach(RadioButton radItem in rad)
            {
                if(radItem == rdbNam)
                {
                    gioitinh = "Nam";
                }
                if(radItem == rdbNu)
                {
                    gioitinh = "Nữ";
                }
            }
            string sdt = txtSDT.Text;
            if (string.IsNullOrEmpty(makh))
            {
                MessageBox.Show("Mã khách hàng lỗi!");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(tenkh))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                isValid = false;
            }
            return (makh, tenkh, gioitinh, sdt, isValid);
        }

        private async void FKhachHang_Load(object sender, EventArgs e)
        {
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                List<KhachHang> khachHangs =  await db.KhachHangs.ToListAsync();
                Load_Datagridview(khachHangs);
            }
            txtMaKH.Enabled = false;
        }

        private async Task<string> TaoMaKH()
        {
            using (var db =new QL_SANBONG_MINIDatacontext())
            {
                List<KhachHang> khachHangs = await db.KhachHangs.ToListAsync();
                int quantity = khachHangs.Count() + 1;
                string maKH = "KH" + quantity.ToString();
                if (khachHangs.FirstOrDefault(kh => kh.makh == maKH) == null)
                {
                    return maKH;
                }
                for(int i = 0; i <= quantity; i++)
                {
                    maKH = "KH" + i.ToString();
                    if (khachHangs.FirstOrDefault(kh => kh.makh == maKH) == null)
                    {
                        return maKH;
                    }
                }
                maKH = "KH0";
                return maKH;
            }
        }

        private void Load_Datagridview(List<KhachHang> khachHangs)
        {
            dgvKH.AutoGenerateColumns = false;
            dgvKH.DataSource = khachHangs;
        }
        private void ValidateTextChanged(object sender, EventArgs e)
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

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            ValidateTextChanged(sender, e);
        }


        private void dgvKH_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow curRow = dgvKH.CurrentRow;
            string makh = curRow.Cells["makh"].Value.ToString();
            string hoten = curRow.Cells["hoten"].Value.ToString();
            string gioitinh = curRow.Cells["gioitinh"].Value.ToString();
            string sdt = curRow.Cells["SDT"].Value.ToString();

            txtMaKH.Text = makh;
            txtTenKH.Text = hoten;
            txtSDT.Text = sdt;
            if (gioitinh == "Nam")
            {
                rdbNam.Checked = true;
            }
            else if (gioitinh == "Nữ")
            {
                rdbNu.Checked = true;
            }
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                List<KhachHang> khachHangs = await db.KhachHangs.ToListAsync();
                Load_Datagridview(khachHangs);
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            var input = getInput();
            if (!input.isValid)
            {
                return;
            }
            input.makh = await TaoMaKH();
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                if(await db.KhachHangs.FirstOrDefaultAsync(k=>k.SDT == input.sdt) != null)
                {
                    MessageBox.Show("Số điện thoại khách hàng bị trùng");
                    return;
                }
                else if(await db.KhachHangs.FirstOrDefaultAsync(k=>k.makh==input.makh) != null)
                {
                    MessageBox.Show("Mã khách hàng bị trùng");
                    return;
                }
                KhachHang kh = new KhachHang()
                {
                    makh = input.makh,
                    hoten = input.tenkh,
                    gioitinh = input.gioitinh,
                    SDT = input.sdt
                };

                await  _lock.WaitAsync();
                try
                {
                    db.KhachHangs.Add(kh);
                    await db.SaveChangesAsync();
                }
                catch
                {
                    MessageBox.Show($"Lỗi");
                    return;
                }
                finally
                {
                    _lock.Release();
                }
                MessageBox.Show("Thêm thành công");
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            var input = getInput();
            if (!input.isValid)
            {
                return;
            }
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                KhachHang updatedkh = await db.KhachHangs.FirstOrDefaultAsync(k => k.makh == input.makh);
                if (updatedkh == null)
                {
                    MessageBox.Show("Mã khách hàng không tồn tại");
                    return;
                }
                else if(await db.KhachHangs.FirstOrDefaultAsync(k => k.SDT == input.sdt && k.makh != updatedkh.makh) != null)
                {
                    MessageBox.Show("Số điện thoại khách hàng đã tồn tại");
                    return;
                }
                updatedkh.hoten = input.tenkh;
                updatedkh.gioitinh = input.gioitinh;
                updatedkh.SDT = input.sdt;

                await _lock.WaitAsync();
                try
                {
                    await db.SaveChangesAsync();
                }
                catch
                {
                    MessageBox.Show($"Lỗi");
                    return;
                }
                finally
                {
                    _lock.Release();
                }
                MessageBox.Show("Sửa thành công");
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            var input = getInput();
            if (!input.isValid)
            {
                return;
            }
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                KhachHang deletedkh = await db.KhachHangs.FirstOrDefaultAsync(k => k.makh == input.makh);
                if (deletedkh == null)
                {
                    MessageBox.Show("Mã khách hàng không tồn tại");
                    return;
                }

                await _lock.WaitAsync();
                try
                {
                    db.KhachHangs.Remove(deletedkh);
                    await db.SaveChangesAsync();
                }
                catch
                {
                    MessageBox.Show($"Lỗi");
                    return;
                }
                finally
                {
                    _lock.Release();
                }
                MessageBox.Show("Xóa thành công");
            }
        }

        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtSDTTimKiem.Text;
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                if (string.IsNullOrEmpty(keyword))
                {
                    List<KhachHang> khachHangs = await db.KhachHangs.ToListAsync();
                    Load_Datagridview(khachHangs);
                }
                else
                {
                    List<KhachHang> khachHangs = await db.KhachHangs.Where(k=>k.SDT.Contains(keyword)).ToListAsync();
                    Load_Datagridview(khachHangs);
                }
            }
        }
    }
}
