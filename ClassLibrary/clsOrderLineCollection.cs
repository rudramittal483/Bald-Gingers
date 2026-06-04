using System;
using System.Collections.Generic;

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
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = DB.Count;
            mOrderLineList = new List<clsOrderLine>();

            while (Index < RecordCount)
            {
                clsOrderLine AnOrderLine = new clsOrderLine();
                AnOrderLine.OrderLineNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderLineNo"]);
                AnOrderLine.OrderNo = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderNo"]);
                AnOrderLine.LaptopNo = Convert.ToInt32(DB.DataTable.Rows[Index]["LaptopNo"]);
                AnOrderLine.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);

                AnOrderLine.Brand = Convert.ToString(DB.DataTable.Rows[Index]["Brand"]);
                AnOrderLine.ModelName = Convert.ToString(DB.DataTable.Rows[Index]["ModelName"]);

                mOrderLineList.Add(AnOrderLine);
                Index++;
            }
        }

        public void ReportByOrderNo(int OrderNo)
        {
            clsDataConnection DB = new clsDataConnection();
            if (OrderNo == 0)
            {
                DB.Execute("sproc_tblOrderLine_SelectAll");
            }
            else
            {
                DB.AddParameter("@OrderNo", OrderNo);
                DB.Execute("sproc_tblOrderLine_FilterByOrderNo");
            }
            PopulateArray(DB);
        }

        public List<clsOrderLine> OrderLineList
        {
            get { return mOrderLineList; }
            set { mOrderLineList = value; }
        }

        public int Count
        {
            get { return mOrderLineList.Count; }
            set { }
        }

        public clsOrderLine ThisOrderLine
        {
            get { return mThisOrderLine; }
            set { mThisOrderLine = value; }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", mThisOrderLine.OrderNo);
            DB.AddParameter("@LaptopNo", mThisOrderLine.LaptopNo);
            DB.AddParameter("@Quantity", mThisOrderLine.Quantity);
            return DB.Execute("sproc_tblOrderLine_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineNo", mThisOrderLine.OrderLineNo);
            DB.AddParameter("@OrderNo", mThisOrderLine.OrderNo);
            DB.AddParameter("@LaptopNo", mThisOrderLine.LaptopNo);
            DB.AddParameter("@Quantity", mThisOrderLine.Quantity);
            DB.Execute("sproc_tblOrderLine_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderLineNo", mThisOrderLine.OrderLineNo);
            DB.Execute("sproc_tblOrderLine_Delete");
        }
    }
}