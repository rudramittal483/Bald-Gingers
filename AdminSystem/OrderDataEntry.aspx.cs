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
        AnOrder.OrderNo = Convert.ToInt32(txtOrderNo.Text);
        AnOrder.CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
        AnOrder.OrderDate = Convert.ToDateTime(txtOrderDate.Text);
        AnOrder.TotalAmount = Convert.ToDouble(txtTotalAmount.Text);
        AnOrder.DeliveryAddress = txtDeliveryAddress.Text;
        AnOrder.IsDispatched = chkIsDispatched.Checked;
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
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