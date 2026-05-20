using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 CustomerNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the customer collection class
        clsCustomerCollection CustomerList = new clsCustomerCollection();

        //find the record to delete
        CustomerList.ThisCustomer.Find(CustomerNo);

        //delete the record using the method we wrote earlier
        CustomerList.Delete();

        //redirect back to the main list page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //user changed their mind, redirect back to the main list page without deleting
        Response.Redirect("CustomerList.aspx");
    }
}