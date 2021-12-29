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
        private System.Windows.Forms.Button hdsd;
        private System.Windows.Forms.Button xemds;
        private System.Windows.Forms.Button btnColorText;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnMaunen;
        private System.Windows.Forms.Button btnHinhnen;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ComboBox thoidiemText;
        private System.Windows.Forms.ToolStripMenuItem RefreshMenu;
    }
}

