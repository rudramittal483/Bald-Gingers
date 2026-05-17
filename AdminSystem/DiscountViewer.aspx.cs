using ClassLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsDiscount
        clsDiscount ADiscount = new clsDiscount();
        //get the data from the session object
        ADiscount = (clsDiscount)Session["ADiscount"];
        //display the data for this entry
        Response.Write("Discount ID: " + ADiscount.DiscountId + "<br/>");
        Response.Write("Discount Code: " + ADiscount.DiscountCode + "<br/>");
        Response.Write("Description: " + ADiscount.DiscountDescription + "<br/>");
        Response.Write("Discount Percentage: " + ADiscount.DiscountPercent + "<br/>");
        Response.Write("Start Date: " + ADiscount.DiscountStartDate + "<br/>");
        Response.Write("End Date: " + ADiscount.DiscountEndDate + "<br/>");
    }
}