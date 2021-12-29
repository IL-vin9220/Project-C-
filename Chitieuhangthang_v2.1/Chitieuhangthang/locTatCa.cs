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
    public partial class locTatCa : Form
    {
        DataUtil obj = new DataUtil();
        private string deleteID;
        private int col;
        private string _old;
        private int numrow;

        public locTatCa()
        {
            InitializeComponent();
        }

        private void tabelLocAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            col = e.ColumnIndex;
            try
            {
                _old = tabelLocAll.Rows[numrow].Cells[col].Value.ToString();

            }
            catch
            {
                _old = "none";
            }

            try
            {
                deleteID = tabelLocAll.Rows[numrow].Cells[2].Value.ToString();

            }
            catch
            {
                deleteID = "";
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.funcUpdate(tabelLocAll, "Lọc tất cả", _old, col, deleteID);
            displayData();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userAnswer = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (userAnswer == DialogResult.Yes)
            {
                obj.funcDelete(tabelLocAll, "Lọc tất cả", deleteID, numrow);
                displayData();
            }
        }

        private void locTatCa_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            List<ChitieuXuat> xuat = new List<ChitieuXuat>();
            xuat = obj.fillterItemDateAll();
            tabelLocAll.DataSource = xuat;
            xuat = obj.removeDot(xuat);

            //List<string> ds = new List<string>();
            //ds = obj.ktraNgay(xuat);
            //List<ChitieuXuat> ds1 = new List<ChitieuXuat>();
            //ds1 = obj.ngayMax_Min(xuat);

            //if (ds.Count == 1)
            //{
            //    maxKey.Text = ds1[0].date;
            //    maxValue.Text = ds1[0].giamua + " - " + ds1[0].sanpham + " sản phẩm";
            //    minKey.Text = ds1[0].date;
            //    minValue.Text = ds1[0].giamua + " - " + ds1[0].sanpham + " sản phẩm";
            //    tong.Text = ds1[0].giamua;
            //}
            //else
            //{
            //    int max = ds1.Max(danhsach1 => int.Parse(danhsach1.giamua));
            //    int min = ds1.Min(danhsach1 => int.Parse(danhsach1.giamua));
            //    for (int i = 0; i < ds1.Count; i++)
            //    {
            //        if (ds1[i].giamua == max.ToString())
            //        {
            //            maxKey.Text = ds1[i].date;
            //            maxValue.Text = ds1[i].giamua + " - " + ds1[i].sanpham + " sản phẩm";
            //        }
            //        else if (ds1[i].giamua == min.ToString())
            //        {
            //            minKey.Text = ds1[i].date;
            //            minValue.Text = ds1[i].giamua + " - " + ds1[i].sanpham + " sản phẩm";
            //        }
            //        else
            //            continue;
            //    }
            //}
            //tong.Text = xuat.Sum(thongtin => int.Parse(thongtin.giamua)).ToString();
            if (xuat.Count == 0)
                tong.Text = "0 sản phẩm";
            else
            {
                Tonggt.Text = xuat.Sum(danhsach => int.Parse(danhsach.giamua)).ToString();
                Tonggt.Text = "Tổng: " + obj.chiaThapPhan(Tonggt.Text);
                tong.Text = xuat.Count.ToString() + " sản phẩm";
                for (int i = 1; i <= xuat.Count; i++)
                    tabelLocAll.Rows[i - 1].Cells[0].Value = i;
            }
        }
    }
}
