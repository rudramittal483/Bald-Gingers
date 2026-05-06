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
        clsOrderLine AnOrderLine = new clsOrderLine();
        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
        Response.Write("OrderLine No: " + AnOrderLine.OrderLineNo + "<br/>");
        Response.Write("Order No: " + AnOrderLine.OrderNo + "<br/>");
        Response.Write("Laptop No: " + AnOrderLine.LaptopNo + "<br/>");
        Response.Write("Quantity: " + AnOrderLine.Quantity + "<br/>");
    }
}