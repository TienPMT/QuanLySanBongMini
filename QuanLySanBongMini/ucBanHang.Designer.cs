namespace QuanLySanBongMini
{
    partial class ucBanHang
    {
       
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

        private void InitializeComponent()
        {
            this.thucdon_Menu = new System.Windows.Forms.SplitContainer();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tab_ThucUong = new System.Windows.Forms.TabPage();
            this.flp_DoUong = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_ThucAn = new System.Windows.Forms.TabPage();
            this.flp_DoAn = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_DoDung = new System.Windows.Forms.TabPage();
            this.flp_DoDung = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Mua = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.txt_TongThanhToan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridGioHang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.thucdon_Menu)).BeginInit();
            this.thucdon_Menu.Panel1.SuspendLayout();
            this.thucdon_Menu.Panel2.SuspendLayout();
            this.thucdon_Menu.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.tab_ThucUong.SuspendLayout();
            this.tab_ThucAn.SuspendLayout();
            this.tab_DoDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // thucdon_Menu
            // 
            this.thucdon_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thucdon_Menu.Location = new System.Drawing.Point(0, 0);
            this.thucdon_Menu.Name = "thucdon_Menu";
            // 
            // thucdon_Menu.Panel1
            // 
            this.thucdon_Menu.Panel1.AutoScroll = true;
            this.thucdon_Menu.Panel1.Controls.Add(this.tabMenu);
            // 
            // thucdon_Menu.Panel2
            // 
            this.thucdon_Menu.Panel2.Controls.Add(this.btn_Mua);
            this.thucdon_Menu.Panel2.Controls.Add(this.btn_Huy);
            this.thucdon_Menu.Panel2.Controls.Add(this.txt_TongThanhToan);
            this.thucdon_Menu.Panel2.Controls.Add(this.label2);
            this.thucdon_Menu.Panel2.Controls.Add(this.gridGioHang);
            this.thucdon_Menu.Size = new System.Drawing.Size(3464, 1727);
            this.thucdon_Menu.SplitterDistance = 1400;
            this.thucdon_Menu.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tab_ThucUong);
            this.tabMenu.Controls.Add(this.tab_ThucAn);
            this.tabMenu.Controls.Add(this.tab_DoDung);
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMenu.Location = new System.Drawing.Point(0, 0);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(1400, 1727);
            this.tabMenu.TabIndex = 0;
            // 
            // tab_ThucUong
            // 
            this.tab_ThucUong.AutoScroll = true;
            this.tab_ThucUong.Controls.Add(this.flp_DoUong);
            this.tab_ThucUong.Location = new System.Drawing.Point(12, 58);
            this.tab_ThucUong.Name = "tab_ThucUong";
            this.tab_ThucUong.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ThucUong.Size = new System.Drawing.Size(1376, 1657);
            this.tab_ThucUong.TabIndex = 0;
            this.tab_ThucUong.Text = "Thức Uống";
            this.tab_ThucUong.UseVisualStyleBackColor = true;
            // 
            // flp_DoUong
            // 
            this.flp_DoUong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_DoUong.Location = new System.Drawing.Point(3, 3);
            this.flp_DoUong.Name = "flp_DoUong";
            this.flp_DoUong.Size = new System.Drawing.Size(1370, 1651);
            this.flp_DoUong.TabIndex = 0;
            // 
            // tab_ThucAn
            // 
            this.tab_ThucAn.AutoScroll = true;
            this.tab_ThucAn.Controls.Add(this.flp_DoAn);
            this.tab_ThucAn.Location = new System.Drawing.Point(12, 58);
            this.tab_ThucAn.Name = "tab_ThucAn";
            this.tab_ThucAn.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ThucAn.Size = new System.Drawing.Size(1376, 1657);
            this.tab_ThucAn.TabIndex = 1;
            this.tab_ThucAn.Text = "Thức Ăn";
            this.tab_ThucAn.UseVisualStyleBackColor = true;
            // 
            // flp_DoAn
            // 
            this.flp_DoAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_DoAn.Location = new System.Drawing.Point(3, 3);
            this.flp_DoAn.Name = "flp_DoAn";
            this.flp_DoAn.Size = new System.Drawing.Size(1370, 1651);
            this.flp_DoAn.TabIndex = 0;
            // 
            // tab_DoDung
            // 
            this.tab_DoDung.AutoScroll = true;
            this.tab_DoDung.BackColor = System.Drawing.Color.Transparent;
            this.tab_DoDung.Controls.Add(this.flp_DoDung);
            this.tab_DoDung.Controls.Add(this.flowLayoutPanel2);
            this.tab_DoDung.Location = new System.Drawing.Point(12, 58);
            this.tab_DoDung.Name = "tab_DoDung";
            this.tab_DoDung.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DoDung.Size = new System.Drawing.Size(1376, 1657);
            this.tab_DoDung.TabIndex = 2;
            this.tab_DoDung.Text = "Đồ Dùng";
            // 
            // flp_DoDung
            // 
            this.flp_DoDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_DoDung.Location = new System.Drawing.Point(3, 3);
            this.flp_DoDung.Name = "flp_DoDung";
            this.flp_DoDung.Size = new System.Drawing.Size(1370, 1651);
            this.flp_DoDung.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(299, 778);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // btn_Mua
            // 
            this.btn_Mua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Mua.Location = new System.Drawing.Point(1148, 1523);
            this.btn_Mua.Name = "btn_Mua";
            this.btn_Mua.Size = new System.Drawing.Size(281, 145);
            this.btn_Mua.TabIndex = 6;
            this.btn_Mua.Text = "Mua";
            this.btn_Mua.UseVisualStyleBackColor = false;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(298, 1537);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(281, 145);
            this.btn_Huy.TabIndex = 5;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            // 
            // txt_TongThanhToan
            // 
            this.txt_TongThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongThanhToan.Location = new System.Drawing.Point(710, 1412);
            this.txt_TongThanhToan.Name = "txt_TongThanhToan";
            this.txt_TongThanhToan.Size = new System.Drawing.Size(270, 53);
            this.txt_TongThanhToan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 1419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng Thanh Toán: ";
            // 
            // gridGioHang
            // 
            this.gridGioHang.AllowUserToAddRows = false;
            this.gridGioHang.AllowUserToDeleteRows = false;
            this.gridGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenSP,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.gridGioHang.Location = new System.Drawing.Point(27, 228);
            this.gridGioHang.Name = "gridGioHang";
            this.gridGioHang.ReadOnly = true;
            this.gridGioHang.RowHeadersWidth = 123;
            this.gridGioHang.RowTemplate.Height = 46;
            this.gridGioHang.Size = new System.Drawing.Size(1980, 1170);
            this.gridGioHang.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 15;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 300;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên";
            this.TenSP.MinimumWidth = 15;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 300;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 15;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 300;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 15;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 300;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            this.ThanhTien.HeaderText = "Thành Tiền";
            this.ThanhTien.MinimumWidth = 15;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            this.ThanhTien.Width = 300;
            // 
            // ucBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.thucdon_Menu);
            this.Name = "ucBanHang";
            this.Size = new System.Drawing.Size(3464, 1727);
            this.Load += new System.EventHandler(this.ucBanHang_Load);
            this.thucdon_Menu.Panel1.ResumeLayout(false);
            this.thucdon_Menu.Panel2.ResumeLayout(false);
            this.thucdon_Menu.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thucdon_Menu)).EndInit();
            this.thucdon_Menu.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.tab_ThucUong.ResumeLayout(false);
            this.tab_ThucAn.ResumeLayout(false);
            this.tab_DoDung.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridGioHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer thucdon_Menu;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tab_ThucUong;
        private System.Windows.Forms.TabPage tab_ThucAn;
        private System.Windows.Forms.TabPage tab_DoDung;
        private System.Windows.Forms.FlowLayoutPanel flp_DoUong;
        private System.Windows.Forms.FlowLayoutPanel flp_DoAn;
        private System.Windows.Forms.FlowLayoutPanel flp_DoDung;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView gridGioHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Mua;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.TextBox txt_TongThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}
