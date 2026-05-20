using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // If this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // Update the list box
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderNo";
        lstOrderList.DataTextField = "DeliveryAddress";
        lstOrderList.DataBind();
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // Store 0 in the session to indicate this is a NEW record
        Session["OrderNo"] = 0;
        // Redirect to the data entry page
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderNo;

        // Check if a record has actually been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to edit
            OrderNo = Convert.ToInt32(lstOrderList.SelectedValue);
            // Store the data in the session object
            Session["OrderNo"] = OrderNo;
            // Redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            // If no record has been selected, display an error
            lblError.Text = "Please select a record from the list to edit.";
        }
    }
}