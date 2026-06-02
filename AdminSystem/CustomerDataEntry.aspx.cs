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
        string DateJoinedText = txtDateJoined.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = ACustomer.Valid(FirstName, LastName, Email, DateJoinedText);

        if (Error == "")
        {
            //capture the customer no (DON'T MISS THIS BIT !!!!!)
            //CustomerNo is the page-level variable we set in Page_Load
            ACustomer.CustomerNo = CustomerNo;

            //capture the rest of the properties
            ACustomer.FirstName = FirstName;
            ACustomer.LastName = LastName;
            ACustomer.Email = Email;
            ACustomer.DateJoined = Convert.ToDateTime(DateJoinedText);
            ACustomer.IsActiveAccount = chkIsActiveAccount.Checked;

            //create a new instance of the customer collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();

            //if this is a new record i.e. CustomerNo = -1 then add the data
            if (CustomerNo == -1)
            {
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add the new record
                CustomerList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerNo);
                //set the ThisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //update the record
                CustomerList.Update();
            }

            //redirect back to the list page
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
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

    //variable to store the primary key with page level scope
    Int32 CustomerNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be processed
        CustomerNo = Convert.ToInt32(Session["CustomerNo"]);

        if (IsPostBack == false)
        {
            //if this is not a new record (-1 means new)
            if (CustomerNo != -1)
            {
                //display the current data for the record
                DisplayCustomer();
            }
        }
    }

    // Method to fetch the existing record and fill the text boxes
    void DisplayCustomer()
    {
        //create an instance of the customer collection
        clsCustomerCollection CustomerBook = new clsCustomerCollection();

        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerNo);

        //display the data for this record inside the text boxes
        txtCustomerNo.Text = CustomerBook.ThisCustomer.CustomerNo.ToString();
        txtFirstName.Text = CustomerBook.ThisCustomer.FirstName;
        txtLastName.Text = CustomerBook.ThisCustomer.LastName;
        txtEmail.Text = CustomerBook.ThisCustomer.Email;
        // Format the date so it looks nice in the text box
        txtDateJoined.Text = CustomerBook.ThisCustomer.DateJoined.ToString("dd/MM/yyyy");
        chkIsActiveAccount.Checked = CustomerBook.ThisCustomer.IsActiveAccount;
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        // Redirect to the Admin Menu page
        Response.Redirect("TeamMainMenu.aspx");
    }
}