namespace Chitieuhangthang
{
    partial class DetailWeek
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.WeekName = new System.Windows.Forms.Label();
            this.Detail = new System.Windows.Forms.DataGridView();
            this.mon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WeekPre = new System.Windows.Forms.Button();
            this.ChartWeek = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WeekInfor = new System.Windows.Forms.DataGridView();
            this.weekday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.WeekNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartWeek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeekInfor)).BeginInit();
            this.SuspendLayout();
            // 
            // WeekName
            // 
            this.WeekName.AutoSize = true;
            this.WeekName.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekName.ForeColor = System.Drawing.Color.Red;
            this.WeekName.Location = new System.Drawing.Point(452, 39);
            this.WeekName.Name = "WeekName";
            this.WeekName.Size = new System.Drawing.Size(120, 51);
            this.WeekName.TabIndex = 0;
            this.WeekName.Text = "Tuần:";
            // 
            // Detail
            // 
            this.Detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mon,
            this.tue,
            this.wen,
            this.thus,
            this.fri,
            this.sat,
            this.sun});
            this.Detail.Location = new System.Drawing.Point(212, 133);
            this.Detail.Name = "Detail";
            this.Detail.RowTemplate.Height = 28;
            this.Detail.Size = new System.Drawing.Size(953, 132);
            this.Detail.TabIndex = 1;
            // 
            // mon
            // 
            this.mon.HeaderText = "Thứ 2";
            this.mon.Name = "mon";
            this.mon.ReadOnly = true;
            this.mon.Width = 130;
            // 
            // tue
            // 
            this.tue.HeaderText = "Thứ 3";
            this.tue.Name = "tue";
            this.tue.ReadOnly = true;
            this.tue.Width = 130;
            // 
            // wen
            // 
            this.wen.HeaderText = "Thứ 4";
            this.wen.Name = "wen";
            this.wen.ReadOnly = true;
            this.wen.Width = 130;
            // 
            // thus
            // 
            this.thus.HeaderText = "Thứ 5";
            this.thus.Name = "thus";
            this.thus.ReadOnly = true;
            this.thus.Width = 130;
            // 
            // fri
            // 
            this.fri.HeaderText = "Thứ 6";
            this.fri.Name = "fri";
            this.fri.ReadOnly = true;
            this.fri.Width = 130;
            // 
            // sat
            // 
            this.sat.HeaderText = "Thứ 7";
            this.sat.Name = "sat";
            this.sat.ReadOnly = true;
            this.sat.Width = 130;
            // 
            // sun
            // 
            this.sun.HeaderText = "Chủ nhật";
            this.sun.Name = "sun";
            this.sun.ReadOnly = true;
            this.sun.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng giá mua:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số lượng sản phẩm:";
            // 
            // WeekPre
            // 
            this.WeekPre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekPre.Location = new System.Drawing.Point(345, 283);
            this.WeekPre.Name = "WeekPre";
            this.WeekPre.Size = new System.Drawing.Size(137, 46);
            this.WeekPre.TabIndex = 4;
            this.WeekPre.Text = "Tuần trước";
            this.WeekPre.UseVisualStyleBackColor = true;
            // 
            // ChartWeek
            // 
            chartArea3.Name = "ChartArea1";
            this.ChartWeek.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.ChartWeek.Legends.Add(legend3);
            this.ChartWeek.Location = new System.Drawing.Point(198, 366);
            this.ChartWeek.Name = "ChartWeek";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ChartWeek.Series.Add(series3);
            this.ChartWeek.Size = new System.Drawing.Size(967, 256);
            this.ChartWeek.TabIndex = 7;
            this.ChartWeek.Text = "chart1";
            // 
            // WeekInfor
            // 
            this.WeekInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeekInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.weekday,
            this.max,
            this.min});
            this.WeekInfor.Location = new System.Drawing.Point(182, 663);
            this.WeekInfor.Name = "WeekInfor";
            this.WeekInfor.RowTemplate.Height = 28;
            this.WeekInfor.Size = new System.Drawing.Size(944, 252);
            this.WeekInfor.TabIndex = 8;
            // 
            // weekday
            // 
            this.weekday.HeaderText = "Thứ";
            this.weekday.Name = "weekday";
            this.weekday.ReadOnly = true;
            // 
            // max
            // 
            this.max.HeaderText = "Max";
            this.max.Name = "max";
            this.max.ReadOnly = true;
            this.max.Width = 400;
            // 
            // min
            // 
            this.min.HeaderText = "Min";
            this.min.Name = "min";
            this.min.ReadOnly = true;
            this.min.Width = 400;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thứ:";
            // 
            // WeekNext
            // 
            this.WeekNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekNext.Location = new System.Drawing.Point(827, 283);
            this.WeekNext.Name = "WeekNext";
            this.WeekNext.Size = new System.Drawing.Size(144, 46);
            this.WeekNext.TabIndex = 4;
            this.WeekNext.Text = "Tuần sau";
            this.WeekNext.UseVisualStyleBackColor = true;
            // 
            // DetailWeek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1254, 646);
            this.Controls.Add(this.WeekInfor);
            this.Controls.Add(this.ChartWeek);
            this.Controls.Add(this.WeekNext);
            this.Controls.Add(this.WeekPre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.WeekName);
            this.MaximumSize = new System.Drawing.Size(1250, 1100);
            this.MinimumSize = new System.Drawing.Size(1250, 700);
            this.Name = "DetailWeek";
            this.Text = "Thông tin chi tiết";
            this.Load += new System.EventHandler(this.DetailWeek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartWeek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeekInfor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WeekName;
        private System.Windows.Forms.DataGridView Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tue;
        private System.Windows.Forms.DataGridViewTextBoxColumn wen;
        private System.Windows.Forms.DataGridViewTextBoxColumn thus;
        private System.Windows.Forms.DataGridViewTextBoxColumn fri;
        private System.Windows.Forms.DataGridViewTextBoxColumn sat;
        private System.Windows.Forms.DataGridViewTextBoxColumn sun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button WeekPre;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartWeek;
        private System.Windows.Forms.DataGridView WeekInfor;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekday;
        private System.Windows.Forms.DataGridViewTextBoxColumn max;
        private System.Windows.Forms.DataGridViewTextBoxColumn min;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button WeekNext;
    }
}