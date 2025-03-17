using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BillDAO
    {
        private static BillDAO? instance;

        internal static BillDAO Instance 
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        private BillDAO() { }
        public int GetUncheckedBillIDByTable(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.Bill where idTable =" + id + " and status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public DataTable GetListBillByDateAndPage(DateTime cIn, DateTime cOut, int page)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDateAndPage @in , @out , @page", new object[] {cIn,cOut, page});
            
        }
        public void CheckOut(int id, int discount, float totalPrice)
        {
            string q = "update dbo.Bill set TimeCheckOut = GETDATE(), totalPrice = " + totalPrice +" , status = 1, discount = " + discount + " where id = " + id;
            DataProvider.Instance.ExecuteQuery(q);

        }
        public void insertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable", new object[] {id});
        }
        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(id) from Bill");
                
            }
            catch
            {
                return -1;
            }
        }
        public int GetNumBillByDate(DateTime cIn, DateTime cOut)
        {
            return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetNumBillByDate @checkIn , @checkOut ", new object[] { cIn, cOut });
            
        }

        public double GetRevenueByDate(DateTime cIn, DateTime cOut)
        {
            return (double)DataProvider.Instance.ExecuteScalar("exec USP_GetRevenueByDate @cIn , @cOut", new object[] {cIn, cOut });        
        }
    }
}
