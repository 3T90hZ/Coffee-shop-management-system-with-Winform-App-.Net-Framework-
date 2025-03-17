using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { instance = value; }
        }
        private CategoryDAO() {}
        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string q = "select * from FoodCategory";
            DataTable dt = DataProvider.Instance.ExecuteQuery(q);
            foreach(DataRow dr in dt.Rows)
            {
                Category category = new Category(dr);
                list.Add(category);
            }
            return list;
        }
        public Category GetCategory(int id)
        {
            Category c = null;
            string q = "select * from FoodCategory where id = " + id;
            DataTable dt = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow dr in dt.Rows)
            {
                 c = new Category(dr);
                return c;
            }
            return c;
        }
        public bool InsertCategory(string name)
        {
            string q = string.Format("Insert dbo.FoodCategory (name) values (N'{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
        public bool UpdateCategory(int id, string name)
        {
            string q = string.Format("update dbo.FoodCategory set name = N'{0}' where id = {1} ", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
        public bool DeleteCategory(int id)
        {
            //FoodDAO.Instance.DeleteFood();
            string q = "delete dbo.Food where id =" + id;
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
        public bool CheckExistingCategory(string name)
        {
            string q = "select * from FoodCategory where name = '" + name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            return data.Rows.Count > 0;
        }
    }
}
