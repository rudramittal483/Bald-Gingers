using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderDataEntry : System.Web.UI.Page
{
    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        string CustomerNo = txtCustomerNo.Text;
        string OrderDate = txtOrderDate.Text;
        string TotalAmount = txtTotalAmount.Text;
        string DeliveryAddress = txtDeliveryAddress.Text;

        string Error = "";

        Error = AnOrder.Valid(CustomerNo, OrderDate, TotalAmount, DeliveryAddress);

        if (Error == "")
        {
            AnOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);
            AnOrder.CustomerNo = Convert.ToInt32(CustomerNo);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.TotalAmount = Convert.ToDouble(TotalAmount);
            AnOrder.DeliveryAddress = DeliveryAddress;
            AnOrder.IsDispatched = chkIsDispatched.Checked;

            Session["AnOrder"] = AnOrder;

            Response.Redirect("OrderViewer.aspx");
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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderNo;
        Boolean Found = false;

        if (txtOrderNo.Text != "")
        {
            OrderNo = Convert.ToInt32(txtOrderNo.Text);
            Found = AnOrder.Find(OrderNo);

            if (Found == true)
            {
                txtCustomerNo.Text = AnOrder.CustomerNo.ToString();
                txtOrderDate.Text = AnOrder.OrderDate.ToString();
                txtTotalAmount.Text = AnOrder.TotalAmount.ToString();
                txtDeliveryAddress.Text = AnOrder.DeliveryAddress;
                chkIsDispatched.Checked = AnOrder.IsDispatched;
                lblError.Text = "";
            }
            else { lblError.Text = "Order not found."; }
        }
    }
}