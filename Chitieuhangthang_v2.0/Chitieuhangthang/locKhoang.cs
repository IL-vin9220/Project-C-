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
    public partial class locKhoang : Form
    {
        DataUtil obj = new DataUtil();
        private string deleteID;
        private string start;
        private string end;
        private int col;
        private string _old;
        private int numrow;
        public locKhoang()
        {
            InitializeComponent();
        }

        public locKhoang(string _start, string _end): this()
        {
            start = _start;
            end = _end;
        }

        private void tabelLocKhoang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            col = e.ColumnIndex;
            try
            {
                _old = tableLocKhoang.Rows[numrow].Cells[col].Value.ToString();

            }
            catch
            {
                _old = "none";
            }
            deleteID = tableLocKhoang.Rows[numrow].Cells[2].Value.ToString();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.funcUpdate(tableLocKhoang, "Lọc theo khoảng", _old, col, deleteID);
            displayData();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userAnswer = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (userAnswer == DialogResult.Yes)
            {
                obj.funcDelete(tableLocKhoang, "Lọc Khoảng " + start + " - " + end, deleteID, numrow);
                displayData();
            }
        }

        private void locKhoang_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            List<ChitieuXuat> xuat = new List<ChitieuXuat>();
            xuat = obj.fillterItemDateBetween(start, end);
            tableLocKhoang.DataSource = xuat;
            xuat = obj.removeDot(xuat);

            if (xuat.Count == 0)
                tong.Text = "0 sản phẩm";
            else
            {
                for (int i = 1; i <= xuat.Count; i++)
                    // STT: index = 0
                    tableLocKhoang.Rows[i - 1].Cells[0].Value = i;
                tong.Text = xuat.Count.ToString() + " sản phẩm";
                Tonggt.Text = xuat.Sum(danhsach => int.Parse(danhsach.giamua)).ToString();
                Tonggt.Text = "Tổng: " + obj.chiaThapPhan(Tonggt.Text);
            }
        }
    }
}
