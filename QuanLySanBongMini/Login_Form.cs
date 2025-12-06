using QuanLySanBongMini.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Ẩn LOGIN FORM sau khi đăng nhập thành công, chạy Main FORM
            string maNV = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã nhân viên và Mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new QL_SANBONG_MINIDatacontext())
                {
                    // Kiểm tra tài khoản trong database (sử dụng nhanVien.manv nếu cần join, nhưng hiện tại dùng manv trực tiếp)
                    var taiKhoan = db.TaiKhoans.FirstOrDefault(tk => tk.manv == maNV && tk.password == matKhau);

                    if (taiKhoan != null)
                    {
                        // Đăng nhập thành công
                        // Mở Main_Form và truyền MaNV
                        Main_Form mainForm = new Main_Form(taiKhoan.manv);
                        this.Hide(); // Ẩn form Login
                        mainForm.ShowDialog(); // Hiển thị Main_Form (dạng modal)

                        // Sau khi Main_Form bị đóng (do "Đóng ca")
                        // Code sẽ tiếp tục chạy từ đây:
                        this.Show(); // Hiển thị lại form Login
                        txtPassword.Text = ""; // Xóa mật khẩu cho lần đăng nhập sau
                        mainForm.Dispose(); // Giải phóng tài nguyên Main_Form
                    }
                    else
                    {
                        // Đăng nhập thất bại
                        MessageBox.Show("Mã nhân viên hoặc Mật khẩu không chính xác.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Text = ""; // Xóa password nếu sai
                        txtUsername.Focus(); // Focus lại username
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối hoặc truy vấn CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}