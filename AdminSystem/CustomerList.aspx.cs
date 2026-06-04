using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerList : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }

        //create an instance of the stock collection
        clsCustomerUser AnUser = new clsCustomerUser();
        //retrieve the logged-in user from the session
        AnUser = (clsCustomerUser)Session["AnUser"];
        //display the username of the logged-in user
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        // Use LINQ with classic string.Format (C# 5 compatible)
        var formattedList = Customers.CustomerList.Select(c => new
        {
            CustomerNo = c.CustomerNo,
            DisplayText = string.Format("[ID: {0}] {1} {2} | {3} | Joined: {4:dd/MM/yyyy}",
                                        c.CustomerNo, c.FirstName, c.LastName, c.Email, c.DateJoined)
        }).ToList();

        lstCustomerList.DataSource = formattedList;
        lstCustomerList.DataValueField = "CustomerNo";
        lstCustomerList.DataTextField = "DisplayText";
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerNo"] = -1;

        //redirect to the data entry page we created earlier
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 CustomerNo;

        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            CustomerNo = Convert.ToInt32(lstCustomerList.SelectedValue);

            //store the data in the session object
            Session["CustomerNo"] = CustomerNo;

            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 CustomerNo;

        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            CustomerNo = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerNo"] = CustomerNo;
            //redirect to the confirmation page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByEmail(txtFilter.Text);

        var formattedList = Customers.CustomerList.Select(c => new
        {
            CustomerNo = c.CustomerNo,
            DisplayText = string.Format("[ID: {0}] {1} {2} | {3} | Joined: {4:dd/MM/yyyy}",
                                        c.CustomerNo, c.FirstName, c.LastName, c.Email, c.DateJoined)
        }).ToList();

        lstCustomerList.DataSource = formattedList;
        lstCustomerList.DataValueField = "CustomerNo";
        lstCustomerList.DataTextField = "DisplayText";
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByEmail("");

        txtFilter.Text = "";

        var formattedList = Customers.CustomerList.Select(c => new
        {
            CustomerNo = c.CustomerNo,
            DisplayText = string.Format("[ID: {0}] {1} {2} | {3} | Joined: {4:dd/MM/yyyy}",
                                        c.CustomerNo, c.FirstName, c.LastName, c.Email, c.DateJoined)
        }).ToList();

        lstCustomerList.DataSource = formattedList;
        lstCustomerList.DataValueField = "CustomerNo";
        lstCustomerList.DataTextField = "DisplayText";
        lstCustomerList.DataBind();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        // Redirect to the Admin Menu page
        Response.Redirect("TeamMainMenu.aspx");
    }
}