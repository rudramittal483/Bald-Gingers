using System;

namespace ClassLibrary
{
    public class clsStock
    {

        //private data member for the laptop id property
        private Int32 mLaptopId;

        //laptop id property
        public Int32 LaptopId
        {
            get
            {
                //return the private data
                return mLaptopId;
            }
            set
            {
                //set the private data
                mLaptopId = value;
            }
        }

        //private data member for the date added property
        private DateTime mDateAdded;
        //date added property
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
            }
        }

        //private data member for the in stock property
        private bool mInStock;
        //in stock property
        public bool InStock

        {
            get
            {
                return mInStock;
            }
            set
            {
                mInStock = value;
            }
        }

        //private data member for the model property
        private string mModel;
        //model property
        public string Model
        {
            get
            {
                return mModel;
            }
            set
            {
                mModel = value;
            }
        }

        //private data member for the brand property
        private string mBrand;
        //brand property
        public string Brand
        {
            get
            {
                return mBrand;
            }
            set
            {
                mBrand = value;
            }
        }

        //private data member for the price property
        private double mPrice;
        //price property
        public double Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }

        public bool Find(int laptopId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the laptop id to search for
            DB.AddParameter("@LaptopId", laptopId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByLaptopId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mLaptopId = Convert.ToInt32(DB.DataTable.Rows[0]["LaptopId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mModel = Convert.ToString(DB.DataTable.Rows[0]["ModelName"]);
                mBrand = Convert.ToString(DB.DataTable.Rows[0]["Brand"]);
                mPrice = Convert.ToDouble(DB.DataTable.Rows[0]["Price"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
                //return false indicating a problem
                return false;
            }


        }
    }
}
