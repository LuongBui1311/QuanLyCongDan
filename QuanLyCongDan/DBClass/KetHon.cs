using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace QuanLyCongDan.DBClass
{
    public class Cnkh
    {
        private string hotenvo;
        private string ngaysinhvo;
        private string dantocvo;
        private string quoctichvo;
        private string noicutruvo;
        private string giaytotuythanvo;
        private string hotenchong;
        private string ngaysinhchong;
        private string dantocchong;
        private string quoctichchong;
        private string noicutruchong;
        private string giaytotuythanchong;
        private string noidk;
        private DateTime ngaydk;

        public string Hotenvo { get { return hotenvo; } }
        public string Ngaysinhvo { get { return ngaysinhvo; } }
        public string Dantocvo { get { return dantocvo; } }
        public string Quoctichvo { get { return quoctichvo; } }
        public string Noicutruvo { get { return noicutruvo; } }
        public string Giaytotuythanvo { get { return giaytotuythanvo; } }
        public string Hotenchong { get { return hotenchong; } }
        public string Ngaysinhchong { get { return ngaysinhchong; } }
        public string Dantocchong { get { return dantocchong; } }
        public string Quoctichchong { get { return quoctichchong; } }
        public string Noicutruchong { get { return noicutruchong; } }
        public string Giaytotuythanchong { get { return giaytotuythanchong; } }
        public string Noidk { get { return noidk; } }
        public DateTime Ngaydk { get { return ngaydk; } }

        public Cnkh(string hotenvo, string ngaysinhvo, string dantocvo, string quoctichvo, string noicutruvo, string giaytotuythanvo, string hotenchong, string ngaysinhchong, string dantocchong, string quoctichchong, string noicutruchong, string giaytotuythanchong, string noidk, DateTime ngaydk)
        {
            this.hotenvo = hotenvo;
            this.ngaysinhvo = ngaysinhvo;
            this.dantocvo = dantocvo;
            this.quoctichvo = quoctichvo;
            this.noicutruvo = noicutruvo;
            this.giaytotuythanvo = giaytotuythanvo;
            this.hotenchong = hotenchong;
            this.ngaysinhchong = ngaysinhchong;
            this.dantocchong = dantocchong;
            this.quoctichchong = quoctichchong;
            this.noicutruchong = noicutruchong;
            this.giaytotuythanchong = giaytotuythanchong;
            this.noidk = noidk;
            this.ngaydk = ngaydk;
        }
    }
}
