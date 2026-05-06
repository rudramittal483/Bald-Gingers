using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the data for this entry
        Response.Write("Customer No: " + AnCustomer.CustomerNo + "<br/>");
        Response.Write("First Name: " + AnCustomer.FirstName + "<br/>");
        Response.Write("Last Name: " + AnCustomer.LastName + "<br/>");
        Response.Write("Email: " + AnCustomer.Email + "<br/>");
        Response.Write("Date Joined: " + AnCustomer.DateJoined + "<br/>");
        Response.Write("Active: " + AnCustomer.IsActiveAccount + "<br/>");
    }
}