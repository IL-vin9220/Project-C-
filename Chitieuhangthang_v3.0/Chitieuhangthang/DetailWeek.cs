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
    public partial class DetailWeek : Form
    {
        public DetailWeek()
        {
            InitializeComponent();
        }

        private string weekMain;
        DataUtil obj = new DataUtil();

        public DetailWeek(string week): this()
        {
            weekMain = week;
        }

        private void DetailWeek_Load(object sender, EventArgs e)
        {
            loadweek();
        }

        private void loadweek()
        {
            int day = 0, month = 0;
            // dữ liệu truyền là ngày hiện tại
            if(weekMain == null)
            {
                day = int.Parse(DateTime.Today.Day.ToString());
                month = int.Parse(DateTime.Today.Month.ToString());
            }

            // tính toán tuần được hiển thị
            if (day >= 1 && day <= 7)
                WeekName.Text = "Tuần 1 của tháng " + month;
            if (day > 7 && day <= 14)
                WeekName.Text = "Tuần 2 của tháng " + month;
            if (day > 14 && day <= 21)
                WeekName.Text = "Tuần 3 của tháng " + month;
            else
                WeekName.Text = "Tuần 4 của tháng " + month;

            // bảng hiển thị dữ liệu
            // truyền dữ liệu cho bảng
            List<string> data = new List<string>();
            //data = obj.getDetailWeek();
            
        }
    }
}
