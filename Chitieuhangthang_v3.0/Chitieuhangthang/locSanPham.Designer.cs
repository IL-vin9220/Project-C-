namespace Chitieuhangthang
{
    partial class locSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(locSanPham));
            this.tabelLoc = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaymua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoidiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trocap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tietkiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuLoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tong = new System.Windows.Forms.Label();
            this.minValue = new System.Windows.Forms.Label();
            this.minKey = new System.Windows.Forms.Label();
            this.maxValue = new System.Windows.Forms.Label();
            this.maxKey = new System.Windows.Forms.Label();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.demsl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabelLoc)).BeginInit();
            this.menuLoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelLoc
            // 
            this.tabelLoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelLoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.sanpham,
            this.giamua,
            this.ngaymua,
            this.thoidiem,
            this.trocap,
            this.tietkiem,
            this.id});
            this.tabelLoc.ContextMenuStrip = this.menuLoc;
            this.tabelLoc.Location = new System.Drawing.Point(10, 15);
            this.tabelLoc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabelLoc.Name = "tabelLoc";
            this.tabelLoc.RowTemplate.Height = 28;
            this.tabelLoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tabelLoc.Size = new System.Drawing.Size(1000, 440);
            this.tabelLoc.TabIndex = 0;
            this.tabelLoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelLoc_CellClick);
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
            this.thoidiem.Width = 122;
            // 
            // trocap
            // 
            this.trocap.DataPropertyName = "trocap";
            this.trocap.HeaderText = "trợ cấp";
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
            // menuLoc
            // 
            this.menuLoc.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuLoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.menuLoc.Name = "menuLoc";
            this.menuLoc.Size = new System.Drawing.Size(143, 64);
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
            // tong
            // 
            this.tong.AutoSize = true;
            this.tong.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tong.Location = new System.Drawing.Point(181, 585);
            this.tong.Name = "tong";
            this.tong.Size = new System.Drawing.Size(0, 38);
            this.tong.TabIndex = 24;
            // 
            // minValue
            // 
            this.minValue.AutoSize = true;
            this.minValue.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minValue.Location = new System.Drawing.Point(557, 531);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(0, 38);
            this.minValue.TabIndex = 23;
            // 
            // minKey
            // 
            this.minKey.AutoSize = true;
            this.minKey.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minKey.Location = new System.Drawing.Point(181, 531);
            this.minKey.Name = "minKey";
            this.minKey.Size = new System.Drawing.Size(0, 38);
            this.minKey.TabIndex = 22;
            // 
            // maxValue
            // 
            this.maxValue.AutoSize = true;
            this.maxValue.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxValue.Location = new System.Drawing.Point(557, 471);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(0, 38);
            this.maxValue.TabIndex = 21;
            // 
            // maxKey
            // 
            this.maxKey.AutoSize = true;
            this.maxKey.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxKey.Location = new System.Drawing.Point(181, 474);
            this.maxKey.Name = "maxKey";
            this.maxKey.Size = new System.Drawing.Size(0, 38);
            this.maxKey.TabIndex = 20;
            // 
            // btnTong
            // 
            this.btnTong.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(35, 589);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(81, 36);
            this.btnTong.TabIndex = 19;
            this.btnTong.Text = "Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(35, 534);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(81, 36);
            this.btnMin.TabIndex = 18;
            this.btnMin.Text = "min";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnMax
            // 
            this.btnMax.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(35, 474);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(81, 36);
            this.btnMax.TabIndex = 17;
            this.btnMax.Text = "max";
            this.btnMax.UseVisualStyleBackColor = true;
            // 
            // demsl
            // 
            this.demsl.AutoSize = true;
            this.demsl.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demsl.Location = new System.Drawing.Point(847, 471);
            this.demsl.Name = "demsl";
            this.demsl.Size = new System.Drawing.Size(142, 38);
            this.demsl.TabIndex = 25;
            this.demsl.Text = "Số lượng:";
            // 
            // locSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 648);
            this.Controls.Add(this.demsl);
            this.Controls.Add(this.tong);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.minKey);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.maxKey);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.tabelLoc);
            this.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "locSanPham";
            this.Text = "Danh sách lọc sản phẩm";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelLoc)).EndInit();
            this.menuLoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelLoc;
        private System.Windows.Forms.ContextMenuStrip menuLoc;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.Label tong;
        private System.Windows.Forms.Label minValue;
        private System.Windows.Forms.Label minKey;
        private System.Windows.Forms.Label maxValue;
        private System.Windows.Forms.Label maxKey;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Label demsl;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymua;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoidiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn trocap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}