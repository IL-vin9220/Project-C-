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
    public partial class Thontinhomnay : Form
    {
        private string deleteID;
        DataUtil obj = new DataUtil();
        private string _old;
        private int col;
        private int numrow;
        private string tooltip_id;

        public Thontinhomnay()
        {
            InitializeComponent();
        }

        private void Thontinhomnay_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            List<ChitieuXuat> ds = new List<ChitieuXuat>();
            // loại bỏ dấu chấm trong dữ liệu về giá mua
            ds = obj.viewCurrent();
            tableInfor.DataSource = ds;
            ds = obj.removeDot(obj.viewCurrent());


            if (ds.Count == 1)
            {
                maxKey.Text = ds[0].sanpham.ToString();
                maxValue.Text = obj.chiaThapPhan(ds[0].giamua.ToString());
                minKey.Text = ds[0].sanpham.ToString();
                minValue.Text = obj.chiaThapPhan(ds[0].giamua.ToString());
                tonggt.Text = obj.chiaThapPhan(ds[0].giamua.ToString());
                tableInfor.Rows[0].Cells[0].Value = 1;
                dem.Text = "1 sản phẩm";
            }
            else if(ds.Count == 0)
            {
                maxKey.Text = "";
                maxValue.Text = "";
                minKey.Text = "";
                minValue.Text = "";
                tonggt.Text = "";
                dem.Text = "0 sản phẩm";
            }
            else
            {
                int max = ds.Max(danhsach => int.Parse(danhsach.giamua));
                int min = ds.Min(danhsach => int.Parse(danhsach.giamua));
                for (int i = 0; i < ds.Count; i++)
                {
                    if (ds[i].giamua == max.ToString())
                    {
                        maxKey.Text = ds[i].sanpham.ToString();
                        // thêm dấu phân chấm thập phân
                        maxValue.Text = obj.chiaThapPhan(ds[i].giamua.ToString());
                    }
                    else if (ds[i].giamua == min.ToString())
                    {
                        minKey.Text = ds[i].sanpham.ToString();
                        // thêm dấu chấm thập phân
                        minValue.Text = obj.chiaThapPhan(ds[i].giamua.ToString());
                    }
                    else
                        continue;
                }
                string _tong = ds.Sum(danhsach => int.Parse(danhsach.giamua)).ToString();
                // tạo dấu chấm thập phân
                tonggt.Text = obj.chiaThapPhan(_tong);
                dem.Text = ds.Count.ToString() + " sản phẩm";
                for (int i = 1; i <= ds.Count; i++)
                    tableInfor.Rows[i - 1].Cells[0].Value = i;
            }
        }

        private void tableInfor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            col = e.ColumnIndex;
            try
            {
                _old = tableInfor.Rows[numrow].Cells[col].Value.ToString();

            }
            catch
            {
                _old = "none";
            }
            deleteID = tableInfor.Rows[numrow].Cells[2].Value.ToString();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.funcUpdate(tableInfor, "Thông tin hôm nay", _old, col, deleteID);
            displayData();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userAnswer = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (userAnswer == DialogResult.Yes)
            {
                obj.funcDelete(tableInfor, "Thông tin hôm nay", deleteID, numrow);
                displayData();
            }
        }

        //private void tableInfor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if ((e.ColumnIndex == this.tableInfor.Columns[4].Index) && e.Value != null)
        //    {
        //        DataGridViewCell cell = tableInfor.Rows[e.RowIndex].Cells[e.ColumnIndex];
        //        List<string> detailGia = new List<string>(2);
        //        detailGia = obj.getDetailMoney(tooltip_id);
        //        if (detailGia[1].ToString() != "")
        //        {
        //            if (e.Value.Equals(detailGia[1]))
        //            {
        //                cell.ToolTipText = detailGia[0];
        //            }
        //            else
        //            {
        //                cell.ToolTipText = "";
        //            }
        //        }
        //    }
        //}

        //private void tableInfor_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    // lấy ra id để tạo tooltip
        //    tooltip_id = "72";
        //    try
        //    {
        //        tooltip_id = tableInfor.Rows[e.RowIndex].Cells[2].Value.ToString();
        //    }
        //    catch
        //    {
        //        tooltip_id = "72";
        //    }
        //}

        //private void chart()
        //{
        //    chart1.Series["sl"].Points.AddXY("Thứ 2", "1000");
        //    chart1.Series["sl"].Points.AddXY("Thứ 3", "1000");
        //    chart1.Series["sl"].Points.AddXY("Thứ 4", "1000");
        //    chart1.Series["sl"].Points.AddXY("Thứ 5", "1000");
        //    chart1.Series["sl"].Points.AddXY("Thứ 6", "1000");
        //    chart1.Series["sl"].Points.AddXY("Thứ 7", "1000");
        //    chart1.Series["sl"].Points.AddXY("Chủ nhật", "1000");
        //}
    }
}
