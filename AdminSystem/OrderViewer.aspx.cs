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
        clsOrder AnOrder = new clsOrder();
        AnOrder = (clsOrder)Session["AnOrder"];
        Response.Write("Order No: " + AnOrder.OrderNo + "<br/>");
        Response.Write("Customer No: " + AnOrder.CustomerNo + "<br/>");
        Response.Write("Order Date: " + AnOrder.OrderDate + "<br/>");
        Response.Write("Total Amount: " + AnOrder.TotalAmount + "<br/>");
        Response.Write("Delivery Address: " + AnOrder.DeliveryAddress + "<br/>");
        Response.Write("Is dispatched: " + AnOrder.IsDispatched + "<br/>");
    }
}