using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderDataEntry : System.Web.UI.Page
{
    Int32 OrderNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the ID from the session
        OrderNo = Convert.ToInt32(Session["OrderNo"]);

        if (IsPostBack == false)
        {
            // If this is not a new record (ID is not 0)
            if (OrderNo != 0)
            {
                DisplayOrder();
            }
        }
    }

    void DisplayOrder()
    {
        clsOrderCollection OrderList = new clsOrderCollection();
        OrderList.ThisOrder.Find(OrderNo);
        txtOrderNo.Text = OrderList.ThisOrder.OrderNo.ToString();
        txtCustomerNo.Text = OrderList.ThisOrder.CustomerNo.ToString();
        txtOrderDate.Text = OrderList.ThisOrder.OrderDate.ToString();
        txtTotalAmount.Text = OrderList.ThisOrder.TotalAmount.ToString();
        txtDeliveryAddress.Text = OrderList.ThisOrder.DeliveryAddress;
        chkIsDispatched.Checked = OrderList.ThisOrder.IsDispatched;
    }

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
            AnOrder.OrderNo = OrderNo;
            AnOrder.CustomerNo = Convert.ToInt32(CustomerNo);
            AnOrder.OrderDate = Convert.ToDateTime(OrderDate);
            AnOrder.TotalAmount = Convert.ToDouble(TotalAmount);
            AnOrder.DeliveryAddress = DeliveryAddress;
            AnOrder.IsDispatched = chkIsDispatched.Checked;

            clsOrderCollection OrderList = new clsOrderCollection();

            // If this is a new record (ID is 0)
            if (OrderNo == 0)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            // Otherwise it must be an update
            else
            {
                OrderList.ThisOrder.Find(OrderNo);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }

            // Redirect back to the list page
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        Int32 OrderNoTemp;
        Boolean Found = false;

        if (txtOrderNo.Text != "")
        {
            OrderNoTemp = Convert.ToInt32(txtOrderNo.Text);
            Found = AnOrder.Find(OrderNoTemp);

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