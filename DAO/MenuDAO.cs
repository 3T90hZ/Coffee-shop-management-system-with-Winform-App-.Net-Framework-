using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get {if(instance==null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO instance = value; }
        }
        private MenuDAO() { }
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> list = new List<Menu>();
            string q = "select f.name, bi.count, f.price, f.price*bi.count as totalPrice from dbo.BillInfo as bi, dbo.Bill as b, dbo.Food as f where bi.idBill = b.id and bi.idFood = f.id and b.status = 0 and b.idTable = " + id;
            DataTable dt = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow dr in dt.Rows)
            {
                Menu menu = new Menu(dr);
                list.Add(menu);
            }
            return list;
        }

    }
}
