using QuanLySanBongMini.Database;
using QuanLySanBongMini.DTOs;
using QuanLySanBongMini.Report;
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
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace QuanLySanBongMini.User_control
{
    public partial class ucThongKe : UserControl
    {
        public ucThongKe()
        {
            InitializeComponent();
        }

        private async void ucThongKe_Load(object sender, EventArgs e)
        {
            // Khởi tạo ComboBox cho hóa đơn
            cboOption.Items.Clear();
            cboOption.Items.Add("Hôm nay");
            cboOption.Items.Add("Tuần này");
            cboOption.Items.Add("Tháng này");
            cboOption.Items.Add("Tùy chỉnh");
            cboOption.SelectedIndex = 0;

            // Khởi tạo DateTimePicker
            pickerDoanhThu1.Value = DateTime.Now.Date;
            pickerDoanhThu2.Value = DateTime.Now.Date;

            pickerDoanhThu1.Enabled = false;
            pickerDoanhThu2.Enabled = false;

            // Khởi tạo combobox cho thống kê
            cboThang.Items.Clear();
            cboThang.Items.AddRange(new object[]
            {
                "Tháng 1",
                "Tháng 2",
                "Tháng 3",
                "Tháng 4",
                "Tháng 5",
                "Tháng 6",
                "Tháng 7",
                "Tháng 8",
                "Tháng 9",
                "Tháng 10",
                "Tháng 11",
                "Tháng 12"
            });

            cboNam.Items.Clear();
            cboNam.Items.AddRange(new object[]
            {
                "2024",
                "2025"
            });

        }

        private async void btnTimKiemDoanhThu_Click(object sender, EventArgs e)
        {
            // Lấy khoảng thời gian (Set về đầu ngày và cuối ngày để chính xác)
            DateTime fromDate = pickerDoanhThu1.Value.Date; // 00:00:00
            DateTime toDate = pickerDoanhThu2.Value.Date.AddDays(1).AddSeconds(-1); // 23:59:59

            if (toDate < fromDate)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc", 
                    "Lỗi: khoảng thời gian không hợp lệ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var db = new QL_SANBONG_MINIDatacontext())
                {
                    var listHoaDon = await db.PhieuDatSans
                        .Where(s => s.thoigianbatdau >= fromDate && s.thoigianbatdau<= toDate)
                        .Select(s => new ThongKeHoaDonDTO()
                        {
                            NgayLap = s.thoigianbatdau,
                            HoTenKhachHang = s.tenkh.hoten,
                            MaPhieuDatSan = s.maphieu,
                            MaSan = s.sanbong.tensan,
                            TongTien = s.tongtiensan +
                            (db.HoaDonDichVus
                            .Where(hd => hd.maphieu == s.maphieu && hd.trangthai == "Đã thanh toán")
                            .Sum(hd => (decimal?)hd.tongtien) ?? 0
                            )
                        })
                        .OrderByDescending(x => x.NgayLap)
                        .ToListAsync();

                    // Hiển thị lên report
                    if (listHoaDon.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy hoá đơn nào trong khoảng thời gian đã chọn.",
                            "Kết quả tìm kiếm doanh thu",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ThongKeDoanhThu report = new ThongKeDoanhThu();
                        report.SetDataSource(listHoaDon);

                        rptThongKeDoanhThu.ReportSource = report;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " +
                    ex.Message,
                    "Lỗi tìm kiếm doanh thu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cboOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            pickerDoanhThu1.Enabled = false;
            pickerDoanhThu2.Enabled = false;

            switch (cboOption.SelectedIndex)
            {
                case 0: // Hôm nay
                    pickerDoanhThu1.Value = today;
                    pickerDoanhThu2.Value = today;
                    break;
                case 1: // Tuần này
                    int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;

                    pickerDoanhThu1.Value = today.AddDays(-diff).Date;
                    pickerDoanhThu2.Value = today;
                    break;
                case 2: // Tháng này
                    DateTime dauThang = new DateTime(today.Year, today.Month, 1);

                    pickerDoanhThu1.Value = dauThang;
                    pickerDoanhThu2.Value = today;
                    break;
                case 3: // Tuỳ chỉnh
                    pickerDoanhThu1.Enabled = true;
                    pickerDoanhThu2.Enabled = true;

                    break;                    
            }
        }

        private async void btnTimKiemThongKe_Click(object sender, EventArgs e)
        {
            if (cboThang.SelectedIndex == -1 || cboNam.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tháng .",
                    "Lỗi: Chưa chọn tháng",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy giá trị Tháng và Năm thực tế
            int month = cboThang.SelectedIndex + 1;
            int year = int.Parse(cboNam.SelectedItem.ToString());

            // Xác định ngày đầu tháng và ngày cuối tháng để lọc dữ liệu
            DateTime firstDay = new DateTime(year, month, 1);
            DateTime lastDay = firstDay.AddMonths(1).AddSeconds(-1);

            using (var db = new QL_SANBONG_MINIDatacontext())
            {
                List<ThongKeChiPhiDTO> listChiPhi = new List<ThongKeChiPhiDTO>();
                var listLuongNhanVien = await db.NhanViens
                    .Select(nv => new ThongKeChiPhiDTO()
                    {
                        NgayLap = lastDay, // Trả lương cuối tháng
                        MoTaThongTin = "Tiền lương nhân viên: " + nv.hoten,
                        TongTien = nv.luongcb
                    })
                    .ToListAsync();

                var rawData = await (from ct in db.ChiTietPhieuNhaps
                                     join pn in db.PhieuNhapHangs on ct.MaPN equals pn.MaPN
                                     join sp in db.SanPhams on ct.MaSP equals sp.masp
                                     // Lọc theo ngày
                                     where pn.NgayNhap >= firstDay && pn.NgayNhap <= lastDay
                                     // Chỉ lấy những trường cần thiết
                                     select new
                                     {
                                         NgayNhap = pn.NgayNhap,
                                         SoLuong = ct.SoLuong,
                                         TenSP = sp.tensp,
                                         ThanhTien = ct.SoLuong * ct.DonGia
                                     }).ToListAsync();

                //Chuyển sang List<ThongKeChiPhiDTO> và Format chuỗi
                var listNhapHang = rawData.Select(x => new ThongKeChiPhiDTO
                {
                    NgayLap = x.NgayNhap,

                    MoTaThongTin = $"Nhập hàng: {x.SoLuong} {x.TenSP}",

                    TongTien = x.ThanhTien
                }).ToList();
                // Hiển thị lên datagridview
                
                listChiPhi.AddRange(listLuongNhanVien);
                listChiPhi.AddRange(listNhapHang);

                gridThongKeChiPhi.DataSource = listChiPhi.OrderByDescending(x => x.NgayLap).ToList();

                // Tính toán

                // Chi phí
                decimal tongChiPhi = listChiPhi.Sum(x => x.TongTien);

                // Doanh thu
                decimal doanhThuSan = await db.PhieuDatSans
                .Where(p => p.thoigianbatdau >= firstDay && p.thoigianbatdau <= lastDay && p.trangthai == "Đã hoàn thành")
                .SumAsync(p => (decimal?)p.tongtiensan) ?? 0m;

                decimal doanhThuDichVu = await db.HoaDonDichVus
                    .Where(h => h.ngaylap >= firstDay && h.ngaylap <= lastDay && h.trangthai == "Đã thanh toán")
                    .SumAsync(h => (decimal?)h.tongtien) ?? 0m;

                decimal tongDoanhThu = doanhThuSan + doanhThuDichVu;

                // Lợi nhuận
                decimal loiNhuan = tongDoanhThu - tongChiPhi;

                txtLoiNhuan.Text = loiNhuan.ToString("N0");
                txtTongChiPhi.Text = tongChiPhi.ToString("N0");
                txtTongDoanhThu.Text = tongDoanhThu.ToString("N0");
            }
        }
    }
}
