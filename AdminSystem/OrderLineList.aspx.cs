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

        //create an instance of the stock collection
        clsOrderLineUser AnUser = new clsOrderLineUser();
        //retrieve the logged-in user from the session
        AnUser = (clsOrderLineUser)Session["AnUser"];
        //display the username of the logged-in user
        Response.Write("Logged in as: " + AnUser.UserName);
    }

    void DisplayOrderLines()
    {
        clsOrderLineCollection OrderLines = new clsOrderLineCollection();
        lstOrderLineList.DataSource = OrderLines.OrderLineList;
        lstOrderLineList.DataValueField = "OrderLineNo";
        lstOrderLineList.DataTextField = "OrderLineNo";
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
}