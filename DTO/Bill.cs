using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime timeCheckIn, DateTime timeCheckOut, int status, int discount = 0)
        {
            this.ID = id;
            this.TimeCheckIn = timeCheckIn;
            this.TimeCheckOut = timeCheckOut;
            this.Discount = discount;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.TimeCheckIn = (DateTime)row["TimeCheckIn"];
            var timeCheckoutTemp = row["TimeCheckOut"];
            if (row["discount"].ToString() != "")
            {
                this.Discount = (int)row["discount"];
            }
            if (timeCheckoutTemp.ToString() != "")
            {
                this.TimeCheckOut = (DateTime)row["TimeCheckOut"];
            }
            this.Status = (int)row["status"];
        }
        private int iD;
        private DateTime? timeCheckIn;

        private DateTime? timeCheckOut;
        private int discount;

        private int status;

        public int ID { get => iD; set => iD = value; }
        public int Status { get => status; set => status = value; }
        public DateTime? TimeCheckOut { get => timeCheckOut; set => timeCheckOut = value; }
        public DateTime? TimeCheckIn { get => timeCheckIn; set => timeCheckIn = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
