using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chitieuhangthang
{
    class Chitieu
    {
        public string date { get; set; }
        public string id { get; set; }
        public string count { get; set; }
        public string weekday { get; set; }
        public string day { get; set; }
        public string month { get; set; }
        public string year { get; set; }
        public string sl { get; set; }
        public string moneyPerOne { get; set; }
        public string detailGiamua { get; set; }
        public string tienduthangtruoc { get; set; }
        public string sanpham { get; set; }
        public string giamua { get; set; }
        public string thoidiem { get; set; }
        public string trocap { get; set; }
        public string tietkiem { get; set; }

        public Chitieu()
        {

        }

        public Chitieu(string id)
        {
            this.id = id;
        }
    }
}
