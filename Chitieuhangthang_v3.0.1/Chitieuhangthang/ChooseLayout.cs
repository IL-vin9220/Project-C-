using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chitieuhangthang
{
    public partial class ChooseLayout : Form
    {
        public ChooseLayout()
        {
            InitializeComponent();
        }

        private void LayoutCenter_CheckedChanged(object sender, EventArgs e)
        {
            if(LayoutCenter.Checked == true)
            {
                LayoutTitle.Checked = false;
                LayoutZoom.Checked = false;
                LayoutStretch.Checked = false;
            }
        }

        private void LayoutTitle_CheckedChanged(object sender, EventArgs e)
        {
            if(LayoutTitle.Checked == true)
            {
                LayoutCenter.Checked = false;
                LayoutZoom.Checked = false;
                LayoutStretch.Checked = false;
            }
        }

        private void LayoutZoom_CheckedChanged(object sender, EventArgs e)
        {
            if(LayoutZoom.Checked == true)
            {
                LayoutCenter.Checked = false;
                LayoutTitle.Checked = false;
                LayoutStretch.Checked = false;
            }
        }

        private void LayoutStretch_CheckedChanged(object sender, EventArgs e)
        {
            if(LayoutStretch.Checked == true)
            {
                LayoutCenter.Checked = false;
                LayoutTitle.Checked = false;
                LayoutStretch.Checked = false;
            }
        }

        // thiết lập kiểu hiển thị cho hình nền
        private void Apply_btn_Click(object sender, EventArgs e)
        {
            int result = GetTypeDisplay();
            Form1 main = new Form1(result);
            this.Close();
        }

        // lấy ra thông tin kiểu hiển thị
        private int GetTypeDisplay()
        {
            if (LayoutCenter.Checked == true)
                return 1;
            else if (LayoutTitle.Checked == true)
                return 2;
            else if (LayoutZoom.Checked == true)
                return 3;
            else if (LayoutStretch.Checked == true)
                return 4;
            else
                return 5;
        }

        // Hiển thị hình ảnh ở chế độ mặc định
        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
