using QuanLySanBongMini.Database;
using QuanLySanBongMini.Database.Entities;
using QuanLySanBongMini.uc;
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
    public partial class Main_Form : Form
    {
        private Button currentActiveButton = null;

        private string manv_logged;

        // Biến để phân biệt giữa đóng ca và thoát chương trình
        private bool isDongCa = false;

        ucKhachHang UIKhachHang;
        ucSanBong UISanBong;
        ucDatSan UIDatSan;
        ucTaiKhoan UITaiKhoan;
        
        public Main_Form(string MaNhanVien)
        {
            InitializeComponent();

            // Gán mã nhân viên đăng nhập
            this.manv_logged = MaNhanVien;

            // Khởi tạo các UserControl
            UIKhachHang = new ucKhachHang();
            UISanBong = new ucSanBong();
            UIDatSan = new ucDatSan(MaNhanVien);
            UITaiKhoan = new ucTaiKhoan();

            // Set default active button
            SetActiveButton(btnHeThong);
        }

        private void loadUserControl(UserControl uc)
        {
            pnlMainContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(uc);
        }

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

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnHeThong);
            MenuHeThong.Show(btnHeThong, new Point(0, btnHeThong.Height));
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDatSan);
            
            loadUserControl(UIDatSan);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnKhachHang);
            
            loadUserControl(UIKhachHang);
        }

        private void btnSanBong_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnSanBong);
            
            loadUserControl(UISanBong);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnBanHang);

            ucBanHang uc = new ucBanHang();
            loadUserControl(uc);
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnHangHoa);

            ucHangHoa uc = new ucHangHoa();
            loadUserControl(uc);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnNhanVien);

            ucNhanVien uc = new ucNhanVien();
            loadUserControl(uc);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnThongKe);

            User_control.ucThongKe uc = new User_control.ucThongKe();
            loadUserControl(uc);
        }

        public async void Main_Form_Load(object sender, EventArgs e)
        {
            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                NhanVien user = await db.NhanViens.Where(nv => nv.manv == this.manv_logged).FirstOrDefaultAsync();

                if (user == null)
                {
                    MessageBox.Show("Lỗi không tìm thấy user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Hiển thị tên user
                lblUserInfo.Text = "Hello, " + user.hoten;

                // Kiểm tra xem user là nhân viên hay quản lý
                if (user.macv == 2) // Nhân viên
                {
                    // Ẩn chức năng xem thống kê và quản lý nhân viên
                    btnNhanVien.Visible = false;
                    btnThongKe.Visible = false;
                }    
            }
            ucMainForm uc = new ucMainForm();
            loadUserControl(uc);
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu đang đóng ca thì không hiện dialog xác nhận
            if (isDongCa)
            {
                return;
            }

            // Nếu user click nút X hoặc Alt+F4, hiện dialog xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát chương trình?", "Thoát?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            ucMainForm uc = new ucMainForm();
            loadUserControl(uc);
        }

        private void txt_TaiKhoan_Click(object sender, EventArgs e)
        {
            // Load thông tin tài khoản của nhân viên đang đăng nhập
            if (!string.IsNullOrEmpty(manv_logged))
            {
                UITaiKhoan.LoadByMaNV(manv_logged);
            }

            loadUserControl(UITaiKhoan);
        }

        private void txt_DongCa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng ca không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Đánh dấu là đang đóng ca để không hiện dialog trong FormClosing
                isDongCa = true;
                
                // Đóng Main_Form và quay về Login_Form
                this.DialogResult = DialogResult.OK;

                this.Close();
            }
        }

    }
}
