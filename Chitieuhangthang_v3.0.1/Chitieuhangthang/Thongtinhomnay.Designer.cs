namespace Chitieuhangthang
{
    partial class Thongtinhomnay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thongtinhomnay));
            this.tableInfor = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoidiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trocap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietkiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tangdan = new System.Windows.Forms.ToolStripMenuItem();
            this.giamdan = new System.Windows.Forms.ToolStripMenuItem();
            this.Search = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.Danhmuc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MovePage = new System.Windows.Forms.NumericUpDown();
            this.Page = new System.Windows.Forms.Label();
            this.tongsl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tong = new System.Windows.Forms.Label();
            this.sl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfor)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovePage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableInfor
            // 
            this.tableInfor.AllowUserToOrderColumns = true;
            this.tableInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.sp,
            this.giamua,
            this.thoidiem,
            this.ngaymua,
            this.trocap,
            this.tietkiem,
            this.id});
            this.tableInfor.ContextMenuStrip = this.menu;
            this.tableInfor.Location = new System.Drawing.Point(14, 51);
            this.tableInfor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableInfor.Name = "tableInfor";
            this.tableInfor.RowTemplate.Height = 28;
            this.tableInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tableInfor.Size = new System.Drawing.Size(1000, 492);
            this.tableInfor.TabIndex = 0;
            this.tableInfor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableInfor_CellClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 65;
            // 
            // sp
            // 
            this.sp.DataPropertyName = "sanpham";
            this.sp.HeaderText = "Tên sản phẩm";
            this.sp.Name = "sp";
            this.sp.Width = 250;
            // 
            // giamua
            // 
            this.giamua.DataPropertyName = "giamua";
            this.giamua.HeaderText = "Giá mua";
            this.giamua.Name = "giamua";
            this.giamua.Width = 130;
            // 
            // thoidiem
            // 
            this.thoidiem.DataPropertyName = "thoidiem";
            this.thoidiem.HeaderText = "Thời điểm";
            this.thoidiem.Name = "thoidiem";
            this.thoidiem.Width = 122;
            // 
            // ngaymua
            // 
            this.ngaymua.DataPropertyName = "date";
            this.ngaymua.HeaderText = "Ngày mua";
            this.ngaymua.Name = "ngaymua";
            this.ngaymua.Width = 130;
            // 
            // trocap
            // 
            this.trocap.DataPropertyName = "trocap";
            this.trocap.HeaderText = "Trợ cấp";
            this.trocap.Name = "trocap";
            this.trocap.Width = 130;
            // 
            // tietkiem
            // 
            this.tietkiem.DataPropertyName = "tietkiem";
            this.tietkiem.HeaderText = "Tiết kiệm";
            this.tietkiem.Name = "tietkiem";
            this.tietkiem.Width = 130;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.SortMenu});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(148, 94);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // SortMenu
            // 
            this.SortMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tangdan,
            this.giamdan});
            this.SortMenu.Name = "SortMenu";
            this.SortMenu.Size = new System.Drawing.Size(147, 30);
            this.SortMenu.Text = "Sắp xếp";
            // 
            // tangdan
            // 
            this.tangdan.Name = "tangdan";
            this.tangdan.Size = new System.Drawing.Size(172, 30);
            this.tangdan.Text = "Tăng dần";
            this.tangdan.Click += new System.EventHandler(this.tangdan_Click);
            // 
            // giamdan
            // 
            this.giamdan.Name = "giamdan";
            this.giamdan.Size = new System.Drawing.Size(172, 30);
            this.giamdan.Text = "Giảm dần";
            this.giamdan.Click += new System.EventHandler(this.giamdan_Click);
            // 
            // Search
            // 
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.Location = new System.Drawing.Point(944, 8);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(42, 34);
            this.Search.TabIndex = 9;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchText.Location = new System.Drawing.Point(693, 7);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(245, 40);
            this.SearchText.TabIndex = 8;
            this.SearchText.Text = "Search";
            this.SearchText.Enter += new System.EventHandler(this.SearchText_Enter);
            this.SearchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchText_KeyPress);
            this.SearchText.Leave += new System.EventHandler(this.SearchText_Leave);
            // 
            // Danhmuc
            // 
            this.Danhmuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Danhmuc.FormattingEnabled = true;
            this.Danhmuc.ItemHeight = 27;
            this.Danhmuc.Items.AddRange(new object[] {
            "Tên sản phẩm",
            "Giá mua",
            "Ngày mua",
            "Thời điểm",
            "Trợ cấp",
            "Tiết kiệm",
            "ID"});
            this.Danhmuc.Location = new System.Drawing.Point(175, 7);
            this.Danhmuc.Name = "Danhmuc";
            this.Danhmuc.Size = new System.Drawing.Size(231, 35);
            this.Danhmuc.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Danh mục:";
            // 
            // MovePage
            // 
            this.MovePage.Location = new System.Drawing.Point(368, 594);
            this.MovePage.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MovePage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MovePage.Name = "MovePage";
            this.MovePage.Size = new System.Drawing.Size(241, 45);
            this.MovePage.TabIndex = 16;
            this.MovePage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MovePage.ValueChanged += new System.EventHandler(this.MovePage_ValueChanged);
            this.MovePage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MovePage_KeyPress);
            // 
            // Page
            // 
            this.Page.AutoSize = true;
            this.Page.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page.Location = new System.Drawing.Point(84, 548);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(19, 21);
            this.Page.TabIndex = 10;
            this.Page.Text = "1";
            // 
            // tongsl
            // 
            this.tongsl.AutoSize = true;
            this.tongsl.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongsl.Location = new System.Drawing.Point(979, 549);
            this.tongsl.Name = "tongsl";
            this.tongsl.Size = new System.Drawing.Size(19, 21);
            this.tongsl.TabIndex = 11;
            this.tongsl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(853, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tổng số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Trang: ";
            // 
            // tong
            // 
            this.tong.AutoSize = true;
            this.tong.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tong.Location = new System.Drawing.Point(38, 569);
            this.tong.Name = "tong";
            this.tong.Size = new System.Drawing.Size(89, 38);
            this.tong.TabIndex = 14;
            this.tong.Text = "Tổng:";
            // 
            // sl
            // 
            this.sl.AutoSize = true;
            this.sl.Location = new System.Drawing.Point(841, 569);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(142, 38);
            this.sl.TabIndex = 15;
            this.sl.Text = "Số lượng:";
            // 
            // Thongtinhomnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 651);
            this.Controls.Add(this.MovePage);
            this.Controls.Add(this.Page);
            this.Controls.Add(this.tongsl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tong);
            this.Controls.Add(this.sl);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.Danhmuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableInfor);
            this.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Thongtinhomnay";
            this.Text = "Thông tin hôm nay";
            this.Load += new System.EventHandler(this.Thongtinhomnay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableInfor)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MovePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tableInfor;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamua;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoidiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymua;
        private System.Windows.Forms.DataGridViewTextBoxColumn trocap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.ComboBox Danhmuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MovePage;
        private System.Windows.Forms.Label Page;
        private System.Windows.Forms.Label tongsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tong;
        private System.Windows.Forms.Label sl;
        private System.Windows.Forms.ToolStripMenuItem SortMenu;
        private System.Windows.Forms.ToolStripMenuItem tangdan;
        private System.Windows.Forms.ToolStripMenuItem giamdan;
    }
}