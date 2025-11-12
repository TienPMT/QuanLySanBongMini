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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password không được để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                TaiKhoan user = await db.TaiKhoans.Where(tk => tk.manv == username && tk.password == password).FirstOrDefaultAsync();

                // Kiểm tra nếu không tìm thấy tài khoản
                if (user == null)
                {
                    MessageBox.Show("Username hoặc password không hợp lệ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Main_Form f = new Main_Form(user.manv);
                    f.Show();
                    this.Hide();
                }    
            }

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ngăn không cho phát ra tiếng "ding" (lỗi) của Windows
                e.SuppressKeyPress = true;

                btnLogin.PerformClick();
            }
        }
    }
}
