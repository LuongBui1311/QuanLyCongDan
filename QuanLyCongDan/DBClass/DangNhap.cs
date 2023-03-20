using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCongDan.DBClass
{
    public class DangNhap
    {
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public DangNhap(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
