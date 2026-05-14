using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();

        //capture the data from the UI controls
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Email = txtEmail.Text;
        string DateJoined = txtDateJoined.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = ACustomer.Valid(FirstName, LastName, Email, DateJoined);

        if (Error == "")
        {
            //capture the properties
            ACustomer.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
            ACustomer.FirstName = FirstName;
            ACustomer.LastName = LastName;
            ACustomer.Email = Email;
            ACustomer.DateJoined = Convert.ToDateTime(DateJoined);
            ACustomer.IsActiveAccount = chkIsActiveAccount.Checked;

            //store the customer in the session object
            Session["ACustomer"] = ACustomer;

            //redirect to the viewer page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int32 CustomerNo;
        Boolean Found = false;

        if (txtCustomerNo.Text != "")
        {
            CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
            Found = AnCustomer.Find(CustomerNo);
           
            if (Found == true)
            {
                txtCustomerNo.Text = AnCustomer.CustomerNo.ToString();
                txtFirstName.Text = AnCustomer.FirstName.ToString();
                txtLastName.Text = AnCustomer.LastName.ToString();
                txtDateJoined.Text = AnCustomer.DateJoined.ToString();
                txtEmail.Text = AnCustomer.Email.ToString();
                chkIsActiveAccount.Checked = AnCustomer.IsActiveAccount;
                lblError.Text = "";
            }
            else { lblError.Text = "Customer not found."; }
        }
    }
}