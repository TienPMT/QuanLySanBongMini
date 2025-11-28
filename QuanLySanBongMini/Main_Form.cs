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
    public partial class Main_Form : Form
    {
        private Button currentActiveButton = null;

        //Khởi tạo uc
        ucKhachHang UIKhachHang = new ucKhachHang();
        ucSanBong UISanBong = new ucSanBong();
        ucDatSan UIDatSan = new ucDatSan();
        ucTaiKhoan UITaiKhoan = new ucTaiKhoan();
        ucBanHang UIThucDon = new ucBanHang();
        //Sửa tên bán hàng thành thực đơn

       



        public Main_Form()
        {
            InitializeComponent();
            // Set default active button
            SetActiveButton(btnHeThong);
        }

        // Constructor accepting a single argument (employee id)
        public Main_Form(string maNV) : this()
        {
            // Hiển thị MaNV vào lbl_TaiKhoan (giả sử tồn tại trên form; nếu không, dùng Tag)
            try
            {
                var lblTaiKhoan = this.Controls.Find("lbl_TaiKhoan", true).FirstOrDefault() as Label;
                if (lblTaiKhoan != null)
                {
                    lblTaiKhoan.Text = maNV; // Hiển thị trực tiếp trên giao diện
                }
                else
                {
                    // Fallback: Lưu vào Tag để các UserControl sử dụng sau (ví dụ: quyền hạn dựa trên MaNV)
                    this.Tag = maNV;
                }

                // Gán mã nhân viên cho ucTaiKhoan để khi người dùng mở phần Tài khoản, control sẽ load đúng dữ liệu
                if (!string.IsNullOrEmpty(maNV))
                {
                    UITaiKhoan.LoadByMaNV(maNV);
                }
            }
            catch
            {
                // Nếu lỗi, lưu vào Tag
                this.Tag = maNV;
            }
        }

        private void loadUserControl(UserControl uc)
        {
            pnlMainContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(uc);
        }

        // Method to handle button active state
        private void SetActiveButton(Button button)
        {
            if (currentActiveButton != null)
            {
                currentActiveButton.BackColor = Color.FromArgb(230, 126, 34);
                currentActiveButton.ForeColor = Color.White;
            }

            currentActiveButton = button;
            button.BackColor = Color.FromArgb(211, 84, 0);
            button.ForeColor = Color.White;
        }

        // Event handlers for menu buttons
        private void btnHeThong_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnHeThong);
            // Logic sẽ thêm ở giai đoạn 2
            MenuHeThong.Show(btnHeThong, new Point(0, btnHeThong.Height));
        }


        private void btnDatSan_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDatSan);
            // Logic sẽ thêm ở giai đoạn 2
            loadUserControl(UIDatSan);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnKhachHang);
            // Logic sẽ thêm ở giai đoạn 2
            loadUserControl(UIKhachHang);
        }

        private void btnSanBong_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnSanBong);
            // Logic sẽ thêm ở giai đoạn 2
            loadUserControl(UISanBong);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnBanHang);
            // Logic sẽ thêm ở giai đoạn 2
            loadUserControl(UIThucDon);
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnHangHoa);
            // Logic sẽ thêm ở giai đoạn 2
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNhanVien);
            // Logic sẽ thêm ở giai đoạn 2
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnThongKe);
            // Logic sẽ thêm ở giai đoạn 2
        }

        private void txt_TaiKhoan_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnHeThong);

            // Trước khi load uc, đảm bảo uc đã có mã nhân viên hiện tại (lấy từ lbl_TaiKhoan hoặc Tag)
            string currentMaNV = null;
            var lblTaiKhoan = this.Controls.Find("lbl_TaiKhoan", true).FirstOrDefault() as Label;
            if (lblTaiKhoan != null && !string.IsNullOrEmpty(lblTaiKhoan.Text))
            {
                currentMaNV = lblTaiKhoan.Text;
            }
            else if (this.Tag != null)
            {
                currentMaNV = this.Tag.ToString();
            }

            if (!string.IsNullOrEmpty(currentMaNV))
            {
                UITaiKhoan.LoadByMaNV(currentMaNV);
            }

            loadUserControl(UITaiKhoan);
        }

        private void txt_DongCa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng ca không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Logic đóng ca sẽ được thêm ở giai đoạn 2
               this.Close();
            }
        }
    }
}
