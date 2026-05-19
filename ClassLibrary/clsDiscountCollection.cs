using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsDiscountCollection
    {
        //constructor for the class
        public clsDiscountCollection()
        {
            
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the data
            DB.Execute("sproc_tblDiscount_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);

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

        clsDiscount mThisDiscount = new clsDiscount();
        public clsDiscount ThisDiscount
        {
            get { return mThisDiscount; }
            set { mThisDiscount = value; }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@DiscountCode", mThisDiscount.DiscountCode);
            DB.AddParameter("@DiscountPercent", mThisDiscount.DiscountPercent);
            DB.AddParameter("@Description", mThisDiscount.DiscountDescription);
            DB.AddParameter("@StartDate", mThisDiscount.DiscountStartDate);
            DB.AddParameter("@EndDate", mThisDiscount.DiscountEndDate);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblDiscount_Insert");
        }

        public void Update()
        {
            //update an existing record in the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@DiscountId", mThisDiscount.DiscountId);
            DB.AddParameter("@DiscountCode", mThisDiscount.DiscountCode);
            DB.AddParameter("@DiscountPercent", mThisDiscount.DiscountPercent);
            DB.AddParameter("@Description", mThisDiscount.DiscountDescription);
            DB.AddParameter("@StartDate", mThisDiscount.DiscountStartDate);
            DB.AddParameter("@EndDate", mThisDiscount.DiscountEndDate);

            //execute the query returning the primary key value
            DB.Execute("sproc_tblDiscount_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DiscountId", mThisDiscount.DiscountId);
            DB.Execute("sproc_tblDiscount_Delete");
        }

        public void ReportByDiscountCode(string DiscountCode)
        {
            //filters the records based on a full or partial discount code
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@DiscountCode", DiscountCode);
            DB.Execute("sproc_tblDiscount_FilterByDiscountCode");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount;
            //get the count of records returned
            RecordCount = DB.Count;
            //clear the private array list
            mDiscountList = new List<clsDiscount>();
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
                //get the description from the database and store it in the object
                ADiscount.DiscountDescription = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                //get the start date from the database and store it in the object
                ADiscount.DiscountStartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                //get the end date from the database and store it in the object
                ADiscount.DiscountEndDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["EndDate"]);
                //add the record to the private data member list
                mDiscountList.Add(ADiscount);
                //increment the index
                Index++;
            }
        }
    }
}