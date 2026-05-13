using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrderLineCollection
    {
        List<clsOrderLine> mOrderLineList = new List<clsOrderLine>();
        clsOrderLine mThisOrderLine = new clsOrderLine();

        public clsOrderLineCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrderLine_SelectAll");
            Int32 Index = 0;
            Int32 RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrderLine AnOrderLine = new clsOrderLine();
                AnOrderLine.OrderLineNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineNo"]);
                AnOrderLine.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrderLine.LaptopNo = Convert.ToInt32(DB.DataTable.Rows[Index]["LaptopNo"]);
                AnOrderLine.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                mOrderLineList.Add(AnOrderLine);
                Index++;
            }
        }

        public List<clsOrderLine> OrderLineList
        {
            get { return mOrderLineList; }
            set { mOrderLineList = value; }
        }

        public int Count
        {
            get { return mOrderLineList.Count; }
            set { /* handled by list size */ }
        }

        public clsOrderLine ThisOrderLine
        {
            get { return mThisOrderLine; }
            set { mThisOrderLine = value; }
        }
    }
}
