using System;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        private Int32 mOrderLineNo;
        private Int32 mOrderNo;
        private Int32 mLaptopNo;
        private Int32 mQuantity;

        private string mBrand;
        private string mModelName;

        public string Brand { get { return mBrand; } set { mBrand = value; } }
        public string ModelName { get { return mModelName; } set { mModelName = value; } }

        public string OrderLineSummary
        {
            get
            {
                return "OrderLineNo #" + mOrderLineNo + " | " + "Order #" + mOrderNo + " | " + Brand + " " + ModelName + " (Qty: " + mQuantity + ")";
            }
        }
        
        public int OrderLineNo { get { return mOrderLineNo; } set { mOrderLineNo = value; } }
        public int OrderNo { get { return mOrderNo; } set { mOrderNo = value; } }
        public int LaptopNo { get { return mLaptopNo; } set { mLaptopNo = value; } }
        public int Quantity { get { return mQuantity; } set { mQuantity = value; } }

        public bool Find(int OrderLineNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineNo", OrderLineNo);
            DB.Execute("sproc_tblOrderLine_FilterByOrderLineNo");

            if (DB.Count == 1)
            {
                mOrderLineNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderLineNo"]);
                mOrderNo = Convert.ToInt32(DB.DataTable.Rows[0]["OrderNo"]);
                mLaptopNo = Convert.ToInt32(DB.DataTable.Rows[0]["LaptopNo"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                return true;
            }
            else { return false; }
        }

        public string Valid(string orderNo, string laptopNo, string quantity)
        {
            String Error = "";
            Int32 OrderNoTemp;
            Int32 LaptopNoTemp;
            Int32 QuantityTemp;
            try { OrderNoTemp = Convert.ToInt32(orderNo); }
            catch { Error = Error + "The order number is not a valid number : "; }

            try { LaptopNoTemp = Convert.ToInt32(laptopNo); }
            catch { Error = Error + "The laptop number is not a valid number : "; }

            try
            {
                QuantityTemp = Convert.ToInt32(quantity);
                if (QuantityTemp < 1) { Error = Error + "Quantity must be at least 1 : "; }
                if (QuantityTemp > 50) { Error = Error + "Quantity must be 50 or less : "; }
            }
            catch { Error = Error + "The quantity is not a valid number : "; }

            return Error;
        }

        public int GetNextID()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderLine_GetNextID");

            if (DB.Count == 1)
            {
                return Convert.ToInt32(DB.DataTable.Rows[0]["NextID"]);
            }
            else
            {
                return 1;
            }
        }
    }
}