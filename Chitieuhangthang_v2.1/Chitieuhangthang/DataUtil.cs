using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace Chitieuhangthang
{
    class DataUtil
    {
        XmlElement root;
        XmlDocument doc;
        string filename;

        public DataUtil()
        {
            filename = "Data.xml";
            doc = new XmlDocument();
            if (!File.Exists(filename))
            {
                XmlElement rt = doc.CreateElement("chitieuhangngay");
                doc.AppendChild(rt);
                doc.Save(filename);
            }

            // tạo file nhật ký
            string path = "NhatKy.txt";
            FileStream filelog;
            if(!File.Exists(path))
            {
                filelog = new FileStream(path, FileMode.CreateNew);
                filelog.Close();
            }

            doc.Load(filename);
            root = doc.DocumentElement;
        }

        // nhập dữ liệu vào file dữ liệu
        public void addItem(Chitieu chiTieu)
        {
            int id = ktraID();
            XmlElement ngay = doc.CreateElement("ngay");
            ngay.SetAttribute("date", chiTieu.date);
            ngay.SetAttribute("id", id.ToString());
            ngay.SetAttribute("count", chiTieu.count);
            ngay.SetAttribute("weekday", chiTieu.weekday);
            ngay.SetAttribute("day", chiTieu.day);
            ngay.SetAttribute("month", chiTieu.month);
            ngay.SetAttribute("year", chiTieu.year);

            XmlElement sanpham = doc.CreateElement("sanpham");
            sanpham.InnerText = chiTieu.sanpham;
            XmlElement giamua = doc.CreateElement("giamua");
            giamua.InnerText = chiTieu.giamua;
            XmlElement detailGiamua = doc.CreateElement("detailGiamua");
            detailGiamua.InnerText = chiTieu.detailGiamua;
            XmlElement sl = doc.CreateElement("sl");
            sl.InnerText = chiTieu.sl;
            XmlElement moneyperOne = doc.CreateElement("moneyPerOne");
            moneyperOne.InnerText = chiTieu.moneyPerOne;
            XmlElement thoidiem = doc.CreateElement("thoidiem");
            thoidiem.InnerText = chiTieu.thoidiem;
            XmlElement trocap = doc.CreateElement("trocap");
            trocap.InnerText = chiTieu.trocap;
            XmlElement tietkiem = doc.CreateElement("tietkiem");
            tietkiem.InnerText = chiTieu.tietkiem;

            ngay.AppendChild(sanpham);
            ngay.AppendChild(giamua);
            ngay.AppendChild(detailGiamua);
            ngay.AppendChild(sl);
            ngay.AppendChild(moneyperOne);
            ngay.AppendChild(thoidiem);
            ngay.AppendChild(trocap);
            ngay.AppendChild(tietkiem);

            root.AppendChild(ngay);
            doc.Save(filename);
        }

        // trả về sự thay đổi giá cả của mặt hàng
        public List<ChitieuXuat> fillterItemSP(string sanpham)
        {
            XmlNodeList nodes = root.SelectNodes("ngay[sanpham = '" + sanpham + "']");
            List<ChitieuXuat> ds = new List<ChitieuXuat>();
            
            foreach(XmlNode item in nodes)
            {
                ChitieuXuat chiTieu = new ChitieuXuat();
                chiTieu.id = item.Attributes[1].InnerText;
                chiTieu.sanpham = item.SelectSingleNode("sanpham").InnerText;
                chiTieu.giamua = item.SelectSingleNode("giamua").InnerText;
                chiTieu.date = item.Attributes[0].InnerText;
                chiTieu.thoidiem = item.SelectSingleNode("thoidiem").InnerText;
                chiTieu.trocap = item.SelectSingleNode("trocap").InnerText;
                chiTieu.tietkiem = item.SelectSingleNode("tietkiem").InnerText;
                ds.Add(chiTieu);
            }
            //ChitieuXuat xuat = new ChitieuXuat();
            //xuat.id = "";
            //xuat.sanpham = "";
            //xuat.giamua = "";
            //xuat.date = "";
            //xuat.thoidiem = "";
            //xuat.trocap = "";
            //xuat.tietkiem = "";
            //ds.Add(xuat);
            //sxgia(ds);
            return ds;
        }

        public void sxgia(List<Chitieu> ds)
        {
            List<Chitieu> ds1 = null;
            for (int i = 1; i < ds.Count; i++)
            {
                if (string.Compare(ds[i].giamua, ds[0].giamua) > 0)
                {
                    ds1 = new List<Chitieu>();
                    ds1[0] = ds[0];
                    ds[0] = ds[i];
                    ds[i] = ds1[0];
                }
            }
        }

        // trả về các mặt hàng cùng giá
        public List<ChitieuXuat> fillterItemMoney(string giamua)
        {
            XmlNodeList nodes = root.SelectNodes("ngay[giamua = '" + giamua + "']");
            List<ChitieuXuat> ds = new List<ChitieuXuat>();
            foreach (XmlNode item in nodes)
            {
                ChitieuXuat chiTieu = new ChitieuXuat();
                chiTieu.id = item.Attributes[1].InnerText;
                chiTieu.sanpham = item.SelectSingleNode("sanpham").InnerText;
                chiTieu.giamua = item.SelectSingleNode("giamua").InnerText;
                chiTieu.date = item.Attributes[0].InnerText;
                chiTieu.thoidiem = item.SelectSingleNode("thoidiem").InnerText;
                chiTieu.trocap = item.SelectSingleNode("trocap").InnerText;
                chiTieu.tietkiem = item.SelectSingleNode("tietkiem").InnerText;
                ds.Add(chiTieu);
            }
            //ds.Reverse();
            return ds;
        }

        // trả về ds ngày tiêu nhiều nhất
        public List<ChitieuXuat> fillterItemDateAll()
        {
            // lọc ra ds ngày
            XmlNodeList date = root.SelectNodes("ngay[@date]");

            // tính tổng giá 1 ngày, tổng sl hàng 1 ngày
            List<ChitieuXuat> ds = new List<ChitieuXuat>();
            foreach(XmlNode item in date)
            {
                ChitieuXuat chiTieu = new ChitieuXuat();
                chiTieu.id = item.Attributes[1].InnerText;
                chiTieu.sanpham = item.SelectSingleNode("sanpham").InnerText;
                chiTieu.giamua = item.SelectSingleNode("giamua").InnerText;
                chiTieu.date = item.Attributes[0].InnerText;
                chiTieu.thoidiem = item.SelectSingleNode("thoidiem").InnerText;

                if (item.SelectSingleNode("trocap").InnerText == "0")
                    chiTieu.trocap = "";
                else
                    chiTieu.trocap = item.SelectSingleNode("trocap").InnerText;
                if (item.SelectSingleNode("tietkiem").InnerText == "0")
                    chiTieu.tietkiem = "";
                else
                    chiTieu.tietkiem = item.SelectSingleNode("tietkiem").InnerText;

                ds.Add(chiTieu);
            }

            // sắp xếp giá theo thứ tự giảm dần
            //ds.Reverse();
            
            // lưu vào ds để trả về
            return ds;
        }

        // lọc khoảng ngày
        public List<ChitieuXuat> fillterItemDateBetween(string start, string end)
        {
            // lọc ra ds ngày
            // ktra điều kiện: nếu >= start và <= end ==> lọc
            XmlNodeList date = root.SelectNodes("ngay[@date]");
            List<ChitieuXuat> ds = new List<ChitieuXuat>();
            // tính tổng giá 1 ngày, tổng sl hàng 1 ngày
            foreach (XmlNode item in date)
            {
                if (string.Compare(item.Attributes[0].InnerText, start) > 0 && string.Compare(item.Attributes[0].InnerText, end) < 0 || string.Compare(item.Attributes[0].InnerText, start) == 0 || string.Compare(item.Attributes[0].InnerText, end) == 0)
                {
                    ChitieuXuat chiTieu = new ChitieuXuat();
                    chiTieu.id = item.Attributes[1].InnerText;
                    chiTieu.sanpham = item.SelectSingleNode("sanpham").InnerText;
                    chiTieu.giamua = item.SelectSingleNode("giamua").InnerText;
                    chiTieu.date = item.Attributes[0].InnerText;
                    chiTieu.thoidiem = item.SelectSingleNode("thoidiem").InnerText;

                    if (item.SelectSingleNode("trocap").InnerText == "0")
                        chiTieu.trocap = "";
                    else
                        chiTieu.trocap = item.SelectSingleNode("trocap").InnerText;
                    if (item.SelectSingleNode("tietkiem").InnerText == "0")
                        chiTieu.tietkiem = "";
                    else
                        chiTieu.tietkiem = item.SelectSingleNode("tietkiem").InnerText;

                    ds.Add(chiTieu);
                }
            }
            // sắp xếp giá theo thứ tự giảm dần
            //ds.Reverse();
            
            // lưu vào ds để trả về
            return ds;
        }

        // đưa ra bảng thông tin
        public List<string> viewInfor(string month)
        {
            // tính tổng tiền trợ cấp
            XmlNodeList nodes = root.SelectNodes("ngay[@month = '" + month + "']");
            List<ChitieuXuat> result = new List<ChitieuXuat>();
            int sp = 0;
            foreach(XmlNode item in nodes)
            {
                ChitieuXuat xuat = new ChitieuXuat();
                string tc = item.SelectSingleNode("trocap").InnerText;
                xuat.trocap = rmDot1(tc);
                string tk = item.SelectSingleNode("tietkiem").InnerText;
                xuat.tietkiem = rmDot1(tk);
                string gia = item.SelectSingleNode("giamua").InnerText;
                xuat.giamua = rmDot1(gia);
                sp += item.SelectNodes("sanpham").Count;
                result.Add(xuat);
            }
            


            string trocap = result.Sum(rlt => int.Parse(rlt.trocap)).ToString();
            trocap = chiaThapPhan(trocap.ToString());
            string tietkiem = result.Sum(rlt => int.Parse(rlt.tietkiem)).ToString();
            tietkiem = chiaThapPhan(tietkiem.ToString());
            string tong = result.Sum(rlt => int.Parse(rlt.giamua)).ToString();
            tong = chiaThapPhan(tong.ToString());
            int money = (result.Sum(rlt => int.Parse(rlt.trocap)) - result.Sum(rlt => int.Parse(rlt.giamua)));
            string realSave = "";
            if (money < 0)
            {
                money = Math.Abs(money);
                realSave = "-" + chiaThapPhan(money.ToString());
            }
            else
                realSave = chiaThapPhan(money.ToString());
            
            List<string> ds = new List<string>();
            ds.Add(trocap);
            ds.Add(tietkiem);
            ds.Add(tong);
            ds.Add(realSave);
            ds.Add(sp.ToString());
            return ds;
        }

        // Xem thông tin hiện tại
        public List<ChitieuXuat> viewCurrent()
        {
            string date = DateTime.Now.ToShortDateString();
            XmlNodeList nodes = root.SelectNodes("ngay[@date = '" + date + "']");
            List<ChitieuXuat> ds = new List<ChitieuXuat>();

            foreach(XmlNode item in nodes)
            {
                ChitieuXuat xuat = new ChitieuXuat();
                xuat.id = item.Attributes[1].InnerText;
                xuat.sanpham = item.SelectSingleNode("sanpham").InnerText;
                xuat.giamua = item.SelectSingleNode("giamua").InnerText;
                xuat.thoidiem = item.SelectSingleNode("thoidiem").InnerText;
                xuat.date = item.Attributes[0].InnerText;
                if (item.SelectSingleNode("trocap").InnerText == "0")
                    xuat.trocap = "";
                else
                    xuat.trocap = item.SelectSingleNode("trocap").InnerText;
                if (item.SelectSingleNode("tietkiem").InnerText == "0")
                    xuat.tietkiem = "";
                else
                    xuat.tietkiem = item.SelectSingleNode("tietkiem").InnerText;
                ds.Add(xuat);
            }

            return ds;
        }

        // update item vào file dữ liệu
        public bool Update(Chitieu chiTieu)
        {
            XmlNode node = root.SelectSingleNode("ngay[@id = '" + chiTieu.id + "']");
            if(node != null)
            {
                // lỗi file dữ liệu đang mở bằng phần mềm khác
                try
                {
                    Chitieu chiTieu1 = new Chitieu();
                    // lấy ra thông tin của weekday, day, month, year để ghi đè
                    chiTieu1.weekday = node.Attributes[3].InnerText;
                    chiTieu1.day = node.Attributes[4].InnerText;
                    chiTieu1.month = node.Attributes[5].InnerText;
                    chiTieu1.year = node.Attributes[6].InnerText;

                    XmlElement ngay = doc.CreateElement("ngay");
                    ngay.SetAttribute("date", chiTieu.date);
                    ngay.SetAttribute("id", chiTieu.id);
                    ngay.SetAttribute("count", chiTieu.count);
                    ngay.SetAttribute("weekday", chiTieu1.weekday);
                    ngay.SetAttribute("day", chiTieu1.day);
                    ngay.SetAttribute("month", chiTieu1.month);
                    ngay.SetAttribute("year", chiTieu1.year);

                    XmlElement sanpham = doc.CreateElement("sanpham");
                    sanpham.InnerText = chiTieu.sanpham;
                    XmlElement giamua = doc.CreateElement("giamua");
                    giamua.InnerText = chiTieu.giamua;
                    XmlElement thoidiem = doc.CreateElement("thoidiem");
                    thoidiem.InnerText = chiTieu.thoidiem;
                    XmlElement trocap = doc.CreateElement("trocap");
                    trocap.InnerText = chiTieu.trocap;
                    XmlElement tietkiem = doc.CreateElement("tietkiem");
                    tietkiem.InnerText = chiTieu.tietkiem;

                    ngay.AppendChild(sanpham);
                    ngay.AppendChild(giamua);
                    ngay.AppendChild(thoidiem);
                    ngay.AppendChild(trocap);
                    ngay.AppendChild(tietkiem);

                    root.ReplaceChild(ngay, node);
                    doc.Save(filename);
                    return true;
                }
                catch
                {
                    return false;
                }
                
            }
            return false;
        }

        // xóa item trong dữ liệu
        public bool Delete(string id)
        {
            XmlNode node = root.SelectSingleNode("ngay[@id = '" + id + "']");
            if(node != null)
            {
                root.RemoveChild(node);
                doc.Save(filename);
                return true;
            }
            return false;
        }

        // kiểm tra số định danh id trong dữ liệu
        public int ktraID()
        {
            int id = 0;
            XmlNodeList nodes = root.SelectNodes("ngay[@id]");
            if (nodes.Count == 0)
                id = 1;
            else
            {
                string item = nodes[nodes.Count - 1].Attributes[1].InnerText;
                id = int.Parse(item);
                id += 1;
            }

            return id;
        }

        // kiểm tra số đếm lần nhập
        public int ktraCount()
        {
            int count = 0;
            XmlNodeList nodes = root.SelectNodes("ngay[@count]");
            if (nodes.Count == 0)
                count = 1;
            else
            {
                string item = nodes[nodes.Count - 1].Attributes[2].InnerText;
                count = int.Parse(item);
                count += 1;
            }

            return count;
        }

        // tìm sản phẩm     <trả về có hoặc không có sản phẩm trong dữ liệu>
        public bool findSanpham(string sanpham)
        {
            string result = "";

            // Viết hoa các chữ cái đầu tiên của mỗi từ
            string[] words = sanpham.Split(' ');
            foreach (string word in words)
            {
                // nếu là khoảng trắng thì bỏ qua
                if (word.Trim() != "")
                    if (word.Length > 1)
                        result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                    else
                        result += word.ToUpper() + " ";
            }

            XmlNode node = root.SelectSingleNode("ngay[sanpham = '" + result.Trim() + "']");
            if (node != null)
            {
                return true;
            }

            return false;
        }

        // tìm giá mua trong dữ liệu
        public bool findGia(string giamua)
        {
            XmlNode node1 = root.SelectSingleNode("ngay[giamua = '" + giamua + "']");
            if (node1 != null)
            {
                return true;
            }

            return false;
        }

        // hiện tại đang lỗi <cần update>
        public List<string> ktraNgay(List<ChitieuXuat> xuat)
        {
            // Lấy ra danh sách các ngày
            List<string> dsNgay = new List<string>();
            dsNgay.Add(xuat[0].date);
            int j = 0;
            for(int i = 0; i < xuat.Count; i++)
                if(xuat[i].date != dsNgay[j])
                {
                    j++;
                    dsNgay.Add(xuat[i].date);
                }
            return dsNgay;
        }

        // hiện tại đang lỗi <cần update>
        public List<ChitieuXuat> ngayMax_Min(List<ChitieuXuat> xuat)
        {
            // danh sách ngày có trong bảng
            List<string> ngay = new List<string>();
            ngay = ktraNgay(xuat);
            
            //danh sách max min
            List<ChitieuXuat> dsReturn = new List<ChitieuXuat>();

            for (int i = 0; i < ngay.Count; i++)
            {
                List<int> dsgia = new List<int>();
                List<string> dssp = new List<string>();
                for (int j = 0; j < xuat.Count; j++)
                {
                    if (xuat[j].date == ngay[i])
                    {
                        dsgia = new List<int>();
                        dssp = new List<string>();
                        dssp.Add(xuat[j].sanpham);
                        dsgia.Add(int.Parse(xuat[j].giamua));
                    }
                    else
                    {
                        int tonggt = dsgia.Sum(danhsach => danhsach);
                        int tongsl = dssp.Count;

                        ChitieuXuat x = new ChitieuXuat();
                        x.date = xuat[j - 1].date;
                        x.sanpham = tongsl.ToString();
                        x.giamua = tonggt.ToString();
                        dsReturn.Add(x);
                        break;
                    }
                }
                
            }

            // danh sách trả về: ngày, tổng tiền, tổng sl
            return dsReturn;
        }

        // chuẩn hóa sản phẩm   <viết hoa chữ cái đầu mỗi từ>
        public string chuanhoaSP(string sanpham)
        {
            string result = "";

            // Viết hoa các chữ cái đầu tiên của mỗi từ
            string[] words = sanpham.Split(' ');
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

        // chuẩn hóa giá mua    <kiểm tra giá mua có phải là số hay không>
        public string chuanhoaGia(string giamua)
        {
            string result = "";
            try
            {
                giamua = rmDot1(giamua);
                int gia1 = int.Parse(giamua);
                result = chiaThapPhan(gia1.ToString());
                return result;
            }
            catch
            {
                result = "not";
                return result;
            }
        }

        //ghi thông tin nhập vào file nhật ký
        public void nhapLog(string date, string time, string id, string sp, string gia, string td, string tc, string tk)
        {
            string path = "NhatKy.txt";
            FileStream filelog = new FileStream(path, FileMode.Append);
            StreamWriter userWrite = new StreamWriter(filelog, Encoding.UTF8);
            string mess;
            mess = "[Nhập - " + date + " : " + time + " ,id = " + id + "]  Sản phẩm: " + sp + " -- Giá mua: " + gia + " -- Thời điểm: " + td + " -- Trợ cấp: " + tc + " -- Tiết kiệm: " + tk;
            userWrite.WriteLine(mess);
            userWrite.Close();
            filelog.Close();
        }

        // ghi thông tin update vào file nhật ký
        public void updateLog(string name, string date, string time, string id, string _old, string _new)
        {
            string path = "NhatKy.txt";
            FileStream filelog = new FileStream(path, FileMode.Append);
            StreamWriter userWrite = new StreamWriter(filelog, Encoding.UTF8);
            string mess;
            mess = "[Update - " + name + " " + date + " : " + time + " ,id = " + id + "]  " + _old + " --> " + _new;
            userWrite.WriteLine(mess);
            userWrite.Close();
            filelog.Close();
        }

        // ghi thông tin delete vào file nhật ký
        public void deleteLog(string name, string date, string time, string id, string sp, string gia, string td, string tc, string tk)
        {
            string path = "NhatKy.txt";
            FileStream filelog = new FileStream(path, FileMode.Append);
            StreamWriter userWrite = new StreamWriter(filelog, Encoding.UTF8);
            string mess;
            mess = "[Xóa - " + name + " " + date + " : " + time + " ,id = " + id + "] (Đã xóa)   Sản phẩm: " + sp + " -- Giá mua: " + gia + " -- Thời điểm: " + td + " -- Trợ cấp: " + tc + " -- Tiết kiệm: " + tk;
            userWrite.WriteLine(mess);
            userWrite.Close();
            filelog.Close();
        }

        // loại bỏ dấu chấm thập phân và trả về danh sách
        public List<ChitieuXuat> removeDot(List<ChitieuXuat> xuat)
        {
            List<ChitieuXuat> ds = new List<ChitieuXuat>();
            foreach(ChitieuXuat item in xuat)
            {
                ChitieuXuat xuat1 = new ChitieuXuat();
                xuat1.date = item.date;
                xuat1.id = item.id;
                xuat1.sanpham = item.sanpham;
                xuat1.thoidiem = item.thoidiem;
                xuat1.trocap = item.trocap;
                xuat1.tietkiem = item.tietkiem;
                xuat1.giamua = rmDot1(item.giamua);
                ds.Add(xuat1);
            }

            return ds;
        }

        // loại bỏ dấu chấm thập phân
        public string rmDot1(string giamua)
        {
            string gia = "";
            string[] _new = giamua.Split('.');
            foreach (string item in _new)
                gia += item;

            return gia;
        }

        // tạo dấu chấm thập phân
        public string chiaThapPhan(string chuoi)
        {
            string result = "";
            int i = 0;

            if (chuoi.Length <= 3)
            {
                result = chuoi;
            }

            while (chuoi.Length > 3)
            {
                i = chuoi.Length - 3;
                result = "." + chuoi.Substring(i, 3) + result;
                chuoi = chuoi.Substring(0, i);

                if (chuoi.Length <= 3)
                {
                    result = chuoi + result;
                }
            }

            return result;
        }

        // tạo chức năng update
        public void funcUpdate(DataGridView table, string name, string _old, int col, string ID)
        {
            for (int i = 0; i < table.RowCount; i++)
            {
                Chitieu chiTieu = new Chitieu();
                try
                {
                    chiTieu.id = table.Rows[i].Cells[2].Value.ToString();
                    chiTieu.sanpham = chuanhoaSP(table.Rows[i].Cells[3].Value.ToString());
                    string gia = chuanhoaGia(table.Rows[i].Cells[4].Value.ToString());
                    if (gia == "not")
                    {
                        MessageBox.Show("Giá mua không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    else
                    {
                        if (testDot(gia))
                        {
                            chiTieu.giamua = gia;
                        }
                        else
                        {
                            gia = chiaThapPhan(gia);
                            chiTieu.giamua = gia;
                        }
                    }


                    chiTieu.date = table.Rows[i].Cells[1].Value.ToString();
                    chiTieu.thoidiem = chuanhoaSP(table.Rows[i].Cells[5].Value.ToString());

                    string tc = table.Rows[i].Cells[6].Value.ToString();
                    if (tc == "")
                        chiTieu.trocap = "0";
                    else
                    {
                        if(testDot(tc))
                        {
                            chiTieu.trocap = tc;
                        }
                        else
                        {
                            tc = chiaThapPhan(tc);
                            chiTieu.trocap = tc;
                        }
                    }

                    string tk = table.Rows[i].Cells[7].Value.ToString();
                    if (tk == "")
                        chiTieu.tietkiem = "0";
                    else
                    {
                        if(testDot(tk))
                        {
                            chiTieu.tietkiem = tk;
                        }
                        else
                        {
                            tk = chiaThapPhan(tk);
                            chiTieu.tietkiem = tk;
                        }
                    }

                    if (chiTieu.id == ID)
                    {
                        string _new = table.Rows[i].Cells[col].Value.ToString();
                        updateLog(name, DateTime.Today.ToShortDateString(), DateTime.Now.ToLongTimeString(), ID, _old, _new);
                    }
                }
                catch
                {
                    MessageBox.Show("Bạn nên để 0 nếu không có giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                bool ktra = Update(chiTieu);
                //if (!ktra)
                //{
                //    MessageBox.Show("Không thể cập nhật được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
            }
        }

        // kiểm tra những item trong cùng 1 lần nhập


        // tạo chức năng xóa
        public void funcDelete(DataGridView table, string name, string ID, int numrow)
        {
            string sanpham = table.Rows[numrow].Cells[3].Value.ToString();
            string giamua = table.Rows[numrow].Cells[4].Value.ToString();
            if (giamua == "")
                giamua = "0";
            string thoidiem = table.Rows[numrow].Cells[5].Value.ToString();
            string trocap = table.Rows[numrow].Cells[6].Value.ToString();
            if (trocap == "")
                trocap = "0";
            string tietkiem = table.Rows[numrow].Cells[7].Value.ToString();
            if (tietkiem == "")
                tietkiem = "0";

            deleteLog(name, DateTime.Today.ToShortDateString(), DateTime.Now.ToLongTimeString(), ID, sanpham, giamua, thoidiem, trocap, tietkiem);
            bool ktra = Delete(ID);
            if (!ktra)
            {
                MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // kiểm tra xem chuỗi có dấu chấm thập phân không
        public bool testDot(string chuoi)
        {
            foreach(char item in chuoi)
            {
                if (item == '.')
                    return true;
            }
            return false;

        }

        // lấy ra tiền dự kiến tiết kiệm mỗi tháng
        public string ktraTietkiem()
        {
            string month = DateTime.Today.Month.ToString();
            string year = DateTime.Today.Year.ToString();
            string tietkiem = "0";
            XmlNodeList items = root.SelectNodes("ngay[@month = '" + month + "' and @year = '" + year + "']");

            
            foreach(XmlNode item in items)
            {
                if (item.SelectSingleNode("tietkiem").InnerText != "0")
                    tietkiem = item.SelectSingleNode("tietkiem").InnerText;
            }
            return tietkiem;
        }

        // lấy ra detailmoney    <cần update>
        public List<string> getDetailMoney(string id)
        {
            List<string> detail = new List<string>(2);
            // lọc nút có id = parameter(id)
            XmlNodeList items = root.SelectNodes("ngay[@id = '" + id + "']");
            foreach(XmlNode item in items)
            {
                if (item.SelectSingleNode("detailGiamua").InnerText == "0")
                {
                    detail.Add("");
                    detail.Add(item.SelectSingleNode("giamua").InnerText);
                }

                else
                {
                    detail.Add(item.SelectSingleNode("detailGiamua").InnerText);
                    detail.Add(item.SelectSingleNode("giamua").InnerText);
                }
            }
            
            return detail;
        }

    }
}
