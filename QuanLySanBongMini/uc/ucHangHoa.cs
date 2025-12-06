using QuanLySanBongMini.Database;
using QuanLySanBongMini.Database.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanBongMini.uc
{
    public partial class ucHangHoa : UserControl
    {
        private QL_SANBONG_MINIDatacontext db = new QL_SANBONG_MINIDatacontext();
        private bool isAdding = false;
        private string currentImagePath = null;
        public string MaNhanVien { get; set; } = "NV001";

        public ucHangHoa()
        {
            InitializeComponent();
        }

        private void ucHangHoa_Load(object sender, EventArgs e)
        {
            
        }
        private void ConfigureGridView()
        {
            gridHangHoa.AutoGenerateColumns = false;
            gridHangHoa.Columns.Clear();

            gridHangHoa.Columns.Add("masp", "Mã SP");
            gridHangHoa.Columns.Add("tensp", "Tên sản phẩm");
            gridHangHoa.Columns.Add("soluongton", "Số lượng tồn");
            gridHangHoa.Columns.Add("donvitinh", "Đơn vị tính");
            gridHangHoa.Columns.Add("dongiaban", "Đơn giá bán");
            gridHangHoa.Columns.Add("tenloai", "Loại sản phẩm");

            gridHangHoa.Columns["masp"].DataPropertyName = "masp";
            gridHangHoa.Columns["tensp"].DataPropertyName = "tensp";
            gridHangHoa.Columns["soluongton"].DataPropertyName = "soluongton";
            gridHangHoa.Columns["donvitinh"].DataPropertyName = "donvitinh";
            gridHangHoa.Columns["dongiaban"].DataPropertyName = "dongiaban";
            gridHangHoa.Columns["tenloai"].DataPropertyName = "tenloai";

            gridHangHoa.Columns["dongiaban"].DefaultCellStyle.Format = "N0";
            gridHangHoa.Columns["soluongton"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridHangHoa.Columns["dongiaban"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // gridHangHoa.SelectionChanged += GridHangHoa_SelectionChanged;
        }

    }
}
