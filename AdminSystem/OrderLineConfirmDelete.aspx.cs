using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineConfirmDelete : System.Web.UI.Page
{
    Int32 OrderLineNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        OrderLineNo = Convert.ToInt32(Session["OrderLineNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection LineList = new clsOrderLineCollection();
        LineList.ThisOrderLine.Find(OrderLineNo);
        LineList.Delete();
        Response.Redirect("OrderLineList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderLineList.aspx");
    }
}