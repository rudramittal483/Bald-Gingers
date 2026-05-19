using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsAddressCollection
    {
        //private data member for the list
        List<clsAddress> mAddressList = new List<clsAddress>();
        //private data member for ThisAddress
        clsAddress mThisAddress = new clsAddress();

        //public property for the address list
        public List<clsAddress> AddressList
        {
            get { return mAddressList; }
            set { mAddressList = value; }
        }

        //public property for count
        public int Count
        {
            get { return mAddressList.Count; }
            set { /* handled by list size */ }
        }

        //public property for ThisAddress
        public clsAddress ThisAddress
        {
            get { return mThisAddress; }
            set { mThisAddress = value; }
        }

        //constructor for the class
        public clsAddressCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblAddress_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank address
                clsAddress AnAddress = new clsAddress();
                //read in the fields from the current record
                AnAddress.AddressId = Convert.ToInt32(DB.DataTable.Rows[Index]["AddressId"]);
                AnAddress.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnAddress.Emirate = Convert.ToString(DB.DataTable.Rows[Index]["Emirate"]);
                AnAddress.BuildingName = Convert.ToString(DB.DataTable.Rows[Index]["BuildingName"]);
                AnAddress.StreetName = Convert.ToString(DB.DataTable.Rows[Index]["StreetName"]);
                AnAddress.AddressType = Convert.ToString(DB.DataTable.Rows[Index]["AddressType"]);
                AnAddress.Postcode = Convert.ToInt32(DB.DataTable.Rows[Index]["Postcode"]);
                AnAddress.IsDefault = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsDefault"]);
                //add the record to the private data member
                mAddressList.Add(AnAddress);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            throw new NotImplementedException();
        }
    }
}