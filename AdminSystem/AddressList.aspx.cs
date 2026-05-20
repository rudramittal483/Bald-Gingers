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
    }

    void DisplayAddresses()
    {
        //create an instance of the Address Collection
        clsAddressCollection Addresses = new clsAddressCollection();

        //set the data source to the list of addresses in the collection
        lstAddressList.DataSource = Addresses.AddressList;

        //set the name of the primary key
        lstAddressList.DataValueField = "AddressId";

        //set the data field to display (Postcode is used here as a descriptor)
        lstAddressList.DataTextField = "Postcode";

        //bind the data to the list
        lstAddressList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["AddressId"] = -1;

        //redirect to the data entry page we created earlier
        Response.Redirect("AddressDataEntry.aspx");
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
        //set the name of the field to display
        lstAddressList.DataTextField = "Postcode";
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
        //set the name of the field to display
        lstAddressList.DataTextField = "Postcode";
        //bind the data to the list
        lstAddressList.DataBind();
    }

}