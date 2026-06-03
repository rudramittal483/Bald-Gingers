using System;
using ClassLibrary; // Make sure this matches your actual library namespace

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create a new instance of clsStock
        clsStock AStock = new clsStock();

        // Get the data from the session object
        AStock = (clsStock)Session["AStock"];

        // If the session object isn't completely empty, display the data inside the card's label
        if (AStock != null)
        {
            lblViewerData.Text =
                "<b>Laptop ID:</b> " + AStock.LaptopId + "<br/>" +
                "<b>Discount ID:</b> " + AStock.DiscountId + "<br/>" +
                "<b>Brand:</b> " + AStock.Brand + "<br/>" +
                "<b>Model Name:</b> " + AStock.Model + "<br/>" +
                "<b>Date Added:</b> " + AStock.DateAdded.ToString("dd-MM-yyyy") + "<br/>" +
                "<b>Price:</b> $" + AStock.Price.ToString("0.00") + "<br/>" +
                "<b>Quantity:</b> " + AStock.Quantity + "<br/>" +
                "<b>In Stock:</b> " + AStock.InStock;
        }
    }

    protected void btnBack_Click(object sender, EventArgs e)
    {
        // Redirect back to the Data Entry or List page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        // Redirect back to the Main Menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}