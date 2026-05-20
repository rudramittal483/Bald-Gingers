using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineDataEntry : System.Web.UI.Page
{
    Int32 OrderLineNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the ID from the session
        OrderLineNo = Convert.ToInt32(Session["OrderLineNo"]);

        if (IsPostBack == false)
        {
            // If this is not a new record (ID is not 0)
            if (OrderLineNo != 0)
            {
                DisplayOrderLine();
            }
        }
    }

    void DisplayOrderLine()
    {
        clsOrderLineCollection LineList = new clsOrderLineCollection();
        LineList.ThisOrderLine.Find(OrderLineNo);
        txtOrderLineNo.Text = LineList.ThisOrderLine.OrderLineNo.ToString();
        txtOrderNo.Text = LineList.ThisOrderLine.OrderNo.ToString();
        txtLaptopNo.Text = LineList.ThisOrderLine.LaptopNo.ToString();
        txtQuantity.Text = LineList.ThisOrderLine.Quantity.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();
        string OrderNo = txtOrderNo.Text;
        string LaptopNo = txtLaptopNo.Text;
        string Quantity = txtQuantity.Text;

        string Error = "";
        Error = AnOrderLine.Valid(OrderNo, LaptopNo, Quantity);

        if (Error == "")
        {
            AnOrderLine.OrderLineNo = OrderLineNo;
            AnOrderLine.OrderNo = Convert.ToInt32(OrderNo);
            AnOrderLine.LaptopNo = Convert.ToInt32(LaptopNo);
            AnOrderLine.Quantity = Convert.ToInt32(Quantity);

            clsOrderLineCollection LineList = new clsOrderLineCollection();

            // If this is a new record (ID is 0)
            if (OrderLineNo == 0)
            {
                LineList.ThisOrderLine = AnOrderLine;
                LineList.Add();
            }
            // Otherwise it must be an update
            else
            {
                LineList.ThisOrderLine.Find(OrderLineNo);
                LineList.ThisOrderLine = AnOrderLine;
                LineList.Update();
            }

            // Redirect back to the list page
            Response.Redirect("OrderLineList.aspx");
        }
        else
        {
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
        Int32 OrderLineNoTemp;
        Boolean Found = false;

        if (txtOrderLineNo.Text != "")
        {
            OrderLineNoTemp = Convert.ToInt32(txtOrderLineNo.Text);
            Found = AnOrderLine.Find(OrderLineNoTemp);

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