namespace Chitieuhangthang
{
    partial class locGiaMua
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(locGiaMua));
            this.tong = new System.Windows.Forms.Label();
            this.tableLocGia = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoidiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trocap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietkiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tonggt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableLocGia)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tong
            // 
            this.tong.AutoSize = true;
            this.tong.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tong.Location = new System.Drawing.Point(842, 591);
            this.tong.Name = "tong";
            this.tong.Size = new System.Drawing.Size(142, 38);
            this.tong.TabIndex = 33;
            this.tong.Text = "Số lượng:";
            // 
            // tableLocGia
            // 
            this.tableLocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLocGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.sanpham,
            this.giamua,
            this.ngaymua,
            this.thoidiem,
            this.trocap,
            this.tietkiem,
            this.id});
            this.tableLocGia.ContextMenuStrip = this.menu;
            this.tableLocGia.Location = new System.Drawing.Point(12, 19);
            this.tableLocGia.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLocGia.Name = "tableLocGia";
            this.tableLocGia.RowTemplate.Height = 28;
            this.tableLocGia.Size = new System.Drawing.Size(1003, 566);
            this.tableLocGia.TabIndex = 25;
            this.tableLocGia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableLocGia_CellClick);
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
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.menu.Name = "contextMenuStrip1";
            this.menu.Size = new System.Drawing.Size(143, 64);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // Tonggt
            // 
            this.Tonggt.AutoSize = true;
            this.Tonggt.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tonggt.Location = new System.Drawing.Point(25, 591);
            this.Tonggt.Name = "Tonggt";
            this.Tonggt.Size = new System.Drawing.Size(89, 38);
            this.Tonggt.TabIndex = 34;
            this.Tonggt.Text = "Tổng:";
            // 
            // locGiaMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 648);
            this.Controls.Add(this.Tonggt);
            this.Controls.Add(this.tong);
            this.Controls.Add(this.tableLocGia);
            this.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "locGiaMua";
            this.Text = "Danh sách lọc giá mua hàng";
            this.Load += new System.EventHandler(this.locGiaMua_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableLocGia)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tong;
        private System.Windows.Forms.DataGridView tableLocGia;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymua;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoidiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn trocap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label Tonggt;
    }
}