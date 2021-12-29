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
    public partial class Form2 : Form
    {
        DataUtil obj = new DataUtil();
        private string deleteID;
        private string _old;
        private int numrow;
        private int col;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            List<ChitieuXuat> xuat = new List<ChitieuXuat>();
            xuat = obj.fillterItemDateAll();
            tableDanhSach.DataSource = xuat;
            xuat = obj.removeDot(xuat);

            //if (xuat.Count == 0)
            //    tong.Text = "0 sản phẩm";
            //else
            //{
            //    for (int i = 1; i <= xuat.Count; i++)
            //        tableDanhSach.Rows[i - 1].Cells[0].Value = i;

            //    tong.Text = tableDanhSach.RowCount.ToString() + " sản phẩm";
            //}
            for (int i = 1; i <= xuat.Count; i++)
                tableDanhSach.Rows[i - 1].Cells[0].Value = i;
            Tonggt.Text = xuat.Sum(danhsach => int.Parse(danhsach.giamua)).ToString();
            Tonggt.Text = "Tổng: " + obj.chiaThapPhan(Tonggt.Text);
            tong.Text = tableDanhSach.RowCount.ToString() + " sản phẩm";
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.funcUpdate(tableDanhSach, "Xem danh sách", _old, col, deleteID);
            displayData();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userAnswer = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (userAnswer == DialogResult.Yes)
            {
                obj.funcDelete(tableDanhSach, "Xem danh sách", deleteID, numrow);
                displayData();
            }
        }

        private void tableDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            col = e.ColumnIndex;
            try
            {
                _old = tableDanhSach.Rows[numrow].Cells[col].Value.ToString();

            }
            catch
            {
                _old = "none";
            }
            //_old = tableDanhSach.Rows[numrow].Cells[col].Value.ToString();

            // tong.Text = tableDanhSach.Rows[numrow].Cells[numcol].Value.ToString();
            deleteID = tableDanhSach.Rows[numrow].Cells[2].Value.ToString();
        }
    }
}
