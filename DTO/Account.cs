using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Account
    {
        public Account(string username, string password, string displayName, int type) 
        {
            this.userName = username;
            this.password = password;
            this.displayName = displayName;
            this.type = type;
        }
        public Account(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.Password = row["Password"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.Type = (int)row["Type"];
        }

        private int type;
        private string userName;
        private string password;
        private string displayName;

        public int Type { get => type; set => type = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
    }
}
