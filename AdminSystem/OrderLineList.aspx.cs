using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrderLines();
        }

        // Check if a user is currently logged in
        if (Session["AnUser"] != null)
        {
            //create an instance of the user
            clsOrderLineUser AnUser = new clsOrderLineUser();

            //retrieve the logged-in user from the session
            AnUser = (clsOrderLineUser)Session["AnUser"];

            lblUser.Text = AnUser.UserName;
        }
        else
        {
            // Fallback if accessed without logging in
            lblUser.Text = "Guest";
        }
    }

    void DisplayOrderLines()
    {
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        lstOrderLineList.DataSource = OrderLines.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineNo";
        lstOrderLineList.DataTextField = "OrderLineSummary";
        lstOrderLineList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderLineNo"] = 0;
        Response.Redirect("OrderLineDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderLineNo;
        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderLineNo = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderLineNo"] = OrderLineNo;
            Response.Redirect("OrderLineDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderLineNo;
        if (lstOrderLineList.SelectedIndex != -1)
        {
            OrderLineNo = Convert.ToInt32(lstOrderLineList.SelectedValue);
            Session["OrderLineNo"] = OrderLineNo;
            Response.Redirect("OrderLineConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        // Redirect to the Admin Menu page
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        int orderNoFilter;

        // Validate that the user typed a number
        if (int.TryParse(txtFilter.Text, out orderNoFilter))
        {
            OrderLines.ReportByOrderNo(orderNoFilter);
            lblError.Text = ""; // Clear errors
        }
        else
        {
            // If they typed text, pull everything and warn them
            OrderLines.ReportByOrderNo(0);
            lblError.Text = "Please enter a valid numeric Order Number to filter.";
        }

        lstOrderLineList.DataSource = OrderLines.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineNo";
        lstOrderLineList.DataTextField = "OrderLineSummary";
        lstOrderLineList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        OrderLines.ReportByOrderNo(0); // 0 triggers the SelectAll logic
        txtFilter.Text = "";
        lblError.Text = "";
        lstOrderLineList.DataSource = OrderLines.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineNo";
        lstOrderLineList.DataTextField = "OrderLineSummary";
        lstOrderLineList.DataBind();
    }
}