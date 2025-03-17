
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO? instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string username, string password)
        {
            string q = "USP_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(q, new object[] { username, password });
            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string displayName,string userName, string password, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] {userName, displayName, password, newPass});
            return result > 0;
        }
        public Account GetAccountByUserName(string username)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Account where UserName like '" + username +"'");
            foreach (DataRow row in data.Rows)
            {
                return new Account(row);
            }
            return null;
        }
        public DataTable GetListAccount()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select UserName, DisplayName, Type from dbo.Account");
            return data;
        }
        public bool InsertAccount(string userName, int type, string displayName)
        {
            string q = string.Format("Insert dbo.Account ( UserName, DisplayName, Type) values (N'{0}', {1}, {2})", userName, displayName , type );
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
        public bool DeleteAccount(string userName)
        {
            string q = "delete dbo.Account where UserName = '" + userName + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
        public bool ResetPassword(string name)
        {
            string q = "update account set password = N'1' where UserName = '" + name + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
        public bool CheckExistingAccount(string name)
        {
            string q = "select * from Account where UserName = '" + name +"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            return data.Rows.Count > 0;
        }
    }
}
