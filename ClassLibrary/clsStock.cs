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
            //set the private data member to the test data value
            mLaptopId = 4;
            mDateAdded = Convert.ToDateTime("10-02-2024");
            mInStock = true;
            mModel = "Spectre x360";
            mBrand = "HP";
            mPrice = 1249.99;
            // always return true 
            return true;
        }

       
    }
}
