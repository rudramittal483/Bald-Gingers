using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddressList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list boxs
            DisplayAddresses();
        }

        //create an instance of the stock collection
        clsAddressUser AnUser = new clsAddressUser();
        //retrieve the logged-in user from the session
        AnUser = (clsAddressUser)Session["AnUser"];
        //display the username of the logged-in user
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    void DisplayAddresses()
    {
        clsAddressCollection Addresses = new clsAddressCollection();

        // Format the string to include the Customer ID (C# 5 Safe)
        var formattedList = Addresses.AddressList.Select(a => new
        {
            AddressId = a.AddressId,
            DisplayText = string.Format("[Cust ID: {0}] {1} - {2}, {3} ({4})",
                                        a.CustomerNo, a.AddressType, a.BuildingName, a.StreetName, a.Postcode)
        }).ToList();

        lstAddressList.DataSource = formattedList;
        lstAddressList.DataValueField = "AddressId";
        lstAddressList.DataTextField = "DisplayText";
        lstAddressList.DataBind();
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 AddressId;

        //if a record has been selected from the list
        if (lstAddressList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            AddressId = Convert.ToInt32(lstAddressList.SelectedValue);

            //store the data in the session object
            Session["AddressId"] = AddressId;

            //redirect to the edit page
            Response.Redirect("AddressDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 AddressId;

        //if a record has been selected from the list
        if (lstAddressList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            AddressId = Convert.ToInt32(lstAddressList.SelectedValue);
            //store the data in the session object
            Session["AddressId"] = AddressId;
            //redirect to the confirmation page
            Response.Redirect("AddressConfirmDelete.aspx");
        }
        else
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsAddressCollection Addresses = new clsAddressCollection();

        // 1. Try to convert whatever the user typed into a number
        int searchCustomerNo;
        bool isNumber = int.TryParse(txtFilter.Text, out searchCustomerNo);

        // 2. Start with the full list
        var filteredAddresses = Addresses.AddressList;

        // 3. If they typed a valid number, filter the list by CustomerNo
        if (isNumber)
        {
            filteredAddresses = Addresses.AddressList.Where(a => a.CustomerNo == searchCustomerNo).ToList();
            lblError.Text = ""; // Clear any previous errors
        }
        else if (txtFilter.Text != "")
        {
            // If they typed text instead of a number, show an error and don't filter
            lblError.Text = "Please enter a valid numeric Customer Number.";
            return;
        }

        // 4. Format and bind the newly filtered list
        var formattedList = filteredAddresses.Select(a => new
        {
            AddressId = a.AddressId,
            DisplayText = string.Format("[Cust ID: {0}] {1} - {2}, {3} ({4})",
                                        a.CustomerNo, a.AddressType, a.BuildingName, a.StreetName, a.Postcode)
        }).ToList();

        lstAddressList.DataSource = formattedList;
        lstAddressList.DataValueField = "AddressId";
        lstAddressList.DataTextField = "DisplayText";
        lstAddressList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        // Tidy up the text box and error labels
        txtFilter.Text = "";
        lblError.Text = "";

        // Just call the display method again to reset the list and save code!
        DisplayAddresses();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        // Redirect to the Admin Menu page
        Response.Redirect("TeamMainMenu.aspx");
    }
}