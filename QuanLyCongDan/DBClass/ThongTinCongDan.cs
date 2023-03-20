using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyCongDan.DBClass
{
    public class ThongTinCongDan
    {
        private string _hoten;
        private string _gioitinh;
        private string _cccd;
        private DateTime _ngaysinh;
        private string _noisinh;
        private string _tinhtranghonnhan;
        private string _quoctich;
        private string _dantoc;
        private string _tongiao;
        private string _noiothuongtru;
        private string _quequan;
        private string _choohientai;
        private string _sdt;
        private string _email;

        public string HoTen
        {
            get { return _hoten; }
            set { _hoten = value; }
        } 
        public string GioiTinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        public string CCCD
        {
            get { return _cccd; }
            set { _cccd = value; }
        }
        public DateTime NgaySinh
        {
            get { return _ngaysinh; }
            set { _ngaysinh = value;}
        }
        public string NoiSinh
        {
            get { return _noisinh; }
            set { _noisinh = value; }
        }
        public string TinhTrangHonNhan
        {
            get { return _tinhtranghonnhan; }
            set { _tinhtranghonnhan = value; }
        }
        public string QuocTich
        {
            get { return _quoctich; }
            set {_quoctich = value; }
        }
        public string DanToc
        {
            get { return _dantoc; }
            set { _dantoc = value; }
        }
        public string TonGiao
        {
            get { return _tongiao; }
            set { _tongiao = value; }
        }
        public string ThuongTru
        {
            get { return _noiothuongtru; }
            set { _noiothuongtru = value; }
        }
        public string QueQuan
        {
            get { return _quequan; }
            set { _quequan = value; }
        }
        public string DiaChi
        {
            get { return _choohientai; }
            set { _choohientai = value; }
        }
        public string SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public ThongTinCongDan(string hoten, string gioitinh, string cccd, DateTime ngaysinh, string noisinh, string tinhtranghonnhan, string quoctich, string dantoc, string tongiao, string noiothuongtru, string quequan, string choohientai, string sdt, string email)
        {
            this.HoTen = hoten;
            this.GioiTinh = gioitinh;
            this.CCCD = cccd;
            this.NgaySinh = ngaysinh;
            this.NoiSinh = noisinh;
            this.TinhTrangHonNhan = tinhtranghonnhan;
            this.QuocTich = quoctich;
            this.DanToc = dantoc;
            this.TonGiao = tongiao;
            this.ThuongTru = noiothuongtru;
            this.QueQuan = quequan;
            this.DiaChi = choohientai;
            this.SDT = sdt;
            this.Email = email;
        }
    }
}
