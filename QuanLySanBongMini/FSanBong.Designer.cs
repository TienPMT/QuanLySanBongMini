namespace QuanLySanBongMini
{
    partial class FSanBong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnTim;
            System.Windows.Forms.Button btnReload;
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnHangHoa = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnSanBong = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnDatSan = new System.Windows.Forms.Button();
            this.btnHeThong = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.grbLichSu = new System.Windows.Forms.GroupBox();
            this.txtTimMPD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dgvPhieuDatSan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbSanBong = new System.Windows.Forms.GroupBox();
            this.lvSanBong = new System.Windows.Forms.ListView();
            this.grbThongTinSan = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.cbbLoaiSan = new System.Windows.Forms.ComboBox();
            this.txtTenSan = new System.Windows.Forms.TextBox();
            this.txtMaSan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            btnTim = new System.Windows.Forms.Button();
            btnReload = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.grbLichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDatSan)).BeginInit();
            this.grbSanBong.SuspendLayout();
            this.grbThongTinSan.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            btnTim.Location = new System.Drawing.Point(237, 20);
            btnTim.Name = "btnTim";
            btnTim.Size = new System.Drawing.Size(75, 23);
            btnTim.TabIndex = 12;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(250, 130);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "⚽\r\nQUẢN LÝ\r\nSÂN BÓNG";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.pnlSidebar.Controls.Add(this.lblUserInfo);
            this.pnlSidebar.Controls.Add(this.btnThongKe);
            this.pnlSidebar.Controls.Add(this.btnNhanVien);
            this.pnlSidebar.Controls.Add(this.btnHangHoa);
            this.pnlSidebar.Controls.Add(this.btnBanHang);
            this.pnlSidebar.Controls.Add(this.btnSanBong);
            this.pnlSidebar.Controls.Add(this.btnKhachHang);
            this.pnlSidebar.Controls.Add(this.btnDatSan);
            this.pnlSidebar.Controls.Add(this.btnHeThong);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 700);
            this.pnlSidebar.TabIndex = 2;
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.lblUserInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserInfo.ForeColor = System.Drawing.Color.White;
            this.lblUserInfo.Location = new System.Drawing.Point(0, 650);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(250, 50);
            this.lblUserInfo.TabIndex = 9;
            this.lblUserInfo.Text = "Hello, [User]";
            this.lblUserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(0, 480);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(250, 50);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "📊  Thống Kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = false;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 430);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(250, 50);
            this.btnNhanVien.TabIndex = 7;
            this.btnNhanVien.Text = "👥  Nhân Viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnHangHoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHangHoa.FlatAppearance.BorderSize = 0;
            this.btnHangHoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHangHoa.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHangHoa.ForeColor = System.Drawing.Color.White;
            this.btnHangHoa.Location = new System.Drawing.Point(0, 380);
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHangHoa.Size = new System.Drawing.Size(250, 50);
            this.btnHangHoa.TabIndex = 6;
            this.btnHangHoa.Text = "📦  Hàng Hóa";
            this.btnHangHoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHangHoa.UseVisualStyleBackColor = false;
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnBanHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnBanHang.ForeColor = System.Drawing.Color.White;
            this.btnBanHang.Location = new System.Drawing.Point(0, 330);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBanHang.Size = new System.Drawing.Size(250, 50);
            this.btnBanHang.TabIndex = 5;
            this.btnBanHang.Text = "💰  Bán Hàng";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.UseVisualStyleBackColor = false;
            // 
            // btnSanBong
            // 
            this.btnSanBong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnSanBong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSanBong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanBong.FlatAppearance.BorderSize = 0;
            this.btnSanBong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanBong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSanBong.ForeColor = System.Drawing.Color.White;
            this.btnSanBong.Location = new System.Drawing.Point(0, 280);
            this.btnSanBong.Name = "btnSanBong";
            this.btnSanBong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSanBong.Size = new System.Drawing.Size(250, 50);
            this.btnSanBong.TabIndex = 4;
            this.btnSanBong.Text = "⚽  Sân Bóng";
            this.btnSanBong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanBong.UseVisualStyleBackColor = false;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 230);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(250, 50);
            this.btnKhachHang.TabIndex = 3;
            this.btnKhachHang.Text = "👤  Khách Hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            // 
            // btnDatSan
            // 
            this.btnDatSan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnDatSan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatSan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatSan.FlatAppearance.BorderSize = 0;
            this.btnDatSan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatSan.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDatSan.ForeColor = System.Drawing.Color.White;
            this.btnDatSan.Location = new System.Drawing.Point(0, 180);
            this.btnDatSan.Name = "btnDatSan";
            this.btnDatSan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDatSan.Size = new System.Drawing.Size(250, 50);
            this.btnDatSan.TabIndex = 2;
            this.btnDatSan.Text = "📅  Đặt Sân";
            this.btnDatSan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatSan.UseVisualStyleBackColor = false;
            // 
            // btnHeThong
            // 
            this.btnHeThong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnHeThong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHeThong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHeThong.FlatAppearance.BorderSize = 0;
            this.btnHeThong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeThong.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHeThong.ForeColor = System.Drawing.Color.White;
            this.btnHeThong.Location = new System.Drawing.Point(0, 130);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHeThong.Size = new System.Drawing.Size(250, 50);
            this.btnHeThong.TabIndex = 1;
            this.btnHeThong.Text = "⚙️  Hệ Thống";
            this.btnHeThong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeThong.UseVisualStyleBackColor = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 130);
            this.pnlLogo.TabIndex = 0;
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.pnlMainContent.Controls.Add(this.grbLichSu);
            this.pnlMainContent.Controls.Add(this.grbSanBong);
            this.pnlMainContent.Controls.Add(this.grbThongTinSan);
            this.pnlMainContent.Controls.Add(this.lblWelcome);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1300, 700);
            this.pnlMainContent.TabIndex = 3;
            // 
            // grbLichSu
            // 
            this.grbLichSu.Controls.Add(btnReload);
            this.grbLichSu.Controls.Add(this.txtTimMPD);
            this.grbLichSu.Controls.Add(this.label7);
            this.grbLichSu.Controls.Add(btnTim);
            this.grbLichSu.Controls.Add(this.btnLoc);
            this.grbLichSu.Controls.Add(this.label6);
            this.grbLichSu.Controls.Add(this.label5);
            this.grbLichSu.Controls.Add(this.dtpEnd);
            this.grbLichSu.Controls.Add(this.dtpStart);
            this.grbLichSu.Controls.Add(this.dgvPhieuDatSan);
            this.grbLichSu.Location = new System.Drawing.Point(256, 294);
            this.grbLichSu.Name = "grbLichSu";
            this.grbLichSu.Size = new System.Drawing.Size(1032, 394);
            this.grbLichSu.TabIndex = 5;
            this.grbLichSu.TabStop = false;
            this.grbLichSu.Text = "Lịch sử phiếu đặt sân";
            // 
            // txtTimMPD
            // 
            this.txtTimMPD.Location = new System.Drawing.Point(107, 21);
            this.txtTimMPD.Name = "txtTimMPD";
            this.txtTimMPD.Size = new System.Drawing.Size(124, 22);
            this.txtTimMPD.TabIndex = 14;
            this.txtTimMPD.TextChanged += new System.EventHandler(this.txtTimMPD_TextChanged);
            this.txtTimMPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimMPD_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã phiếu đặt:";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(951, 20);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 11;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(699, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thời gian kết thúc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thời gian bắt đầu:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(832, 22);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(113, 22);
            this.dtpEnd.TabIndex = 2;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(562, 21);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(113, 22);
            this.dtpStart.TabIndex = 1;
            // 
            // dgvPhieuDatSan
            // 
            this.dgvPhieuDatSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDatSan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvPhieuDatSan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPhieuDatSan.Location = new System.Drawing.Point(1, 49);
            this.dgvPhieuDatSan.Name = "dgvPhieuDatSan";
            this.dgvPhieuDatSan.ReadOnly = true;
            this.dgvPhieuDatSan.RowHeadersWidth = 51;
            this.dgvPhieuDatSan.RowTemplate.Height = 24;
            this.dgvPhieuDatSan.Size = new System.Drawing.Size(1031, 345);
            this.dgvPhieuDatSan.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maphieu";
            this.Column1.HeaderText = "Mã phiếu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "makh";
            this.Column2.HeaderText = "Mã khách hàng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 75;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "manv";
            this.Column3.HeaderText = "Mã nhân viên";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "masan";
            this.Column4.HeaderText = "Mã sân";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "thoigianbatdau";
            this.Column5.HeaderText = "Thời gian bắt đầu";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "thoigiancaidat";
            this.Column6.HeaderText = "Thời gian cài đặt";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 110;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ngaydat";
            this.Column7.HeaderText = "Ngày đặt";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 110;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "tongtiensan";
            this.Column8.HeaderText = "Tổng tiền sân";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "tiencoc";
            this.Column9.HeaderText = "Tiền cọc";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "trangthai";
            this.Column10.HeaderText = "Trạng thái";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 125;
            // 
            // grbSanBong
            // 
            this.grbSanBong.Controls.Add(this.lvSanBong);
            this.grbSanBong.Location = new System.Drawing.Point(734, 12);
            this.grbSanBong.Name = "grbSanBong";
            this.grbSanBong.Size = new System.Drawing.Size(554, 276);
            this.grbSanBong.TabIndex = 4;
            this.grbSanBong.TabStop = false;
            this.grbSanBong.Text = "Sân bóng";
            // 
            // lvSanBong
            // 
            this.lvSanBong.HideSelection = false;
            this.lvSanBong.Location = new System.Drawing.Point(-1, 15);
            this.lvSanBong.MultiSelect = false;
            this.lvSanBong.Name = "lvSanBong";
            this.lvSanBong.Size = new System.Drawing.Size(564, 261);
            this.lvSanBong.TabIndex = 0;
            this.lvSanBong.UseCompatibleStateImageBehavior = false;
            this.lvSanBong.SelectedIndexChanged += new System.EventHandler(this.lvSanBong_SelectedIndexChanged);
            // 
            // grbThongTinSan
            // 
            this.grbThongTinSan.Controls.Add(this.btnXoa);
            this.grbThongTinSan.Controls.Add(this.btnCapNhat);
            this.grbThongTinSan.Controls.Add(this.btnThem);
            this.grbThongTinSan.Controls.Add(this.cbbTinhTrang);
            this.grbThongTinSan.Controls.Add(this.cbbLoaiSan);
            this.grbThongTinSan.Controls.Add(this.txtTenSan);
            this.grbThongTinSan.Controls.Add(this.txtMaSan);
            this.grbThongTinSan.Controls.Add(this.label4);
            this.grbThongTinSan.Controls.Add(this.label3);
            this.grbThongTinSan.Controls.Add(this.label2);
            this.grbThongTinSan.Controls.Add(this.label1);
            this.grbThongTinSan.Location = new System.Drawing.Point(256, 12);
            this.grbThongTinSan.Name = "grbThongTinSan";
            this.grbThongTinSan.Size = new System.Drawing.Size(471, 276);
            this.grbThongTinSan.TabIndex = 1;
            this.grbThongTinSan.TabStop = false;
            this.grbThongTinSan.Text = "Thông tin sân";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(369, 232);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 28);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(159, 232);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(93, 28);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(78, 232);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 28);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Location = new System.Drawing.Point(78, 185);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(366, 24);
            this.cbbTinhTrang.TabIndex = 7;
            this.cbbTinhTrang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbTinhTrang_KeyPress);
            // 
            // cbbLoaiSan
            // 
            this.cbbLoaiSan.FormattingEnabled = true;
            this.cbbLoaiSan.Location = new System.Drawing.Point(78, 135);
            this.cbbLoaiSan.Name = "cbbLoaiSan";
            this.cbbLoaiSan.Size = new System.Drawing.Size(366, 24);
            this.cbbLoaiSan.TabIndex = 6;
            this.cbbLoaiSan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbLoaiSan_KeyPress);
            // 
            // txtTenSan
            // 
            this.txtTenSan.Location = new System.Drawing.Point(78, 86);
            this.txtTenSan.Name = "txtTenSan";
            this.txtTenSan.Size = new System.Drawing.Size(366, 22);
            this.txtTenSan.TabIndex = 5;
            // 
            // txtMaSan
            // 
            this.txtMaSan.Location = new System.Drawing.Point(78, 41);
            this.txtMaSan.Name = "txtMaSan";
            this.txtMaSan.Size = new System.Drawing.Size(366, 22);
            this.txtMaSan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại sân:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sân:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sân:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblWelcome.Location = new System.Drawing.Point(0, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1300, 700);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReload
            // 
            btnReload.Location = new System.Drawing.Point(318, 20);
            btnReload.Name = "btnReload";
            btnReload.Size = new System.Drawing.Size(75, 23);
            btnReload.TabIndex = 15;
            btnReload.Text = "Tải lại";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // FSanBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlMainContent);
            this.Name = "FSanBong";
            this.Text = "FSanBong";
            this.Load += new System.EventHandler(this.FSanBong_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.grbLichSu.ResumeLayout(false);
            this.grbLichSu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDatSan)).EndInit();
            this.grbSanBong.ResumeLayout(false);
            this.grbThongTinSan.ResumeLayout(false);
            this.grbThongTinSan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnHangHoa;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnSanBong;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnDatSan;
        private System.Windows.Forms.Button btnHeThong;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.GroupBox grbThongTinSan;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.ComboBox cbbLoaiSan;
        private System.Windows.Forms.TextBox txtTenSan;
        private System.Windows.Forms.TextBox txtMaSan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbSanBong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbLichSu;
        private System.Windows.Forms.DataGridView dgvPhieuDatSan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox txtTimMPD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.ListView lvSanBong;
    }
}