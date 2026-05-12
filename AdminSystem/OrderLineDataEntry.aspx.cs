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
        // Create a new instance of clsOrderLine
        clsOrderLine AnOrderLine = new clsOrderLine();

        // Capture inputs as strings for validation
        string OrderNo = txtOrderNo.Text;
        string LaptopNo = txtLaptopNo.Text;
        string Quantity = txtQuantity.Text;

        string Error = "";

        // Validate the data
        Error = AnOrderLine.Valid(OrderNo, LaptopNo, Quantity);

        if (Error == "")
        {
            // If valid, map to properties and convert types
            AnOrderLine.OrderLineNo = Convert.ToInt32(txtOrderLineNo.Text);
            AnOrderLine.OrderNo = Convert.ToInt32(OrderNo);
            AnOrderLine.LaptopNo = Convert.ToInt32(LaptopNo);
            AnOrderLine.Quantity = Convert.ToInt32(Quantity);

            // Store in session and redirect
            Session["AnOrderLine"] = AnOrderLine;
            Response.Redirect("OrderLineViewer.aspx");
        }
        else
        {
            // Show errors in the red label
            lblError.Text = Error;
        }
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