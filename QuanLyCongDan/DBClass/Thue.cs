using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.DBClass
{
    public class Thue
    {
        private string masothue;
        private string tenguoinopthue;
        private string coquanthue;
        private string soCMT_CCCD;
        private DateTime ngaythaydoithongtingannhat;

        public string Masothue { get { return masothue; } }
        public string Tenguoinopthue { get { return tenguoinopthue; } }
        public string Coquanthue { get { return coquanthue; } }

        public string SoCMT_CCCD { get { return soCMT_CCCD; } }
        public DateTime Ngaythaydoithongtingannhat { get { return ngaythaydoithongtingannhat; } }

        public Thue(string masothue, string tenguoinopthue, string coquanthue, string soCMT_CCCD, DateTime ngaythaydoithongtingannhat)
        {
            this.masothue = masothue;
            this.tenguoinopthue = tenguoinopthue;
            this.coquanthue = coquanthue;
            this.soCMT_CCCD = soCMT_CCCD;
            this.ngaythaydoithongtingannhat = ngaythaydoithongtingannhat;
        }
    }
}
