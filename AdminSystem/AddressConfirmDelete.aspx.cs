using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddressConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 AddressId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be deleted from the session object
        AddressId = Convert.ToInt32(Session["AddressId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the address collection class
        clsAddressCollection AddressList = new clsAddressCollection();

        //find the record to delete
        AddressList.ThisAddress.Find(AddressId);

        //delete the record using the method we wrote earlier
        AddressList.Delete();

        //redirect back to the main list page
        Response.Redirect("AddressList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //user changed their mind, redirect back to the main list page without deleting
        Response.Redirect("AddressList.aspx");
    }
}