using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO? instance;

        public static TableDAO Instance 
        { 
            get { if(instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set => TableDAO.instance = value; 
        }
        public static int TableWidth = 120;
        public static int TableHeight = 80;
        private TableDAO() { }
        public List<Table> loadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("USP_LoadTableList");
            foreach (DataRow dr in dt.Rows)
            {
                Table table = new Table(dr);
                tableList.Add(table);
            }
            return tableList;
        }
        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2 ", new object[] { id1, id2 });
        }
        public bool InsertTable(string name)
        {
            string q = string.Format("Insert dbo.TableFood (name, status) values (N'{0}', N'Trống')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
        public bool UpdateTable(int id, string name)
        {
            string q = string.Format("update dbo.TableFood set name = N'{0}' where id = {1} ", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
        public bool CheckExistingTable(string name)
        {
            string q = "select * from Table where name = '" + name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            return data.Rows.Count > 0;
        }
    }
}
