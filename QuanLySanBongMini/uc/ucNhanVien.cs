using QuanLySanBongMini.Database;
using QuanLySanBongMini.Database.Entities;
using QuanLySanBongMini.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Management;
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
            List<ChucVuDTO> dschucvu = new List<ChucVuDTO>();

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
                        MaChucVu = nv.macv,
                        TenChucVu = nv.tencv.tencv
                    }).ToListAsync();

                if (dsNhanVien == null || dsNhanVien.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu nhân viên!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dschucvu = await db.ChucVus.Select(cv => new ChucVuDTO()
                {
                    MaChucVu = cv.macv,
                    TenChucVu = cv.tencv
                }).ToListAsync();
            }

            cboChucVu.DataSource = dschucvu;

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
                DateTime NgaySinh = Convert.ToDateTime(selected.Cells["NgaySinh"].Value);
                string Email = selected.Cells["Email"].Value.ToString();
                string SoDienThoai = selected.Cells["SDT"].Value.ToString();
                object LuongCoBan = selected.Cells["LuongCB"].Value;
                decimal luong = Convert.ToDecimal(LuongCoBan);
                

                txtMaNV.Text = MaNV;
                txtHoTen.Text = HoTen;
                pickerNgaySinh.Value = NgaySinh;
                txtEmail.Text = Email;
                

                // Tắt event handler trước khi gán giá trị SDT
                txtSoDienThoai.TextChanged -= txtSoDienThoai_TextChanged;
                txtSoDienThoai.Text = SoDienThoai;
                txtSoDienThoai.TextChanged += txtSoDienThoai_TextChanged;

                // Tắt event handler trước khi gán giá trị Lương cơ bản
                txtLuongCoBan.TextChanged -= txtLuongCoBan_TextChanged;
                txtLuongCoBan.Text = luong.ToString("F0"); // Chỉ lấy phần nguyên, không có dấu phẩy
                txtLuongCoBan.TextChanged += txtLuongCoBan_TextChanged;


                // Xử lý chức vụ
                object MaChucVu = selected.Cells["MaChucVu"].Value;
                cboChucVu.SelectedValue = MaChucVu;

                // Xử lý giới tính
                if (GioiTinh == "Nam")
                {
                    radioNam.Select();
                }
                else
                {
                    radioNu.Select();
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtHoTen.Clear();
            txtLuongCoBan.Clear();
            txtMaNV.Clear();
            pickerNgaySinh.Value = DateTime.Parse("01/01/2000");
            txtSoDienThoai.Clear();
            cboChucVu.SelectedIndex = 1;

            radioNam.Checked = false;
            radioNu.Checked = false;

        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLuongCoBan_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra ký tự không phải số trong chuỗi
            if (Regex.IsMatch(txtLuongCoBan.Text, "[^0-9]"))
            {
                // Lưu vị trí của con trỏ hiện tại
                int currentPosition = txtLuongCoBan.SelectionStart;

                // Thay các ký tự không phải số bằng rỗng
                txtLuongCoBan.Text = Regex.Replace(txtLuongCoBan.Text, "[^0-9]", "");

                if (currentPosition > 0)
                {
                    txtLuongCoBan.SelectionStart = currentPosition - 1;
                }
                else
                {
                    txtLuongCoBan.SelectionStart = 0;
                }

                MessageBox.Show("Lương chỉ được nhập số!", "Erorr: lỗi nhập lương!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private int checkTuoi(DateTime NgaySinh)
        {
            DateTime now = DateTime.Now;
            int tuoi = now.Year - NgaySinh.Year;

            if (now.Month < NgaySinh.Month)
            {
                tuoi--;
            }
            return tuoi;
        }

        private bool checkPhoneNumber(string phoneNumber)
        {
            // nếu như ký tự không phải số hoặc độ dài khác 10
            return Regex.IsMatch(phoneNumber, @"^0\d{9}$");
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra ký tự không phải số trong chuỗi
            if (Regex.IsMatch(txtSoDienThoai.Text, "[^0-9]"))
            {
                // Lưu vị trí của con trỏ hiện tại
                int currentPosition = txtSoDienThoai.SelectionStart;

                // Thay các ký tự không phải số bằng rỗng
                txtSoDienThoai.Text = Regex.Replace(txtSoDienThoai.Text, "[^0-9]", "");

                if (currentPosition > 0)
                {
                    txtSoDienThoai.SelectionStart = currentPosition - 1;
                }
                else
                {
                    txtSoDienThoai.SelectionStart = 0;
                }

                MessageBox.Show("SDT chỉ được nhập số!", "Erorr: Số điện thoại lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra ký tự là số trong chuỗi
            if (Regex.IsMatch(txtHoTen.Text, "[0-9]"))
            {
                // Lưu vị trí của con trỏ hiện tại
                int currentPosition = txtHoTen.SelectionStart;

                // Thay các ký tự không phải số bằng rỗng
                txtHoTen.Text = Regex.Replace(txtHoTen.Text, "[0-9]", "");

                if (currentPosition > 0)
                {
                    txtHoTen.SelectionStart = currentPosition - 1;
                }
                else
                {
                    txtHoTen.SelectionStart = 0;
                }

                MessageBox.Show("Họ tên không được nhập số!", "Erorr: họ tên lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private bool checkName(string name)
        {
            // Tên không được có số hay ký tự đặc biệt
            return Regex.IsMatch(name, @"^[\p{L}\s]+$");
        }

        private string xoaKhoangTrangThua(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Loại bỏ khoảng trắng ở đầu và cuối
            input = input.Trim();

            // Loại bỏ các khoảng trắng ở giữa
            return Regex.Replace(input, @"\s+", " ");
        }

        private async void btnThemNV_Click(object sender, EventArgs e)
        {
            // Kiểm tra thiếu sót thông tin
            if (string.IsNullOrEmpty(cboChucVu.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtHoTen.Text) ||
                string.IsNullOrEmpty(txtLuongCoBan.Text) ||
                string.IsNullOrEmpty(txtMaNV.Text) ||
                string.IsNullOrEmpty(txtSoDienThoai.Text) ||
                (!radioNam.Checked && !radioNu.Checked)
            )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi thêm nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra lương
            if (decimal.Parse(txtLuongCoBan.Text) <= 0)
            {
                MessageBox.Show("Lương không được âm!", "Error: Lương âm!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra định dạng Email
            if (!checkEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không đúng định dạng!", "Error: sai Email!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra tuổi nhân viên có lớn hơn 18 không
            if (checkTuoi(pickerNgaySinh.Value) < 18)
            {
                MessageBox.Show("Nhân viên chưa đủ 18 tuổi!", "Error: không đủ tuổi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra định dạng sdt
            if (!checkPhoneNumber(txtSoDienThoai.Text))
            {
                MessageBox.Show("SDT không đúng định dạng!", "Error: sai SDT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra định dạng họ tên nhân viên
            if (!checkName(txtHoTen.Text))
            {
                MessageBox.Show("Họ tênkhông đúng định dạng!", "Error: sai tên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var db = new QL_SANBONG_MINIDatacontext())
                {
                    bool check = await db.NhanViens.Where(nv => nv.manv == txtMaNV.Text).AnyAsync();

                    if (check)
                    {
                        MessageBox.Show("Đã tồn tại mã nhân viên này!", "Lỗi thêm nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Lấy giới tính
                    string GioiTinh = radioNam.Checked ? "Nam" : "Nữ";

                    // Lấy mã chức vụ
                    int MaChucVu = Convert.ToInt16(cboChucVu.SelectedValue);

                    NhanVien newNV = new NhanVien()
                    {
                        macv = int.Parse(xoaKhoangTrangThua(MaChucVu.ToString())),
                        email = xoaKhoangTrangThua(txtEmail.Text),
                        gioitinh = xoaKhoangTrangThua(GioiTinh),
                        hoten = xoaKhoangTrangThua(txtHoTen.Text),
                        luongcb = decimal.Parse(xoaKhoangTrangThua(txtLuongCoBan.Text)),
                        manv = xoaKhoangTrangThua(txtMaNV.Text),
                        ngaysinh = pickerNgaySinh.Value,
                        sdt = xoaKhoangTrangThua(txtSoDienThoai.Text)
                    };

                    TaiKhoan newTK = new TaiKhoan()
                    {
                        manv = newNV.manv,
                        password = newNV.sdt
                    };

                    // Xác nhận có thêm nhân viên không?
                    DialogResult confirm = MessageBox.Show("Bạn có chắc muốn thêm nhân viên này?" +
                        "\nMã nhân viên: " + newNV.manv +
                        "\nHọ tên: " + newNV.hoten +
                        "\nGiới tính: " + newNV.gioitinh +
                        "\nNgày sinh: " + newNV.ngaysinh.ToString("dd/MM/yyyy") +
                        "\nEmail: " + newNV.email +
                        "\nSố điện thoại: " + newNV.sdt +
                        "\nLương cơ bản: " + newNV.luongcb.ToString("N0") + " VNĐ" +
                        "\nChức vụ: " + cboChucVu.Text,
                        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.No)
                    {
                        return;
                    }

                    db.NhanViens.Add(newNV);
                    db.TaiKhoans.Add(newTK);
                    db.SaveChanges();

                    MessageBox.Show("Thêm nhân viên thành công!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucNhanVien_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private async void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (gridQuanLyNhanVien.SelectedCells.Count > 0)
            {
                DataGridViewRow selected = gridQuanLyNhanVien.SelectedRows[0];

                string MaNV = selected.Cells["MaNhanVien"].Value.ToString();

                using (var db = new QL_SANBONG_MINIDatacontext())
                {
                    NhanVien deleteNV = await db.NhanViens.
                        Where(nv => nv.manv == MaNV).FirstOrDefaultAsync();

                    if (deleteNV == null)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên muốn xoá!", "Erorr: Xoá nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    TaiKhoan deleteTK = await db.TaiKhoans.
                        Where(tk => tk.manv == MaNV).FirstOrDefaultAsync();

                    if (deleteTK == null)
                    {
                        MessageBox.Show("Không tìm thấy tài khoản nhân viên muốn xoá!", "Erorr: Xoá tài khoàn NV!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Xác nhận có xoá nhân viên không?
                    DialogResult confirm = MessageBox.Show("Bạn có chắc muốn thêm nhân viên này?" +
                        "\nMã nhân viên: " + deleteNV.manv +
                        "\nHọ tên: " + deleteNV.hoten,
                        "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirm == DialogResult.No)
                    {
                        return;
                    }

                    db.TaiKhoans.Remove(deleteTK);
                    db.NhanViens.Remove(deleteNV);
                    db.SaveChanges();

                    MessageBox.Show("Xoá nhân viên thành công!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ucNhanVien_Load(sender, e);

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn xoá!", "Erorr: Xoá nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private async void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (gridQuanLyNhanVien.SelectedCells.Count > 0)
            {
                // Kiểm tra thiếu sót thông tin
                if (string.IsNullOrEmpty(cboChucVu.Text) ||
                    string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtHoTen.Text) ||
                    string.IsNullOrEmpty(txtLuongCoBan.Text) ||
                    string.IsNullOrEmpty(txtMaNV.Text) ||
                    string.IsNullOrEmpty(txtSoDienThoai.Text) ||
                    (!radioNam.Checked && !radioNu.Checked)
                )
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi thêm nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra lương
                if (decimal.Parse(txtLuongCoBan.Text) <= 0)
                {
                    MessageBox.Show("Lương không được âm!", "Error: Lương âm!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra định dạng Email
                if (!checkEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email không đúng định dạng!", "Error: sai Email!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra tuổi nhân viên có lớn hơn 18 không
                if (checkTuoi(pickerNgaySinh.Value) < 18)
                {
                    MessageBox.Show("Nhân viên chưa đủ 18 tuổi!", "Error: không đủ tuổi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra định dạng sdt
                if (!checkPhoneNumber(txtSoDienThoai.Text))
                {
                    MessageBox.Show("SDT không đúng định dạng!", "Error: sai SDT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra định dạng họ tên nhân viên
                if (!checkName(txtHoTen.Text))
                {
                    MessageBox.Show("Họ tênkhông đúng định dạng!", "Error: sai tên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow seleceted = gridQuanLyNhanVien.SelectedRows[0];
                int changes = 0;
                string MaNV = seleceted.Cells["MaNhanVien"].Value.ToString();

                try
                {
                    using (var db = new QL_SANBONG_MINIDatacontext())
                    {
                        NhanVien updateNV = await db.NhanViens.
                            Where(nv => nv.manv == MaNV).FirstOrDefaultAsync();

                        if (updateNV == null)
                        {
                            MessageBox.Show("Mã nhân viên muốn chỉnh sửa không tồn tại!", "Erorr: Cập nhật nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Nếu mã nhân viên thay đổi => Không cho phép!
                        if (updateNV.manv != txtMaNV.Text)
                        {
                            MessageBox.Show("Không được thay đổi mã nhân viên!", "Erorr: Cập nhật nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Nếu họ tên thay đổi
                        if (txtHoTen.Text != updateNV.hoten)
                        {
                            updateNV.hoten = xoaKhoangTrangThua(txtHoTen.Text);
                            changes++;
                        }

                        // Nếu giới tính thay đổi
                        if (radioNam.Checked)
                        {
                            updateNV.gioitinh = "Nam";
                            changes++;
                        }
                        if (radioNu.Checked)
                        {
                            updateNV.gioitinh = "Nữ";
                            changes++;
                        }

                        // Nếu ngày sinh thay đổi
                        if (updateNV.ngaysinh != pickerNgaySinh.Value)
                        {
                            updateNV.ngaysinh = pickerNgaySinh.Value;
                            changes++;
                        }

                        // Nếu Email thay đổi
                        if (updateNV.email != txtEmail.Text)
                        {
                            updateNV.email = xoaKhoangTrangThua(txtEmail.Text);
                            changes++;
                        }

                        // Nếu sdt thay đổi
                        if (updateNV.sdt != txtSoDienThoai.Text)
                        {
                            updateNV.sdt = xoaKhoangTrangThua(txtSoDienThoai.Text);
                            changes++;
                        }

                        // Nếu lương cơ bản thay đổi
                        if (updateNV.luongcb != decimal.Parse(txtLuongCoBan.Text))
                        {
                            updateNV.luongcb = decimal.Parse(txtLuongCoBan.Text);
                            changes++;
                        }

                        // Nếu chức vụ thay đổi
                        if (updateNV.tencv.tencv == cboChucVu.SelectedText)
                        {
                            updateNV.macv = int.Parse(cboChucVu.SelectedValue.ToString());
                            changes++;
                        }

                        if (changes == 0)
                        {
                            MessageBox.Show("Chưa có thông tin nào được sửa!", "Erorr: Cập nhật nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            // Xác nhận có thêm nhân viên không?
                            DialogResult confirm = MessageBox.Show($"Bạn có chắc muốn cập nhật thông tin nhân viên {MaNV}?" +
                                "\nMã nhân viên: " + updateNV.manv +
                                "\nHọ tên: " + updateNV.hoten +
                                "\nGiới tính: " + updateNV.gioitinh +
                                "\nNgày sinh: " + updateNV.ngaysinh.ToString("dd/MM/yyyy") +
                                "\nEmail: " + updateNV.email +
                                "\nSố điện thoại: " + updateNV.sdt +
                                "\nLương cơ bản: " + updateNV.luongcb.ToString("N0") + " VNĐ" +
                                "\nChức vụ: " + cboChucVu.Text,
                                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (confirm == DialogResult.No)
                            {
                                return;
                            }

                            db.SaveChanges();

                            MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ucNhanVien_Load(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erorr: Cập nhật nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên muốn chỉnh sửa!", "Erorr: Cập nhật nhân viên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

