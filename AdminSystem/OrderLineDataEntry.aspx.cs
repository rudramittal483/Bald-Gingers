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

    protected void btnFindLine_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        Int32 OrderLineNo;
        Boolean Found = false;

        if (txtOrderLineNo.Text != "")
        {
            OrderLineNo = Convert.ToInt32(txtOrderLineNo.Text);
            Found = AnOrderLine.Find(OrderLineNo);

            if (Found == true)
            {
                txtOrderNo.Text = AnOrderLine.OrderNo.ToString();
                txtLaptopNo.Text = AnOrderLine.LaptopNo.ToString();
                txtQuantity.Text = AnOrderLine.Quantity.ToString();
                lblError.Text = "";
            }
            else { lblError.Text = "Order Line not found."; }
        }
    }
}