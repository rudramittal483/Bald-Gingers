using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member for ThisCustomer
        clsCustomer mThisCustomer = new clsCustomer();

        //public property for the customer list
        public List<clsCustomer> CustomerList
        {
            get { return mCustomerList; }
            set { mCustomerList = value; }
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            Int32 Index = 0;
            //get the count of records
            Int32 RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();

            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer object
                clsCustomer ACustomer = new clsCustomer();

                //read in the fields from the current record
                ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                ACustomer.IsActiveAccount = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActiveAccount"]);

                //add the record to the private data member
                mCustomerList.Add(ACustomer);

                //point at the next record
                Index++;
            }
        }

        //public property for count
        public int Count
        {
            get { return mCustomerList.Count; }
            set { /* handled by list size */ }
        }

        //public property for ThisCustomer
        public clsCustomer ThisCustomer
        {
            get { return mThisCustomer; }
            set { mThisCustomer = value; }
        }

        //constructor for the class
        public clsCustomerCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                //read in the fields from the current record
                ACustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                ACustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                ACustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                ACustomer.DateJoined = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateJoined"]);
                ACustomer.IsActiveAccount = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActiveAccount"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;
            }
        }

        public int Add()
        {
            //adds a record to the database based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the stored procedure
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@DateJoined", mThisCustomer.DateJoined);
            DB.AddParameter("@IsActiveAccount", mThisCustomer.IsActiveAccount);

            //execute the query returning the primary key value
            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            //update an existing record based on the values of mThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();

            //set the parameters for the new stored procedure
            //First parameter is the Primary Key
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            //The rest of the fields
            DB.AddParameter("@FirstName", mThisCustomer.FirstName);
            DB.AddParameter("@LastName", mThisCustomer.LastName);
            DB.AddParameter("@Email", mThisCustomer.Email);
            DB.AddParameter("@DateJoined", mThisCustomer.DateJoined);
            DB.AddParameter("@IsActiveAccount", mThisCustomer.IsActiveAccount);

            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //deletes the record pointed to by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public void ReportByEmail(string Email)
        {
            //filters the records based on a full or partial email address
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Email parameter to the database
            DB.AddParameter("@Email", Email);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByEmail");
            //populate the array list with the data table
            PopulateArray(DB);
        }
    }
}