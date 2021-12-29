namespace Chitieuhangthang
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tableDanhSach = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoidiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trocap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietkiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SortTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tangdan = new System.Windows.Forms.ToolStripMenuItem();
            this.giamdan = new System.Windows.Forms.ToolStripMenuItem();
            this.tong = new System.Windows.Forms.Label();
            this.Tonggt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Danhmuc = new System.Windows.Forms.ComboBox();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Page = new System.Windows.Forms.Label();
            this.MovePage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Tongsl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableDanhSach)).BeginInit();
            this.menuTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovePage)).BeginInit();
            this.SuspendLayout();
            // 
            // tableDanhSach
            // 
            this.tableDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.sp,
            this.giamua,
            this.ngaymua,
            this.thoidiem,
            this.trocap,
            this.tietkiem,
            this.id});
            this.tableDanhSach.ContextMenuStrip = this.menuTable;
            this.tableDanhSach.Location = new System.Drawing.Point(12, 54);
            this.tableDanhSach.Name = "tableDanhSach";
            this.tableDanhSach.RowTemplate.Height = 28;
            this.tableDanhSach.Size = new System.Drawing.Size(1001, 492);
            this.tableDanhSach.TabIndex = 5;
            this.tableDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDanhSach_CellClick);
            this.tableDanhSach.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableDanhSach_CellMouseDown);
            this.tableDanhSach.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableDanhSach_CellMouseUp);
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
            // ngaymua
            // 
            this.ngaymua.DataPropertyName = "date";
            this.ngaymua.HeaderText = "Ngày mua";
            this.ngaymua.Name = "ngaymua";
            this.ngaymua.Width = 130;
            // 
            // thoidiem
            // 
            this.thoidiem.DataPropertyName = "thoidiem";
            this.thoidiem.HeaderText = "Thời điểm";
            this.thoidiem.Name = "thoidiem";
            this.thoidiem.Width = 123;
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
            // menuTable
            // 
            this.menuTable.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.SortTable});
            this.menuTable.Name = "menuTable";
            this.menuTable.Size = new System.Drawing.Size(148, 94);
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
            // SortTable
            // 
            this.SortTable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tangdan,
            this.giamdan});
            this.SortTable.Name = "SortTable";
            this.SortTable.Size = new System.Drawing.Size(147, 30);
            this.SortTable.Text = "Sắp xếp";
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
            // tong
            // 
            this.tong.AutoSize = true;
            this.tong.Location = new System.Drawing.Point(833, 569);
            this.tong.Name = "tong";
            this.tong.Size = new System.Drawing.Size(142, 38);
            this.tong.TabIndex = 7;
            this.tong.Text = "Số lượng:";
            // 
            // Tonggt
            // 
            this.Tonggt.AutoSize = true;
            this.Tonggt.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tonggt.Location = new System.Drawing.Point(30, 569);
            this.Tonggt.Name = "Tonggt";
            this.Tonggt.Size = new System.Drawing.Size(89, 38);
            this.Tonggt.TabIndex = 6;
            this.Tonggt.Text = "Tổng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục:";
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
            this.Danhmuc.Location = new System.Drawing.Point(164, 10);
            this.Danhmuc.Name = "Danhmuc";
            this.Danhmuc.Size = new System.Drawing.Size(231, 35);
            this.Danhmuc.TabIndex = 1;
            // 
            // SearchText
            // 
            this.SearchText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.SearchText.Location = new System.Drawing.Point(682, 12);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(245, 40);
            this.SearchText.TabIndex = 2;
            this.SearchText.Text = "Search";
            this.SearchText.Enter += new System.EventHandler(this.SearchText_Enter);
            this.SearchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchText_KeyPress);
            this.SearchText.Leave += new System.EventHandler(this.SearchText_Leave);
            // 
            // Search
            // 
            this.Search.Image = ((System.Drawing.Image)(resources.GetObject("Search.Image")));
            this.Search.Location = new System.Drawing.Point(933, 11);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(42, 34);
            this.Search.TabIndex = 3;
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Trang: ";
            // 
            // Page
            // 
            this.Page.AutoSize = true;
            this.Page.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page.Location = new System.Drawing.Point(76, 548);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(19, 21);
            this.Page.TabIndex = 6;
            this.Page.Text = "1";
            // 
            // MovePage
            // 
            this.MovePage.Location = new System.Drawing.Point(360, 594);
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
            this.MovePage.TabIndex = 8;
            this.MovePage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MovePage.ValueChanged += new System.EventHandler(this.MovePage_ValueChanged);
            this.MovePage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MovePage_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(845, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng số lượng:";
            // 
            // Tongsl
            // 
            this.Tongsl.AutoSize = true;
            this.Tongsl.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tongsl.Location = new System.Drawing.Point(971, 549);
            this.Tongsl.Name = "Tongsl";
            this.Tongsl.Size = new System.Drawing.Size(19, 21);
            this.Tongsl.TabIndex = 6;
            this.Tongsl.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 667);
            this.Controls.Add(this.MovePage);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.Danhmuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Page);
            this.Controls.Add(this.Tongsl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tonggt);
            this.Controls.Add(this.tong);
            this.Controls.Add(this.tableDanhSach);
            this.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form2";
            this.Text = "Danh sách chi tiêu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableDanhSach)).EndInit();
            this.menuTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MovePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableDanhSach;
        private System.Windows.Forms.Label tong;
        private System.Windows.Forms.ContextMenuStrip menuTable;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.Label Tonggt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Danhmuc;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ToolStripMenuItem SortTable;
        private System.Windows.Forms.ToolStripMenuItem tangdan;
        private System.Windows.Forms.ToolStripMenuItem giamdan;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymua;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoidiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn trocap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Page;
        private System.Windows.Forms.NumericUpDown MovePage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Tongsl;
    }
}