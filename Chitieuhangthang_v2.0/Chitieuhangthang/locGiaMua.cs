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
    public partial class locGiaMua : Form
    {
        DataUtil obj = new DataUtil();
        private string gia;
        private string deleteID;
        private string _old;
        private int col;
        private int numrow;
        public locGiaMua()
        {
            InitializeComponent();
        }

        public locGiaMua(string Tienchi): this()
        {
            gia = Tienchi;
        }

        private void locGiaMua_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            List<ChitieuXuat> ds = new List<ChitieuXuat>();
            ds = obj.fillterItemMoney(gia);
            tableLocGia.DataSource = ds;
            ds = obj.removeDot(ds);

            if (ds.Count == 0)
                tong.Text = "0 sản phẩm";
            else
            {
                Tonggt.Text = ds.Sum(danhsach => int.Parse(danhsach.giamua)).ToString();
                Tonggt.Text = "Tổng: " + obj.chiaThapPhan(Tonggt.Text);
                tong.Text = ds.Count.ToString() + " sản phẩm";
                for (int i = 1; i <= ds.Count; i++)
                    tableLocGia.Rows[i - 1].Cells[0].Value = i;
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.funcUpdate(tableLocGia, "Lọc giá mua", _old, col, deleteID);
            displayData();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userAnswer = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (userAnswer == DialogResult.Yes)
            {
                obj.funcDelete(tableLocGia, "Lọc giá mua", deleteID, numrow);
                displayData();
            }
        }

        private void tableLocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            col = e.ColumnIndex;
            try
            {
                _old = tableLocGia.Rows[numrow].Cells[col].Value.ToString();

            }
            catch
            {
                _old = "none";
            }
            deleteID = tableLocGia.Rows[numrow].Cells[2].Value.ToString();
        }
    }
}
