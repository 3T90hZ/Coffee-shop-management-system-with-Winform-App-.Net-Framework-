using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BillInfo
    {
        public BillInfo(int id, int billID, int foodID, int count) 
        {
            this.ID = id;
            this.BillID = billID;
            this.FoodID = foodID;
            this.Count = count;

        }
        public BillInfo(DataRow row)
        {
            this.ID1 = (int)row["id"];
            this.BillID = (int)row["idBill"];
            this.FoodID = (int)row["idFood"];
            this.Count = (int)row["count"];
        }
        private int Count;
        private int FoodID;
        private int BillID;
        private int ID;
        public int Count1 { get => Count; set => Count = value; }
        public int FoodID1 { get => FoodID; set => FoodID = value; }
        public int BillID1 { get => BillID; set => BillID = value; }
        public int ID1 { get => ID; set => ID = value; }
    }
}