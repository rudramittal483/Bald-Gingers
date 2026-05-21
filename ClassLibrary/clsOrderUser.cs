using System;

namespace ClassLibrary
{
    public class clsOrderUser
    {
        private int mUserID;
        private string mUserName;
        private string mPassword;
        private string mDepartment;


        public int UserID
        {
            get
            {
                return mUserID;
            }
            set
            {
                mUserID = value;
            }
        }

        public string UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
            }
        }

        public string Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
            }
        }

        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }


        public bool FindUser(string userName, string password)
        {
            //create an instance of the data connection class
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the stored procedure
            DB.AddParameter("@UserName", userName);
            DB.AddParameter("@Password", password);
            //execute the stored procedure
            DB.Execute("sproc_tblUsers_FindUserNamePW");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mUserID = Convert.ToInt32(DB.DataTable.Rows[0]["UserID"]);
                mUserName = Convert.ToString(DB.DataTable.Rows[0]["UserName"]);
                mPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                //return that everything worked OK
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}