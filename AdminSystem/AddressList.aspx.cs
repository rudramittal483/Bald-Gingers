using ClassLibrary;
using System;
using System.Collections.Generic;
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
            //update the list box
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
}