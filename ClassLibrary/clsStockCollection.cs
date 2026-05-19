using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private data member for the thisStock property
        clsStock mThisStock = new clsStock();

        //constructor for the class
        public clsStockCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the data
            DB.Execute("sproc_tblProduct_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);          
        }



        public List<clsStock> StockList
        {
            get
            { return mStockList; }
            set
            { mStockList = value; }
        }

        public int Count
        {
            get
            { return mStockList.Count; }

            set
            {
                //we will worry about this later
            }
        }

        public clsStock ThisStock
        {
            get
            { return mThisStock; }
            set
            { mThisStock = value; }
        }

        public int Add()
        {
            //adds a new record to the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@DiscountId", mThisStock.DiscountId);
            DB.AddParameter("@Brand", mThisStock.Brand);
            DB.AddParameter("@ModelName", mThisStock.Model);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@InStock", mThisStock.InStock);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblProduct_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@LaptopId", mThisStock.LaptopId);
            DB.Execute("sproc_tblProduct_Delete");
        }

        public void Update()
        {
            //update an existing record in the database based on the values of mThisStock
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@LaptopId", mThisStock.LaptopId);
            DB.AddParameter("@DiscountId", mThisStock.DiscountId);
            DB.AddParameter("@Brand", mThisStock.Brand);
            DB.AddParameter("@ModelName", mThisStock.Model);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@Price", mThisStock.Price);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@InStock", mThisStock.InStock);

            //execute the query returning the primary key value
            DB.Execute("sproc_tblProduct_Update");
        }

        public void ReportByBrand(string Brand)
        {
            //filters the records based on a full or partial brand name
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Brand", Brand);
            DB.Execute("sproc_tblProduct_FilterByBrand");
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
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a new instance of the stock class
                clsStock AStock = new clsStock();
                //get the laptop id from the database and store it in the object
                AStock.LaptopId = Convert.ToInt32(DB.DataTable.Rows[Index]["LaptopId"]);
                //get the discount id from the database and store it in the object
                AStock.DiscountId = Convert.ToInt32(DB.DataTable.Rows[Index]["DiscountId"]);
                //get the brand from the database and store it in the object
                AStock.Brand = Convert.ToString(DB.DataTable.Rows[Index]["Brand"]);
                //get the model from the database and store it in the object
                AStock.Model = Convert.ToString(DB.DataTable.Rows[Index]["ModelName"]);
                //get the date added from the database and store it in the object
                AStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                //get the price from the database and store it in the object
                AStock.Price = Convert.ToDouble(DB.DataTable.Rows[Index]["Price"]);
                //get the quantity from the database and store it in the object
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                //get the in stock status from the database and store it in the object
                AStock.InStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["InStock"]);
                //add the record to the private data member list
                mStockList.Add(AStock);
                //increment the index
                Index++;
            }
        }
    }
}