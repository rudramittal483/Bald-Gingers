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

        //private data member for the discount id property
        private int mDiscountId;
        //discount id property
        public int DiscountId 
        {
            get
            {
                return mDiscountId;
            }
            set
            {
                mDiscountId = value;
            }

        }

        //private data member for the Quantity property
        private int mQuantity;
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        public bool Find(int laptopId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the laptop id to search for
            DB.AddParameter("@LaptopId", laptopId);
            //execute the stored procedure
            DB.Execute("sproc_tblProduct_FilterByLaptopId");
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
                mDiscountId = Convert.ToInt32(DB.DataTable.Rows[0]["DiscountId"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
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

        public string Valid(string Model, string Brand, string Price, string DateAdded, string DiscountId, string Quantity)
        {
            String Error = "";
            DateTime DateTemp;
            Double PriceTemp;
            Int32 LaptopIdTemp;

            // --- Model Validation ---
            if (Model.Length == 0) { Error = Error + "The Model may not be blank. "; }
            if (Model.Length > 100) { Error = Error + "The Model must be less than 100 characters. "; }

            // --- Brand Validation ---
            if (Brand.Length == 0) { Error = Error + "The Brand may not be blank. "; }
            if (Brand.Length > 100) { Error = Error + "The Brand must be less than 100 characters. "; }

            // --- LaptopId Validation (Assuming it's a property, though not passed in parameters) ---
            try { LaptopIdTemp = Convert.ToInt32(LaptopId); }
            catch { Error = Error + "The Laptop ID is not a valid number. "; }

            // --- Price Validation ---
            try
            {
                PriceTemp = Convert.ToDouble(Price);
                if (PriceTemp < 0.01) { Error = Error + "The Price must be at least 0.01. "; }
            }
            catch { Error = Error + "The Price is not a valid number. "; }

            // --- DateAdded Validation ---
            try
            {
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date) { Error = Error + "The Date cannot be in the past. "; }
                if (DateTemp > DateTime.Now.Date) { Error = Error + "The Date cannot be in the future. "; }
            }
            catch { Error = Error + "The Date was not a valid date. "; }

            // --- DiscountId Validation ---
            if (DiscountId.Length > 0)
            {
                try
                {
                    int DiscountIdTemp = Convert.ToInt32(DiscountId);
                    if (DiscountIdTemp < 0)
                    {
                        Error = Error + "The discount ID cannot be less than zero. ";
                    }
                }
                catch
                {
                    Error = Error + "The discount ID must be a valid whole number. ";
                }
            }

            // --- Quantity Validation ---
            if (Quantity.Length == 0)
            {
                Error = Error + "The Quantity must not be left blank. ";
            }
            else
            {
                try
                {
                    int QuantityTemp = Convert.ToInt32(Quantity);
                    if (QuantityTemp < 0)
                    {
                        Error = Error + "The Quantity cannot be negative. ";
                    }
                }
                catch
                {
                    Error = Error + "The Quantity must be a valid whole number. ";
                }
            }

            return Error;
        }
    }
}
