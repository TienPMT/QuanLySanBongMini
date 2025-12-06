namespace QuanLySanBongMini
{
    partial class ucKhachHang
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
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.txtSDTTimKiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.grbTimKiem.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKH
            // 
            this.dgvKH.CausesValidation = false;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makh,
            this.hoten,
            this.gioitinh,
            this.SDT});
            this.dgvKH.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvKH.Location = new System.Drawing.Point(-1, 295);
            this.dgvKH.MultiSelect = false;
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvKH.Size = new System.Drawing.Size(1040, 425);
            this.dgvKH.TabIndex = 6;
            this.dgvKH.SelectionChanged += new System.EventHandler(this.dgvKH_SelectionChanged);
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã khách hàng";
            this.makh.MinimumWidth = 6;
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            this.makh.Width = 150;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "hoten";
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Width = 250;
            // 
            // gioitinh
            // 
            this.gioitinh.DataPropertyName = "gioitinh";
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ReadOnly = true;
            this.gioitinh.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 225;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.txtSDTTimKiem);
            this.grbTimKiem.Controls.Add(this.label5);
            this.grbTimKiem.Controls.Add(this.btnTimKiem);
            this.grbTimKiem.Location = new System.Drawing.Point(508, 26);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(534, 262);
            this.grbTimKiem.TabIndex = 5;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // txtSDTTimKiem
            // 
            this.txtSDTTimKiem.Location = new System.Drawing.Point(119, 121);
            this.txtSDTTimKiem.Name = "txtSDTTimKiem";
            this.txtSDTTimKiem.Size = new System.Drawing.Size(320, 22);
            this.txtSDTTimKiem.TabIndex = 15;
            this.txtSDTTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số điện thoại:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(445, 121);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.btnXoa);
            this.grbThongTin.Controls.Add(this.btnSua);
            this.grbThongTin.Controls.Add(this.btnThem);
            this.grbThongTin.Controls.Add(this.btnReload);
            this.grbThongTin.Controls.Add(this.rdbNu);
            this.grbThongTin.Controls.Add(this.rdbNam);
            this.grbThongTin.Controls.Add(this.txtSDT);
            this.grbThongTin.Controls.Add(this.txtTenKH);
            this.grbThongTin.Controls.Add(this.txtMaKH);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Location = new System.Drawing.Point(-2, 26);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(504, 262);
            this.grbThongTin.TabIndex = 4;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin khách hàng";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(263, 227);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(182, 227);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(101, 227);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(344, 227);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 12;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(182, 163);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(45, 20);
            this.rdbNu.TabIndex = 8;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(119, 163);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(57, 20);
            this.rdbNam.TabIndex = 7;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(119, 124);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(379, 22);
            this.txtSDT.TabIndex = 6;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(119, 82);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(379, 22);
            this.txtTenKH.TabIndex = 5;
            this.txtTenKH.TextChanged += new System.EventHandler(this.txtTenKH_TextChanged);
            this.txtTenKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKH_KeyPress);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(119, 40);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(379, 22);
            this.txtMaKH.TabIndex = 4;
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKH_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng:";
            // 
            // ucKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvKH);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.grbThongTin);
            this.Name = "ucKhachHang";
            this.Size = new System.Drawing.Size(1040, 747);
            this.Load += new System.EventHandler(this.ucKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.TextBox txtSDTTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
