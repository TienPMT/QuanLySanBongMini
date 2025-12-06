namespace QuanLySanBongMini
{
    partial class ucNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.gridQuanLyNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtLuongCoBan = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.pickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.radioNam = new System.Windows.Forms.RadioButton();
            this.radioNu = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuanLyNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("MS Outlook", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1050, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridQuanLyNhanVien
            // 
            this.gridQuanLyNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridQuanLyNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQuanLyNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhanVien,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.Email,
            this.SDT,
            this.LuongCB,
            this.ChucVu,
            this.MaChucVu});
            this.gridQuanLyNhanVien.Location = new System.Drawing.Point(18, 236);
            this.gridQuanLyNhanVien.Name = "gridQuanLyNhanVien";
            this.gridQuanLyNhanVien.ReadOnly = true;
            this.gridQuanLyNhanVien.RowHeadersWidth = 51;
            this.gridQuanLyNhanVien.RowTemplate.Height = 24;
            this.gridQuanLyNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridQuanLyNhanVien.Size = new System.Drawing.Size(1018, 436);
            this.gridQuanLyNhanVien.TabIndex = 1;
            this.gridQuanLyNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridQuanLyNhanVien_CellClick);
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTenNhanVien";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 125;
            // 
            // LuongCB
            // 
            this.LuongCB.DataPropertyName = "LuongCB";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.LuongCB.DefaultCellStyle = dataGridViewCellStyle1;
            this.LuongCB.HeaderText = "Lương cơ bản";
            this.LuongCB.MinimumWidth = 6;
            this.LuongCB.Name = "LuongCB";
            this.LuongCB.ReadOnly = true;
            this.LuongCB.Width = 125;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "TenChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            this.ChucVu.Width = 125;
            // 
            // MaChucVu
            // 
            this.MaChucVu.DataPropertyName = "MaChucVu";
            this.MaChucVu.HeaderText = "Mã chức vụ";
            this.MaChucVu.MinimumWidth = 6;
            this.MaChucVu.Name = "MaChucVu";
            this.MaChucVu.ReadOnly = true;
            this.MaChucVu.Visible = false;
            this.MaChucVu.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(395, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Chức vụ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lương cơ bản";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(420, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Email";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(760, 76);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(136, 27);
            this.btnThemNV.TabIndex = 10;
            this.btnThemNV.Text = "Thêm nhân viên";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Location = new System.Drawing.Point(760, 114);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(136, 27);
            this.btnXoaNV.TabIndex = 11;
            this.btnXoaNV.Text = "Xoá nhân viên";
            this.btnXoaNV.UseVisualStyleBackColor = true;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(760, 154);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(136, 27);
            this.btnCapNhat.TabIndex = 12;
            this.btnCapNhat.Text = "Cập nhật thông tin";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(169, 78);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(179, 22);
            this.txtMaNV.TabIndex = 13;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(169, 114);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(179, 22);
            this.txtHoTen.TabIndex = 14;
            this.txtHoTen.TextChanged += new System.EventHandler(this.txtHoTen_TextChanged);
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // txtLuongCoBan
            // 
            this.txtLuongCoBan.Location = new System.Drawing.Point(490, 153);
            this.txtLuongCoBan.Name = "txtLuongCoBan";
            this.txtLuongCoBan.Size = new System.Drawing.Size(135, 22);
            this.txtLuongCoBan.TabIndex = 19;
            this.txtLuongCoBan.TextChanged += new System.EventHandler(this.txtLuongCoBan_TextChanged);
            this.txtLuongCoBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(490, 113);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(179, 22);
            this.txtSoDienThoai.TabIndex = 18;
            this.txtSoDienThoai.TextChanged += new System.EventHandler(this.txtSoDienThoai_TextChanged);
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(490, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 22);
            this.txtEmail.TabIndex = 17;
            // 
            // cboChucVu
            // 
            this.cboChucVu.DisplayMember = "TenChucVu";
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(490, 192);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(179, 24);
            this.cboChucVu.TabIndex = 20;
            this.cboChucVu.ValueMember = "MaChucVu";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(760, 193);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(136, 27);
            this.btnLamMoi.TabIndex = 21;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // pickerNgaySinh
            // 
            this.pickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.pickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerNgaySinh.Location = new System.Drawing.Point(169, 193);
            this.pickerNgaySinh.Name = "pickerNgaySinh";
            this.pickerNgaySinh.Size = new System.Drawing.Size(179, 22);
            this.pickerNgaySinh.TabIndex = 22;
            // 
            // radioNam
            // 
            this.radioNam.AutoSize = true;
            this.radioNam.Location = new System.Drawing.Point(185, 153);
            this.radioNam.Name = "radioNam";
            this.radioNam.Size = new System.Drawing.Size(57, 20);
            this.radioNam.TabIndex = 23;
            this.radioNam.TabStop = true;
            this.radioNam.Text = "Nam";
            this.radioNam.UseVisualStyleBackColor = true;
            // 
            // radioNu
            // 
            this.radioNu.AutoSize = true;
            this.radioNu.Location = new System.Drawing.Point(263, 153);
            this.radioNu.Name = "radioNu";
            this.radioNu.Size = new System.Drawing.Size(45, 20);
            this.radioNu.TabIndex = 24;
            this.radioNu.TabStop = true;
            this.radioNu.Text = "Nữ";
            this.radioNu.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(631, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "VNĐ";
            // 
            // ucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.radioNu);
            this.Controls.Add(this.radioNam);
            this.Controls.Add(this.pickerNgaySinh);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.cboChucVu);
            this.Controls.Add(this.txtLuongCoBan);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridQuanLyNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "ucNhanVien";
            this.Size = new System.Drawing.Size(1050, 700);
            this.Load += new System.EventHandler(this.ucNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridQuanLyNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridQuanLyNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtLuongCoBan;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChucVu;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DateTimePicker pickerNgaySinh;
        private System.Windows.Forms.RadioButton radioNam;
        private System.Windows.Forms.RadioButton radioNu;
        private System.Windows.Forms.Label label11;
    }
}
