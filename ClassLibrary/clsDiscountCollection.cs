using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsDiscountCollection
    {
        //constructor for the class
        public clsDiscountCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the data
            DB.Execute("sproc_tblDiscount_SelectAll");
            //get the count of records returned
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of the discount class
                clsDiscount ADiscount = new clsDiscount();
                //get the discount id from the database and store it in the object
                ADiscount.DiscountId = Convert.ToInt32(DB.DataTable.Rows[Index]["DiscountId"]);
                //get the discount code from the database and store it in the object
                ADiscount.DiscountCode = Convert.ToString(DB.DataTable.Rows[Index]["DiscountCode"]);
                //get the discount percent from the database and store it in the object
                ADiscount.DiscountPercent = Convert.ToDouble(DB.DataTable.Rows[Index]["DiscountPercent"]);
                //get the discount description from the database and store it in the object
                ADiscount.DiscountDescription = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                //get the discount start date from the database and store it in the object
                ADiscount.DiscountStartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                //get the discount end date from the database and store it in the object
                ADiscount.DiscountEndDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["EndDate"]);
                //add the record to the private data member list
                mDiscountList.Add(ADiscount);
                //increment the index
                Index++;
            }

        }

        //private data member for the list
        List<clsDiscount> mDiscountList = new List<clsDiscount>();

        public List<clsDiscount> DiscountList
        {
            get
            { return mDiscountList; }
            set
            { mDiscountList = value; }
        }

        public int Count
        {
            get
            { return mDiscountList.Count; }

            set
            {
                //we will worry about this later
            }
        }

        public clsDiscount ThisDiscount { get; set; }
    }
}