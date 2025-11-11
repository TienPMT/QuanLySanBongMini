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

        public Main_Form()
        {
            InitializeComponent();
            // Set default active button
            SetActiveButton(btnHeThong);
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
        }

        private void btnDatSan_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDatSan);
            // Logic sẽ thêm ở giai đoạn 2
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

    }
}
