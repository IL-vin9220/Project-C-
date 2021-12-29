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
    public partial class search : Form
    {
        private List<ChitieuXuat> xuat;
        private string deleteID;
        private string _old;
        private int col;
        private int numrow;
        private string colChoose = "date";
        private string sort;
        private string TypeSort = "giamdan";
        DataUtil obj = new DataUtil();
        public search()
        {
            InitializeComponent();
        }

        int pageNumber = 1;
        int numberRecord = 50;


        List<ChitieuXuat> Loadrecord(int page, int recordNum, string sort, string typeSort)
        {
            List<ChitieuXuat> result = new List<ChitieuXuat>();

            xuat.Sort((x, y) => y.date.CompareTo(x.date));
            result = xuat.Take(recordNum).ToList();
            if (page > 1)
                result = xuat.Skip((page - 1) * recordNum).Take(recordNum).ToList();

            if (sort != "date")
            {
                result = obj.SortData(xuat, sort, typeSort);
                result = result.Skip((page - 1) * recordNum).Take(recordNum).ToList();
            }

            return result;
        }

        public search(List<ChitieuXuat> ds) : this()
        {
            xuat = ds;
        }

        private void search_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            tableSearch.DataSource = Loadrecord(pageNumber, numberRecord, colChoose, TypeSort);

            if (xuat.Count == 0)
            {
                soluong.Text = "0 sản phẩm";
                Tonggt.Text = "Tổng: 0";
                Page.Text = "0";
                Tongsl.Text = "0";
            }
            else
            {
                //xuat = obj.fillterItemDateAll();
                //xuat = obj.removeDot(xuat);
                int TotalRecord = 0;
                TotalRecord = xuat.Count();
                TotalRecord = TotalRecord / numberRecord + 1;
                Page.Text = pageNumber + "/" + TotalRecord.ToString();

                // hiển thị tổng số lượng của toàn bộ danh sách
                Tongsl.Text = xuat.Count.ToString();
                // đánh số thứ tự
                for (int i = 1; i <= tableSearch.RowCount; i++)
                    tableSearch.Rows[i - 1].Cells[0].Value = i;
                // hiển thị tổng giá trị giá mua trong bảng
                Tonggt.Text = obj.TongdanhsachHientai(tableSearch);
                Tonggt.Text = "Tổng: " + obj.chiaThapPhan(Tonggt.Text);
                // hiển thị số lượng sản phẩm trong bảng
                soluong.Text = tableSearch.RowCount.ToString() + " sản phẩm";
            }
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult userAnswer = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (userAnswer == DialogResult.Yes)
            {
                obj.funcDelete(tableSearch, this.Text, deleteID, numrow);
                displayData();
            }
        }

        private void tableSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numrow = e.RowIndex;
            col = e.ColumnIndex;
            try
            {
                _old = tableSearch.Rows[numrow].Cells[col].Value.ToString();
                sort = tableSearch.Columns[col].Name.ToString();
            }
            catch
            {
                _old = "none";
            }

            try
            {
                deleteID = tableSearch.Rows[numrow].Cells[2].Value.ToString();

            }
            catch
            {
                deleteID = "";
            }
        }

        private void tangdan_Click(object sender, EventArgs e)
        {
            colChoose = sort;
            TypeSort = "tangdan";
            displayData();
        }

        private void giamdan_Click(object sender, EventArgs e)
        {
            colChoose = sort;
            TypeSort = "giamdan";
            displayData();
        }

        private void MovePage_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = sender as NumericUpDown;
            int TotalRecord = 0;
            TotalRecord = xuat.Count();

            numeric.Maximum = TotalRecord / numberRecord + 1;

            if (numeric.Value > pageNumber)
            {
                pageNumber++;
                Page.Text = pageNumber.ToString() + "/" + numeric.Maximum.ToString();
            }
            else
            {
                pageNumber--;
                Page.Text = pageNumber.ToString() + "/" + numeric.Maximum.ToString();
            }

            tableSearch.DataSource = Loadrecord(pageNumber, numberRecord, colChoose, TypeSort);
            displayData();
        }

        private void MovePage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                NumericUpDown numeric = sender as NumericUpDown;
                List<ChitieuXuat> xuat = obj.fillterItemDateAll();
                int TotalRecord = 0;
                TotalRecord = xuat.Count();

                numeric.Maximum = TotalRecord / numberRecord + 1;

                pageNumber = int.Parse(MovePage.Value.ToString());
                Page.Text = pageNumber.ToString() + "/" + numeric.Maximum.ToString();

                tableSearch.DataSource = Loadrecord(pageNumber, numberRecord, colChoose, TypeSort);
                e.Handled = true;
            }
            displayData();
        }
    }
}
