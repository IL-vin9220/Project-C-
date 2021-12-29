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
        private string colChoose = "date";
        private string sort = "";
        private string TypeSort = "giamdan";
        public Form2()
        {
            InitializeComponent();

        }

        //int loadRecord = 0;
        int pageNumber = 1;
        int numberRecord = 50;
        

        List<ChitieuXuat> Loadrecord(int page, int recordNum, string sort, string typeSort)
        {
            List<ChitieuXuat> result = new List<ChitieuXuat>();
            List<ChitieuXuat> xuat1 = obj.fillterItemDateAll();
            
            xuat1.Sort((x, y) => y.date.CompareTo(x.date));
            result = xuat1.Take(recordNum).ToList();
            if(page > 1)
                result = xuat1.Skip((page - 1) * recordNum).Take(recordNum).ToList();

            if (sort != "date")
            {
                result = obj.SortData(xuat1, sort, typeSort);
                result = result.Skip((page - 1) * recordNum).Take(recordNum).ToList();
            }

            return result;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void displayData()
        {
            List<ChitieuXuat> xuat = new List<ChitieuXuat>();
            tableDanhSach.DataSource = Loadrecord(pageNumber, numberRecord, colChoose, TypeSort);

            xuat = obj.fillterItemDateAll();
            //xuat = obj.removeDot(xuat);
            if(xuat.Count == 0)
            {
                Page.Text = "0";
                Tonggt.Text = "Tổng: 0";
                tong.Text = "0 sản phẩm";
                Tongsl.Text = "0";
            }
            else
            {
                int TotalRecord = 0;
                TotalRecord = xuat.Count();
                TotalRecord = TotalRecord / numberRecord + 1;
                Page.Text = pageNumber + "/" + TotalRecord.ToString();

                // hiển thị tổng số lượng của toàn bộ danh sách
                Tongsl.Text = xuat.Count.ToString();
                // đánh số thứ tự
                for (int i = 1; i <= tableDanhSach.RowCount; i++)
                    tableDanhSach.Rows[i - 1].Cells[0].Value = i;
                // hiển thị tổng giá trị giá mua trong bảng
                Tonggt.Text = obj.TongdanhsachHientai(tableDanhSach);
                Tonggt.Text = "Tổng: " + obj.chiaThapPhan(Tonggt.Text);
                // hiển thị số lượng sản phẩm trong bảng
                tong.Text = tableDanhSach.RowCount.ToString() + " sản phẩm";

                Danhmuc.Text = "Tên sản phẩm";
                ToolTip tldanhmuc = new ToolTip();
                tldanhmuc.SetToolTip(Danhmuc, "Bạn không nên chọn danh mục khác với danh mục đã có");

                ToolTip tlSearchDate = new ToolTip();
                tlSearchDate.SetToolTip(SearchText, "Nếu bạn muốn tìm theo khoảng ngày thì hãy nhập theo định dạng:\n11/05/2001 - 12/04/2002\n Tháng/Ngày/Năm - Tháng/Ngày/Năm (hoặc Ngày/Tháng/Năm - Ngày/Tháng/Năm)");
            }
            
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
                if(tableDanhSach.Columns[col].HeaderText.ToString() != "STT")
                {
                    SearchText.Text = _old;
                    SearchText.ForeColor = Color.Black;
                    Danhmuc.Text = tableDanhSach.Columns[col].HeaderText.ToString();
                    sort = tableDanhSach.Columns[col].Name.ToString();
                }
                
            }
            catch
            {
                _old = "none";
            }
            //_old = tableDanhSach.Rows[numrow].Cells[col].Value.ToString();

            // tong.Text = tableDanhSach.Rows[numrow].Cells[numcol].Value.ToString();
            try
            {
                deleteID = tableDanhSach.Rows[numrow].Cells[2].Value.ToString();

            }
            catch
            {
                deleteID = "";
            }
        }

        private void SearchText_Enter(object sender, EventArgs e)
        {
            if (SearchText.Text == "Search")
            {
                SearchText.Clear();
                SearchText.ForeColor = Color.Black;
            }
        }

        private void SearchText_Leave(object sender, EventArgs e)
        {
            //SearchText.Text = "Search";
            this.Refresh();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            // kiểm tra việc nhập giá trị có đúng với danh mục không
            if (Danhmuc.Text == "Giá mua" || Danhmuc.Text == "Trợ cấp" || Danhmuc.Text == "Tiết kiệm" || Danhmuc.Text == "ID" || Danhmuc.Text == "Ngày" || Danhmuc.Text == "Tháng" || Danhmuc.Text == "Năm")
                try
                {
                    string value = obj.rmDot1(SearchText.Text);
                    int.Parse(value);
                }
                catch
                {
                    MessageBox.Show("Giá trị không phù hợp với danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

            // lấy tên danh mục tìm kiếm
            string danhmuc = Danhmuc.Text;
            // lấy giá trị tìm kiếm của danh mục <giá trị ở ô tìm kiếm>
            //string find = obj.rmDot1(SearchText.Text);
            string find = obj.chuanhoaSP(SearchText.Text);
            // tìm kiếm giá trị trong danh sách, nếu không có thì thông báo không có giá trị nào
            // lấy danh sách ban đầu
            List<ChitieuXuat> xuat = new List<ChitieuXuat>();
            xuat = obj.fillterItemDateAll();
            //xuat = obj.removeDot(xuat);
            // thực hiện tìm kiếm
            bool ktra = obj.CheckDanhmuc(danhmuc, find, xuat);
            if (!ktra)
                MessageBox.Show("Không tìm thấy giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // lấy ra danh sách sau khi tìm kiếm
                List<ChitieuXuat> ds = new List<ChitieuXuat>();
                ds = obj.TimkiemDanhmuc(danhmuc, find, xuat);
                // truyền dữ liệu sang form hiển thị và hiển thị lên màn hình
                search slist = new search(ds);
                slist.Text = "Tìm kiếm " + find + " - " + danhmuc;
                slist.Show();
            }
        }

        private void SearchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                // kiểm tra việc nhập giá trị có đúng với danh mục không
                if (Danhmuc.Text == "Giá mua" || Danhmuc.Text == "Trợ cấp" || Danhmuc.Text == "Tiết kiệm" || Danhmuc.Text == "ID")
                    try
                    {
                        string value = obj.rmDot1(SearchText.Text);
                        int.Parse(value);
                    }
                    catch
                    {
                        MessageBox.Show("Giá trị không phù hợp với danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                // lấy tên danh mục tìm kiếm
                string danhmuc = Danhmuc.Text;
                // lấy giá trị tìm kiếm của danh mục <giá trị ở ô tìm kiếm>
                string find = obj.rmDot1(SearchText.Text);
                find = obj.chuanhoaSP(find);
                // tìm kiếm giá trị trong danh sách, nếu không có thì thông báo không có giá trị nào
                // lấy danh sách ban đầu
                List<ChitieuXuat> xuat = new List<ChitieuXuat>();
                xuat = obj.fillterItemDateAll();
                xuat = obj.removeDot(xuat);
                // thực hiện tìm kiếm
                bool ktra = obj.CheckDanhmuc(danhmuc, find, xuat);
                if (!ktra)
                    MessageBox.Show("Không tìm thấy giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    // lấy ra danh sách sau khi tìm kiếm
                    List<ChitieuXuat> ds = new List<ChitieuXuat>();
                    ds = obj.TimkiemDanhmuc(danhmuc, find, xuat);
                    // truyền dữ liệu sang form hiển thị và hiển thị lên màn hình
                    search slist = new search(ds);
                    slist.Text = "Tìm kiếm " + find + " - " + danhmuc;
                    slist.Show();
                }

                SearchText.Text = "Search";
                SearchText.ForeColor = Color.LightGray;
                e.Handled = true;
            }
        }

        private void MovePage_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numeric = sender as NumericUpDown;
            List<ChitieuXuat> xuat = obj.fillterItemDateAll();
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

            tableDanhSach.DataSource = Loadrecord(pageNumber, numberRecord, colChoose, TypeSort);
            displayData();
        }

        private void MovePage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                NumericUpDown numeric = sender as NumericUpDown;
                List<ChitieuXuat> xuat = obj.fillterItemDateAll();
                int TotalRecord = 0;
                TotalRecord = xuat.Count();

                numeric.Maximum = TotalRecord / numberRecord + 1;

                pageNumber = int.Parse(MovePage.Value.ToString());
                Page.Text = pageNumber.ToString() + "/" + numeric.Maximum.ToString();

                tableDanhSach.DataSource = Loadrecord(pageNumber, numberRecord, colChoose, TypeSort);
                e.Handled = true;
            }
            displayData();
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

        private void tableDanhSach_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (tableDanhSach.Columns[e.ColumnIndex].Name.ToString() == "ngaymua")
                {
                    SearchText.Text = tableDanhSach[e.ColumnIndex, e.RowIndex].Value.ToString();
                    SearchText.ForeColor = Color.Black;
                }
            }
            catch
            {

            }
        }

        private void tableDanhSach_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == col && e.RowIndex != numrow)
                    if (tableDanhSach.Columns[e.ColumnIndex].Name.ToString() == "ngaymua")
                    {
                        SearchText.Text += " - " + tableDanhSach[e.ColumnIndex, e.RowIndex].Value.ToString();
                        Danhmuc.Text = "Ngày mua";
                    }
            }
            catch
            {

            }
        }
        
    }
}
