using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        // Private data members for the properties
        private Int32 mCustomerNo;
        private string mFirstName;
        private string mLastName;
        private string mEmail;
        private DateTime mDateJoined;
        private bool mIsActiveAccount;

        // Public properties
        public Int32 CustomerNo
        {
            get { return mCustomerNo; }
            set { mCustomerNo = value; }
        }

        public string FirstName
        {
            get { return mFirstName; }
            set { mFirstName = value; }
        }

        public string LastName
        {
            get { return mLastName; }
            set { mLastName = value; }
        }

        public string Email
        {
            get { return mEmail; }
            set { mEmail = value; }
        }

        public DateTime DateJoined
        {
            get { return mDateJoined; }
            set { mDateJoined = value; }
        }

        public bool IsActiveAccount
        {
            get { return mIsActiveAccount; }
            set { mIsActiveAccount = value; }
        }

        // The Find Method
        public bool Find(int CustomerNo)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the customer no to search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            // Execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");

            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mDateJoined = Convert.ToDateTime(DB.DataTable.Rows[0]["DateJoined"]);
                mIsActiveAccount = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActiveAccount"]);
                // Return that everything worked OK
                return true;
            }
            // If no record was found
            else
            {
                return false;
            }
        }
    }
}