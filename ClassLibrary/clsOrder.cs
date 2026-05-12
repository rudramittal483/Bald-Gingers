using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        // Private data members for the properties
        private Int32 mOrderNo;
        private Int32 mCustomerNo;
        private DateTime mOrderDate;
        private double mTotalAmount;
        private string mDeliveryAddress;
        private bool mIsDispatched;

        // Public properties
        public int OrderNo
        {
            get { return mOrderNo; }
            set { mOrderNo = value; }
        }
        public int CustomerNo
        {
            get { return mCustomerNo; }
            set { mCustomerNo = value; }
        }
        public DateTime OrderDate
        {
            get { return mOrderDate; }
            set { mOrderDate = value; }
        }
        public double TotalAmount
        {
            get { return mTotalAmount; }
            set { mTotalAmount = value; }
        }
        public string DeliveryAddress
        {
            get { return mDeliveryAddress; }
            set { mDeliveryAddress = value; }
        }
        public bool IsDispatched
        {
            get { return mIsDispatched; }
            set { mIsDispatched = value; }
        }

        // The Find Method
        public bool Find(int OrderNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", OrderNo);
            DB.Execute("sproc_tblOrder_FilterByOrderNo");

            if (DB.Count == 1)
            {
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mOrderDate = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mTotalAmount = Convert.ToDouble(DB.DataTable.Rows[0]["TotalAmount"]); // Using double as you mentioned
                mDeliveryAddress = Convert.ToString(DB.DataTable.Rows[0]["DeliveryAddress"]);
                mIsDispatched = Convert.ToBoolean(DB.DataTable.Rows[0]["IsDispatched"]);
                return true;
            }
            else { return false; }
        }

        public string Valid(string customerNo, string orderDate, string totalAmount, string deliveryAddress)
        {
            String Error = "";
            DateTime DateTemp;
            Double AmountTemp;
            Int32 CustomerNoTemp;

            if (deliveryAddress.Length == 0) { Error = Error + "The delivery address may not be blank : "; }
            if (deliveryAddress.Length > 50) { Error = Error + "The delivery address must be less than 50 characters : "; }

            try { CustomerNoTemp = Convert.ToInt32(customerNo); }
            catch { Error = Error + "The customer number is not a valid number : "; }
            try
            {
                AmountTemp = Convert.ToDouble(totalAmount);
                if (AmountTemp < 0.01) { Error = Error + "The amount must be at least 0.01 : "; }
            }
            catch { Error = Error + "The total amount is not a valid number : "; }

            try
            {
                DateTemp = Convert.ToDateTime(orderDate);
                if (DateTemp < DateTime.Now.Date) { Error = Error + "The date cannot be in the past : "; }
                if (DateTemp > DateTime.Now.Date) { Error = Error + "The date cannot be in the future : "; }
            }
            catch { Error = Error + "The date was not a valid date : "; }

            return Error;
        }
    }
}