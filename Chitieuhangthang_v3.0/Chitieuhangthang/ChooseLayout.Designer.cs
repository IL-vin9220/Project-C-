namespace Chitieuhangthang
{
    partial class ChooseLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseLayout));
            this.LayoutCenter = new System.Windows.Forms.CheckBox();
            this.LayoutZoom = new System.Windows.Forms.CheckBox();
            this.LayoutTitle = new System.Windows.Forms.CheckBox();
            this.LayoutStretch = new System.Windows.Forms.CheckBox();
            this.Apply_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LayoutCenter
            // 
            this.LayoutCenter.AutoSize = true;
            this.LayoutCenter.Checked = true;
            this.LayoutCenter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LayoutCenter.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutCenter.Location = new System.Drawing.Point(28, 38);
            this.LayoutCenter.Name = "LayoutCenter";
            this.LayoutCenter.Size = new System.Drawing.Size(115, 37);
            this.LayoutCenter.TabIndex = 0;
            this.LayoutCenter.Text = "Center";
            this.LayoutCenter.UseVisualStyleBackColor = true;
            this.LayoutCenter.CheckedChanged += new System.EventHandler(this.LayoutCenter_CheckedChanged);
            // 
            // LayoutZoom
            // 
            this.LayoutZoom.AutoSize = true;
            this.LayoutZoom.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutZoom.Location = new System.Drawing.Point(28, 91);
            this.LayoutZoom.Name = "LayoutZoom";
            this.LayoutZoom.Size = new System.Drawing.Size(106, 37);
            this.LayoutZoom.TabIndex = 0;
            this.LayoutZoom.Text = "Zoom";
            this.LayoutZoom.UseVisualStyleBackColor = true;
            this.LayoutZoom.CheckedChanged += new System.EventHandler(this.LayoutZoom_CheckedChanged);
            // 
            // LayoutTitle
            // 
            this.LayoutTitle.AutoSize = true;
            this.LayoutTitle.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutTitle.Location = new System.Drawing.Point(210, 38);
            this.LayoutTitle.Name = "LayoutTitle";
            this.LayoutTitle.Size = new System.Drawing.Size(84, 37);
            this.LayoutTitle.TabIndex = 0;
            this.LayoutTitle.Text = "Tile";
            this.LayoutTitle.UseVisualStyleBackColor = true;
            this.LayoutTitle.CheckedChanged += new System.EventHandler(this.LayoutTitle_CheckedChanged);
            // 
            // LayoutStretch
            // 
            this.LayoutStretch.AutoSize = true;
            this.LayoutStretch.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LayoutStretch.Location = new System.Drawing.Point(210, 91);
            this.LayoutStretch.Name = "LayoutStretch";
            this.LayoutStretch.Size = new System.Drawing.Size(120, 37);
            this.LayoutStretch.TabIndex = 0;
            this.LayoutStretch.Text = "Stretch";
            this.LayoutStretch.UseVisualStyleBackColor = true;
            this.LayoutStretch.CheckedChanged += new System.EventHandler(this.LayoutStretch_CheckedChanged);
            // 
            // Apply_btn
            // 
            this.Apply_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply_btn.Location = new System.Drawing.Point(28, 162);
            this.Apply_btn.Name = "Apply_btn";
            this.Apply_btn.Size = new System.Drawing.Size(109, 41);
            this.Apply_btn.TabIndex = 1;
            this.Apply_btn.Text = "OK";
            this.Apply_btn.UseVisualStyleBackColor = true;
            this.Apply_btn.Click += new System.EventHandler(this.Apply_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.Location = new System.Drawing.Point(183, 162);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(109, 41);
            this.Cancel_btn.TabIndex = 2;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // ChooseLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 228);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Apply_btn);
            this.Controls.Add(this.LayoutStretch);
            this.Controls.Add(this.LayoutTitle);
            this.Controls.Add(this.LayoutZoom);
            this.Controls.Add(this.LayoutCenter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChooseLayout";
            this.Text = "Kiểu hiển thị";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox LayoutCenter;
        private System.Windows.Forms.CheckBox LayoutZoom;
        private System.Windows.Forms.CheckBox LayoutTitle;
        private System.Windows.Forms.CheckBox LayoutStretch;
        private System.Windows.Forms.Button Apply_btn;
        private System.Windows.Forms.Button Cancel_btn;
    }
}