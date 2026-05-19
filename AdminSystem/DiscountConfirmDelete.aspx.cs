using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    Int32 DiscountId;

    protected void Page_Load(object sender, EventArgs e)
    {
        DiscountId = Convert.ToInt32(Session["DiscountId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsDiscountCollection DiscountCollection = new clsDiscountCollection();
        DiscountCollection.ThisDiscount.Find(DiscountId);
        DiscountCollection.Delete();
        Response.Redirect("DiscountList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("DiscountList.aspx");
    }
}