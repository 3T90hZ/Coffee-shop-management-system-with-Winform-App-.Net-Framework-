using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance 
        {
            get { if(instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { instance = value; }
        }
        private FoodDAO() { }
        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> foodList = new List<Food>();
            string q = "select * from Food where idCategory = " + id;
            DataTable dt = DataProvider.Instance.ExecuteQuery(q);
            foreach (DataRow dr in dt.Rows) 
            {
                Food food = new Food(dr);
                foodList.Add(food);
            }
            return foodList;
        }
        public DataTable GetListFood()
        {
            string q = "select * from Food";
            DataTable dt = DataProvider.Instance.ExecuteQuery(q);
            return dt;
        }
        public bool InsertFood(string name, int id, float price)
        {
            string q = string.Format("Insert dbo.Food ( name, idCategory, price) values (N'{0}', {1}, {2})", name,id,price);
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }

        public bool UpdateFood(int idFood, string name, int id, float price)
        {
            string q = string.Format("update dbo.Food set name = N'{0}' , idCategory = {1} , price = {2} where id = {3} ", name, id, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(q);            
            return result > 0;
        }
        public bool DeleteFood(int id)
        {
            BillInfoDAO.Instance.DeleteBillInfo(id);
            string q = "delete dbo.Food where id =" + id;
            int result = DataProvider.Instance.ExecuteNonQuery(q);
            return result > 0;
        }
        public DataTable SearchFoodByName(string name)
        {
            string q = "exec USP_SearchFoodByName '"+ name +"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            if(data.Rows.Count > 0)
            {
                return data;
            }
            return null;
        }
        public bool CheckExistingFood(string name)
        {
            string q = "select * from Food where name = '" + name + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(q);
            return data.Rows.Count > 0;
        }
    }
}
