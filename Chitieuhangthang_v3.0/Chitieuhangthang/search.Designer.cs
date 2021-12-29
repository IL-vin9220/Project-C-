namespace Chitieuhangthang
{
    partial class search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            this.Tonggt = new System.Windows.Forms.Label();
            this.soluong = new System.Windows.Forms.Label();
            this.tableSearch = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoidiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trocap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietkiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuSearch = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.Sort = new System.Windows.Forms.ToolStripMenuItem();
            this.tangdan = new System.Windows.Forms.ToolStripMenuItem();
            this.giamdan = new System.Windows.Forms.ToolStripMenuItem();
            this.MovePage = new System.Windows.Forms.NumericUpDown();
            this.Page = new System.Windows.Forms.Label();
            this.Tongsl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableSearch)).BeginInit();
            this.menuSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovePage)).BeginInit();
            this.SuspendLayout();
            // 
            // Tonggt
            // 
            this.Tonggt.AutoSize = true;
            this.Tonggt.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tonggt.Location = new System.Drawing.Point(25, 534);
            this.Tonggt.Name = "Tonggt";
            this.Tonggt.Size = new System.Drawing.Size(89, 38);
            this.Tonggt.TabIndex = 37;
            this.Tonggt.Text = "Tổng:";
            // 
            // soluong
            // 
            this.soluong.AutoSize = true;
            this.soluong.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluong.Location = new System.Drawing.Point(844, 534);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(142, 38);
            this.soluong.TabIndex = 36;
            this.soluong.Text = "Số lượng:";
            // 
            // tableSearch
            // 
            this.tableSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.sanpham,
            this.giamua,
            this.ngaymua,
            this.thoidiem,
            this.trocap,
            this.tietkiem,
            this.id});
            this.tableSearch.ContextMenuStrip = this.menuSearch;
            this.tableSearch.Location = new System.Drawing.Point(13, 19);
            this.tableSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableSearch.Name = "tableSearch";
            this.tableSearch.RowTemplate.Height = 28;
            this.tableSearch.Size = new System.Drawing.Size(1003, 486);
            this.tableSearch.TabIndex = 35;
            this.tableSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableSearch_CellClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 65;
            // 
            // sanpham
            // 
            this.sanpham.DataPropertyName = "sanpham";
            this.sanpham.HeaderText = "Tên sản phẩm";
            this.sanpham.Name = "sanpham";
            this.sanpham.Width = 250;
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
            // menuSearch
            // 
            this.menuSearch.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuSearch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete,
            this.Sort});
            this.menuSearch.Name = "menuSearch";
            this.menuSearch.Size = new System.Drawing.Size(148, 64);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(147, 30);
            this.Delete.Text = "Xóa";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Sort
            // 
            this.Sort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tangdan,
            this.giamdan});
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(147, 30);
            this.Sort.Text = "Sắp xếp";
            // 
            // tangdan
            // 
            this.tangdan.Name = "tangdan";
            this.tangdan.Size = new System.Drawing.Size(252, 30);
            this.tangdan.Text = "Tăng dần";
            this.tangdan.Click += new System.EventHandler(this.tangdan_Click);
            // 
            // giamdan
            // 
            this.giamdan.Name = "giamdan";
            this.giamdan.Size = new System.Drawing.Size(252, 30);
            this.giamdan.Text = "Giảm dần";
            this.giamdan.Click += new System.EventHandler(this.giamdan_Click);
            // 
            // MovePage
            // 
            this.MovePage.Location = new System.Drawing.Point(370, 554);
            this.MovePage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MovePage.Name = "MovePage";
            this.MovePage.Size = new System.Drawing.Size(235, 45);
            this.MovePage.TabIndex = 38;
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
            this.Page.Location = new System.Drawing.Point(80, 511);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(19, 21);
            this.Page.TabIndex = 39;
            this.Page.Text = "1";
            // 
            // Tongsl
            // 
            this.Tongsl.AutoSize = true;
            this.Tongsl.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tongsl.Location = new System.Drawing.Point(987, 511);
            this.Tongsl.Name = "Tongsl";
            this.Tongsl.Size = new System.Drawing.Size(19, 21);
            this.Tongsl.TabIndex = 40;
            this.Tongsl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(861, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tổng số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 42;
            this.label2.Text = "Trang: ";
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 634);
            this.Controls.Add(this.Page);
            this.Controls.Add(this.Tongsl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MovePage);
            this.Controls.Add(this.Tonggt);
            this.Controls.Add(this.soluong);
            this.Controls.Add(this.tableSearch);
            this.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "search";
            this.Text = "search";
            this.Load += new System.EventHandler(this.search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableSearch)).EndInit();
            this.menuSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MovePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tonggt;
        private System.Windows.Forms.Label soluong;
        private System.Windows.Forms.DataGridView tableSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymua;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoidiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn trocap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.ContextMenuStrip menuSearch;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem Sort;
        private System.Windows.Forms.ToolStripMenuItem tangdan;
        private System.Windows.Forms.ToolStripMenuItem giamdan;
        private System.Windows.Forms.NumericUpDown MovePage;
        private System.Windows.Forms.Label Page;
        private System.Windows.Forms.Label Tongsl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}