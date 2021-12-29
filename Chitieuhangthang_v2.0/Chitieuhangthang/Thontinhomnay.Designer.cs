namespace Chitieuhangthang
{
    partial class Thontinhomnay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thontinhomnay));
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
            this.max = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.tong = new System.Windows.Forms.Button();
            this.maxKey = new System.Windows.Forms.Label();
            this.maxValue = new System.Windows.Forms.Label();
            this.minKey = new System.Windows.Forms.Label();
            this.minValue = new System.Windows.Forms.Label();
            this.tonggt = new System.Windows.Forms.Label();
            this.dem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfor)).BeginInit();
            this.menu.SuspendLayout();
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
            this.tableInfor.Location = new System.Drawing.Point(14, 15);
            this.tableInfor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableInfor.Name = "tableInfor";
            this.tableInfor.RowTemplate.Height = 28;
            this.tableInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tableInfor.Size = new System.Drawing.Size(1000, 398);
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
            this.xóaToolStripMenuItem});
            this.menu.Name = "menu";
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
            // max
            // 
            this.max.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.Location = new System.Drawing.Point(26, 441);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(93, 40);
            this.max.TabIndex = 1;
            this.max.Text = "max";
            this.max.UseVisualStyleBackColor = true;
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(26, 509);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(93, 40);
            this.min.TabIndex = 1;
            this.min.Text = "min";
            this.min.UseVisualStyleBackColor = true;
            // 
            // tong
            // 
            this.tong.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tong.Location = new System.Drawing.Point(26, 586);
            this.tong.Name = "tong";
            this.tong.Size = new System.Drawing.Size(93, 40);
            this.tong.TabIndex = 1;
            this.tong.Text = "Tổng";
            this.tong.UseVisualStyleBackColor = true;
            // 
            // maxKey
            // 
            this.maxKey.AutoSize = true;
            this.maxKey.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxKey.Location = new System.Drawing.Point(199, 443);
            this.maxKey.Name = "maxKey";
            this.maxKey.Size = new System.Drawing.Size(79, 32);
            this.maxKey.TabIndex = 2;
            this.maxKey.Text = "label1";
            // 
            // maxValue
            // 
            this.maxValue.AutoSize = true;
            this.maxValue.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxValue.Location = new System.Drawing.Point(617, 443);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(79, 32);
            this.maxValue.TabIndex = 3;
            this.maxValue.Text = "label2";
            // 
            // minKey
            // 
            this.minKey.AutoSize = true;
            this.minKey.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minKey.Location = new System.Drawing.Point(199, 517);
            this.minKey.Name = "minKey";
            this.minKey.Size = new System.Drawing.Size(79, 32);
            this.minKey.TabIndex = 4;
            this.minKey.Text = "label3";
            // 
            // minValue
            // 
            this.minValue.AutoSize = true;
            this.minValue.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minValue.Location = new System.Drawing.Point(617, 511);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(79, 32);
            this.minValue.TabIndex = 6;
            this.minValue.Text = "label4";
            // 
            // tonggt
            // 
            this.tonggt.AutoSize = true;
            this.tonggt.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tonggt.Location = new System.Drawing.Point(199, 594);
            this.tonggt.Name = "tonggt";
            this.tonggt.Size = new System.Drawing.Size(79, 32);
            this.tonggt.TabIndex = 5;
            this.tonggt.Text = "label5";
            // 
            // dem
            // 
            this.dem.AutoSize = true;
            this.dem.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dem.Location = new System.Drawing.Point(909, 431);
            this.dem.Name = "dem";
            this.dem.Size = new System.Drawing.Size(79, 32);
            this.dem.TabIndex = 5;
            this.dem.Text = "label5";
            // 
            // Thontinhomnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 651);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.dem);
            this.Controls.Add(this.tonggt);
            this.Controls.Add(this.minKey);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.maxKey);
            this.Controls.Add(this.min);
            this.Controls.Add(this.tong);
            this.Controls.Add(this.max);
            this.Controls.Add(this.tableInfor);
            this.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Thontinhomnay";
            this.Text = "Thông tin hôm nay";
            this.Load += new System.EventHandler(this.Thontinhomnay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableInfor)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tableInfor;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.Button max;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button tong;
        private System.Windows.Forms.Label maxKey;
        private System.Windows.Forms.Label maxValue;
        private System.Windows.Forms.Label minKey;
        private System.Windows.Forms.Label minValue;
        private System.Windows.Forms.Label tonggt;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamua;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoidiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaymua;
        private System.Windows.Forms.DataGridViewTextBoxColumn trocap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tietkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.Label dem;
    }
}