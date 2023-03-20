using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.DBClass
{
    public class TamVang
    {
        public string noichuyendi { get; set; }
        public string noichyenden { get; set; }
        public string hovaten { get; set; }
        public DateTime ngaysinh { get; set; }
        public string CMND { get; set; }
        public string noicapCMND { get; set; }
        public DateTime ngaycapCMND { get; set; }
        public string diachithuongtru { get; set; }
        public string diachitamtru { get; set; }
        public DateTime ngaydi { get; set; }
        public DateTime ngayve { get; set; }
        public string lydo { get; set; }

        public TamVang(string noichuyendi, string noichuyenden, string hovaten,
                       DateTime ngaysinh, string CMND, string noicapCMND, DateTime ngaycapCMND,
                       string diachithuongtru, string diachitamtru, DateTime ngaydi,
                       DateTime ngayve, string lydo)
        {
            this.noichuyendi= noichuyendi;
            this.noichyenden= noichuyenden;
            this.hovaten= hovaten;

            this.ngaysinh=ngaysinh;
            this.CMND=CMND;
            this.noicapCMND=noicapCMND;

            this.ngaycapCMND=ngaycapCMND;
            this.diachithuongtru= diachithuongtru;
            this.diachitamtru= diachitamtru;

            this.ngaydi=ngaydi;
            this.ngayve=ngayve;
            this.lydo=lydo;
        }
    }
}
