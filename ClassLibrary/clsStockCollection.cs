using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {

        //constructor for the class
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure to get the data
            DB.Execute("sproc_tblProduct_SelectAll");
            //get the count of records returned
            RecordCount = DB.Count;
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

        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

        public List<clsStock> StockList
        {
            get
            { return mStockList; }
            set
            { mStockList = value; }
        }

        public int Count {
            get 
            { return mStockList.Count; }

            set
            {
                //we will worry about this later
            }
        }

        public clsStock ThisStock { get; set; }
    }
}