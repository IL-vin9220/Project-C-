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
            XmlElement tienduthangtruoc = doc.CreateElement("tienduthangtruoc");
            tienduthangtruoc.InnerText = Tienthua();
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
            //ds.Sort((x, y) => y.date.CompareTo(x.date));

            List<ChitieuXuat> xuat = ds;
            // lưu vào ds để trả về
            return xuat;
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
            string tietkiem = result.Sum(rlt => int.Parse(rlt.tietkiem)).ToString();
            string tong = result.Sum(rlt => int.Parse(rlt.giamua)).ToString();
            int money = int.Parse(trocap) - int.Parse(tong);

            trocap = chiaThapPhan(trocap.ToString());
            tietkiem = chiaThapPhan(tietkiem.ToString());
            tong = chiaThapPhan(tong.ToString());

            string realSave = money.ToString();
            
            List<string> ds = new List<string>();
            ds.Add(trocap);
            ds.Add(tietkiem);
            ds.Add(tong);
            ds.Add(realSave);
            ds.Add(sp.ToString());
            return ds;
        }

        // kiểm tra tiền còn lại tháng trước
        public string Tienthua()
        {
            // lấy ra tháng hiện tại
            int currentMonth = DateTime.Today.Month;
            // lấy ra năm hiện tại
            int currentYear = DateTime.Today.Year;
            // khởi tạo tháng trước và năm trước
            int lastMonth = 0, lastYear = 0;
            // nếu tháng hiện tại là tháng 1 thì tháng trước là tháng 12 và năm trước = năm hiện tại - 1
            if(currentMonth == 1)
            {
                lastMonth = 12;
                lastYear = currentYear - 1;
            }
            else
            {
                lastMonth = currentMonth - 1;
                lastYear = currentYear;
            }

            //duyệt nút
            XmlNodeList nodes = root.SelectNodes("ngay[@month = '" + lastMonth.ToString()+ "' and @year = '" + lastYear.ToString() + "']");
            List<Chitieu> result = new List<Chitieu>();

            // khởi tạo biến tổng trợ cấp và tổng giá mua
            int tongtc = 0, tonggm = 0, tiendu = 0;
            foreach (XmlNode item in nodes)
            {
                string tc = item.SelectSingleNode("trocap").InnerText;
                tongtc += int.Parse(rmDot1(tc));
                try
                {
                    string tdu = item.SelectSingleNode("tienduthangtruoc").InnerText;
                    tiendu = int.Parse(rmDot1(tdu));
                }
                catch
                {
                    tiendu = 0;
                }
                
                string gia = item.SelectSingleNode("giamua").InnerText;
                tonggm += int.Parse(rmDot1(gia));
            }
            int money = tongtc - tonggm + tiendu;
            if (money > 0)
                return money.ToString();
            else
                return "0";
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
        public bool Update(Chitieu chiTieu, string danhmuc)
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
                xuat1.giamua = rmDot1(item.giamua);
                xuat1.trocap = item.trocap;
                xuat1.tietkiem = item.tietkiem;
                ds.Add(xuat1);
            }

            return ds;
        }

        // sắp xếp danh sách hiển thị trong bảng
        // sắp xếp danh sách tăng dần
        //public List<ChitieuXuat> SortAsc(List<ChitieuXuat> xuat, string nameSort)
        //{
        //    List<ChitieuXuat> ds = new List<ChitieuXuat>();

        //    List<ChitieuXuatSort> xuatSort = new List<ChitieuXuatSort>();
        //    // chuyển đổi dữ liệu để sắp xếp
        //    foreach(ChitieuXuat item in xuat)
        //    {
        //        ChitieuXuatSort sort = new ChitieuXuatSort();
        //        sort.sanpham = item.sanpham;
        //        sort.giamua = int.Parse(item.giamua);
        //        sort.thoidiem = item.thoidiem;
        //        sort.date = item.date;
        //        if (item.trocap != "" && item.trocap != null)
        //            sort.trocap = int.Parse(item.trocap);
        //        else
        //            sort.trocap = 0;
        //        if (item.tietkiem != "" && item.tietkiem != null)
        //            sort.tietkiem = int.Parse(item.tietkiem);
        //        else
        //            sort.tietkiem = 0;
        //        sort.id = item.id;
        //        xuatSort.Add(sort);
        //    }

        //    // sắp xếp
        //    if(nameSort == "giamua")
        //        xuatSort.Sort((x, y) => x.giamua.CompareTo(y.giamua));
        //    else if(nameSort == "trocap")
        //        xuatSort.Sort((x, y) => x.trocap.CompareTo(y.trocap));
        //    else
        //        xuatSort.Sort((x, y) => x.tietkiem.CompareTo(y.tietkiem));


        //    // chuyển lại dữ liệu để đưa vào đầu ra
        //    foreach (ChitieuXuatSort item in xuatSort)
        //    {
        //        ChitieuXuat xuat1 = new ChitieuXuat();
        //        xuat1.sanpham = item.sanpham;
        //        xuat1.giamua = item.giamua.ToString();
        //        xuat1.thoidiem = item.thoidiem;
        //        xuat1.date = item.date;
        //        if (item.trocap == 0)
        //            xuat1.trocap = "";
        //        else
        //            xuat1.trocap = item.trocap.ToString();
        //        if (item.tietkiem == 0)
        //            xuat1.tietkiem = "";
        //        else
        //            xuat1.tietkiem = item.tietkiem.ToString();
        //        xuat1.id = item.id;
        //        ds.Add(xuat1);
        //    }

        //    return ds;
        //}

        //// sắp xếp danh sách giảm dần
        //public List<ChitieuXuat> SortDesc(List<ChitieuXuat> xuat, string nameSort)
        //{
        //    List<ChitieuXuat> ds = new List<ChitieuXuat>();

        //    List<ChitieuXuatSort> xuatSort = new List<ChitieuXuatSort>();
        //    // chuyển đổi dữ liệu để sắp xếp
        //    foreach (ChitieuXuat item in xuat)
        //    {
        //        ChitieuXuatSort sort = new ChitieuXuatSort();
        //        sort.sanpham = item.sanpham;
        //        sort.giamua = int.Parse(item.giamua);
        //        sort.thoidiem = item.thoidiem;
        //        sort.date = item.date;
        //        if (item.trocap != "" && item.trocap != null)
        //            sort.trocap = int.Parse(item.trocap);
        //        else
        //            sort.trocap = 0;
        //        if (item.tietkiem != "" && item.tietkiem != null)
        //            sort.tietkiem = int.Parse(item.tietkiem);
        //        else
        //            sort.tietkiem = 0;
        //        sort.id = item.id;
        //        xuatSort.Add(sort);
        //    }

        //    // sắp xếp
        //    if (nameSort == "giamua")
        //        xuatSort.Sort((y, x) => x.giamua.CompareTo(y.giamua));
        //    else if (nameSort == "trocap")
        //        xuatSort.Sort((y, x) => x.trocap.CompareTo(y.trocap));
        //    else
        //        xuatSort.Sort((y, x) => x.tietkiem.CompareTo(y.tietkiem));


        //    // chuyển lại dữ liệu để đưa vào đầu ra
        //    foreach (ChitieuXuatSort item in xuatSort)
        //    {
        //        ChitieuXuat xuat1 = new ChitieuXuat();
        //        xuat1.sanpham = item.sanpham;
        //        xuat1.giamua = item.giamua.ToString();
        //        xuat1.thoidiem = item.thoidiem;
        //        xuat1.date = item.date;
        //        if (item.trocap == 0)
        //            xuat1.trocap = "";
        //        else
        //            xuat1.trocap = item.trocap.ToString();
        //        if (item.tietkiem == 0)
        //            xuat1.tietkiem = "";
        //        else
        //            xuat1.tietkiem = item.tietkiem.ToString();
        //        xuat1.id = item.id;
        //        ds.Add(xuat1);
        //    }

        //    return ds;
        //}

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

        // tạo dấu chấm thập phân cho danh sách
        public List<ChitieuXuat> ChiaThapPhanDanhSach(List<ChitieuXuat> xuat)
        {
            List<ChitieuXuat> ds = new List<ChitieuXuat>();
            foreach (ChitieuXuat item in xuat)
            {
                ChitieuXuat xuat1 = new ChitieuXuat();
                xuat1.date = item.date;
                xuat1.id = item.id;
                xuat1.sanpham = item.sanpham;
                xuat1.thoidiem = item.thoidiem;
                xuat1.trocap = chiaThapPhan(item.trocap);
                xuat1.tietkiem = chiaThapPhan(item.tietkiem);
                xuat1.giamua = chiaThapPhan(item.giamua);
                ds.Add(xuat1);
            }

            return ds;
        }

        // tạo chức năng update
        public void funcUpdate(DataGridView table, string name, string _old, int col, string ID, string danhmuc)
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


                bool ktra = Update(chiTieu, danhmuc);
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

        // lưu các cài đặt
        public void save(string image, string backcolor, string font, string fontcolor)
        {
            FileStream fs = new FileStream("Setup.txt", FileMode.Create, FileAccess.Write);
            StreamWriter stwriter = new StreamWriter(fs);
            stwriter.WriteLine(image);
            stwriter.WriteLine(backcolor);
            stwriter.WriteLine(font);
            stwriter.WriteLine(fontcolor);

            stwriter.Flush();
            stwriter.Close();
            fs.Close();
        }

        // tìm kiếm giá trị của danh mục trong danh sách
        public bool CheckDanhmuc(string danhmuc, string value, List<ChitieuXuat> xuat)
        {
            if (danhmuc == "Tên sản phẩm")
            {
                for (int i = 0; i < xuat.Count; i++)
                    if (xuat[i].sanpham == value)
                        return true;
            }
            else if (danhmuc == "Giá mua")
            {
                for (int i = 0; i < xuat.Count; i++)
                    if (xuat[i].giamua == value)
                        return true;
            }
            else if (danhmuc == "Thời điểm")
            {
                for (int i = 0; i < xuat.Count; i++)
                    if (xuat[i].thoidiem == value)
                        return true;
            }
            else if (danhmuc == "Trợ cấp")
            {
                for (int i = 0; i < xuat.Count; i++)
                    if (xuat[i].trocap == value)
                        return true;
            }
            else if (danhmuc == "Tiết kiệm")
            {
                for (int i = 0; i < xuat.Count; i++)
                    if (xuat[i].tietkiem == value)
                        return true;
            }
            else if (danhmuc == "ID")
            {
                for (int i = 0; i < xuat.Count; i++)
                    if (xuat[i].id == value)
                        return true;
            }
            else
            {
                string[] ngay = value.Split('-');
                if (ngay.Length == 1)
                {
                    for (int i = 0; i < xuat.Count; i++)
                        if (xuat[i].date == value)
                            return true;
                }
                else
                {
                    int start = 0, end = 0;
                    // kiểm tra ngày bắt đầu có trong danh sách không
                    for (int i = 0; i < xuat.Count; i++)
                        if (xuat[i].date == ngay[0].Trim())
                        {
                            start++;
                            break;
                        }

                    // kiểm tra ngày kết thúc có trong danh sách không
                    for (int i = 0; i < xuat.Count; i++)
                        if (xuat[i].date != ngay[1].Trim())
                        {
                            end++;
                            break;
                        }

                    // nếu dem = 0 thì trả về true(cả start và end đều có trong date)
                    if (start > 0 && end > 0)
                        return true;
                }
            }
            return false;

        }

        // trả về danh sách tìm kiếm
        public List<ChitieuXuat> TimkiemDanhmuc(string danhmuc, string value, List<ChitieuXuat> xuat)
        {
            List<ChitieuXuat> ds = new List<ChitieuXuat>();
            if (danhmuc == "Tên sản phẩm")
            {
                for (int i = 0; i < xuat.Count; i++)
                {
                    if (xuat[i].sanpham == value)
                    {
                        ChitieuXuat chitieu1 = new ChitieuXuat();
                        chitieu1.sanpham = xuat[i].sanpham;
                        chitieu1.giamua = xuat[i].giamua;
                        chitieu1.date = xuat[i].date;
                        chitieu1.thoidiem = xuat[i].thoidiem;
                        chitieu1.trocap = xuat[i].trocap;
                        chitieu1.tietkiem = xuat[i].tietkiem;
                        chitieu1.id = xuat[i].id;
                        ds.Add(chitieu1);
                    }
                }
                return ds;
            }
            else if (danhmuc == "Giá mua")
            {
                for (int i = 0; i < xuat.Count; i++)
                {
                    if(xuat[i].giamua == value)
                    {
                        ChitieuXuat chitieu1 = new ChitieuXuat();
                        chitieu1.sanpham = xuat[i].sanpham;
                        chitieu1.giamua = xuat[i].giamua;
                        chitieu1.date = xuat[i].date;
                        chitieu1.thoidiem = xuat[i].thoidiem;
                        chitieu1.trocap = xuat[i].trocap;
                        chitieu1.tietkiem = xuat[i].tietkiem;
                        chitieu1.id = xuat[i].id;
                        ds.Add(chitieu1);
                    }
                }
                return ds;
            }
            else if (danhmuc == "Thời điểm")
            {
                for (int i = 0; i < xuat.Count; i++)
                {
                    if(xuat[i].thoidiem == value)
                    {
                        ChitieuXuat chitieu1 = new ChitieuXuat();
                        chitieu1.sanpham = xuat[i].sanpham;
                        chitieu1.giamua = xuat[i].giamua;
                        chitieu1.date = xuat[i].date;
                        chitieu1.thoidiem = xuat[i].thoidiem;
                        chitieu1.trocap = xuat[i].trocap;
                        chitieu1.tietkiem = xuat[i].tietkiem;
                        chitieu1.id = xuat[i].id;
                        ds.Add(chitieu1);
                    }
                }
                return ds;
            }
            else if (danhmuc == "Trợ cấp")
            {
                //// lấy ra các tháng có cùng trợ cấp trong danh sách
                //List<ChitieuXuat> dsxuat = new List<ChitieuXuat>();
                //for (int i = 0; i < xuat.Count; i++)
                //{
                //    if(xuat[i].trocap == value)
                //    {
                //        DateTime dt = DateTime.Parse(xuat[i].date);
                //        // lấy ra các ngày của tháng trong danh sách
                //        for(int j = 0; j < xuat.Count; j++)
                //        {
                //            DateTime test = DateTime.Parse(xuat[i].date);
                //            if(test.Month == dt.Month)
                //            {
                //                ChitieuXuat chitieu1 = new ChitieuXuat();
                //                chitieu1.sanpham = xuat[i].sanpham;
                //                chitieu1.giamua = xuat[i].giamua;
                //                chitieu1.date = xuat[i].date;
                //                chitieu1.thoidiem = xuat[i].thoidiem;
                //                chitieu1.trocap = xuat[i].trocap;
                //                chitieu1.tietkiem = xuat[i].tietkiem;
                //                chitieu1.id = xuat[i].id;
                //                // thêm các ngày của tháng trong danh sách vào ds xuất
                //                dsxuat.Add(chitieu1);
                //            }
                //        }


                //    }
                //}
                //return dsxuat;

                for (int i = 0; i < xuat.Count; i++)
                {
                    if (xuat[i].trocap == value)
                    {
                        ChitieuXuat chitieu1 = new ChitieuXuat();
                        chitieu1.sanpham = xuat[i].sanpham;
                        chitieu1.giamua = xuat[i].giamua;
                        chitieu1.date = xuat[i].date;
                        chitieu1.thoidiem = xuat[i].thoidiem;
                        chitieu1.trocap = xuat[i].trocap;
                        chitieu1.tietkiem = xuat[i].tietkiem;
                        chitieu1.id = xuat[i].id;
                        ds.Add(chitieu1);
                    }
                }
                return ds;
            }
            else if (danhmuc == "Tiết kiệm")
            {
                for (int i = 0; i < xuat.Count; i++)
                {
                    if(xuat[i].tietkiem == value)
                    {
                        ChitieuXuat chitieu1 = new ChitieuXuat();
                        chitieu1.sanpham = xuat[i].sanpham;
                        chitieu1.giamua = xuat[i].giamua;
                        chitieu1.date = xuat[i].date;
                        chitieu1.thoidiem = xuat[i].thoidiem;
                        chitieu1.trocap = xuat[i].trocap;
                        chitieu1.tietkiem = xuat[i].tietkiem;
                        chitieu1.id = xuat[i].id;
                        ds.Add(chitieu1);
                    }
                }
                return ds;
            }
            else if (danhmuc == "ID")
            {
                for (int i = 0; i < xuat.Count; i++)
                {
                    if(xuat[i].id == value)
                    {
                        ChitieuXuat chitieu1 = new ChitieuXuat();
                        chitieu1.sanpham = xuat[i].sanpham;
                        chitieu1.giamua = xuat[i].giamua;
                        chitieu1.date = xuat[i].date;
                        chitieu1.thoidiem = xuat[i].thoidiem;
                        chitieu1.trocap = xuat[i].trocap;
                        chitieu1.tietkiem = xuat[i].tietkiem;
                        chitieu1.id = xuat[i].id;
                        ds.Add(chitieu1);
                    }
                }
                return ds;
            }
            else
            {
                string[] ngay = value.Split('-');
                if (ngay.Length == 1)
                {
                    for (int i = 0; i < xuat.Count; i++)
                        if (xuat[i].date == value)
                        {
                            ChitieuXuat chitieu1 = new ChitieuXuat();
                            chitieu1.sanpham = xuat[i].sanpham;
                            chitieu1.giamua = xuat[i].giamua;
                            chitieu1.date = xuat[i].date;
                            chitieu1.thoidiem = xuat[i].thoidiem;
                            chitieu1.trocap = xuat[i].trocap;
                            chitieu1.tietkiem = xuat[i].tietkiem;
                            chitieu1.id = xuat[i].id;
                            ds.Add(chitieu1);
                        }
                    return ds;
                }
                else
                {
                    for (int i = 0; i < xuat.Count; i++)
                        if (string.Compare(xuat[i].date, ngay[0].Trim()) <= 0 && string.Compare(xuat[i].date, ngay[1].Trim()) >= 0 ||
                            string.Compare(xuat[i].date, ngay[0].Trim()) >= 0 && string.Compare(xuat[i].date, ngay[1].Trim()) <= 0)
                        {
                            ChitieuXuat chitieu1 = new ChitieuXuat();
                            chitieu1.sanpham = xuat[i].sanpham;
                            chitieu1.giamua = xuat[i].giamua;
                            chitieu1.date = xuat[i].date;
                            chitieu1.thoidiem = xuat[i].thoidiem;
                            chitieu1.trocap = xuat[i].trocap;
                            chitieu1.tietkiem = xuat[i].tietkiem;
                            chitieu1.id = xuat[i].id;
                            ds.Add(chitieu1);
                        }
                    return ds;
                }
            }
        }

        public string TongdanhsachHientai(DataGridView table)
        {
            int tong = 0;
            for(int i=0; i<table.RowCount; i++)
            {
                // lấy ra thông tin về ô của cột giá mua
                string gia = table.Rows[i].Cells[4].Value.ToString();
                // bỏ giá dấu chấm thập phân
                gia = rmDot1(gia);
                // cộng vào tổng giá
                tong += int.Parse(gia);
            }

            return tong.ToString();
        }

        public List<string> CapnhatDong(string id, string stt)
        {
            XmlNode item = root.SelectSingleNode("ngay[@id = '" + id + "']");
            List<string> result = new List<string>();
            result.Add(stt);
            result.Add(item.SelectSingleNode("sanpham").InnerText);
            result.Add(item.SelectSingleNode("giamua").InnerText);
            result.Add(item.Attributes[0].InnerText);
            result.Add(item.SelectSingleNode("thoidiem").InnerText);
            result.Add(item.SelectSingleNode("trocap").InnerText);
            result.Add(item.SelectSingleNode("tietkiem").InnerText);
            result.Add(item.Attributes[1].InnerText);

            return result;
        }

        // sắp xếp chỉ mục trong bảng
        public List<ChitieuXuat> SortData(List<ChitieuXuat> xuat1, string sort, string typeSort)
        {
            List<ChitieuXuat> result = new List<ChitieuXuat>();
            result = xuat1;

            if (sort == "sp" && typeSort == "giamdan")
            {
                xuat1.Sort((x, y) => y.sanpham.CompareTo(x.date));
                result = xuat1;
            }
            else if (sort == "giamua" && typeSort == "giamdan")
            {
                xuat1.Sort((x, y) => int.Parse(rmDot1(y.giamua)).CompareTo(int.Parse(rmDot1(x.giamua))));
                result = xuat1;
            }
            else if (sort == "ngaymua" && typeSort == "giamdan")
            {
                xuat1.Sort((x, y) => y.date.CompareTo(x.date));
                result = xuat1;
            }
            else if (sort == "thoidiem" && typeSort == "giamdan")
            {
                xuat1.Sort((x, y) => y.thoidiem.CompareTo(x.thoidiem));
                result = xuat1;
            }
            else if (sort == "trocap" && typeSort == "giamdan")
            {
                xuat1.Sort(delegate (ChitieuXuat x, ChitieuXuat y)
                {
                    if (x.trocap == "" && y.trocap == "") return 0;
                    else if (x.trocap == "") return 1;
                    else if (y.trocap == "") return -1;
                    else return int.Parse(rmDot1(y.trocap)).CompareTo(int.Parse(rmDot1(x.trocap)));
                });
                result = xuat1;
            }
            else if (sort == "tietkiem" && typeSort == "giamdan")
            {
                xuat1.Sort(delegate (ChitieuXuat x, ChitieuXuat y)
                {
                    if (x.tietkiem == "" && y.tietkiem == "") return 0;
                    else if (x.tietkiem == "") return 1;
                    else if (y.tietkiem == "") return -1;
                    else return int.Parse(rmDot1(y.tietkiem)).CompareTo(int.Parse(rmDot1(x.tietkiem)));
                });
                result = xuat1;
            }
            else if (sort == "sp" && typeSort == "tangdan")
            {
                xuat1.Sort((x, y) => x.sanpham.CompareTo(y.sanpham));
                result = xuat1;
            }
            else if (sort == "giamua" && typeSort == "tangdan")
            {
                xuat1.Sort((x, y) => int.Parse(rmDot1(x.giamua)).CompareTo(int.Parse(rmDot1(y.giamua))));
                result = xuat1;
            }
            else if (sort == "ngaymua" && typeSort == "tangdan")
            {
                xuat1.Sort((x, y) => x.date.CompareTo(y.date));
                result = xuat1;
            }
            else if (sort == "thoidiem" && typeSort == "tangdan")
            {
                xuat1.Sort((x, y) => x.thoidiem.CompareTo(y.thoidiem));
                result = xuat1;
            }
            else if (sort == "trocap" && typeSort == "tangdan")
            {
                xuat1.Sort(delegate (ChitieuXuat x, ChitieuXuat y)
                {
                    if (x.trocap == "" && y.trocap == "") return 0;
                    else if (x.trocap == "") return -1;
                    else if (y.trocap == "") return 1;
                    else return int.Parse(rmDot1(x.trocap)).CompareTo(int.Parse(rmDot1(y.trocap)));
                });
                result = xuat1;
            }
            else
            {
                xuat1.Sort(delegate (ChitieuXuat x, ChitieuXuat y)
                {
                    if (x.tietkiem == "" && y.tietkiem == "") return 0;
                    else if (x.tietkiem == "") return -1;
                    else if (y.tietkiem == "") return 1;
                    else return int.Parse(rmDot1(x.tietkiem)).CompareTo(int.Parse(rmDot1(y.tietkiem)));
                });
                result = xuat1;
            }


            return result;
        }

    }
}
