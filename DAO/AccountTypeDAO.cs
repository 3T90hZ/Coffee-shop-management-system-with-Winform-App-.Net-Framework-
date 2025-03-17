using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class AccountTypeDAO
    {
        private static AccountTypeDAO? instance;
        public static AccountTypeDAO Instance
        {
            get { if (instance == null) instance = new AccountTypeDAO(); return AccountTypeDAO.instance; }
            private set { AccountTypeDAO.instance = value; }
        }

        private AccountTypeDAO() { }
        public List<AccountType> GetListAccountType()
        {
            List<AccountType> list = new List<AccountType>();
            string q = "select * from dbo.AccountType";
            DataTable dt = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow dr in dt.Rows)
            {
                AccountType type = new AccountType(dr);
                list.Add(type);
            }
            return list;
        }
    }

}
