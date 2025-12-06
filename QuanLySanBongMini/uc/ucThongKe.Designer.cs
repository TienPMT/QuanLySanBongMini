namespace QuanLySanBongMini.User_control
{
    partial class ucThongKe
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
            this.rptThongKeDoanhThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cboOption = new System.Windows.Forms.ComboBox();
            this.btnTimKiemHoaDon = new System.Windows.Forms.Button();
            this.pickerDoanhThu1 = new System.Windows.Forms.DateTimePicker();
            this.pickerDoanhThu2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLoiNhuan = new System.Windows.Forms.TextBox();
            this.txtTongChiPhi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();
            this.gridThongKeChiPhi = new System.Windows.Forms.DataGridView();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.btnTimKiemThongKe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongKeChiPhi)).BeginInit();
            this.SuspendLayout();
            // 
            // rptThongKeDoanhThu
            // 
            this.rptThongKeDoanhThu.ActiveViewIndex = -1;
            this.rptThongKeDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptThongKeDoanhThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptThongKeDoanhThu.Location = new System.Drawing.Point(16, 101);
            this.rptThongKeDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rptThongKeDoanhThu.Name = "rptThongKeDoanhThu";
            this.rptThongKeDoanhThu.Size = new System.Drawing.Size(1181, 353);
            this.rptThongKeDoanhThu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "TÌM KIẾM HÓA ĐƠN";
            // 
            // cboOption
            // 
            this.cboOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOption.FormattingEnabled = true;
            this.cboOption.Location = new System.Drawing.Point(343, 27);
            this.cboOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboOption.Name = "cboOption";
            this.cboOption.Size = new System.Drawing.Size(200, 24);
            this.cboOption.TabIndex = 3;
            this.cboOption.SelectedIndexChanged += new System.EventHandler(this.cboOption_SelectedIndexChanged);
            // 
            // btnTimKiemHoaDon
            // 
            this.btnTimKiemHoaDon.Location = new System.Drawing.Point(605, 46);
            this.btnTimKiemHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemHoaDon.Name = "btnTimKiemHoaDon";
            this.btnTimKiemHoaDon.Size = new System.Drawing.Size(117, 42);
            this.btnTimKiemHoaDon.TabIndex = 4;
            this.btnTimKiemHoaDon.Text = "Tìm kiếm";
            this.btnTimKiemHoaDon.UseVisualStyleBackColor = true;
            this.btnTimKiemHoaDon.Click += new System.EventHandler(this.btnTimKiemDoanhThu_Click);
            // 
            // pickerDoanhThu1
            // 
            this.pickerDoanhThu1.Location = new System.Drawing.Point(77, 65);
            this.pickerDoanhThu1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickerDoanhThu1.Name = "pickerDoanhThu1";
            this.pickerDoanhThu1.Size = new System.Drawing.Size(200, 22);
            this.pickerDoanhThu1.TabIndex = 5;
            // 
            // pickerDoanhThu2
            // 
            this.pickerDoanhThu2.Location = new System.Drawing.Point(343, 65);
            this.pickerDoanhThu2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickerDoanhThu2.Name = "pickerDoanhThu2";
            this.pickerDoanhThu2.Size = new System.Drawing.Size(200, 22);
            this.pickerDoanhThu2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(303, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "THỐNG KÊ CHI PHÍ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SeaGreen;
            this.label11.Location = new System.Drawing.Point(849, 723);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "LỢI NHUẬN";
            // 
            // txtLoiNhuan
            // 
            this.txtLoiNhuan.Location = new System.Drawing.Point(855, 750);
            this.txtLoiNhuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLoiNhuan.Name = "txtLoiNhuan";
            this.txtLoiNhuan.ReadOnly = true;
            this.txtLoiNhuan.Size = new System.Drawing.Size(251, 22);
            this.txtLoiNhuan.TabIndex = 25;
            // 
            // txtTongChiPhi
            // 
            this.txtTongChiPhi.Location = new System.Drawing.Point(864, 688);
            this.txtTongChiPhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongChiPhi.Name = "txtTongChiPhi";
            this.txtTongChiPhi.ReadOnly = true;
            this.txtTongChiPhi.Size = new System.Drawing.Size(251, 22);
            this.txtTongChiPhi.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(858, 661);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "TỔNG CHI PHÍ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(849, 570);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "TỔNG DOANH THU";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Location = new System.Drawing.Point(855, 613);
            this.txtTongDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.ReadOnly = true;
            this.txtTongDoanhThu.Size = new System.Drawing.Size(251, 22);
            this.txtTongDoanhThu.TabIndex = 23;
            // 
            // gridThongKeChiPhi
            // 
            this.gridThongKeChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridThongKeChiPhi.Location = new System.Drawing.Point(16, 550);
            this.gridThongKeChiPhi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridThongKeChiPhi.Name = "gridThongKeChiPhi";
            this.gridThongKeChiPhi.RowHeadersWidth = 51;
            this.gridThongKeChiPhi.Size = new System.Drawing.Size(785, 274);
            this.gridThongKeChiPhi.TabIndex = 26;
            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(85, 512);
            this.cboThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(200, 24);
            this.cboThang.TabIndex = 27;
            // 
            // cboNam
            // 
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(341, 512);
            this.cboNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(200, 24);
            this.cboNam.TabIndex = 28;
            // 
            // btnTimKiemThongKe
            // 
            this.btnTimKiemThongKe.Location = new System.Drawing.Point(592, 502);
            this.btnTimKiemThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiemThongKe.Name = "btnTimKiemThongKe";
            this.btnTimKiemThongKe.Size = new System.Drawing.Size(117, 42);
            this.btnTimKiemThongKe.TabIndex = 29;
            this.btnTimKiemThongKe.Text = "Tìm kiếm";
            this.btnTimKiemThongKe.UseVisualStyleBackColor = true;
            this.btnTimKiemThongKe.Click += new System.EventHandler(this.btnTimKiemThongKe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(512, 869);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "label3";
            // 
            // ucThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTimKiemThongKe);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.gridThongKeChiPhi);
            this.Controls.Add(this.txtLoiNhuan);
            this.Controls.Add(this.txtTongChiPhi);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pickerDoanhThu2);
            this.Controls.Add(this.pickerDoanhThu1);
            this.Controls.Add(this.btnTimKiemHoaDon);
            this.Controls.Add(this.cboOption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rptThongKeDoanhThu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucThongKe";
            this.Size = new System.Drawing.Size(1200, 900);
            this.Load += new System.EventHandler(this.ucThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridThongKeChiPhi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptThongKeDoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboOption;
        private System.Windows.Forms.Button btnTimKiemHoaDon;
        private System.Windows.Forms.DateTimePicker pickerDoanhThu1;
        private System.Windows.Forms.DateTimePicker pickerDoanhThu2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLoiNhuan;
        private System.Windows.Forms.TextBox txtTongChiPhi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.DataGridView gridThongKeChiPhi;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.Button btnTimKiemThongKe;
        private System.Windows.Forms.Label label3;
    }
}
