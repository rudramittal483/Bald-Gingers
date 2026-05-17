using System;

namespace ClassLibrary
{
    public class clsDiscount
    {
        private int mDiscountId;
        public int DiscountId
        {
            get { return mDiscountId; }

            set { mDiscountId = value; }
        }

        private double mDiscountPercent;
        public double DiscountPercent
        {
            get { return mDiscountPercent; }
            set { mDiscountPercent = value; }
        } 

        private string mDiscountCode;
        public string DiscountCode 
        { 
            get { return mDiscountCode; }
            set { mDiscountCode = value; }
        }

        private string mDiscountDescription;
        public string DiscountDescription

        {
            get { return mDiscountDescription; }
            set { mDiscountDescription = value; }
        }

        private DateTime mDiscountStartDate;
        public DateTime DiscountStartDate
        {
            get { return mDiscountStartDate; }
            set { mDiscountStartDate = value; }
        }

        private DateTime mDiscountEndDate;
        public DateTime DiscountEndDate
        {
            get { return mDiscountEndDate; }
            set { mDiscountEndDate = value; }
        }

        public bool Find(int discountId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the laptop id to search for
            DB.AddParameter("@DiscountId", discountId);
            //execute the stored procedure
            DB.Execute("sproc_tblDiscount_FilterByDiscountId");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mDiscountId = Convert.ToInt32(DB.DataTable.Rows[0]["DiscountId"]);
                mDiscountPercent = Convert.ToDouble(DB.DataTable.Rows[0]["DiscountPercent"]);
                mDiscountCode = Convert.ToString(DB.DataTable.Rows[0]["DiscountCode"]);
                mDiscountDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                mDiscountStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                mDiscountEndDate = Convert.ToDateTime(DB.DataTable.Rows[0]["EndDate"]);
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

        public string Valid(string discountCode, string discountDescription, string discountPercent, string discountStartDate, string discountEndDate)
        {
            // String variable to store the error message
            String Error = "";
            Int32 DiscountIdTemp;

            // --- Discount Code Validation ---
            // Matches test: DiscountCodeMinLessOne (checking for empty string)
            // Matches test: DiscountCodeMin (checking that 1 character is allowed)
            if (discountCode.Length == 0)
            {
                Error = Error + "The Discount Code may not be blank. ";
            }

            try { DiscountIdTemp = Convert.ToInt32(DiscountId); }
            catch { Error = Error + "The Discount ID is not a valid number. "; }

            // --- Discount Description Validation ---
            // Matches test: DescriptionInvalid (checking for empty string)
            if (discountDescription.Length == 0)
            {
                Error = Error + "The Discount Description may not be blank.  ";
            }

            // --- Discount Percent Validation ---
            // Matches test: DiscountPercentInvalid (checking for non-numeric text)
            try
            {
                double PercentTemp = Convert.ToDouble(discountPercent);
            }
            catch
            {
                Error = Error + "The Discount Percent must be a valid number. ";
            }

            // --- Discount Start Date Validation ---
            // Matches test: DiscountStartDateInvalid (checking for non-date text)
            try
            {
                DateTime StartDateTemp = Convert.ToDateTime(discountStartDate);
            }
            catch
            {
                Error = Error + "The Start Date is not a valid date. ";
            }

            // --- Discount End Date Validation ---
            // Matches test: DiscountEndDateInvalid (checking for non-date text)
            try
            {
                DateTime EndDateTemp = Convert.ToDateTime(discountEndDate);
            }
            catch
            {
                Error = Error + "The End Date is not a valid date. ";
            }

            // Return any error messages found
            return Error;
        }
    }
}