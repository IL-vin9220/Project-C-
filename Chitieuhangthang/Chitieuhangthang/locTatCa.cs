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

        public locTatCa()
        {
            InitializeComponent();
        }

        private void tabelLocAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            col = e.ColumnIndex;
            _old = tabelLocAll.Rows[numrow].Cells[col].Value.ToString();
            deleteID = tabelLocAll.Rows[numrow].Cells[2].Value.ToString();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // lấy thông tin dữ liệu từ bảng
            //List<ChitieuXuat> xuat = new List<ChitieuXuat>();
            for (int i = 0; i < tabelLocAll.RowCount; i++)
            {
                // do sắp xếp trong Chitieu đặt khác nên cần truy xuất theo thứ tự của Chitieu
                Chitieu chiTieu = new Chitieu();
                chiTieu.id = tabelLocAll.Rows[i].Cells[2].Value.ToString();
                chiTieu.sanpham = obj.chuanhoaSP(tabelLocAll.Rows[i].Cells[3].Value.ToString());
                string gia = obj.chuanhoaSP(tabelLocAll.Rows[i].Cells[4].Value.ToString());
                if(gia == "not")
                {
                    MessageBox.Show("Không thể update", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                else
                    chiTieu.giamua = gia;
                chiTieu.date = tabelLocAll.Rows[i].Cells[1].Value.ToString();
                chiTieu.thoidiem = tabelLocAll.Rows[i].Cells[5].Value.ToString();
                if (tabelLocAll.Rows[i].Cells[6].Value.ToString() == "")
                    chiTieu.trocap = "0";
                else
                    chiTieu.trocap = tabelLocAll.Rows[i].Cells[5].Value.ToString();
                if (tabelLocAll.Rows[i].Cells[7].Value.ToString() == "")
                    chiTieu.tietkiem = "0";
                else
                    chiTieu.tietkiem = tabelLocAll.Rows[i].Cells[6].Value.ToString();

                if(chiTieu.id == deleteID)
                {
                    string _new = tabelLocAll.Rows[i].Cells[col].Value.ToString(); ;
                    obj.updateLog("Lọc sản phẩm", DateTime.Today.ToShortDateString(), DateTime.Now.ToLongTimeString(), deleteID, _old, _new);
                }

                bool ktra = obj.Update(chiTieu);
                if (!ktra)
                {
                    MessageBox.Show("Không thể cập nhật được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            displayData();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userAnswer = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (userAnswer == DialogResult.Yes)
            {
                obj.deleteLog("Lọc tất cả", DateTime.Today.ToShortDateString(), DateTime.Now.ToLongTimeString(), deleteID);
                bool ktra = obj.Delete(deleteID);
                if (!ktra)
                {
                    MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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
                tong.Text = xuat.Count.ToString() + " sản phẩm";
                for (int i = 1; i <= xuat.Count; i++)
                    tabelLocAll.Rows[i - 1].Cells[0].Value = i;
            }
        }
    }
}
