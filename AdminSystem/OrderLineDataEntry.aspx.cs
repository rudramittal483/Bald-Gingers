using System;
using ClassLibrary; //
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineDataEntry : System.Web.UI.Page
{
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();

        AnOrderLine.OrderLineNo = Convert.ToInt32(txtOrderLineNo.Text);
        AnOrderLine.OrderNo = Convert.ToInt32(txtOrderNo.Text);
        AnOrderLine.LaptopNo = Convert.ToInt32(txtLaptopNo.Text);
        AnOrderLine.Quantity = Convert.ToInt32(txtQuantity.Text);

        Session["AnOrderLine"] = AnOrderLine;

        Response.Redirect("OrderLineViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}