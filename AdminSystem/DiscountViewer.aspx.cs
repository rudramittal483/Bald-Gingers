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

        // CHECK IF IT IS NULL BEFORE WRITING TO THE SCREEN
        if (ADiscount != null)
        {
            // Build the string securely using concatenation (C# 5 compatible) and send it to the Label
            lblViewerData.Text =
                "<b>Discount ID:</b> " + ADiscount.DiscountId + "<br/>" +
                "<b>Discount Code:</b> " + ADiscount.DiscountCode + "<br/>" +
                "<b>Description:</b> " + ADiscount.DiscountDescription + "<br/>" +
                "<b>Discount Percentage:</b> " + ADiscount.DiscountPercent + "%<br/>" +
                "<b>Start Date:</b> " + ADiscount.DiscountStartDate.ToString("dd-MM-yyyy") + "<br/>" +
                "<b>End Date:</b> " + ADiscount.DiscountEndDate.ToString("dd-MM-yyyy");
        }
        else
        {
            // If the session is empty, display a friendly message in the Label
            lblViewerData.Text = "<b>No Discount data found.</b><br/><br/>Please go back to the Data Entry page and submit a new record.";
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        // Redirects back to the list page (or Data Entry page, depending on your flow)
        Response.Redirect("DiscountList.aspx");
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        // Redirects back to the main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}