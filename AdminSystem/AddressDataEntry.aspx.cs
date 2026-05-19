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
        string CustomerNo = txtCustomerNo.Text;
        string Emirate = txtEmirate.Text;
        string BuildingName = txtBuildingName.Text;
        string StreetName = txtStreetName.Text;
        string AddressType = txtAddressType.Text;
        string Postcode = txtPostcode.Text;

        //variable to store any error messages
        string Error = "";

        //validate the data
        Error = AnAddress.Valid(CustomerNo, Emirate, BuildingName, StreetName, AddressType, Postcode);

        if (Error == "")
        {
            //capture the properties, parsing where necessary
            if (!string.IsNullOrEmpty(txtAddressId.Text))
            {
                AnAddress.AddressId = Convert.ToInt32(txtAddressId.Text);
            }
            AnAddress.CustomerNo = Convert.ToInt32(CustomerNo);
            AnAddress.Emirate = Emirate;
            AnAddress.BuildingName = BuildingName;
            AnAddress.StreetName = StreetName;
            AnAddress.AddressType = AddressType;
            AnAddress.Postcode = Convert.ToInt32(Postcode);
            AnAddress.IsDefault = chkIsDefault.Checked;

            //store the address in the session object
            Session["AnAddress"] = AnAddress;

            //redirect to the viewer page
            Response.Redirect("AddressViewer.aspx");
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
}