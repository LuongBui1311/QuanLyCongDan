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
        public string hotenvo;
        public string ngaysinhvo;
        public string dantocvo;
        public string quoctichvo;
        public string noicutruvo;
        public string gtttvo;

        public string hotenchong;
        public string ngaysinhchong;
        public string dantocchong;
        public string quoctichchong;
        public string noicutruchong;
        public string gtttchong;

        public string noidkkh;
        public string ngaydkkh;

        public Cnkh(string hotenvo, string ngaysinhvo, string dantocvo, string quoctichvo, string noicutruvo, string gtttvo, string hotenchong,
            string ngaysinhchong, string dantocchong, string quoctichchong, string noicutruchong, string gtttchong, string noidkkh, string ngaydkkh)
        {
            this.hotenvo = hotenvo;
            this.ngaysinhvo = ngaysinhvo;
            this.dantocvo = dantocvo;
            this.quoctichvo = quoctichvo;
            this.noicutruvo = noicutruvo;
            this.gtttvo = gtttvo;
            this.hotenchong = hotenchong;
            this.ngaysinhchong = ngaysinhchong;
            this.dantocchong = dantocchong;
            this.quoctichchong = quoctichchong;
            this.noicutruchong = noicutruchong;
            this.gtttchong = gtttchong;
            this.noidkkh = noidkkh;
            this.ngaydkkh = ngaydkkh;
        }
    }
}
