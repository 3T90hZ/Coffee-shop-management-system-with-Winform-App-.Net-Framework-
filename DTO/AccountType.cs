using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class AccountType
    {
        public AccountType(int id, string name)
        {
            this.iD = id;
            this.name = name;
        }
        public AccountType(DataRow dr)
        {
            this.ID = (int)dr["id"];
            this.Name = dr["name"].ToString();
        }
        private int iD;
        private string name;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
