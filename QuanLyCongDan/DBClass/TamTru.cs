using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.DBClass
{
    public class TamTru
    {
        private DateTime ngaydk;
        private string noidk;
        private string hoten;
        private DateTime ngaysinh;
        private string cccd;
        private string noicapcccd;
        private DateTime ngaycapcccd;
        private string diachitht;
        private string diachitt;
        private DateTime ngayden;
        private DateTime ngaydi;
        private string lydo;

        public DateTime Ngaydk { get { return ngaydk; } }
        public string Noidk { get { return noidk; } }
        public string Hoten { get { return hoten; } }
        public DateTime Ngaysinh { get { return ngaysinh; } }
        public string CCCD { get { return cccd; } }
        public string Noicapcccd { get { return noicapcccd; } }
        public DateTime Ngaycapcccd { get { return ngaycapcccd; } }
        public string Diachitht { get { return diachitht; } }
        public string Diachitt { get { return diachitt; } }
        public DateTime Ngayden { get { return ngayden; } }
        public DateTime Ngaydi { get { return ngaydi; } }
        public string Lydo { get { return lydo; } }

        public TamTru(DateTime ngaydk, string noidk, string hoten, DateTime ngaysinh, string cccd, string noicapcccd, DateTime ngaycapcccd, string diachitht, string diachitt, DateTime ngayden, DateTime ngaydi, string lydo)
        {
            this.ngaydk = ngaydk;
            this.noidk = noidk;
            this.hoten = hoten;
            this.ngaysinh = ngaysinh;
            this.cccd = cccd;
            this.noicapcccd = noicapcccd;
            this.ngaycapcccd = ngaycapcccd;
            this.diachitht = diachitht;
            this.diachitt = diachitt;
            this.ngayden = ngayden;
            this.ngaydi = ngaydi;
            this.lydo = lydo;
        }
    }
}
