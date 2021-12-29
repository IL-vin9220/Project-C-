namespace Chitieuhangthang
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.thoidiemText = new System.Windows.Forms.ComboBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.ngay = new System.Windows.Forms.DateTimePicker();
            this.giamuaText = new System.Windows.Forms.TextBox();
            this.sanphamText = new System.Windows.Forms.TextBox();
            this.trocapText = new System.Windows.Forms.TextBox();
            this.tietkiemText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fillterGiamua = new System.Windows.Forms.TextBox();
            this.fillterSanpham = new System.Windows.Forms.TextBox();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.checkKhoang = new System.Windows.Forms.CheckBox();
            this.checkToanBo = new System.Windows.Forms.CheckBox();
            this.checkNgay = new System.Windows.Forms.CheckBox();
            this.checkGiaMua = new System.Windows.Forms.CheckBox();
            this.checkSanPham = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.hdsd = new System.Windows.Forms.Button();
            this.xemds = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnColorText = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnMaunen = new System.Windows.Forms.Button();
            this.btnHinhnen = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(314, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(483, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHI TIÊU HÀNG THÁNG";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 101);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(952, 565);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.thoidiemText);
            this.tabPage1.Controls.Add(this.btnNhap);
            this.tabPage1.Controls.Add(this.ngay);
            this.tabPage1.Controls.Add(this.giamuaText);
            this.tabPage1.Controls.Add(this.sanphamText);
            this.tabPage1.Controls.Add(this.trocapText);
            this.tabPage1.Controls.Add(this.tietkiemText);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(944, 520);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhập thông tin";
            // 
            // thoidiemText
            // 
            this.thoidiemText.FormattingEnabled = true;
            this.thoidiemText.Items.AddRange(new object[] {
            "Buổi Sáng",
            "Buổi Chiều",
            "Buổi Tối"});
            this.thoidiemText.Location = new System.Drawing.Point(627, 318);
            this.thoidiemText.Name = "thoidiemText";
            this.thoidiemText.Size = new System.Drawing.Size(261, 40);
            this.thoidiemText.TabIndex = 5;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(41, 435);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(287, 54);
            this.btnNhap.TabIndex = 6;
            this.btnNhap.Text = "Nhập thông tin";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // ngay
            // 
            this.ngay.CustomFormat = "dd-mm-yyyy";
            this.ngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ngay.Location = new System.Drawing.Point(627, 234);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(261, 40);
            this.ngay.TabIndex = 4;
            // 
            // giamuaText
            // 
            this.giamuaText.BackColor = System.Drawing.SystemColors.Window;
            this.giamuaText.Location = new System.Drawing.Point(627, 142);
            this.giamuaText.Name = "giamuaText";
            this.giamuaText.Size = new System.Drawing.Size(261, 40);
            this.giamuaText.TabIndex = 3;
            // 
            // sanphamText
            // 
            this.sanphamText.Location = new System.Drawing.Point(627, 58);
            this.sanphamText.Name = "sanphamText";
            this.sanphamText.Size = new System.Drawing.Size(261, 40);
            this.sanphamText.TabIndex = 2;
            // 
            // trocapText
            // 
            this.trocapText.Location = new System.Drawing.Point(50, 310);
            this.trocapText.Name = "trocapText";
            this.trocapText.Size = new System.Drawing.Size(261, 40);
            this.trocapText.TabIndex = 1;
            this.trocapText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.trocapText_KeyPress);
            // 
            // tietkiemText
            // 
            this.tietkiemText.Location = new System.Drawing.Point(50, 92);
            this.tietkiemText.Name = "tietkiemText";
            this.tietkiemText.Size = new System.Drawing.Size(261, 40);
            this.tietkiemText.TabIndex = 0;
            this.tietkiemText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tietkiemText_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sản phẩm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giá mua:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(455, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Thời điểm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trợ cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiết kiệm";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.fillterGiamua);
            this.tabPage2.Controls.Add(this.fillterSanpham);
            this.tabPage2.Controls.Add(this.end);
            this.tabPage2.Controls.Add(this.start);
            this.tabPage2.Controls.Add(this.btnLoc);
            this.tabPage2.Controls.Add(this.checkKhoang);
            this.tabPage2.Controls.Add(this.checkToanBo);
            this.tabPage2.Controls.Add(this.checkNgay);
            this.tabPage2.Controls.Add(this.checkGiaMua);
            this.tabPage2.Controls.Add(this.checkSanPham);
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(944, 520);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tìm kiếm - Lọc";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 32);
            this.label9.TabIndex = 11;
            this.label9.Text = "Giá mua:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 32);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tên sản phẩm:";
            // 
            // fillterGiamua
            // 
            this.fillterGiamua.Location = new System.Drawing.Point(240, 156);
            this.fillterGiamua.Name = "fillterGiamua";
            this.fillterGiamua.Size = new System.Drawing.Size(325, 40);
            this.fillterGiamua.TabIndex = 8;
            // 
            // fillterSanpham
            // 
            this.fillterSanpham.Location = new System.Drawing.Point(240, 63);
            this.fillterSanpham.Name = "fillterSanpham";
            this.fillterSanpham.Size = new System.Drawing.Size(325, 40);
            this.fillterSanpham.TabIndex = 7;
            // 
            // end
            // 
            this.end.CustomFormat = "dd-MM-yyyy";
            this.end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end.Location = new System.Drawing.Point(844, 406);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(24, 40);
            this.end.TabIndex = 6;
            // 
            // start
            // 
            this.start.CustomFormat = "dd-MM-yyyy";
            this.start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start.Location = new System.Drawing.Point(763, 406);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(24, 40);
            this.start.TabIndex = 5;
            // 
            // btnLoc
            // 
            this.btnLoc.ForeColor = System.Drawing.Color.Black;
            this.btnLoc.Location = new System.Drawing.Point(60, 415);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(139, 74);
            this.btnLoc.TabIndex = 9;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // checkKhoang
            // 
            this.checkKhoang.AutoSize = true;
            this.checkKhoang.Checked = true;
            this.checkKhoang.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkKhoang.Location = new System.Drawing.Point(714, 350);
            this.checkKhoang.Name = "checkKhoang";
            this.checkKhoang.Size = new System.Drawing.Size(203, 36);
            this.checkKhoang.TabIndex = 4;
            this.checkKhoang.Text = "Theo khoảng";
            this.checkKhoang.UseVisualStyleBackColor = true;
            this.checkKhoang.CheckedChanged += new System.EventHandler(this.checkKhoang_CheckedChanged);
            // 
            // checkToanBo
            // 
            this.checkToanBo.AutoSize = true;
            this.checkToanBo.Location = new System.Drawing.Point(535, 350);
            this.checkToanBo.Name = "checkToanBo";
            this.checkToanBo.Size = new System.Drawing.Size(140, 36);
            this.checkToanBo.TabIndex = 3;
            this.checkToanBo.Text = "Toàn bộ";
            this.checkToanBo.UseVisualStyleBackColor = true;
            this.checkToanBo.CheckedChanged += new System.EventHandler(this.checkToanBo_CheckedChanged);
            // 
            // checkNgay
            // 
            this.checkNgay.AutoSize = true;
            this.checkNgay.Location = new System.Drawing.Point(655, 264);
            this.checkNgay.Name = "checkNgay";
            this.checkNgay.Size = new System.Drawing.Size(106, 36);
            this.checkNgay.TabIndex = 2;
            this.checkNgay.Text = "Ngày";
            this.checkNgay.UseVisualStyleBackColor = true;
            this.checkNgay.CheckedChanged += new System.EventHandler(this.checkNgay_CheckedChanged);
            // 
            // checkGiaMua
            // 
            this.checkGiaMua.AutoSize = true;
            this.checkGiaMua.Location = new System.Drawing.Point(655, 160);
            this.checkGiaMua.Name = "checkGiaMua";
            this.checkGiaMua.Size = new System.Drawing.Size(148, 36);
            this.checkGiaMua.TabIndex = 1;
            this.checkGiaMua.Text = "Giá mua";
            this.checkGiaMua.UseVisualStyleBackColor = true;
            this.checkGiaMua.CheckedChanged += new System.EventHandler(this.checkGiaMua_CheckedChanged);
            // 
            // checkSanPham
            // 
            this.checkSanPham.AutoSize = true;
            this.checkSanPham.Location = new System.Drawing.Point(655, 56);
            this.checkSanPham.Name = "checkSanPham";
            this.checkSanPham.Size = new System.Drawing.Size(170, 36);
            this.checkSanPham.TabIndex = 0;
            this.checkSanPham.Text = "Sản phẩm";
            this.checkSanPham.UseVisualStyleBackColor = true;
            this.checkSanPham.CheckedChanged += new System.EventHandler(this.checkSanPham_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.hdsd);
            this.tabPage3.Controls.Add(this.xemds);
            this.tabPage3.Location = new System.Drawing.Point(4, 41);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(944, 520);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Trợ giúp";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // hdsd
            // 
            this.hdsd.Location = new System.Drawing.Point(326, 275);
            this.hdsd.Name = "hdsd";
            this.hdsd.Size = new System.Drawing.Size(252, 74);
            this.hdsd.TabIndex = 1;
            this.hdsd.Text = "Hướng dẫn sử dụng";
            this.hdsd.UseVisualStyleBackColor = true;
            this.hdsd.Click += new System.EventHandler(this.hdsd_Click);
            // 
            // xemds
            // 
            this.xemds.Location = new System.Drawing.Point(326, 82);
            this.xemds.Name = "xemds";
            this.xemds.Size = new System.Drawing.Size(252, 74);
            this.xemds.TabIndex = 0;
            this.xemds.Text = "Xem danh sách";
            this.xemds.UseVisualStyleBackColor = true;
            this.xemds.Click += new System.EventHandler(this.xemds_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.btnColorText);
            this.tabPage4.Controls.Add(this.btnFont);
            this.tabPage4.Controls.Add(this.btnMaunen);
            this.tabPage4.Controls.Add(this.btnHinhnen);
            this.tabPage4.Location = new System.Drawing.Point(4, 41);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(944, 520);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cài đặt";
            // 
            // btnColorText
            // 
            this.btnColorText.Location = new System.Drawing.Point(566, 214);
            this.btnColorText.Name = "btnColorText";
            this.btnColorText.Size = new System.Drawing.Size(279, 60);
            this.btnColorText.TabIndex = 3;
            this.btnColorText.Text = "Đổi màu chữ";
            this.btnColorText.UseVisualStyleBackColor = true;
            this.btnColorText.Click += new System.EventHandler(this.btnColorText_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(566, 52);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(279, 60);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "Đổi font chữ";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnMaunen
            // 
            this.btnMaunen.Location = new System.Drawing.Point(51, 214);
            this.btnMaunen.Name = "btnMaunen";
            this.btnMaunen.Size = new System.Drawing.Size(279, 60);
            this.btnMaunen.TabIndex = 1;
            this.btnMaunen.Text = "Đổi màu nền";
            this.btnMaunen.UseVisualStyleBackColor = true;
            this.btnMaunen.Click += new System.EventHandler(this.btnMaunen_Click);
            // 
            // btnHinhnen
            // 
            this.btnHinhnen.Location = new System.Drawing.Point(51, 52);
            this.btnHinhnen.Name = "btnHinhnen";
            this.btnHinhnen.Size = new System.Drawing.Size(279, 60);
            this.btnHinhnen.TabIndex = 0;
            this.btnHinhnen.Text = "Đổi hình nền";
            this.btnHinhnen.UseVisualStyleBackColor = true;
            this.btnHinhnen.Click += new System.EventHandler(this.btnHinhnen_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinToolStripMenuItem,
            this.InfoToolStripMenuItem,
            this.RefreshMenu,
            this.exitToolStripMenuItem1});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(236, 124);
            // 
            // xemThôngTinToolStripMenuItem
            // 
            this.xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
            this.xemThôngTinToolStripMenuItem.Size = new System.Drawing.Size(235, 30);
            this.xemThôngTinToolStripMenuItem.Text = "Xem thông tin";
            this.xemThôngTinToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(235, 30);
            this.InfoToolStripMenuItem.Text = "Thông tin hôm nay";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // RefreshMenu
            // 
            this.RefreshMenu.Name = "RefreshMenu";
            this.RefreshMenu.Size = new System.Drawing.Size(235, 30);
            this.RefreshMenu.Text = "Refresh";
            this.RefreshMenu.Click += new System.EventHandler(this.RefreshMenu_Click_1);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(235, 30);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(976, 678);
            this.ContextMenuStrip = this.menu;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(998, 734);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiêu hàng tháng v3.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.DateTimePicker ngay;
        private System.Windows.Forms.TextBox giamuaText;
        private System.Windows.Forms.TextBox sanphamText;
        private System.Windows.Forms.TextBox trocapText;
        private System.Windows.Forms.TextBox tietkiemText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker start;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.CheckBox checkKhoang;
        private System.Windows.Forms.CheckBox checkToanBo;
        private System.Windows.Forms.CheckBox checkNgay;
        private System.Windows.Forms.CheckBox checkGiaMua;
        private System.Windows.Forms.CheckBox checkSanPham;
        private System.Windows.Forms.Button hdsd;
        private System.Windows.Forms.Button xemds;
        private System.Windows.Forms.Button btnColorText;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnMaunen;
        private System.Windows.Forms.Button btnHinhnen;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.DateTimePicker end;
        private System.Windows.Forms.ComboBox thoidiemText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fillterGiamua;
        private System.Windows.Forms.TextBox fillterSanpham;
        private System.Windows.Forms.ToolStripMenuItem RefreshMenu;
    }
}

