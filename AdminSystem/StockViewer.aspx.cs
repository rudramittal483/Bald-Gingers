using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //get the data from the session object
        AStock = (clsStock)Session["AStock"];
        //display the data for this entry
        Response.Write("Laptop ID: " + AStock.LaptopId + "<br/>");
        Response.Write("Brand: " + AStock.Brand + "<br/>");
        Response.Write("Model Name: " + AStock.Model + "<br/>");
        Response.Write("Date Added: " + AStock.DateAdded + "<br/>");
        Response.Write("Price: " + AStock.Price + "<br/>");
        Response.Write("In Stock: " + AStock.InStock + "<br/>");
    }
}