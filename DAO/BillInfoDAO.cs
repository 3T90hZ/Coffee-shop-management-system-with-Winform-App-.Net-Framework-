using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;
        public static BillInfoDAO Instance
        {
            get { if (instance == null) instance = new BillInfoDAO(); return BillInfoDAO.instance; }
            private set { BillInfoDAO.instance = value; }
        }
        private BillInfoDAO() { }
        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> list = new List<BillInfo>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.BillInfo where idBill =" + id);
            foreach (DataRow row in data.Rows)
            {
                BillInfo info = new BillInfo(row);
                list.Add(info);
            }
            return list;
        }
        public void insertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }
        public void DeleteBillInfo(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete dbo.BillInfo where idFood = " + id);
        }
        public string GetBestSellingFood(DateTime cIn, DateTime cOut)
        {
            return (DataProvider.Instance.ExecuteScalar("exec USP_GetBestSelling @cIn , @cOut", new object[] { cIn, cOut })).ToString();
        }

        public int GetNumBestSellingFood(DateTime cIn, DateTime cOut)
        {
            return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetNumBestSelling @cIn , @cOut", new object[] { cIn, cOut });
        }

        public string GetWorstSellingFood(DateTime cIn, DateTime cOut)
        {
            return (DataProvider.Instance.ExecuteScalar("exec USP_GetWorstSelling @cIn , @cOut", new object[] { cIn, cOut })).ToString();
        }

        public int GetNumWorstSellingFood(DateTime cIn, DateTime cOut)
        {
            return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetNumWorstSelling @cIn , @cOut", new object[] { cIn, cOut }); ;
        }
    }
}
