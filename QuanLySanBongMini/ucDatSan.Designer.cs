namespace QuanLySanBongMini
{
    partial class ucDatSan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnReload;
            System.Windows.Forms.Button btnTim;
            this.grbSanBong = new System.Windows.Forms.GroupBox();
            this.lvSanBong = new System.Windows.Forms.ListView();
            this.grbFormDatSan = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.cbbGioChoi = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpGioDat = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtMaSan = new System.Windows.Forms.TextBox();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.txtMaPhieuDat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbLichSu = new System.Windows.Forms.GroupBox();
            this.txtTimMPD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dgvPhieuDatSan = new System.Windows.Forms.DataGridView();
            this.maphieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiencoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnReload = new System.Windows.Forms.Button();
            btnTim = new System.Windows.Forms.Button();
            this.grbSanBong.SuspendLayout();
            this.grbFormDatSan.SuspendLayout();
            this.grbLichSu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDatSan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            btnReload.Location = new System.Drawing.Point(339, 21);
            btnReload.Name = "btnReload";
            btnReload.Size = new System.Drawing.Size(75, 23);
            btnReload.TabIndex = 15;
            btnReload.Text = "Tải lại";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnTim
            // 
            btnTim.Location = new System.Drawing.Point(258, 21);
            btnTim.Name = "btnTim";
            btnTim.Size = new System.Drawing.Size(75, 23);
            btnTim.TabIndex = 12;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // grbSanBong
            // 
            this.grbSanBong.Controls.Add(this.lvSanBong);
            this.grbSanBong.Location = new System.Drawing.Point(557, 35);
            this.grbSanBong.Name = "grbSanBong";
            this.grbSanBong.Size = new System.Drawing.Size(482, 276);
            this.grbSanBong.TabIndex = 8;
            this.grbSanBong.TabStop = false;
            this.grbSanBong.Text = "Sân bóng";
            // 
            // lvSanBong
            // 
            this.lvSanBong.HideSelection = false;
            this.lvSanBong.Location = new System.Drawing.Point(0, 15);
            this.lvSanBong.MultiSelect = false;
            this.lvSanBong.Name = "lvSanBong";
            this.lvSanBong.Size = new System.Drawing.Size(483, 261);
            this.lvSanBong.TabIndex = 0;
            this.lvSanBong.UseCompatibleStateImageBehavior = false;
            this.lvSanBong.SelectedIndexChanged += new System.EventHandler(this.lvSanBong_SelectedIndexChanged);
            // 
            // grbFormDatSan
            // 
            this.grbFormDatSan.Controls.Add(this.btnClear);
            this.grbFormDatSan.Controls.Add(this.btnCapNhat);
            this.grbFormDatSan.Controls.Add(this.btnThem);
            this.grbFormDatSan.Controls.Add(this.label10);
            this.grbFormDatSan.Controls.Add(this.cbbTrangThai);
            this.grbFormDatSan.Controls.Add(this.txtTienCoc);
            this.grbFormDatSan.Controls.Add(this.txtTongTien);
            this.grbFormDatSan.Controls.Add(this.cbbGioChoi);
            this.grbFormDatSan.Controls.Add(this.label9);
            this.grbFormDatSan.Controls.Add(this.dtpGioDat);
            this.grbFormDatSan.Controls.Add(this.dtpNgayDat);
            this.grbFormDatSan.Controls.Add(this.txtMaSan);
            this.grbFormDatSan.Controls.Add(this.txtSDTKH);
            this.grbFormDatSan.Controls.Add(this.txtMaPhieuDat);
            this.grbFormDatSan.Controls.Add(this.label8);
            this.grbFormDatSan.Controls.Add(this.label7);
            this.grbFormDatSan.Controls.Add(this.label6);
            this.grbFormDatSan.Controls.Add(this.label5);
            this.grbFormDatSan.Controls.Add(this.label4);
            this.grbFormDatSan.Controls.Add(this.label3);
            this.grbFormDatSan.Controls.Add(this.label2);
            this.grbFormDatSan.Controls.Add(this.label1);
            this.grbFormDatSan.Location = new System.Drawing.Point(0, 35);
            this.grbFormDatSan.Name = "grbFormDatSan";
            this.grbFormDatSan.Size = new System.Drawing.Size(551, 276);
            this.grbFormDatSan.TabIndex = 9;
            this.grbFormDatSan.TabStop = false;
            this.grbFormDatSan.Text = "Thông tin đặt sân";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(339, 234);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(250, 234);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(83, 30);
            this.btnCapNhat.TabIndex = 20;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(169, 234);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(250, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Phút";
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Location = new System.Drawing.Point(121, 200);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(123, 24);
            this.cbbTrangThai.TabIndex = 17;
            this.cbbTrangThai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbTrangThai_KeyPress);
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.Location = new System.Drawing.Point(121, 175);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(415, 22);
            this.txtTienCoc.TabIndex = 16;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(121, 149);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(415, 22);
            this.txtTongTien.TabIndex = 15;
            // 
            // cbbGioChoi
            // 
            this.cbbGioChoi.FormattingEnabled = true;
            this.cbbGioChoi.Location = new System.Drawing.Point(121, 124);
            this.cbbGioChoi.Name = "cbbGioChoi";
            this.cbbGioChoi.Size = new System.Drawing.Size(123, 24);
            this.cbbGioChoi.TabIndex = 14;
            this.cbbGioChoi.SelectedIndexChanged += new System.EventHandler(this.cbbGioChoi_SelectedIndexChanged);
            this.cbbGioChoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbGioChoi_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Giờ đặt:";
            // 
            // dtpGioDat
            // 
            this.dtpGioDat.CustomFormat = "hh:mm";
            this.dtpGioDat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGioDat.Location = new System.Drawing.Point(311, 101);
            this.dtpGioDat.Name = "dtpGioDat";
            this.dtpGioDat.Size = new System.Drawing.Size(123, 22);
            this.dtpGioDat.TabIndex = 12;
            // 
            // dtpNgayDat
            // 
            this.dtpNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDat.Location = new System.Drawing.Point(121, 101);
            this.dtpNgayDat.Name = "dtpNgayDat";
            this.dtpNgayDat.Size = new System.Drawing.Size(123, 22);
            this.dtpNgayDat.TabIndex = 11;
            // 
            // txtMaSan
            // 
            this.txtMaSan.Location = new System.Drawing.Point(121, 76);
            this.txtMaSan.Name = "txtMaSan";
            this.txtMaSan.Size = new System.Drawing.Size(415, 22);
            this.txtMaSan.TabIndex = 10;
            this.txtMaSan.TextChanged += new System.EventHandler(this.txtMaSan_TextChanged);
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(121, 48);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(415, 22);
            this.txtSDTKH.TabIndex = 9;
            this.txtSDTKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTKH_KeyPress);
            // 
            // txtMaPhieuDat
            // 
            this.txtMaPhieuDat.Location = new System.Drawing.Point(121, 21);
            this.txtMaPhieuDat.Name = "txtMaPhieuDat";
            this.txtMaPhieuDat.Size = new System.Drawing.Size(415, 22);
            this.txtMaPhieuDat.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Trạng thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tiền cọc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tổng tiền sân:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giờ chơi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày đặt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sân:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "SĐT khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu đặt:";
            // 
            // grbLichSu
            // 
            this.grbLichSu.Controls.Add(btnReload);
            this.grbLichSu.Controls.Add(this.txtTimMPD);
            this.grbLichSu.Controls.Add(this.label11);
            this.grbLichSu.Controls.Add(btnTim);
            this.grbLichSu.Controls.Add(this.btnLoc);
            this.grbLichSu.Controls.Add(this.label12);
            this.grbLichSu.Controls.Add(this.label13);
            this.grbLichSu.Controls.Add(this.dtpEnd);
            this.grbLichSu.Controls.Add(this.dtpStart);
            this.grbLichSu.Controls.Add(this.dgvPhieuDatSan);
            this.grbLichSu.Location = new System.Drawing.Point(0, 305);
            this.grbLichSu.Name = "grbLichSu";
            this.grbLichSu.Size = new System.Drawing.Size(1041, 439);
            this.grbLichSu.TabIndex = 21;
            this.grbLichSu.TabStop = false;
            this.grbLichSu.Text = "Lịch sử phiếu đặt sân";
            // 
            // txtTimMPD
            // 
            this.txtTimMPD.Location = new System.Drawing.Point(107, 21);
            this.txtTimMPD.Name = "txtTimMPD";
            this.txtTimMPD.Size = new System.Drawing.Size(145, 22);
            this.txtTimMPD.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Mã phiếu đặt:";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(928, 22);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 11;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(679, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Thời gian kết thúc:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(423, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Thời gian bắt đầu:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(809, 22);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(113, 22);
            this.dtpEnd.TabIndex = 2;
            this.dtpEnd.Value = new System.DateTime(2025, 11, 11, 18, 34, 29, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(556, 22);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(113, 22);
            this.dtpStart.TabIndex = 1;
            this.dtpStart.Value = new System.DateTime(2025, 11, 11, 18, 33, 52, 0);
            // 
            // dgvPhieuDatSan
            // 
            this.dgvPhieuDatSan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDatSan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphieu,
            this.makh,
            this.manv,
            this.masan,
            this.batdau,
            this.ketthuc,
            this.ngaydat,
            this.tongtien,
            this.tiencoc,
            this.trangthai});
            this.dgvPhieuDatSan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPhieuDatSan.Location = new System.Drawing.Point(1, 49);
            this.dgvPhieuDatSan.MultiSelect = false;
            this.dgvPhieuDatSan.Name = "dgvPhieuDatSan";
            this.dgvPhieuDatSan.ReadOnly = true;
            this.dgvPhieuDatSan.RowHeadersWidth = 51;
            this.dgvPhieuDatSan.RowTemplate.Height = 24;
            this.dgvPhieuDatSan.Size = new System.Drawing.Size(1040, 393);
            this.dgvPhieuDatSan.TabIndex = 0;
            this.dgvPhieuDatSan.SelectionChanged += new System.EventHandler(this.dgvPhieuDatSan_SelectionChanged);
            this.dgvPhieuDatSan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvPhieuDatSan_KeyPress);
            // 
            // maphieu
            // 
            this.maphieu.DataPropertyName = "maphieu";
            this.maphieu.HeaderText = "Mã phiếu";
            this.maphieu.MinimumWidth = 6;
            this.maphieu.Name = "maphieu";
            this.maphieu.ReadOnly = true;
            this.maphieu.Width = 50;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.MinimumWidth = 6;
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            this.makh.Width = 75;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            this.manv.Width = 75;
            // 
            // masan
            // 
            this.masan.DataPropertyName = "masan";
            this.masan.HeaderText = "Mã sân";
            this.masan.MinimumWidth = 6;
            this.masan.Name = "masan";
            this.masan.ReadOnly = true;
            this.masan.Width = 75;
            // 
            // batdau
            // 
            this.batdau.DataPropertyName = "thoigianbatdau";
            this.batdau.HeaderText = "Thời gian bắt đầu";
            this.batdau.MinimumWidth = 6;
            this.batdau.Name = "batdau";
            this.batdau.ReadOnly = true;
            this.batdau.Width = 110;
            // 
            // ketthuc
            // 
            this.ketthuc.DataPropertyName = "thoigiancaidat";
            this.ketthuc.HeaderText = "Thời gian cài đặt";
            this.ketthuc.MinimumWidth = 6;
            this.ketthuc.Name = "ketthuc";
            this.ketthuc.ReadOnly = true;
            this.ketthuc.Width = 110;
            // 
            // ngaydat
            // 
            this.ngaydat.DataPropertyName = "ngaydat";
            this.ngaydat.HeaderText = "Ngày đặt";
            this.ngaydat.MinimumWidth = 6;
            this.ngaydat.Name = "ngaydat";
            this.ngaydat.ReadOnly = true;
            this.ngaydat.Width = 110;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtiensan";
            this.tongtien.HeaderText = "Tổng tiền sân";
            this.tongtien.MinimumWidth = 6;
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            this.tongtien.Width = 125;
            // 
            // tiencoc
            // 
            this.tiencoc.DataPropertyName = "tiencoc";
            this.tiencoc.HeaderText = "Tiền cọc";
            this.tiencoc.MinimumWidth = 6;
            this.tiencoc.Name = "tiencoc";
            this.tiencoc.ReadOnly = true;
            this.tiencoc.Width = 125;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.MinimumWidth = 6;
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            this.trangthai.Width = 125;
            // 
            // ucDatSan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbLichSu);
            this.Controls.Add(this.grbFormDatSan);
            this.Controls.Add(this.grbSanBong);
            this.Name = "ucDatSan";
            this.Size = new System.Drawing.Size(1040, 747);
            this.Load += new System.EventHandler(this.ucDatSan_Load);
            this.grbSanBong.ResumeLayout(false);
            this.grbFormDatSan.ResumeLayout(false);
            this.grbFormDatSan.PerformLayout();
            this.grbLichSu.ResumeLayout(false);
            this.grbLichSu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDatSan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSanBong;
        private System.Windows.Forms.ListView lvSanBong;
        private System.Windows.Forms.GroupBox grbFormDatSan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpGioDat;
        private System.Windows.Forms.DateTimePicker dtpNgayDat;
        private System.Windows.Forms.TextBox txtMaSan;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.TextBox txtMaPhieuDat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.ComboBox cbbGioChoi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox grbLichSu;
        private System.Windows.Forms.TextBox txtTimMPD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DataGridView dgvPhieuDatSan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn masan;
        private System.Windows.Forms.DataGridViewTextBoxColumn batdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketthuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiencoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.Button btnClear;
    }
}
