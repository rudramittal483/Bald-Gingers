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
        //create an instance of the Address Collection
        clsAddressCollection Addresses = new clsAddressCollection();

        //set the data source to the list of addresses in the collection
        lstAddressList.DataSource = Addresses.AddressList;

        //set the name of the primary key
        lstAddressList.DataValueField = "AddressId";

        // *** CHANGED: Now points to your new glued-together property ***
        lstAddressList.DataTextField = "FullAddress";

        //bind the data to the list
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
        //create an instance of the address object
        clsAddressCollection Addresses = new clsAddressCollection();
        //invoke the method passing the filter text
        Addresses.ReportByPostcode(txtFilter.Text);
        //set the data source to the list of addresses in the collection
        lstAddressList.DataSource = Addresses.AddressList;
        //set the name of the primary key
        lstAddressList.DataValueField = "AddressId";

        // *** CHANGED: Now points to your new glued-together property ***
        lstAddressList.DataTextField = "FullAddress";

        //bind the data to the list
        lstAddressList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the address object
        clsAddressCollection Addresses = new clsAddressCollection();
        //invoke the method passing a blank string to clear the filter
        Addresses.ReportByPostcode("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of addresses in the collection
        lstAddressList.DataSource = Addresses.AddressList;
        //set the name of the primary key
        lstAddressList.DataValueField = "AddressId";

        // *** CHANGED: Now points to your new glued-together property ***
        lstAddressList.DataTextField = "FullAddress";

        //bind the data to the list
        lstAddressList.DataBind();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        // Redirect to the Admin Menu page
        Response.Redirect("TeamMainMenu.aspx");
    }
}