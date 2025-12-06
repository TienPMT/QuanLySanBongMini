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
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini
{
    public partial class ForgotPassword_Form : Form
    {
        public ForgotPassword_Form()
        {
            InitializeComponent();
        }

        private async void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) &&
                string.IsNullOrEmpty(txtHoTen.Text) &&
                string.IsNullOrEmpty(txtEmail.Text) &&
                string.IsNullOrEmpty(txtSDT.Text)
            )
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập (mã nhân viên)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng Email
            if (!checkEmail(txtEmail.Text))
            {
                MessageBox.Show("Email không đúng định dạng!", "Error: sai Email!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra định dạng sdt
            if (!checkPhoneNumber(txtSDT.Text))
            {
                MessageBox.Show("SDT không đúng định dạng!", "Error: sai SDT!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra định dạng họ tên nhân viên
            if (!checkName(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không đúng định dạng!", "Error: sai tên!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string MaNV = xoaKhoangTrangThua(txtMaNV.Text);
            string HoTen = xoaKhoangTrangThua(txtHoTen.Text);
            string Email = xoaKhoangTrangThua(txtEmail.Text);
            string SDT = xoaKhoangTrangThua(txtSDT.Text);

            try
            {
                using (var db = new QL_SANBONG_MINIDatacontext())
                {

                    NhanVien nv = await db.NhanViens
                        .Where(
                            t => t.manv == MaNV &&
                            t.hoten == HoTen &&
                            t.sdt == SDT &&
                            t.email == Email
                        )
                        .FirstOrDefaultAsync();

                    if (nv == null)
                    {
                        MessageBox.Show("Lỗi: không tồn tại nhân viên này!",
                        "Lỗi truy xuất nhân viên",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        return;
                    }

                    var taiKhoan = await db.TaiKhoans
                        .Where(tk => tk.manv == MaNV)
                        .FirstOrDefaultAsync();

                    if (taiKhoan == null)
                    {
                        MessageBox.Show("Lỗi: Tên đăng nhập không tồn tại trong hệ thống!",
                            "Lỗi xác nhận người dùng",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    else
                    {
                        MessageBox.Show("Nhân viên " +
                           nv.manv + " " +
                           nv.hoten +
                           "\nMật khẩu tài khoản: " +
                           taiKhoan.password,
                           "Xác nhận người dùng thành công",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool checkEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private bool checkPhoneNumber(string phoneNumber)
        {
            // nếu như ký tự không phải số hoặc độ dài khác 10
            return Regex.IsMatch(phoneNumber, @"^0\d{9}$");
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra ký tự không phải số trong chuỗi
            if (Regex.IsMatch(txtSDT.Text, "[^0-9]"))
            {
                // Lưu vị trí của con trỏ hiện tại
                int currentPosition = txtSDT.SelectionStart;

                // Thay các ký tự không phải số bằng rỗng
                txtSDT.Text = Regex.Replace(txtSDT.Text, "[^0-9]", "");

                if (currentPosition > 0)
                {
                    txtSDT.SelectionStart = currentPosition - 1;
                }
                else
                {
                    txtSDT.SelectionStart = 0;
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

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
