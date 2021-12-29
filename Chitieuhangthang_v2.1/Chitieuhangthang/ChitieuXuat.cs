using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chitieuhangthang
{
    class ChitieuXuat
    {
        public string date { get; set; }
        public string id { get; set; }
        public string sanpham { get; set; }
        public string giamua { get; set; }
        public string thoidiem { get; set; }
        public string trocap { get; set; }
        public string tietkiem { get; set; }

        public ChitieuXuat()
        {

        }

        public ChitieuXuat(string id)
        {
            this.id = id;
        }
    }
}
