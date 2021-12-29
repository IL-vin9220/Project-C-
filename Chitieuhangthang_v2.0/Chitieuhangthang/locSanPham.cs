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
    public partial class locSanPham : Form
    {
        DataUtil obj = new DataUtil();
        private string tensp;
        private string deleteID;
        private int col;
        private string _old;
        private int numrow;
        public locSanPham()
        {
            InitializeComponent();
        }

        public locSanPham(string Sanpham): this()
        {
            tensp = Sanpham;
        }

        private void displayData()
        {
            List<ChitieuXuat> ds = new List<ChitieuXuat>();
            ds = obj.fillterItemSP(chuanhoa(tensp));
            tabelLoc.DataSource = ds;
            ds = obj.removeDot(ds);

            if (ds.Count == 1)
            {
                maxKey.Text = ds[0].sanpham.ToString();
                maxValue.Text = obj.chiaThapPhan(ds[0].giamua.ToString());
                minKey.Text = ds[0].sanpham.ToString();
                minValue.Text = obj.chiaThapPhan(ds[0].giamua.ToString());
                tong.Text = obj.chiaThapPhan(ds[0].giamua.ToString());
                tabelLoc.Rows[0].Cells[0].Value = 1;
                demsl.Text = "1 sản phẩm";
            }
            else if(ds.Count == 0)
            {
                maxKey.Text = "";
                maxValue.Text = "";
                minKey.Text = "";
                minValue.Text = "";
                tong.Text = "";
                demsl.Text = "0 sản phẩm";
            }
            else
            {
                int max = ds.Max(danhsach => int.Parse(danhsach.giamua));
                int min = ds.Min(danhsach => int.Parse(danhsach.giamua));
                for (int i = 0; i < ds.Count; i++)
                {
                    if (ds[i].giamua == max.ToString())
                    {
                        maxKey.Text = ds[i].date.ToString();
                        maxValue.Text = obj.chiaThapPhan(ds[i].giamua.ToString());
                    }
                    else if (ds[i].giamua == min.ToString())
                    {
                        minKey.Text = ds[i].date.ToString();
                        minValue.Text = obj.chiaThapPhan(ds[i].giamua.ToString());
                    }
                    else
                        continue;
                }

                string _tong = ds.Sum(danhsach => int.Parse(danhsach.giamua)).ToString();
                tong.Text = obj.chiaThapPhan(_tong);
                demsl.Text = tabelLoc.RowCount.ToString() + " sản phẩm";

                for (int i = 1; i <= tabelLoc.RowCount; i++)
                    tabelLoc.Rows[i - 1].Cells[0].Value = i;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private string chuanhoa(string chuoi)
        {
            string result = "";

            // Viết hoa các chữ cái đầu tiên của mỗi từ
            string[] words = chuoi.Split(' ');
            foreach (string word in words)
            {
                // nếu là khoảng trắng thì bỏ qua
                if (word.Trim() != "")
                    if (word.Length > 1)
                        result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                    else
                        result += word.ToUpper() + " ";
            }

            return result.Trim();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            obj.funcUpdate(tabelLoc, "Lọc sản phẩm", _old, col, deleteID);
            displayData();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userAnswer = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(userAnswer == DialogResult.Yes)
            {
                obj.funcDelete(tabelLoc, "Lọc sản phẩm", deleteID, numrow);
                displayData();
            }
        }

        private void tabelLoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            col = e.ColumnIndex;
            try
            {
                _old = tabelLoc.Rows[numrow].Cells[col].Value.ToString();

            }
            catch
            {
                _old = "none";
            }
            deleteID = tabelLoc.Rows[numrow].Cells[2].Value.ToString();
        }
    }
}
