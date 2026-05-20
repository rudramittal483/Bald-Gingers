using ClassLibrary;
using System;
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
        // Store 0 in the session to tell the next page this is a NEW record
        Session["OrderLineNo"] = 0;
        // Redirect to the data entry page
        Response.Redirect("OrderLineDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderLineNo;

        // Check if the user has actually clicked on a record in the listbox
        if (lstOrderLineList.SelectedIndex != -1)
        {
            // Get the ID of the selected record
            OrderLineNo = Convert.ToInt32(lstOrderLineList.SelectedValue);
            // Store it in the session
            Session["OrderLineNo"] = OrderLineNo;
            // Redirect to the data entry page to edit it
            Response.Redirect("OrderLineDataEntry.aspx");
        }
        else
        {
            // Trigger the error label if they click edit without selecting anything
            lblError.Text = "Please select a record from the list to edit.";
        }
    }
}