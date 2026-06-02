using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TeamMainMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnStock_Click(object sender, EventArgs e)
    {
        // Redirect to the Stock page
        Response.Redirect("StockLogin.aspx");
    }

    protected void btnOrder_Click(object sender, EventArgs e)
    {
        // Redirect to the Order page
        Response.Redirect("OrderLogin.aspx");
    }

    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        // Redirect to the Customer page
        Response.Redirect("CustomerLogin.aspx");
    }

    protected void btnDiscount_Click(object sender, EventArgs e)
    {
        // Redirect to the Discount page
        Response.Redirect("DiscountLogin.aspx");
    }

    protected void btnOrderLine_Click(object sender, EventArgs e)
    {
        // Redirect to the Order Line page
        Response.Redirect("OrderLineLogin.aspx");
    }

    protected void btnAddress_Click(object sender, EventArgs e)
    {
        // Redirect to the Address page
        Response.Redirect("AddressLogin.aspx");
    }
}