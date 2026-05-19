using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddressViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsAddress AnAddress = new clsAddress();

        //get the data from the session object
        AnAddress = (clsAddress)Session["AnAddress"];

        //display the data for this entry
        Response.Write("Address ID: " + AnAddress.AddressId + "<br/>");
        Response.Write("Customer No: " + AnAddress.CustomerNo + "<br/>");
        Response.Write("Emirate: " + AnAddress.Emirate + "<br/>");
        Response.Write("Building Name: " + AnAddress.BuildingName + "<br/>");
        Response.Write("Street Name: " + AnAddress.StreetName + "<br/>");
        Response.Write("Address Type: " + AnAddress.AddressType + "<br/>");
        Response.Write("Postcode: " + AnAddress.Postcode + "<br/>");
        Response.Write("Is Default: " + AnAddress.IsDefault + "<br/>");
    }
}