using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddressDataEntry : System.Web.UI.Page
{
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsAddress
        clsAddress AnAddress = new clsAddress();

        //capture the data from the UI controls as strings
        string CustomerNoText = txtCustomerNo.Text;
        string Emirate = txtEmirate.Text;
        string BuildingName = txtBuildingName.Text;
        string StreetName = txtStreetName.Text;
        string AddressType = txtAddressType.Text;
        string PostcodeText = txtPostcode.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AnAddress.Valid(CustomerNoText, Emirate, BuildingName, StreetName, AddressType, PostcodeText);

        if (Error == "")
        {
            //capture the address id (DON't MISS THIS BIT !!!!!)
            //AddressId is the page-level variable we set in Page_Load
            AnAddress.AddressId = AddressId;

            //capture the rest of the properties
            AnAddress.CustomerNo = Convert.ToInt32(CustomerNoText);
            AnAddress.Emirate = Emirate;
            AnAddress.BuildingName = BuildingName;
            AnAddress.StreetName = StreetName;
            AnAddress.AddressType = AddressType;
            AnAddress.Postcode = Convert.ToInt32(PostcodeText);
            AnAddress.IsDefault = chkIsDefault.Checked;

            //create a new instance of the address collection
            clsAddressCollection AddressList = new clsAddressCollection();

            //if this is a new record i.e. AddressId = -1 then add the data
            if (AddressId == -1)
            {
                //set the ThisAddress property
                AddressList.ThisAddress = AnAddress;
                //add the new record
                AddressList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                AddressList.ThisAddress.Find(AddressId);
                //set the ThisAddress property
                AddressList.ThisAddress = AnAddress;
                //update the record
                AddressList.Update();
            }

            //redirect back to the list page
            Response.Redirect("AddressList.aspx");
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
        //create an instance of the address class
        clsAddress AnAddress = new clsAddress();
        //variable to store the primary key
        Int32 AddressId;
        //variable to store the result of the find operation
        Boolean Found = false;

        //if the Address ID text box is not empty
        if (txtAddressId.Text != "")
        {
            //get the primary key entered by the user
            AddressId = Convert.ToInt32(txtAddressId.Text);
            //find the record
            Found = AnAddress.Find(AddressId);

            if (Found == true)
            {
                //display the values of the properties in the form
                txtAddressId.Text = AnAddress.AddressId.ToString();
                txtCustomerNo.Text = AnAddress.CustomerNo.ToString();
                txtEmirate.Text = AnAddress.Emirate;
                txtBuildingName.Text = AnAddress.BuildingName;
                txtStreetName.Text = AnAddress.StreetName;
                txtAddressType.Text = AnAddress.AddressType;
                txtPostcode.Text = AnAddress.Postcode.ToString();
                chkIsDefault.Checked = AnAddress.IsDefault;

                //clear any previous errors
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Address not found.";
            }
        }
    }

    //variable to store the primary key with page level scope
    Int32 AddressId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        AddressId = Convert.ToInt32(Session["AddressId"]);

        if (IsPostBack == false)
        {
            //if this is not a new record (-1 means new)
            if (AddressId != -1)
            {
                //display the current data for the record
                DisplayAddress();
            }
        }
    }

    // Method to fetch the existing record and fill the text boxes
    void DisplayAddress()
    {
        //create an instance of the address collection
        clsAddressCollection AddressBook = new clsAddressCollection();

        //find the record to update
        AddressBook.ThisAddress.Find(AddressId);

        //display the data for this record inside the text boxes
        txtAddressId.Text = AddressBook.ThisAddress.AddressId.ToString();
        txtCustomerNo.Text = AddressBook.ThisAddress.CustomerNo.ToString();
        txtEmirate.Text = AddressBook.ThisAddress.Emirate;
        txtBuildingName.Text = AddressBook.ThisAddress.BuildingName;
        txtStreetName.Text = AddressBook.ThisAddress.StreetName;
        txtAddressType.Text = AddressBook.ThisAddress.AddressType;
        txtPostcode.Text = AddressBook.ThisAddress.Postcode.ToString();
        chkIsDefault.Checked = AddressBook.ThisAddress.IsDefault;
    }
}