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
    public partial class Form1 : Form
    {
        DataUtil obj = new DataUtil();
        private int sl;
        private string detail;
        private int TypeDisplay;
        private string filename;
        public Form1()
        {
            InitializeComponent();
        }
        
        public Form1(int type): this()
        {
            TypeDisplay = type;
        }

        // thông tin hôm nay <hoàn thành>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongtinhomnay currentInfo = new Thongtinhomnay();
            currentInfo.Show();
        }

        // đổi font chữ <hoàn thành>
        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            fontDialog.Font = label2.Font;
            fontDialog.Color = label2.ForeColor;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                label2.Font = fontDialog.Font;
                //label2.ForeColor = fontDialog.Color;
                label3.Font = fontDialog.Font;
                label4.Font = fontDialog.Font;
                label5.Font = fontDialog.Font;
                label6.Font = fontDialog.Font;
                label7.Font = fontDialog.Font;
                xemds.Font = fontDialog.Font;
                hdsd.Font = fontDialog.Font;
                btnHinhnen.Font = fontDialog.Font;
                btnMaunen.Font = fontDialog.Font;
                btnFont.Font = fontDialog.Font;
                btnColorText.Font = fontDialog.Font;
                label2.Font = new Font("Times New Roman", 16, FontStyle.Italic);
                
            }
        }

        // đổi màu chữ <hoàn thành>
        private void btnColorText_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.AllowFullOpen = false;
            color.ShowHelp = true;
            color.Color = label2.ForeColor;

            if (color.ShowDialog() == DialogResult.OK)
            {
                if(tabPage1.BackColor != color.Color)
                {
                    label2.ForeColor = color.Color;
                    label3.ForeColor = color.Color;
                    label4.ForeColor = color.Color;
                    label5.ForeColor = color.Color;
                    label6.ForeColor = color.Color;
                    label7.ForeColor = color.Color;
                    xemds.ForeColor = color.Color;
                    hdsd.ForeColor = color.Color;
                    btnHinhnen.ForeColor = color.Color;
                    btnMaunen.ForeColor = color.Color;
                    btnFont.ForeColor = color.Color;
                    btnColorText.ForeColor = color.Color;
                }
            }
        }

        // đổi màu nền <hoàn thành>
        private void btnMaunen_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.AllowFullOpen = false;
            color.ShowHelp = true;
            color.Color = Form1.DefaultBackColor;

            if (color.ShowDialog() == DialogResult.OK)
            {
                // xóa hình nền
                this.tabPage1.BackgroundImage = null;
                this.tabPage3.BackgroundImage = null;
                this.tabPage4.BackgroundImage = null;

                // kiểm tra màu
                if(label2.ForeColor != color.Color)
                {
                    //this.BackColor = color.Color;
                    this.tabPage1.BackColor = color.Color;
                    this.tabPage3.BackColor = color.Color;
                    this.tabPage4.BackColor = color.Color;
                    // đặt màu nền cho chữ, không đặt thì nó sẽ có cùng màu nền với tab
                    this.label2.BackColor = Color.FromArgb(255, 255, 255);
                    this.label3.BackColor = Color.FromArgb(255, 255, 255);
                    this.label4.BackColor = Color.FromArgb(255, 255, 255);
                    this.label5.BackColor = Color.FromArgb(255, 255, 255);
                    this.label6.BackColor = Color.FromArgb(255, 255, 255);
                    this.label7.BackColor = Color.FromArgb(255, 255, 255);
                }
                else
                {
                    if (label2.ForeColor == Color.FromArgb(0, 0, 0) && color.Color == Color.FromArgb(0, 0, 0))
                    {
                        check();
                    }
                }

            }
        }

        private void check()
        {
            this.label2.ForeColor = Color.FromArgb(255, 255, 255);
            this.label3.ForeColor = Color.FromArgb(255, 255, 255);
            this.label4.ForeColor = Color.FromArgb(255, 255, 255);
            this.label5.ForeColor = Color.FromArgb(255, 255, 255);
            this.label6.ForeColor = Color.FromArgb(255, 255, 255);
            this.label7.ForeColor = Color.FromArgb(255, 255, 255);
        }

        // xem danh sách <hoàn thành>
        private void xemds_Click(object sender, EventArgs e)
        {
            Form2 ds = new Form2();
            ds.Show();
        }

        // Exit <hoàn thành>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // xem thông tin <hoàn thành>
        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string month = DateTime.Now.Month.ToString();
            List<string> ds = new List<string>();
            ds = obj.viewInfor(month);
            
            string tiendu = obj.Tienthua();
            string trocap;
            try
            {
                trocap = (int.Parse(obj.rmDot1(ds[0])) + int.Parse(tiendu)).ToString();

            }
            catch
            {
                trocap = ds[0];
            }
            
            // đánh dấu chấm thập phân cho mục trợ cấp
            trocap = obj.chiaThapPhan(trocap);
            if (ds[0] == "0" && string.Compare(tiendu, "0") > 0)
                trocap = trocap + "   (tiền dư từ tháng trước)";
            else if (string.Compare(ds[0], "0") > 0 && string.Compare(tiendu, "0") > 0)
                trocap = trocap + "   (được cộng đồn từ tháng trước)";
            else
                trocap = trocap;
            
            string dukienTietkiem = ds[1];
            string tong = ds[2];

            string money = ds[3];
            string sub_money = money.Substring(0, 1);
            // nếu tiền tiết kiệm thực bị âm
            if(string.Compare(sub_money, "-") == 0)
            {
                string new_money = money.Substring(1);
                money = (int.Parse(new_money) + int.Parse(tiendu)).ToString();
                money = "- " + obj.chiaThapPhan(money);
            }
            else
            {
                money = (int.Parse(ds[3]) + int.Parse(tiendu)).ToString();
                money = obj.chiaThapPhan(money);
            }
            string sp = ds[4];
            string mess = ("Tháng: " + month + ":\n" + "Trợ cấp: " + trocap + "\nDự kiến tiết kiệm: " + dukienTietkiem + "\nSố lượng sản phẩm: " + sp + "\ntổng tiêu: " + tong + "\nTiền tiết kiệm được: " + money);
            MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        // hướng dẫn sử dụng <hoàn thành>
        private void hdsd_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("help\\help_Chitieu.chm");
            }
            catch
            {
                MessageBox.Show("Không tìm thấy file, bạn hãy liên lạc lại với quản trị viên để nhận lại file", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // xóa ô vừa nhập <hoàn thành>
        private void clearTextBox()
        {
            if (tietkiemText.Enabled == true)
                tietkiemText.Clear();
            trocapText.Clear();
            sanphamText.Clear();
            giamuaText.Clear();
        }

        // nhập thông tin <hoàn thành>
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (sanphamText.Text == "")
                MessageBox.Show("Bạn chưa nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Chitieu chiTieu = new Chitieu();
                string tk = "0";
                if (tietkiemText.Enabled == true)
                    tk = tietkiemText.Text;
                //string tc = trocapText.Text;
                string date = ngay.Text;
                //string td = thoidiemText.Text;
                string[] sp = sanphamText.Text.Split(',');
                string[] gia = giamuaText.Text.Split(',');
                if (gia.Length < sp.Length)
                {
                    if (gia.Length > 1)
                        MessageBox.Show("Bạn chỉ nên nhập 1 giá duy nhất");
                    else
                    {
                        for (int item = 0; item < sp.Length; item++)
                        {
                            chiTieu.sanpham = obj.chuanhoaSP(sp[item].Trim());

                            if (item == 0)
                                chiTieu.giamua = obj.chiaThapPhan(giamuaText.Text);
                            else
                                chiTieu.giamua = "0";

                            chiTieu.detailGiamua = "";

                            chiTieu.date = ngay.Text;

                            chiTieu.weekday = ngay.Value.DayOfWeek.ToString();

                            chiTieu.day = ngay.Value.Day.ToString();

                            chiTieu.month = ngay.Value.Month.ToString();

                            chiTieu.year = ngay.Value.Year.ToString();

                            if (thoidiemText.Text == "")
                                chiTieu.thoidiem = "Không biết";
                            else
                                chiTieu.thoidiem = thoidiemText.Text;

                            if (trocapText.Text == "")
                                chiTieu.trocap = "0";
                            else
                            {
                                if (item == 0)
                                {
                                    trocapText.Text = obj.rmDot1(trocapText.Text);
                                    trocapText.Text = obj.chiaThapPhan(trocapText.Text);
                                    chiTieu.trocap = trocapText.Text;
                                }
                                else
                                    chiTieu.trocap = "0";
                            }

                            if (tietkiemText.Text == "")
                                chiTieu.tietkiem = "0";
                            else
                            {
                                if (tietkiemText.Enabled == true)
                                    if (item == 0)
                                    {
                                        tietkiemText.Text = obj.rmDot1(tietkiemText.Text);
                                        tietkiemText.Text = obj.chiaThapPhan(tietkiemText.Text);
                                        chiTieu.tietkiem = tietkiemText.Text;
                                    }
                                    else
                                        chiTieu.tietkiem = "0";
                                else
                                    chiTieu.tietkiem = "0";
                            }

                            string time = DateTime.Now.ToLongTimeString();
                            obj.nhapLog(chiTieu.date, time, obj.ktraID().ToString(), chiTieu.sanpham, chiTieu.giamua, chiTieu.thoidiem, chiTieu.trocap, chiTieu.tietkiem);

                            obj.addItem(chiTieu);
                        }
                        clearTextBox();
                    }
                }
                else if (gia.Length == sp.Length)
                {
                    for (int item = 0; item < sp.Length; item++)
                    {
                        chiTieu.sanpham = obj.chuanhoaSP(sp[item].Trim());

                        int result = chuanhoaGia(gia[item].Trim());
                        chiTieu.giamua = obj.chiaThapPhan(result.ToString());

                        chiTieu.detailGiamua = detail;

                        chiTieu.sl = sl.ToString();

                        chiTieu.moneyPerOne = obj.chiaThapPhan((result / sl).ToString());

                        chiTieu.date = ngay.Text;

                        chiTieu.weekday = ngay.Value.DayOfWeek.ToString();

                        chiTieu.day = ngay.Value.Day.ToString();

                        chiTieu.month = ngay.Value.Month.ToString();

                        chiTieu.year = ngay.Value.Year.ToString();

                        if (thoidiemText.Text == "")
                            chiTieu.thoidiem = "Không biết";
                        else
                            chiTieu.thoidiem = obj.chuanhoaSP(thoidiemText.Text.Trim());

                        if (trocapText.Text == "")
                            chiTieu.trocap = "0";
                        else
                        {
                            if (item == 0)
                            {
                                trocapText.Text = obj.rmDot1(trocapText.Text);
                                trocapText.Text = obj.chiaThapPhan(trocapText.Text);
                                chiTieu.trocap = trocapText.Text;
                            }
                            else
                                chiTieu.trocap = "0";
                        }

                        if (tietkiemText.Text == "")
                            chiTieu.tietkiem = "0";
                        else
                        {
                            if (tietkiemText.Enabled == true)
                                if (item == 0)
                                {
                                    tietkiemText.Text = obj.rmDot1(tietkiemText.Text);
                                    tietkiemText.Text = obj.chiaThapPhan(tietkiemText.Text);
                                    chiTieu.tietkiem = tietkiemText.Text;
                                }
                                else
                                    chiTieu.tietkiem = "0";
                            else
                                chiTieu.tietkiem = "0";
                        }

                        string time = DateTime.Now.ToLongTimeString();
                        obj.nhapLog(chiTieu.date, time, obj.ktraID().ToString(), chiTieu.sanpham, chiTieu.giamua, chiTieu.thoidiem, chiTieu.trocap, chiTieu.tietkiem);

                        obj.addItem(chiTieu);
                    }

                    clearTextBox();
                }
                else
                    MessageBox.Show("Bạn không nhập đúng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // chuẩn hóa giá <hoàn thành>
        private int chuanhoaGia(string gia)
        {
            int result = 1;
            try
            {
                string[] gia2 = gia.Split('+');
                sl = gia2.Length;
                result = 0;
                foreach (string item in gia2)
                {
                    // nếu nhỏ hơn 1000 thì số đó sai và được sửa lại, bỏ else gây ra lỗi khi chạy if xong sẽ chạy thêm tiếp lệnh gán
                    if (int.Parse(item) < 1000)
                    {
                        string error = gia;
                        DialogResult dialog = MessageBox.Show("Bạn nhập sai: " + error + "\nÝ bạn có phải là: " + obj.chiaThapPhan((int.Parse(item) * 1000).ToString()), "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dialog == DialogResult.Yes)
                        {
                            int tmp = int.Parse(item) * 1000;
                            result += tmp;
                            detail += "+" + obj.chiaThapPhan(tmp.ToString());
                        }
                    }
                    else
                    {
                        result += int.Parse(item);
                        detail += "+" + obj.chiaThapPhan(item);

                    }
                }
                return result;
            }
            catch
            {
                try
                {
                    result = 1;
                    string[] gia3 = gia.Split('*');
                    sl = gia3.Length;
                    foreach (string item2 in gia3)
                    {
                        result *= int.Parse(item2);
                        if (item2 == gia3[0])
                            detail += obj.chiaThapPhan(item2);
                        else
                            detail += "x" + obj.chiaThapPhan(item2);
                    }
                    return result;
                }
                catch
                {
                    try
                    {
                        result = 1;
                        string[] gia3 = gia.Split('x');
                        sl = gia3.Length;
                        foreach (string item2 in gia3)
                        {
                            result *= int.Parse(item2);
                            if (item2 == gia3[0])
                                detail += obj.chiaThapPhan(item2);
                            else
                                detail += "x" + obj.chiaThapPhan(item2);
                        }
                        return result;
                    }
                    catch
                    {
                        result = int.Parse(gia);
                        return result;
                    }
                    
                }
                
            }

        }

        // ktra sản phẩm cần lọc <hoàn thành>
        // private bool findsp(string sanpham)
        //{
        //    bool ktra = obj.findSanpham(sanpham);
        //    return ktra;
        //}

        // ktra giá mua cần lọc <hoàn thành>
        private bool findgia(string giamua)
        {
            bool ktra = obj.findGia(giamua);
            return ktra;
        }

        // đổi hình nền <hoàn thành>
        private void btnHinhnen_Click(object sender, EventArgs e)
        {
            Bitmap file;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Chọn ảnh";
            openFile.Filter = "Image File(*.png, *.jpg, *.jpeg)| *.*g| All Files(*.*)| *.*";
            DialogResult dr = openFile.ShowDialog();
            if(dr == DialogResult.OK)
            {
                file = new Bitmap(openFile.FileName);
                filename = openFile.FileName.ToString();
                //ChooseLayout choose = new ChooseLayout();
                //choose.Show();
                this.tabPage1.BackgroundImage = file;
                this.tabPage3.BackgroundImage = file;
                this.tabPage4.BackgroundImage = file;
                // 1: Center    2: Tile    3: Zoom     4: Stretch
                if(TypeDisplay == 1)
                {
                    this.tabPage1.BackgroundImageLayout = ImageLayout.Center;
                    this.tabPage3.BackgroundImageLayout = ImageLayout.Center;
                    this.tabPage4.BackgroundImageLayout = ImageLayout.Center;
                }
                else if(TypeDisplay == 2)
                {
                    this.tabPage1.BackgroundImageLayout = ImageLayout.Tile;
                    this.tabPage3.BackgroundImageLayout = ImageLayout.Tile;
                    this.tabPage4.BackgroundImageLayout = ImageLayout.Tile;
                }
                else if(TypeDisplay == 3)
                {
                    this.tabPage1.BackgroundImageLayout = ImageLayout.Zoom;
                    this.tabPage3.BackgroundImageLayout = ImageLayout.Zoom;
                    this.tabPage4.BackgroundImageLayout = ImageLayout.Zoom;
                }
                else if(TypeDisplay == 4)
                {
                    this.tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
                    this.tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
                    this.tabPage4.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    this.tabPage1.BackgroundImageLayout = ImageLayout.Center;
                    this.tabPage3.BackgroundImageLayout = ImageLayout.Center;
                    this.tabPage4.BackgroundImageLayout = ImageLayout.Center;
                }

                // đặt màu nền trắng cho các label
                this.label2.BackColor = Color.FromArgb(255, 255, 255);
                this.label3.BackColor = Color.FromArgb(255, 255, 255);
                this.label4.BackColor = Color.FromArgb(255, 255, 255);
                this.label5.BackColor = Color.FromArgb(255, 255, 255);
                this.label6.BackColor = Color.FromArgb(255, 255, 255);
                this.label7.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void tietkiemText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                tietkiemText.Text = obj.chiaThapPhan(tietkiemText.Text);
                e.Handled = true;
            }
        }

        private void trocapText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (Char)Keys.Enter)
            {
                trocapText.Text = obj.chiaThapPhan(trocapText.Text);
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            string tietkiem = obj.ktraTietkiem();
            if (tietkiem != "0")
                tietkiemText.Text = tietkiem;

            ToolTip tl = new ToolTip();
            if (tietkiemText.Text == "")
                tl.SetToolTip(tietkiemText, "Chưa có số tiền tiết kiệm trong tháng này");
            //else
            //    tl.SetToolTip(tietkiemText, "Tiền tiết kiệm dự tính tháng " + DateTime.Today.Month.ToString() + ": " + tietkiemText.Text);
        }

        // refesh dữ liệu
        private void RefreshMenu_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        // đóng các cửa sổ con
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // lưu các cài đặt
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string image, backcolor, font, fontcolor;
            image = filename + "-" + TypeDisplay;
            backcolor = this.tabPage1.BackColor.ToString();
            font = label2.Font.Name.ToString() + "-" + label2.Font.Size.ToString() + "-" + label2.Font.Style.ToString();
            fontcolor = this.label2.ForeColor.ToString();
            // lưu cài đặt
            obj.save(image, backcolor, font, fontcolor);
        }

    }
}
