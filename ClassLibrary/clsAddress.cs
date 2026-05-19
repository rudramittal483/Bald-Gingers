using System;

namespace ClassLibrary
{
    public class clsAddress
    {
        // Private data members for the properties
        private Int32 mAddressId;
        private Int32 mCustomerNo;
        private string mEmirate;
        private string mBuildingName;
        private string mStreetName;
        private string mAddressType;
        private Int32 mPostcode;
        private bool mIsDefault;

        // Public properties
        public Int32 AddressId
        {
            get { return mAddressId; }
            set { mAddressId = value; }
        }

        public Int32 CustomerNo
        {
            get { return mCustomerNo; }
            set { mCustomerNo = value; }
        }

        public string Emirate
        {
            get { return mEmirate; }
            set { mEmirate = value; }
        }

        public string BuildingName
        {
            get { return mBuildingName; }
            set { mBuildingName = value; }
        }

        public string StreetName
        {
            get { return mStreetName; }
            set { mStreetName = value; }
        }

        public string AddressType
        {
            get { return mAddressType; }
            set { mAddressType = value; }
        }

        public Int32 Postcode
        {
            get { return mPostcode; }
            set { mPostcode = value; }
        }

        public bool IsDefault
        {
            get { return mIsDefault; }
            set { mIsDefault = value; }
        }

        // The Find Method
        public bool Find(int AddressId)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the address id to search for
            DB.AddParameter("@AddressId", AddressId);
            // Execute the stored procedure
            DB.Execute("sproc_tblAddress_FilterByAddressId");

            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mAddressId = Convert.ToInt32(DB.DataTable.Rows[0]["AddressId"]);
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mEmirate = Convert.ToString(DB.DataTable.Rows[0]["Emirate"]);
                mBuildingName = Convert.ToString(DB.DataTable.Rows[0]["BuildingName"]);
                mStreetName = Convert.ToString(DB.DataTable.Rows[0]["StreetName"]);
                mAddressType = Convert.ToString(DB.DataTable.Rows[0]["AddressType"]);
                mPostcode = Convert.ToInt32(DB.DataTable.Rows[0]["Postcode"]);
                mIsDefault = Convert.ToBoolean(DB.DataTable.Rows[0]["IsDefault"]);
                // Return that everything worked OK
                return true;
            }
            // If no record was found
            else
            {
                return false;
            }
        }

        // The Valid Method
        public string Valid(string customerNo, string emirate, string buildingName, string streetName, string addressType, string postcode)
        {
            String Error = "";
            Int32 CustomerNoTemp;
            Int32 PostcodeTemp;

            // Validate Emirate (VARCHAR 15)
            if (emirate.Length == 0)
            {
                Error = Error + "The emirate may not be blank : ";
            }
            if (emirate.Length > 15)
            {
                Error = Error + "The emirate must be less than 15 characters : ";
            }

            // Validate Building Name (VARCHAR 50)
            if (buildingName.Length == 0)
            {
                Error = Error + "The building name may not be blank : ";
            }
            if (buildingName.Length > 50)
            {
                Error = Error + "The building name must be less than 50 characters : ";
            }

            // Validate Street Name (VARCHAR 50)
            if (streetName.Length == 0)
            {
                Error = Error + "The street name may not be blank : ";
            }
            if (streetName.Length > 50)
            {
                Error = Error + "The street name must be less than 50 characters : ";
            }

            // Validate Address Type (VARCHAR 9)
            if (addressType.Length == 0)
            {
                Error = Error + "The address type may not be blank : ";
            }
            if (addressType.Length > 9)
            {
                Error = Error + "The address type must be less than 9 characters : ";
            }

            // Validate Postcode (INT)
            try
            {
                PostcodeTemp = Convert.ToInt32(postcode);
            }
            catch
            {
                Error = Error + "The postcode is not a valid number : ";
            }

            // Validate CustomerNo (INT)
            try
            {
                CustomerNoTemp = Convert.ToInt32(customerNo);
            }
            catch
            {
                Error = Error + "The customer number is not a valid number : ";
            }

            return Error;
        }
    }
}